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
            tabControl1 = new TabControl();
            lblUsagerId = new TabPage();
            btnRetournerLivre = new Button();
            dgvEmprunts = new DataGridView();
            txtEmpruntId = new TextBox();
            lblEmpruntId = new Label();
            btnEmprunterLivre = new Button();
            txtUsagerId = new TextBox();
            label1 = new Label();
            txtLivreId = new TextBox();
            lblLivreId = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            btnRetournerMateriel = new Button();
            txtEmpruntMaterielId = new TextBox();
            lblEmpruntMaterielId = new Label();
            btnEmprunterMateriel = new Button();
            txtUsagerIdM = new TextBox();
            lblUsagerIdM = new Label();
            txtMaterielId = new TextBox();
            lblMaterielId = new Label();
            tabControl1.SuspendLayout();
            lblUsagerId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmprunts).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabControl1.Size = new Size(629, 650);
            tabControl1.TabIndex = 1;
            // 
            // lblUsagerId
            // 
            lblUsagerId.Controls.Add(btnRetournerLivre);
            lblUsagerId.Controls.Add(dgvEmprunts);
            lblUsagerId.Controls.Add(txtEmpruntId);
            lblUsagerId.Controls.Add(lblEmpruntId);
            lblUsagerId.Controls.Add(btnEmprunterLivre);
            lblUsagerId.Controls.Add(txtUsagerId);
            lblUsagerId.Controls.Add(label1);
            lblUsagerId.Controls.Add(txtLivreId);
            lblUsagerId.Controls.Add(lblLivreId);
            lblUsagerId.Location = new Point(4, 34);
            lblUsagerId.Name = "lblUsagerId";
            lblUsagerId.Padding = new Padding(3);
            lblUsagerId.Size = new Size(621, 612);
            lblUsagerId.TabIndex = 0;
            lblUsagerId.Text = "Usager ID";
            lblUsagerId.UseVisualStyleBackColor = true;
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
            // dgvEmprunts
            // 
            dgvEmprunts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprunts.Location = new Point(104, 325);
            dgvEmprunts.Name = "dgvEmprunts";
            dgvEmprunts.RowHeadersWidth = 62;
            dgvEmprunts.Size = new Size(360, 225);
            dgvEmprunts.TabIndex = 8;
            // 
            // txtEmpruntId
            // 
            txtEmpruntId.Location = new Point(301, 189);
            txtEmpruntId.Name = "txtEmpruntId";
            txtEmpruntId.Size = new Size(150, 31);
            txtEmpruntId.TabIndex = 6;
            // 
            // lblEmpruntId
            // 
            lblEmpruntId.AutoSize = true;
            lblEmpruntId.Location = new Point(51, 195);
            lblEmpruntId.Name = "lblEmpruntId";
            lblEmpruntId.Size = new Size(103, 25);
            lblEmpruntId.TabIndex = 5;
            lblEmpruntId.Text = "\tEmprunt ID";
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
            // txtUsagerId
            // 
            txtUsagerId.Location = new Point(301, 122);
            txtUsagerId.Name = "txtUsagerId";
            txtUsagerId.Size = new Size(210, 31);
            txtUsagerId.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 122);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 2;
            label1.Text = "ID de l’usager";
            label1.Click += label1_Click;
            // 
            // txtLivreId
            // 
            txtLivreId.Location = new Point(331, 28);
            txtLivreId.Name = "txtLivreId";
            txtLivreId.Size = new Size(150, 31);
            txtLivreId.TabIndex = 1;
            // 
            // lblLivreId
            // 
            lblLivreId.AutoSize = true;
            lblLivreId.Location = new Point(51, 28);
            lblLivreId.Name = "lblLivreId";
            lblLivreId.Size = new Size(71, 25);
            lblLivreId.TabIndex = 0;
            lblLivreId.Text = "Livre ID";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(btnRetournerMateriel);
            tabPage2.Controls.Add(txtEmpruntMaterielId);
            tabPage2.Controls.Add(lblEmpruntMaterielId);
            tabPage2.Controls.Add(btnEmprunterMateriel);
            tabPage2.Controls.Add(txtUsagerIdM);
            tabPage2.Controls.Add(lblUsagerIdM);
            tabPage2.Controls.Add(txtMaterielId);
            tabPage2.Controls.Add(lblMaterielId);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(621, 612);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(125, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 8;
            // 
            // btnRetournerMateriel
            // 
            btnRetournerMateriel.Location = new Point(362, 212);
            btnRetournerMateriel.Name = "btnRetournerMateriel";
            btnRetournerMateriel.Size = new Size(112, 34);
            btnRetournerMateriel.TabIndex = 7;
            btnRetournerMateriel.Text = "Retourner matériel";
            btnRetournerMateriel.UseVisualStyleBackColor = true;
            btnRetournerMateriel.Click += btnRetournerMateriel_Click;
            // 
            // txtEmpruntMaterielId
            // 
            txtEmpruntMaterielId.Location = new Point(352, 150);
            txtEmpruntMaterielId.Name = "txtEmpruntMaterielId";
            txtEmpruntMaterielId.Size = new Size(150, 31);
            txtEmpruntMaterielId.TabIndex = 6;
            txtEmpruntMaterielId.Text = "ID emprunt";
            // 
            // lblEmpruntMaterielId
            // 
            lblEmpruntMaterielId.AutoSize = true;
            lblEmpruntMaterielId.Location = new Point(33, 156);
            lblEmpruntMaterielId.Name = "lblEmpruntMaterielId";
            lblEmpruntMaterielId.Size = new Size(171, 25);
            lblEmpruntMaterielId.TabIndex = 5;
            lblEmpruntMaterielId.Text = "Emprunt matériel ID";
            // 
            // btnEmprunterMateriel
            // 
            btnEmprunterMateriel.Location = new Point(53, 212);
            btnEmprunterMateriel.Name = "btnEmprunterMateriel";
            btnEmprunterMateriel.Size = new Size(112, 34);
            btnEmprunterMateriel.TabIndex = 4;
            btnEmprunterMateriel.Text = "Emprunter matériel";
            btnEmprunterMateriel.UseVisualStyleBackColor = true;
            btnEmprunterMateriel.Click += btnEmprunterMateriel_Click;
            // 
            // txtUsagerIdM
            // 
            txtUsagerIdM.Location = new Point(335, 93);
            txtUsagerIdM.Name = "txtUsagerIdM";
            txtUsagerIdM.Size = new Size(150, 31);
            txtUsagerIdM.TabIndex = 3;
            txtUsagerIdM.Text = "ID usager";
            // 
            // lblUsagerIdM
            // 
            lblUsagerIdM.AutoSize = true;
            lblUsagerIdM.Location = new Point(33, 83);
            lblUsagerIdM.Name = "lblUsagerIdM";
            lblUsagerIdM.Size = new Size(90, 25);
            lblUsagerIdM.TabIndex = 2;
            lblUsagerIdM.Text = "Usager ID";
            // 
            // txtMaterielId
            // 
            txtMaterielId.Location = new Point(335, 28);
            txtMaterielId.Name = "txtMaterielId";
            txtMaterielId.Size = new Size(150, 31);
            txtMaterielId.TabIndex = 1;
            txtMaterielId.Text = "ID matériel";
            // 
            // lblMaterielId
            // 
            lblMaterielId.AutoSize = true;
            lblMaterielId.Location = new Point(33, 18);
            lblMaterielId.Name = "lblMaterielId";
            lblMaterielId.Size = new Size(98, 25);
            lblMaterielId.TabIndex = 0;
            lblMaterielId.Text = "Matériel ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 715);
            Controls.Add(tabControl1);
            Controls.Add(lblTitre);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            lblUsagerId.ResumeLayout(false);
            lblUsagerId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmprunts).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private TabControl tabControl1;
        private TabPage lblUsagerId;
        private TabPage tabPage2;
        private TextBox txtLivreId;
        private Label lblLivreId;
        private Label label1;
        private Button btnEmprunterLivre;
        private TextBox txtUsagerId;
        private Button btnRetournerLivre;
        private TextBox txtEmpruntId;
        private Label lblEmpruntId;
        private DataGridView dgvEmprunts;
        private TextBox txtUsagerIdM;
        private Label lblUsagerIdM;
        private TextBox txtMaterielId;
        private Label lblMaterielId;
        private DataGridView dataGridView1;
        private Button btnRetournerMateriel;
        private TextBox txtEmpruntMaterielId;
        private Label lblEmpruntMaterielId;
        private Button btnEmprunterMateriel;
    }
}
