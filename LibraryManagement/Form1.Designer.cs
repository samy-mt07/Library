namespace LibraryManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitre = new Label();
            tabMateriel = new TabControl();
            lblUsagerId = new TabPage();
            dtRetourPrevu = new DateTimePicker();
            label2 = new Label();
            cboLivreEmprunt = new ComboBox();
            cboUsagerEmprunt = new ComboBox();
            Livre = new Label();
            usager = new Label();
            btnRetournerLivre = new Button();
            dgvEmpruntsLivres = new DataGridView();
            btnEmprunterLivre = new Button();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnInscrire = new Button();
            cboUsagerActivite = new ComboBox();
            label3 = new Label();
            cboActivite = new ComboBox();
            lblActivite = new Label();
            numCapacite = new NumericUpDown();
            cboTypeActivite = new ComboBox();
            dgvParticipations = new DataGridView();
            lblEmpruntMaterielId = new Label();
            btnCreerActivite = new Button();
            lblUsagerIdM = new Label();
            txtTitreActivite = new TextBox();
            lblTitrer = new Label();
            tabPage1 = new TabPage();
            btnRetournerMateriel = new Button();
            dgvMateriels = new DataGridView();
            btnEmprunterMateriel = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblRetourPrevuMateriellblRetourPrevuMateriel = new Label();
            cboMateriel = new ComboBox();
            label4 = new Label();
            cboUsagerMateriel = new ComboBox();
            lblUsagerMateriel = new Label();
            btnAjouterMateriel = new Button();
            numQuantiteMateriel = new NumericUpDown();
            lblQuantiteMateriel = new Label();
            txtNomMateriel = new TextBox();
            lblNomMateriel = new Label();
            tabMateriel.SuspendLayout();
            lblUsagerId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpruntsLivres).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParticipations).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMateriels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantiteMateriel).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.BorderStyle = BorderStyle.Fixed3D;
            lblTitre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(382, 9);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(296, 34);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Gestion de Bibliothèque";
            // 
            // tabMateriel
            // 
            tabMateriel.Controls.Add(lblUsagerId);
            tabMateriel.Controls.Add(tabPage2);
            tabMateriel.Controls.Add(tabPage1);
            tabMateriel.Location = new Point(12, 60);
            tabMateriel.Name = "tabMateriel";
            tabMateriel.SelectedIndex = 0;
            tabMateriel.Size = new Size(664, 879);
            tabMateriel.TabIndex = 1;
            // 
            // lblUsagerId
            // 
            lblUsagerId.Controls.Add(dtRetourPrevu);
            lblUsagerId.Controls.Add(label2);
            lblUsagerId.Controls.Add(cboLivreEmprunt);
            lblUsagerId.Controls.Add(cboUsagerEmprunt);
            lblUsagerId.Controls.Add(Livre);
            lblUsagerId.Controls.Add(usager);
            lblUsagerId.Controls.Add(btnRetournerLivre);
            lblUsagerId.Controls.Add(dgvEmpruntsLivres);
            lblUsagerId.Controls.Add(btnEmprunterLivre);
            lblUsagerId.Controls.Add(label1);
            lblUsagerId.Location = new Point(4, 34);
            lblUsagerId.Name = "lblUsagerId";
            lblUsagerId.Padding = new Padding(3);
            lblUsagerId.Size = new Size(656, 841);
            lblUsagerId.TabIndex = 0;
            lblUsagerId.Text = "Usager ";
            lblUsagerId.UseVisualStyleBackColor = true;
            // 
            // dtRetourPrevu
            // 
            dtRetourPrevu.Location = new Point(351, 125);
            dtRetourPrevu.Name = "dtRetourPrevu";
            dtRetourPrevu.Size = new Size(228, 31);
            dtRetourPrevu.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 125);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 14;
            label2.Text = "Retour prévu";
            // 
            // cboLivreEmprunt
            // 
            cboLivreEmprunt.FormattingEnabled = true;
            cboLivreEmprunt.Location = new Point(360, 75);
            cboLivreEmprunt.Name = "cboLivreEmprunt";
            cboLivreEmprunt.Size = new Size(182, 33);
            cboLivreEmprunt.TabIndex = 13;
            // 
            // cboUsagerEmprunt
            // 
            cboUsagerEmprunt.FormattingEnabled = true;
            cboUsagerEmprunt.Location = new Point(360, 20);
            cboUsagerEmprunt.Name = "cboUsagerEmprunt";
            cboUsagerEmprunt.Size = new Size(182, 33);
            cboUsagerEmprunt.TabIndex = 12;
            cboUsagerEmprunt.SelectedIndexChanged += cboUsagerEmprunt_SelectedIndexChanged_1;
            // 
            // Livre
            // 
            Livre.AutoSize = true;
            Livre.Location = new Point(337, 28);
            Livre.Name = "Livre";
            Livre.Size = new Size(0, 25);
            Livre.TabIndex = 11;
            // 
            // usager
            // 
            usager.AutoSize = true;
            usager.Location = new Point(39, 28);
            usager.Name = "usager";
            usager.Size = new Size(67, 25);
            usager.TabIndex = 9;
            usager.Text = "Usager";
            // 
            // btnRetournerLivre
            // 
            btnRetournerLivre.Location = new Point(63, 241);
            btnRetournerLivre.Name = "btnRetournerLivre";
            btnRetournerLivre.Size = new Size(112, 34);
            btnRetournerLivre.TabIndex = 7;
            btnRetournerLivre.Text = "\tRetourner";
            btnRetournerLivre.UseVisualStyleBackColor = true;
            btnRetournerLivre.Click += btnRetournerLivre_Click;
            // 
            // dgvEmpruntsLivres
            // 
            dgvEmpruntsLivres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpruntsLivres.Location = new Point(21, 358);
            dgvEmpruntsLivres.Name = "dgvEmpruntsLivres";
            dgvEmpruntsLivres.RowHeadersWidth = 62;
            dgvEmpruntsLivres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpruntsLivres.Size = new Size(595, 271);
            dgvEmpruntsLivres.TabIndex = 8;
            // 
            // btnEmprunterLivre
            // 
            btnEmprunterLivre.Location = new Point(301, 241);
            btnEmprunterLivre.Name = "btnEmprunterLivre";
            btnEmprunterLivre.Size = new Size(112, 34);
            btnEmprunterLivre.TabIndex = 4;
            btnEmprunterLivre.Text = "Emprunter";
            btnEmprunterLivre.UseVisualStyleBackColor = true;
            btnEmprunterLivre.Click += btnEmprunterLivre_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 75);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 2;
            label1.Text = "Livre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnInscrire);
            tabPage2.Controls.Add(cboUsagerActivite);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(cboActivite);
            tabPage2.Controls.Add(lblActivite);
            tabPage2.Controls.Add(numCapacite);
            tabPage2.Controls.Add(cboTypeActivite);
            tabPage2.Controls.Add(dgvParticipations);
            tabPage2.Controls.Add(lblEmpruntMaterielId);
            tabPage2.Controls.Add(btnCreerActivite);
            tabPage2.Controls.Add(lblUsagerIdM);
            tabPage2.Controls.Add(txtTitreActivite);
            tabPage2.Controls.Add(lblTitrer);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(656, 841);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Activite";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInscrire
            // 
            btnInscrire.Location = new Point(209, 404);
            btnInscrire.Name = "btnInscrire";
            btnInscrire.Size = new Size(206, 34);
            btnInscrire.TabIndex = 15;
            btnInscrire.Text = "Inscrire";
            btnInscrire.UseVisualStyleBackColor = true;
            btnInscrire.Click += btnInscrire_Click;
            // 
            // cboUsagerActivite
            // 
            cboUsagerActivite.FormattingEnabled = true;
            cboUsagerActivite.Location = new Point(303, 359);
            cboUsagerActivite.Name = "cboUsagerActivite";
            cboUsagerActivite.Size = new Size(182, 33);
            cboUsagerActivite.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 359);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 13;
            label3.Text = "Usager";
            // 
            // cboActivite
            // 
            cboActivite.FormattingEnabled = true;
            cboActivite.Location = new Point(303, 293);
            cboActivite.Name = "cboActivite";
            cboActivite.Size = new Size(182, 33);
            cboActivite.TabIndex = 12;
            // 
            // lblActivite
            // 
            lblActivite.AutoSize = true;
            lblActivite.Location = new Point(49, 301);
            lblActivite.Name = "lblActivite";
            lblActivite.Size = new Size(70, 25);
            lblActivite.TabIndex = 11;
            lblActivite.Text = "Activite";
            // 
            // numCapacite
            // 
            numCapacite.Location = new Point(335, 156);
            numCapacite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCapacite.Name = "numCapacite";
            numCapacite.Size = new Size(180, 31);
            numCapacite.TabIndex = 10;
            numCapacite.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboTypeActivite
            // 
            cboTypeActivite.FormattingEnabled = true;
            cboTypeActivite.Location = new Point(341, 88);
            cboTypeActivite.Name = "cboTypeActivite";
            cboTypeActivite.Size = new Size(182, 33);
            cboTypeActivite.TabIndex = 9;
            // 
            // dgvParticipations
            // 
            dgvParticipations.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvParticipations.BorderStyle = BorderStyle.Fixed3D;
            dgvParticipations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipations.Location = new Point(33, 456);
            dgvParticipations.Name = "dgvParticipations";
            dgvParticipations.ReadOnly = true;
            dgvParticipations.RowHeadersWidth = 62;
            dgvParticipations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParticipations.Size = new Size(595, 268);
            dgvParticipations.TabIndex = 8;
            dgvParticipations.CellContentClick += dgvParticipations_CellContentClick;
            // 
            // lblEmpruntMaterielId
            // 
            lblEmpruntMaterielId.AutoSize = true;
            lblEmpruntMaterielId.ForeColor = SystemColors.WindowFrame;
            lblEmpruntMaterielId.Location = new Point(33, 156);
            lblEmpruntMaterielId.Name = "lblEmpruntMaterielId";
            lblEmpruntMaterielId.Size = new Size(79, 25);
            lblEmpruntMaterielId.TabIndex = 5;
            lblEmpruntMaterielId.Text = "Capacite";
            // 
            // btnCreerActivite
            // 
            btnCreerActivite.ForeColor = SystemColors.Highlight;
            btnCreerActivite.Location = new Point(209, 218);
            btnCreerActivite.Name = "btnCreerActivite";
            btnCreerActivite.Size = new Size(206, 34);
            btnCreerActivite.TabIndex = 4;
            btnCreerActivite.Text = "Creer Activite";
            btnCreerActivite.UseVisualStyleBackColor = true;
            btnCreerActivite.Click += btnEmprunterMateriel_Click;
            // 
            // lblUsagerIdM
            // 
            lblUsagerIdM.AutoSize = true;
            lblUsagerIdM.Location = new Point(33, 83);
            lblUsagerIdM.Name = "lblUsagerIdM";
            lblUsagerIdM.Size = new Size(47, 25);
            lblUsagerIdM.TabIndex = 2;
            lblUsagerIdM.Text = "type";
            lblUsagerIdM.Click += lblUsagerIdM_Click;
            // 
            // txtTitreActivite
            // 
            txtTitreActivite.Location = new Point(335, 28);
            txtTitreActivite.Name = "txtTitreActivite";
            txtTitreActivite.Size = new Size(150, 31);
            txtTitreActivite.TabIndex = 1;
            // 
            // lblTitrer
            // 
            lblTitrer.AutoSize = true;
            lblTitrer.ForeColor = Color.Teal;
            lblTitrer.Location = new Point(37, 28);
            lblTitrer.Name = "lblTitrer";
            lblTitrer.Size = new Size(43, 25);
            lblTitrer.TabIndex = 0;
            lblTitrer.Text = "titre";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRetournerMateriel);
            tabPage1.Controls.Add(dgvMateriels);
            tabPage1.Controls.Add(btnEmprunterMateriel);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(lblRetourPrevuMateriellblRetourPrevuMateriel);
            tabPage1.Controls.Add(cboMateriel);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(cboUsagerMateriel);
            tabPage1.Controls.Add(lblUsagerMateriel);
            tabPage1.Controls.Add(btnAjouterMateriel);
            tabPage1.Controls.Add(numQuantiteMateriel);
            tabPage1.Controls.Add(lblQuantiteMateriel);
            tabPage1.Controls.Add(txtNomMateriel);
            tabPage1.Controls.Add(lblNomMateriel);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(656, 841);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Matériel";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRetournerMateriel
            // 
            btnRetournerMateriel.Location = new Point(161, 452);
            btnRetournerMateriel.Name = "btnRetournerMateriel";
            btnRetournerMateriel.Size = new Size(112, 34);
            btnRetournerMateriel.TabIndex = 13;
            btnRetournerMateriel.Text = "Retourner";
            btnRetournerMateriel.UseVisualStyleBackColor = true;
            btnRetournerMateriel.Click += btnRetournerMateriel_Click;
            // 
            // dgvMateriels
            // 
            dgvMateriels.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvMateriels.BorderStyle = BorderStyle.Fixed3D;
            dgvMateriels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriels.Location = new Point(6, 492);
            dgvMateriels.Name = "dgvMateriels";
            dgvMateriels.RowHeadersWidth = 62;
            dgvMateriels.Size = new Size(644, 259);
            dgvMateriels.TabIndex = 12;
            // 
            // btnEmprunterMateriel
            // 
            btnEmprunterMateriel.Location = new Point(352, 452);
            btnEmprunterMateriel.Name = "btnEmprunterMateriel";
            btnEmprunterMateriel.Size = new Size(112, 34);
            btnEmprunterMateriel.TabIndex = 11;
            btnEmprunterMateriel.Text = "Emprunter";
            btnEmprunterMateriel.UseVisualStyleBackColor = true;
            btnEmprunterMateriel.Click += btnEmprunterMateriel_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(371, 406);
            dateTimePicker1.MinDate = new DateTime(2026, 1, 22, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(218, 31);
            dateTimePicker1.TabIndex = 10;
            // 
            // lblRetourPrevuMateriellblRetourPrevuMateriel
            // 
            lblRetourPrevuMateriellblRetourPrevuMateriel.AutoSize = true;
            lblRetourPrevuMateriellblRetourPrevuMateriel.Location = new Point(41, 406);
            lblRetourPrevuMateriellblRetourPrevuMateriel.Name = "lblRetourPrevuMateriellblRetourPrevuMateriel";
            lblRetourPrevuMateriellblRetourPrevuMateriel.Size = new Size(114, 25);
            lblRetourPrevuMateriellblRetourPrevuMateriel.TabIndex = 9;
            lblRetourPrevuMateriellblRetourPrevuMateriel.Text = "Retour prévu";
            // 
            // cboMateriel
            // 
            cboMateriel.FormattingEnabled = true;
            cboMateriel.Location = new Point(371, 334);
            cboMateriel.Name = "cboMateriel";
            cboMateriel.Size = new Size(182, 33);
            cboMateriel.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 337);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 7;
            label4.Text = "Matériel";
            // 
            // cboUsagerMateriel
            // 
            cboUsagerMateriel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsagerMateriel.FormattingEnabled = true;
            cboUsagerMateriel.Location = new Point(374, 274);
            cboUsagerMateriel.Name = "cboUsagerMateriel";
            cboUsagerMateriel.Size = new Size(182, 33);
            cboUsagerMateriel.TabIndex = 6;
            cboUsagerMateriel.SelectedIndexChanged += cboUsagerMateriel_SelectedIndexChanged;
            // 
            // lblUsagerMateriel
            // 
            lblUsagerMateriel.AutoSize = true;
            lblUsagerMateriel.Location = new Point(36, 268);
            lblUsagerMateriel.Name = "lblUsagerMateriel";
            lblUsagerMateriel.Size = new Size(67, 25);
            lblUsagerMateriel.TabIndex = 5;
            lblUsagerMateriel.Text = "Usager";
            // 
            // btnAjouterMateriel
            // 
            btnAjouterMateriel.Location = new Point(272, 189);
            btnAjouterMateriel.Name = "btnAjouterMateriel";
            btnAjouterMateriel.Size = new Size(112, 34);
            btnAjouterMateriel.TabIndex = 4;
            btnAjouterMateriel.Text = "Ajouter";
            btnAjouterMateriel.UseVisualStyleBackColor = true;
            btnAjouterMateriel.Click += btnAjouterMateriel_Click;
            // 
            // numQuantiteMateriel
            // 
            numQuantiteMateriel.Location = new Point(390, 112);
            numQuantiteMateriel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantiteMateriel.Name = "numQuantiteMateriel";
            numQuantiteMateriel.Size = new Size(180, 31);
            numQuantiteMateriel.TabIndex = 3;
            numQuantiteMateriel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQuantiteMateriel
            // 
            lblQuantiteMateriel.AutoSize = true;
            lblQuantiteMateriel.Location = new Point(36, 118);
            lblQuantiteMateriel.Name = "lblQuantiteMateriel";
            lblQuantiteMateriel.Size = new Size(80, 25);
            lblQuantiteMateriel.TabIndex = 2;
            lblQuantiteMateriel.Text = "Quantité";
            // 
            // txtNomMateriel
            // 
            txtNomMateriel.Location = new Point(390, 45);
            txtNomMateriel.Name = "txtNomMateriel";
            txtNomMateriel.Size = new Size(150, 31);
            txtNomMateriel.TabIndex = 1;
            // 
            // lblNomMateriel
            // 
            lblNomMateriel.AutoSize = true;
            lblNomMateriel.Location = new Point(36, 45);
            lblNomMateriel.Name = "lblNomMateriel";
            lblNomMateriel.Size = new Size(146, 25);
            lblNomMateriel.TabIndex = 0;
            lblNomMateriel.Text = "Nom du matériel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 857);
            Controls.Add(tabMateriel);
            Controls.Add(lblTitre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabMateriel.ResumeLayout(false);
            lblUsagerId.ResumeLayout(false);
            lblUsagerId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpruntsLivres).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacite).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParticipations).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMateriels).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantiteMateriel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private TabControl tabMateriel;
        private TabPage lblUsagerId;
        private TabPage tabPage2;
        private Label label1;
        private Button btnEmprunterLivre;
        private Button btnRetournerLivre;
        private DataGridView dgvEmpruntsLivres;
        private TextBox txtUsagerIdM;
        private Label lblUsagerIdM;
        private TextBox txtTitreActivite;
        private Label lblTitrer;
        private DataGridView dgvParticipations;
        private TextBox txtEmpruntMaterielId;
        private Label lblEmpruntMaterielId;
        private Button btnCreerActivite;
        private Label Livre;
        private Label usager;
        private Label label2;
        private ComboBox cboLivreEmprunt;
        private ComboBox cboUsagerEmprunt;
        private DateTimePicker dtRetourPrevu;
        private NumericUpDown numCapacite;
        private ComboBox cboTypeActivite;
        private ComboBox cboActivite;
        private Label lblActivite;
        private Button btnInscrire;
        private ComboBox cboUsagerActivite;
        private Label label3;
        private TabPage tabPage1;
        private Label lblQuantiteMateriel;
        private TextBox txtNomMateriel;
        private Label lblNomMateriel;
        private ComboBox cboMateriel;
        private Label label4;
        private ComboBox cboUsagerMateriel;
        private Label lblUsagerMateriel;
        private Button btnAjouterMateriel;
        private NumericUpDown numQuantiteMateriel;
        private Button btnEmprunterMateriel;
        private DateTimePicker dateTimePicker1;
        private Label lblRetourPrevuMateriellblRetourPrevuMateriel;
        private DataGridView dgvMateriels;
        private Button btnRetournerMateriel;
    }
}
