using Library.Application.Services;
using Library.Infrastructure.Data;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        private readonly BibliothequeDbContext _db;
        public Form1()
        {
           
            InitializeComponent();
            _db = new BibliothequeDbContext();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnEmprunterLivre_Click(object sender, EventArgs e)
        {
            var service = new EmpruntService(_db);

            await service.EmprunterLivreAsync(
                int.Parse(txtLivreId.Text),
                int.Parse(txtUsagerId.Text)
            );

            MessageBox.Show("Livre emprunté avec succès");
        }

        private async void btnRetournerLivre_Click(object sender, EventArgs e)
        {
            var service = new EmpruntService(_db);

            await service.RetournerLivreAsync(
                int.Parse(txtEmpruntId.Text)
            );

            MessageBox.Show("Livre retourné");
        }
        private async void ChargerEmprunts(int usagerId)
        {
            var service = new EmpruntService(_db);
            dgvEmprunts.DataSource =
                await service.GetEmpruntsParUsagerAsync(usagerId);
        }

        private async void btnEmprunterMateriel_Click(object sender, EventArgs e)
        {
            var service = new MaterielService(_db);

            await service.EmprunterMaterielAsync(
                int.Parse(txtMaterielId.Text),
                int.Parse(txtUsagerIdM.Text)
            );

            MessageBox.Show("Matériel emprunté");
        }

        private async void btnRetournerMateriel_Click(object sender, EventArgs e)
        {
            var service = new MaterielService(_db);

            await service.RetournerMaterielAsync(
                int.Parse(txtEmpruntMaterielId.Text)
            );

            MessageBox.Show("Matériel retourné");
        }
        private async void ChargerMateriel(int usagerId)
        {
            var service = new MaterielService(_db);
            dataGridView1.DataSource =
                await service.GetHistoriqueParUsagerAsync(usagerId);
        }

    }
}
