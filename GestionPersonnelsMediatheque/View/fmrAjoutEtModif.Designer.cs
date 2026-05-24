namespace GestionPersonnelsMediatheque.View
{
    partial class fmrAjoutEtModif
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAjoutEtModif = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAjoutEtModif.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAjoutEtModif
            // 
            this.grpAjoutEtModif.Controls.Add(this.btnAnnuler);
            this.grpAjoutEtModif.Controls.Add(this.btnEnregistrer);
            this.grpAjoutEtModif.Controls.Add(this.cboService);
            this.grpAjoutEtModif.Controls.Add(this.txtMail);
            this.grpAjoutEtModif.Controls.Add(this.txtTel);
            this.grpAjoutEtModif.Controls.Add(this.txtPrenom);
            this.grpAjoutEtModif.Controls.Add(this.txtNom);
            this.grpAjoutEtModif.Controls.Add(this.label5);
            this.grpAjoutEtModif.Controls.Add(this.label4);
            this.grpAjoutEtModif.Controls.Add(this.label3);
            this.grpAjoutEtModif.Controls.Add(this.label2);
            this.grpAjoutEtModif.Controls.Add(this.label1);
            this.grpAjoutEtModif.Location = new System.Drawing.Point(13, 13);
            this.grpAjoutEtModif.Name = "grpAjoutEtModif";
            this.grpAjoutEtModif.Size = new System.Drawing.Size(440, 322);
            this.grpAjoutEtModif.TabIndex = 0;
            this.grpAjoutEtModif.TabStop = false;
            this.grpAjoutEtModif.Text = "Ajouter un personnel";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(192, 275);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(110, 41);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(308, 275);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(110, 41);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // cboService
            // 
            this.cboService.AutoCompleteCustomSource.AddRange(new string[] {
            "administratif",
            "médiation culturelle",
            "prêt"});
            this.cboService.FormattingEnabled = true;
            this.cboService.Items.AddRange(new object[] {
            "administratif",
            "médiation culturelle",
            "prêt"});
            this.cboService.Location = new System.Drawing.Point(93, 232);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(325, 28);
            this.cboService.TabIndex = 9;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(93, 183);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(325, 26);
            this.txtMail.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(93, 137);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(325, 26);
            this.txtTel.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(93, 87);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(325, 26);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(93, 46);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(325, 26);
            this.txtNom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "téléphone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // fmrAjoutEtModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 347);
            this.Controls.Add(this.grpAjoutEtModif);
            this.Name = "fmrAjoutEtModif";
            this.grpAjoutEtModif.ResumeLayout(false);
            this.grpAjoutEtModif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        public System.Windows.Forms.ComboBox cboService;
        public System.Windows.Forms.TextBox txtMail;
        public System.Windows.Forms.TextBox txtTel;
        public System.Windows.Forms.TextBox txtPrenom;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.GroupBox grpAjoutEtModif;
    }
}