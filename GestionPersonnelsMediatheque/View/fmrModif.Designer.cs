namespace GestionPersonnelsMediatheque.View
{
    partial class fmrModif
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
            this.btnAnnulerModif = new System.Windows.Forms.Button();
            this.btnEnregistrerModif = new System.Windows.Forms.Button();
            this.cboServiceModif = new System.Windows.Forms.ComboBox();
            this.txtMailModif = new System.Windows.Forms.TextBox();
            this.txtTelModif = new System.Windows.Forms.TextBox();
            this.txtPrenomModif = new System.Windows.Forms.TextBox();
            this.txtNomModif = new System.Windows.Forms.TextBox();
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
            this.grpAjoutEtModif.Controls.Add(this.btnAnnulerModif);
            this.grpAjoutEtModif.Controls.Add(this.btnEnregistrerModif);
            this.grpAjoutEtModif.Controls.Add(this.cboServiceModif);
            this.grpAjoutEtModif.Controls.Add(this.txtMailModif);
            this.grpAjoutEtModif.Controls.Add(this.txtTelModif);
            this.grpAjoutEtModif.Controls.Add(this.txtPrenomModif);
            this.grpAjoutEtModif.Controls.Add(this.txtNomModif);
            this.grpAjoutEtModif.Controls.Add(this.label5);
            this.grpAjoutEtModif.Controls.Add(this.label4);
            this.grpAjoutEtModif.Controls.Add(this.label3);
            this.grpAjoutEtModif.Controls.Add(this.label2);
            this.grpAjoutEtModif.Controls.Add(this.label1);
            this.grpAjoutEtModif.Location = new System.Drawing.Point(12, 12);
            this.grpAjoutEtModif.Name = "grpAjoutEtModif";
            this.grpAjoutEtModif.Size = new System.Drawing.Size(440, 322);
            this.grpAjoutEtModif.TabIndex = 1;
            this.grpAjoutEtModif.TabStop = false;
            this.grpAjoutEtModif.Text = "Modifier un personnel";
            // 
            // btnAnnulerModif
            // 
            this.btnAnnulerModif.Location = new System.Drawing.Point(192, 275);
            this.btnAnnulerModif.Name = "btnAnnulerModif";
            this.btnAnnulerModif.Size = new System.Drawing.Size(110, 41);
            this.btnAnnulerModif.TabIndex = 11;
            this.btnAnnulerModif.Text = "annuler";
            this.btnAnnulerModif.UseVisualStyleBackColor = true;
            this.btnAnnulerModif.Click += new System.EventHandler(this.btnAnnulerModif_Click);
            // 
            // btnEnregistrerModif
            // 
            this.btnEnregistrerModif.Location = new System.Drawing.Point(308, 275);
            this.btnEnregistrerModif.Name = "btnEnregistrerModif";
            this.btnEnregistrerModif.Size = new System.Drawing.Size(110, 41);
            this.btnEnregistrerModif.TabIndex = 10;
            this.btnEnregistrerModif.Text = "enregistrer";
            this.btnEnregistrerModif.UseVisualStyleBackColor = true;
            this.btnEnregistrerModif.Click += new System.EventHandler(this.btnEnregistrerModif_Click);
            // 
            // cboServiceModif
            // 
            this.cboServiceModif.AutoCompleteCustomSource.AddRange(new string[] {
            "administratif",
            "médiation culturelle",
            "prêt"});
            this.cboServiceModif.FormattingEnabled = true;
            this.cboServiceModif.Items.AddRange(new object[] {
            "administratif",
            "médiation culturelle",
            "prêt"});
            this.cboServiceModif.Location = new System.Drawing.Point(93, 232);
            this.cboServiceModif.Name = "cboServiceModif";
            this.cboServiceModif.Size = new System.Drawing.Size(325, 28);
            this.cboServiceModif.TabIndex = 9;
            // 
            // txtMailModif
            // 
            this.txtMailModif.Location = new System.Drawing.Point(93, 183);
            this.txtMailModif.Name = "txtMailModif";
            this.txtMailModif.Size = new System.Drawing.Size(325, 26);
            this.txtMailModif.TabIndex = 8;
            // 
            // txtTelModif
            // 
            this.txtTelModif.Location = new System.Drawing.Point(93, 137);
            this.txtTelModif.Name = "txtTelModif";
            this.txtTelModif.Size = new System.Drawing.Size(325, 26);
            this.txtTelModif.TabIndex = 7;
            // 
            // txtPrenomModif
            // 
            this.txtPrenomModif.Location = new System.Drawing.Point(93, 87);
            this.txtPrenomModif.Name = "txtPrenomModif";
            this.txtPrenomModif.Size = new System.Drawing.Size(325, 26);
            this.txtPrenomModif.TabIndex = 6;
            // 
            // txtNomModif
            // 
            this.txtNomModif.Location = new System.Drawing.Point(93, 46);
            this.txtNomModif.Name = "txtNomModif";
            this.txtNomModif.Size = new System.Drawing.Size(325, 26);
            this.txtNomModif.TabIndex = 5;
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
            // fmrModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 347);
            this.Controls.Add(this.grpAjoutEtModif);
            this.Name = "fmrModif";
            this.grpAjoutEtModif.ResumeLayout(false);
            this.grpAjoutEtModif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grpAjoutEtModif;
        private System.Windows.Forms.Button btnAnnulerModif;
        private System.Windows.Forms.Button btnEnregistrerModif;
        public System.Windows.Forms.ComboBox cboServiceModif;
        public System.Windows.Forms.TextBox txtMailModif;
        public System.Windows.Forms.TextBox txtTelModif;
        public System.Windows.Forms.TextBox txtPrenomModif;
        public System.Windows.Forms.TextBox txtNomModif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}