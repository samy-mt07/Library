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
<<<<<<< HEAD
            lblTitre = new Label();
            tabControl1 = new TabControl();
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
            tabControl1.SuspendLayout();
            lblUsagerId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpruntsLivres).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParticipations).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Location = new Point(403, 32);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(201, 25);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Gestion de Bibliothèque";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(lblUsagerId);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(47, 60);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(629, 743);
            tabControl1.TabIndex = 1;
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
            lblUsagerId.Size = new Size(621, 705);
            lblUsagerId.TabIndex = 0;
            lblUsagerId.Text = "Usager ID";
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
            dgvEmpruntsLivres.Location = new Point(104, 325);
            dgvEmpruntsLivres.Name = "dgvEmpruntsLivres";
            dgvEmpruntsLivres.RowHeadersWidth = 62;
            dgvEmpruntsLivres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpruntsLivres.Size = new Size(360, 225);
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
            label1.Click += label1_Click;
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
            tabPage2.Size = new Size(621, 705);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInscrire
            // 
            btnInscrire.Location = new Point(209, 404);
            btnInscrire.Name = "btnInscrire";
            btnInscrire.Size = new Size(206, 34);
            btnInscrire.TabIndex = 15;
            btnInscrire.Text = "inscrir";
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
            dgvParticipations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipations.Location = new Point(125, 456);
            dgvParticipations.Name = "dgvParticipations";
            dgvParticipations.ReadOnly = true;
            dgvParticipations.RowHeadersWidth = 62;
            dgvParticipations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParticipations.Size = new Size(360, 225);
            dgvParticipations.TabIndex = 8;
            // 
            // lblEmpruntMaterielId
            // 
            lblEmpruntMaterielId.AutoSize = true;
            lblEmpruntMaterielId.Location = new Point(33, 156);
            lblEmpruntMaterielId.Name = "lblEmpruntMaterielId";
            lblEmpruntMaterielId.Size = new Size(79, 25);
            lblEmpruntMaterielId.TabIndex = 5;
            lblEmpruntMaterielId.Text = "Capacite";
            // 
            // btnCreerActivite
            // 
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
            lblTitrer.Location = new Point(33, 18);
            lblTitrer.Name = "lblTitrer";
            lblTitrer.Size = new Size(43, 25);
            lblTitrer.TabIndex = 0;
            lblTitrer.Text = "titre";
            // 
=======
            SuspendLayout();
            // 
>>>>>>> e80ee4aa827c85436f43b3d8139a9c038cd52199
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(1042, 857);
            Controls.Add(tabControl1);
            Controls.Add(lblTitre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            lblUsagerId.ResumeLayout(false);
            lblUsagerId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpruntsLivres).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacite).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParticipations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private TabControl tabControl1;
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
=======
            ClientSize = new Size(1042, 715);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
>>>>>>> e80ee4aa827c85436f43b3d8139a9c038cd52199
    }
}
