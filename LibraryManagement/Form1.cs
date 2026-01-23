using Microsoft.EntityFrameworkCore;
using System.Linq;
using Library.Application.Services;
using Library.Domain.Entities;
using Library.Infrastructure.Data;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        private readonly DbFactory _dbFactory = new DbFactory();

        private readonly EmpruntService _empruntService;
        private readonly LivreService _livreService;
        private readonly UsagerService _usagerService;
        private readonly ActiviteService _activiteService;

        private bool _loading = false;
        // TAB4 - Matériel
        private int? _selectedUsagerMaterielId => cboUsagerMateriel.SelectedValue as int?;


        public Form1()
        {
            InitializeComponent();

            // Seed 1 seule fois si DB vide
            using (var db = _dbFactory.Create())
            {
                DbSeeder.SeedIfEmpty(db);
            }

            _empruntService = new EmpruntService(_dbFactory);
            _livreService = new LivreService(_dbFactory);
            _usagerService = new UsagerService(_dbFactory);
            _activiteService = new ActiviteService(_dbFactory);

            this.Load += Form1_Load;
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _loading = true;

                LoadTypeActivite();          // ✅ important sinon cboTypeActivite vide
                await ReloadEmpruntsTab();   // TAB1
                await ReloadActivitesTab();  // TAB2
                await ReloadMaterielTab();
                LoadTypeActivite();
                _loading = false;
            }
            catch (Exception ex)
            {
                _loading = false;
                MessageBox.Show("❌ " + ex.Message);
            }
        }

        // =========================
        // TAB 1 - EMPRUNTS LIVRES
        // =========================
        private async Task ReloadEmpruntsTab()
        {
            await LoadUsagersForEmprunt();
            await LoadLivresForEmprunt();
            await LoadEmpruntsGrid();
        }
        private async Task ReloadMaterielTab()
        {
            await LoadUsagersMateriel();
            await LoadMaterielsDisponibles();
            await LoadMaterielsGrid();
            await LoadEmpruntsMaterielGrid(); // selon l'usager sélectionné
        }
        private async Task LoadUsagersMateriel()
        {
            var usagers = await _usagerService.GetActifsAsync();

            cboUsagerMateriel.DisplayMember = "NomComplet";
            cboUsagerMateriel.ValueMember = "Id";
            cboUsagerMateriel.DataSource = usagers.ToList();

            // quand on change d'usager -> refresh historique
            cboUsagerMateriel.SelectedIndexChanged -= cboUsagerMateriel_SelectedIndexChanged;
            cboUsagerMateriel.SelectedIndexChanged += cboUsagerMateriel_SelectedIndexChanged;
        }
        private async Task LoadMaterielsDisponibles()
        {
            using var db = _dbFactory.Create();

            var materiels = await db.Materiels
                .Where(m => m.Actif && m.QuantiteTotale > 0)
                .OrderBy(m => m.Nom)
                .ToListAsync();

            cboMateriel.DisplayMember = "Nom";
            cboMateriel.ValueMember = "Id";
            cboMateriel.DataSource = materiels.ToList();
        }
        private async Task LoadMaterielsGrid()
        {
            using var db = _dbFactory.Create();

            var materiels = await db.Materiels
                .OrderBy(m => m.Nom)
                .ToListAsync();

            dgvMateriels.AutoGenerateColumns = true;
            dgvMateriels.ReadOnly = true;
            dgvMateriels.AllowUserToAddRows = false;
            dgvMateriels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvMateriels.DataSource = materiels.Select(m => new
            {
                m.Id,
                m.Nom,
                m.QuantiteTotale,
                m.Actif
            }).ToList();
        }
        private async Task LoadEmpruntsMaterielGrid()
        {
            if (cboUsagerMateriel.SelectedValue == null)
            {
                dgvMateriels.DataSource = null;
                return;
            }

            int usagerId = (int)cboUsagerMateriel.SelectedValue;

            using var db = _dbFactory.Create();
            var service = new MaterielService(db);

            var emprunts = await service.GetHistoriqueParUsagerAsync(usagerId);

            dgvMateriels.AutoGenerateColumns = true;
            dgvMateriels.ReadOnly = true;
            dgvMateriels.AllowUserToAddRows = false;
            dgvMateriels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvMateriels.DataSource = emprunts.Select(e => new
            {
                e.Id,
                Materiel = e.Materiel.Nom,
                e.DateEmprunt,
                DateRetour = e.DateRetour
            }).ToList();
        }
        private async Task LoadUsagersForEmprunt()
        {
            var usagers = await _usagerService.GetActifsAsync();

            cboUsagerEmprunt.DisplayMember = "NomComplet";
            cboUsagerEmprunt.ValueMember = "Id";
            cboUsagerEmprunt.DataSource = usagers.ToList();
        }

        private async Task LoadLivresForEmprunt()
        {
            var livres = await _livreService.GetDisponiblesAsync();

            cboLivreEmprunt.DisplayMember = "Titre";
            cboLivreEmprunt.ValueMember = "Id";
            cboLivreEmprunt.DataSource = livres.ToList();
        }

        private async Task LoadEmpruntsGrid()
        {
            var emprunts = await _empruntService.GetEmpruntsEnCoursAsync();

            dgvEmpruntsLivres.AutoGenerateColumns = true;
            dgvEmpruntsLivres.DataSource = emprunts.Select(e => new
            {
                e.Id,
                Usager = e.Usager.NomComplet,
                Livre = e.Livre.Titre,
                e.DateEmprunt,
                e.DateRetourPrevue,
                e.Etat
            }).ToList();
        }

        private async void btnEmprunterLivre_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboUsagerEmprunt.SelectedValue == null || cboLivreEmprunt.SelectedValue == null)
                {
                    MessageBox.Show("Choisis un usager et un livre.");
                    return;
                }

                int usagerId = (int)cboUsagerEmprunt.SelectedValue;
                int livreId = (int)cboLivreEmprunt.SelectedValue;
                DateTime retourPrevu = dtRetourPrevu.Value;

                await _empruntService.CreerEmpruntAsync(usagerId, livreId, retourPrevu);

                MessageBox.Show("Emprunt créé !");
                await ReloadEmpruntsTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }

        private async void btnRetournerLivre_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpruntsLivres.CurrentRow == null)
                {
                    MessageBox.Show("Sélectionne un emprunt dans la liste.");
                    return;
                }

                int empruntId = (int)dgvEmpruntsLivres.CurrentRow.Cells["Id"].Value;
                await _empruntService.RetournerAsync(empruntId);

                MessageBox.Show("Retour effectué !");
                await ReloadEmpruntsTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }

        // Si tu veux filtrer la grille quand tu changes d’usager :
        private async void cboUsagerEmprunt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loading) return;

            if (cboUsagerEmprunt.SelectedValue is int usagerId)
                await ChargerEmpruntsAsync(usagerId);
        }

        private async void btnEmprunterMateriel_Click(object sender, EventArgs e)
        {
            try
            {
                string titre = txtTitreActivite.Text.Trim();
                int capacite = (int)numCapacite.Value;
                var type = (TypeActivite)cboTypeActivite.SelectedItem;

                if (titre.Length < 3)
                {
                    MessageBox.Show("Titre trop court.");
                    return;
                }

                await _activiteService.CreerAsync(titre, type, capacite);

                MessageBox.Show("Activité créée !");
                await ReloadActivitesTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }


        private async Task ChargerEmpruntsAsync(int usagerId)
        {
            var emprunts = await _empruntService.GetEmpruntsParUsagerAsync(usagerId);

            dgvEmpruntsLivres.AutoGenerateColumns = true;
            dgvEmpruntsLivres.DataSource = emprunts.Select(e => new
            {
                e.Id,
                Livre = e.Livre.Titre,
                Usager = e.Usager.NomComplet,
                e.DateEmprunt,
                e.DateRetourPrevue,
                e.Etat
            }).ToList();
        }


        private void LoadTypeActivite()
        {
            cboTypeActivite.DataSource = Enum.GetValues(typeof(TypeActivite));
        }

        private async Task ReloadActivitesTab()
        {
            await LoadActivites();
            await LoadUsagersActivite();
            await LoadParticipations();
        }

        private async Task LoadActivites()
        {
            var activites = await _activiteService.GetAllAsync();

            cboActivite.DisplayMember = "Titre";
            cboActivite.ValueMember = "Id";
            cboActivite.DataSource = activites.ToList();
        }

        private async Task LoadUsagersActivite()
        {
            var usagers = await _usagerService.GetActifsAsync();

            cboUsagerActivite.DisplayMember = "NomComplet";
            cboUsagerActivite.ValueMember = "Id";
            cboUsagerActivite.DataSource = usagers.ToList();
        }

        private async Task LoadParticipations()
        {
            var data = await _activiteService.GetParticipationsAsync();

            dgvParticipations.AutoGenerateColumns = true;
            dgvParticipations.DataSource = data.Select(p => new
            {
                Activite = p.Activite.Titre,
                Usager = p.Usager.NomComplet,
                p.DateInscription,
                p.Presence
            }).ToList();
        }


        //private async void btnEmprunterMateriel_Click(object sender, EventArgs e)
        //{
            
        //}

        private async void btnInscrire_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboActivite.SelectedValue == null || cboUsagerActivite.SelectedValue == null)
                {
                    MessageBox.Show("Choisis une activité et un usager.");
                    return;
                }

                int activiteId = (int)cboActivite.SelectedValue;
                int usagerId = (int)cboUsagerActivite.SelectedValue;

                await _activiteService.InscrireAsync(usagerId, activiteId);

                MessageBox.Show("Usager inscrit !");
                await LoadParticipations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }

        }

        private void cboUsagerEmprunt_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private async void cboUsagerMateriel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsagerMateriel.SelectedValue == null) return;

            try
            {
                await LoadEmpruntsMaterielGrid();
            }
            catch
            {
                // ignore pendant le binding
            }
        }

        private async void btnAjouterMateriel_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = txtNomMateriel.Text.Trim();
                int quantite = (int)numQuantiteMateriel.Value;

                if (string.IsNullOrWhiteSpace(nom))
                {
                    MessageBox.Show("Nom du matériel obligatoire.");
                    return;
                }

                if (quantite <= 0)
                {
                    MessageBox.Show("Quantité invalide.");
                    return;
                }

                using var db = _dbFactory.Create();

                db.Materiels.Add(new Materiel
                {
                    Nom = nom,
                    QuantiteTotale = quantite,
                    Actif = true
                });

                await db.SaveChangesAsync();

                MessageBox.Show("✅ Matériel ajouté !");
                txtNomMateriel.Clear();
                numQuantiteMateriel.Value = 1;

                await ReloadMaterielTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }

        private async void btnEmprunterMateriel_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cboUsagerMateriel.SelectedValue == null || cboMateriel.SelectedValue == null)
                {
                    MessageBox.Show("Choisis un usager et un matériel.");
                    return;
                }

                int usagerId = (int)cboUsagerMateriel.SelectedValue;
                int materielId = (int)cboMateriel.SelectedValue;

                using var db = _dbFactory.Create();
                var service = new MaterielService(db);

                await service.EmprunterMaterielAsync(materielId, usagerId);

                MessageBox.Show("✅ Matériel emprunté !");
                await ReloadMaterielTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }

        private async void btnRetournerMateriel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMateriels.CurrentRow == null)
                {
                    MessageBox.Show("Sélectionne un emprunt matériel dans la liste.");
                    return;
                }

                int empruntId = (int)dgvMateriels.CurrentRow.Cells["Id"].Value;

                using var db = _dbFactory.Create();
                var service = new MaterielService(db);

                await service.RetournerMaterielAsync(empruntId);

                MessageBox.Show("✅ Matériel retourné !");
                await ReloadMaterielTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }

        private void dgvParticipations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblUsagerIdM_Click(object sender, EventArgs e)
        { }

        private async void btnCreerActivite_Click(object sender, EventArgs e)
        {
            try
            {
                string titre = txtTitreActivite.Text.Trim();
                int capacite = (int)numCapacite.Value;
                var type = (TypeActivite)cboTypeActivite.SelectedItem;

                await _activiteService.CreerAsync(titre, type, capacite);

                MessageBox.Show("✅ Activité créée !");
                await ReloadActivitesTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }
    }
}
