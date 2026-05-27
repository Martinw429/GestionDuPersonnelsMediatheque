namespace GestionPersonnelsMediatheque.View
{
    partial class fmrModifAbsence
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
            this.btnEnregistrerModifAbsence = new System.Windows.Forms.Button();
            this.btnAnnulerModifAbsence = new System.Windows.Forms.Button();
            this.cboMotifModifAbsence = new System.Windows.Forms.ComboBox();
            this.dateFinAbsenceModif = new System.Windows.Forms.DateTimePicker();
            this.dateDebutModifAbsence = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAjoutEtModif.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAjoutEtModif
            // 
            this.grpAjoutEtModif.Controls.Add(this.btnEnregistrerModifAbsence);
            this.grpAjoutEtModif.Controls.Add(this.btnAnnulerModifAbsence);
            this.grpAjoutEtModif.Controls.Add(this.cboMotifModifAbsence);
            this.grpAjoutEtModif.Controls.Add(this.dateFinAbsenceModif);
            this.grpAjoutEtModif.Controls.Add(this.dateDebutModifAbsence);
            this.grpAjoutEtModif.Controls.Add(this.label3);
            this.grpAjoutEtModif.Controls.Add(this.label2);
            this.grpAjoutEtModif.Controls.Add(this.label1);
            this.grpAjoutEtModif.Location = new System.Drawing.Point(12, 12);
            this.grpAjoutEtModif.Name = "grpAjoutEtModif";
            this.grpAjoutEtModif.Size = new System.Drawing.Size(331, 270);
            this.grpAjoutEtModif.TabIndex = 1;
            this.grpAjoutEtModif.TabStop = false;
            this.grpAjoutEtModif.Text = "Modifier absence";
            // 
            // btnEnregistrerModifAbsence
            // 
            this.btnEnregistrerModifAbsence.Location = new System.Drawing.Point(198, 186);
            this.btnEnregistrerModifAbsence.Name = "btnEnregistrerModifAbsence";
            this.btnEnregistrerModifAbsence.Size = new System.Drawing.Size(110, 41);
            this.btnEnregistrerModifAbsence.TabIndex = 13;
            this.btnEnregistrerModifAbsence.Text = "enregistrer";
            this.btnEnregistrerModifAbsence.UseVisualStyleBackColor = true;
            this.btnEnregistrerModifAbsence.Click += new System.EventHandler(this.btnEnregistrerModifAbsence_Click);
            // 
            // btnAnnulerModifAbsence
            // 
            this.btnAnnulerModifAbsence.Location = new System.Drawing.Point(82, 186);
            this.btnAnnulerModifAbsence.Name = "btnAnnulerModifAbsence";
            this.btnAnnulerModifAbsence.Size = new System.Drawing.Size(110, 41);
            this.btnAnnulerModifAbsence.TabIndex = 12;
            this.btnAnnulerModifAbsence.Text = "annuler";
            this.btnAnnulerModifAbsence.UseVisualStyleBackColor = true;
            // 
            // cboMotifModifAbsence
            // 
            this.cboMotifModifAbsence.FormattingEnabled = true;
            this.cboMotifModifAbsence.Items.AddRange(new object[] {
            "Vacances",
            "Maladie",
            "motif familial",
            "congé parental"});
            this.cboMotifModifAbsence.Location = new System.Drawing.Point(149, 140);
            this.cboMotifModifAbsence.Name = "cboMotifModifAbsence";
            this.cboMotifModifAbsence.Size = new System.Drawing.Size(154, 28);
            this.cboMotifModifAbsence.TabIndex = 5;
            // 
            // dateFinAbsenceModif
            // 
            this.dateFinAbsenceModif.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinAbsenceModif.Location = new System.Drawing.Point(149, 92);
            this.dateFinAbsenceModif.Name = "dateFinAbsenceModif";
            this.dateFinAbsenceModif.Size = new System.Drawing.Size(154, 26);
            this.dateFinAbsenceModif.TabIndex = 4;
            // 
            // dateDebutModifAbsence
            // 
            this.dateDebutModifAbsence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDebutModifAbsence.Location = new System.Drawing.Point(149, 46);
            this.dateDebutModifAbsence.Name = "dateDebutModifAbsence";
            this.dateDebutModifAbsence.Size = new System.Drawing.Size(154, 26);
            this.dateDebutModifAbsence.TabIndex = 3;
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
            // fmrModifAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 291);
            this.Controls.Add(this.grpAjoutEtModif);
            this.Name = "fmrModifAbsence";
            this.grpAjoutEtModif.ResumeLayout(false);
            this.grpAjoutEtModif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAjoutEtModif;
        private System.Windows.Forms.Button btnEnregistrerModifAbsence;
        private System.Windows.Forms.Button btnAnnulerModifAbsence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cboMotifModifAbsence;
        public System.Windows.Forms.DateTimePicker dateFinAbsenceModif;
        public System.Windows.Forms.DateTimePicker dateDebutModifAbsence;
    }
}