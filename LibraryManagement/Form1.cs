using Library.Application.Services;
using Library.Domain.Entities;
using Library.Infrastructure.Data;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        private readonly DbFactory _dbFactory = new DbFactory();

        private readonly EmpruntService _empruntService;
        private readonly Livreservice _livreService;
        private readonly UsagerService _usagerService;
        private readonly ActiviteService _activiteService;

        public Form1()
        {

            InitializeComponent();
            using (var db = _dbFactory.Create())
            {
                DbSeeder.SeedIfEmpty(db);
            }

            _empruntService = new EmpruntService(_dbFactory);
            _livreService = new Livreservice(_dbFactory);
            _usagerService = new UsagerService(_dbFactory);
            _activiteService = new ActiviteService(_dbFactory);

            this.Load += Form1_Load;
        }


        private void label1_Click(object sender, EventArgs e)
        {

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

                MessageBox.Show("✅ Emprunt créé !");
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

                MessageBox.Show("✅ Retour effectué !");
                await ReloadEmpruntsTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }
        private async void ChargerEmprunts(int usagerId)
        {
            var service = new EmpruntService(_dbFactory);
            dgvEmpruntsLivres.DataSource =
                await service.GetEmpruntsParUsagerAsync(usagerId);
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

                MessageBox.Show("✅ Activité créée !");
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


        private void lblLivreId_Click(object sender, EventArgs e)
        {

        }

        private void cboUsagerEmprunt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await ReloadEmpruntsTab();
            await ReloadActivitesTab();

        }
        private void LoadTypeActivite()
        {
            cboTypeActivite.DataSource = Enum.GetValues(typeof(TypeActivite));
        }

        private async Task ReloadEmpruntsTab()
        {
            await LoadUsagersForEmprunt();
            await LoadLivresForEmprunt();
            await LoadEmpruntsGrid();
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

                MessageBox.Show("✅ Usager inscrit !");
                await LoadParticipations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }
    }
}
