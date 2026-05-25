namespace GestionPersonnelsMediatheque.View
{
    partial class fmrAjoutAbsence
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
            this.btnEnregistrerAjoutAbsence = new System.Windows.Forms.Button();
            this.btnAnnulerAjoutAbsence = new System.Windows.Forms.Button();
            this.cboMotifAjoutAbsence = new System.Windows.Forms.ComboBox();
            this.dateFinAjoutAbsence = new System.Windows.Forms.DateTimePicker();
            this.dateDebutAjoutAbsence = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAjoutEtModif.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAjoutEtModif
            // 
            this.grpAjoutEtModif.Controls.Add(this.btnEnregistrerAjoutAbsence);
            this.grpAjoutEtModif.Controls.Add(this.btnAnnulerAjoutAbsence);
            this.grpAjoutEtModif.Controls.Add(this.cboMotifAjoutAbsence);
            this.grpAjoutEtModif.Controls.Add(this.dateFinAjoutAbsence);
            this.grpAjoutEtModif.Controls.Add(this.dateDebutAjoutAbsence);
            this.grpAjoutEtModif.Controls.Add(this.label3);
            this.grpAjoutEtModif.Controls.Add(this.label2);
            this.grpAjoutEtModif.Controls.Add(this.label1);
            this.grpAjoutEtModif.Location = new System.Drawing.Point(13, 13);
            this.grpAjoutEtModif.Name = "grpAjoutEtModif";
            this.grpAjoutEtModif.Size = new System.Drawing.Size(331, 270);
            this.grpAjoutEtModif.TabIndex = 0;
            this.grpAjoutEtModif.TabStop = false;
            this.grpAjoutEtModif.Text = "Ajouter absence";
            // 
            // btnEnregistrerAjoutAbsence
            // 
            this.btnEnregistrerAjoutAbsence.Location = new System.Drawing.Point(198, 186);
            this.btnEnregistrerAjoutAbsence.Name = "btnEnregistrerAjoutAbsence";
            this.btnEnregistrerAjoutAbsence.Size = new System.Drawing.Size(110, 41);
            this.btnEnregistrerAjoutAbsence.TabIndex = 13;
            this.btnEnregistrerAjoutAbsence.Text = "enregistrer";
            this.btnEnregistrerAjoutAbsence.UseVisualStyleBackColor = true;
            this.btnEnregistrerAjoutAbsence.Click += new System.EventHandler(this.btnEnregistrerAjoutAbsence_Click);
            // 
            // btnAnnulerAjoutAbsence
            // 
            this.btnAnnulerAjoutAbsence.Location = new System.Drawing.Point(82, 186);
            this.btnAnnulerAjoutAbsence.Name = "btnAnnulerAjoutAbsence";
            this.btnAnnulerAjoutAbsence.Size = new System.Drawing.Size(110, 41);
            this.btnAnnulerAjoutAbsence.TabIndex = 12;
            this.btnAnnulerAjoutAbsence.Text = "annuler";
            this.btnAnnulerAjoutAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulerAjoutAbsence.Click += new System.EventHandler(this.btnAnnulerAjoutAbsence_Click);
            // 
            // cboMotifAjoutAbsence
            // 
            this.cboMotifAjoutAbsence.FormattingEnabled = true;
            this.cboMotifAjoutAbsence.Items.AddRange(new object[] {
            "Vacances",
            "Maladie",
            "motif familial",
            "congé parental"});
            this.cboMotifAjoutAbsence.Location = new System.Drawing.Point(149, 140);
            this.cboMotifAjoutAbsence.Name = "cboMotifAjoutAbsence";
            this.cboMotifAjoutAbsence.Size = new System.Drawing.Size(154, 28);
            this.cboMotifAjoutAbsence.TabIndex = 5;
            // 
            // dateFinAjoutAbsence
            // 
            this.dateFinAjoutAbsence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinAjoutAbsence.Location = new System.Drawing.Point(149, 92);
            this.dateFinAjoutAbsence.Name = "dateFinAjoutAbsence";
            this.dateFinAjoutAbsence.Size = new System.Drawing.Size(154, 26);
            this.dateFinAjoutAbsence.TabIndex = 4;
            // 
            // dateDebutAjoutAbsence
            // 
            this.dateDebutAjoutAbsence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDebutAjoutAbsence.Location = new System.Drawing.Point(149, 46);
            this.dateDebutAjoutAbsence.Name = "dateDebutAjoutAbsence";
            this.dateDebutAjoutAbsence.Size = new System.Drawing.Size(154, 26);
            this.dateDebutAjoutAbsence.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "motif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "date de fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "date de début ";
            // 
            // fmrAjoutAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 297);
            this.Controls.Add(this.grpAjoutEtModif);
            this.Name = "fmrAjoutAbsence";
            this.grpAjoutEtModif.ResumeLayout(false);
            this.grpAjoutEtModif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAjoutEtModif;
        private System.Windows.Forms.ComboBox cboMotifAjoutAbsence;
        private System.Windows.Forms.DateTimePicker dateFinAjoutAbsence;
        private System.Windows.Forms.DateTimePicker dateDebutAjoutAbsence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnulerAjoutAbsence;
        private System.Windows.Forms.Button btnEnregistrerAjoutAbsence;
    }
}