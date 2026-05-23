namespace GestionPersonnelsMediatheque
{
    partial class fmrGestionPersonnels
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
            this.btnAbsencePerso = new System.Windows.Forms.Button();
            this.btnModifierPerso = new System.Windows.Forms.Button();
            this.btnSupprimerPerso = new System.Windows.Forms.Button();
            this.btnAjouterPerso = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbsencePerso
            // 
            this.btnAbsencePerso.BackgroundImage = global::GestionPersonnelsMediatheque.Properties.Resources.absence__2_;
            this.btnAbsencePerso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbsencePerso.Location = new System.Drawing.Point(821, 391);
            this.btnAbsencePerso.Name = "btnAbsencePerso";
            this.btnAbsencePerso.Size = new System.Drawing.Size(120, 120);
            this.btnAbsencePerso.TabIndex = 4;
            this.btnAbsencePerso.UseVisualStyleBackColor = true;
            this.btnAbsencePerso.Click += new System.EventHandler(this.btnAbsencePerso_Click);
            // 
            // btnModifierPerso
            // 
            this.btnModifierPerso.BackgroundImage = global::GestionPersonnelsMediatheque.Properties.Resources.modifier;
            this.btnModifierPerso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModifierPerso.Location = new System.Drawing.Point(821, 265);
            this.btnModifierPerso.Name = "btnModifierPerso";
            this.btnModifierPerso.Size = new System.Drawing.Size(120, 120);
            this.btnModifierPerso.TabIndex = 3;
            this.btnModifierPerso.UseVisualStyleBackColor = true;
            this.btnModifierPerso.Click += new System.EventHandler(this.btnModifierPerso_Click);
            // 
            // btnSupprimerPerso
            // 
            this.btnSupprimerPerso.BackgroundImage = global::GestionPersonnelsMediatheque.Properties.Resources.supprimer;
            this.btnSupprimerPerso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupprimerPerso.Location = new System.Drawing.Point(821, 139);
            this.btnSupprimerPerso.Name = "btnSupprimerPerso";
            this.btnSupprimerPerso.Size = new System.Drawing.Size(120, 120);
            this.btnSupprimerPerso.TabIndex = 2;
            this.btnSupprimerPerso.UseVisualStyleBackColor = true;
            // 
            // btnAjouterPerso
            // 
            this.btnAjouterPerso.BackgroundImage = global::GestionPersonnelsMediatheque.Properties.Resources.ajouter_un_utilisateur;
            this.btnAjouterPerso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjouterPerso.Location = new System.Drawing.Point(821, 13);
            this.btnAjouterPerso.Name = "btnAjouterPerso";
            this.btnAjouterPerso.Size = new System.Drawing.Size(120, 120);
            this.btnAjouterPerso.TabIndex = 1;
            this.btnAjouterPerso.UseVisualStyleBackColor = true;
            this.btnAjouterPerso.Click += new System.EventHandler(this.btnAjouterPerso_Click);
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(12, 13);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.RowHeadersWidth = 62;
            this.dgvPersonnel.RowTemplate.Height = 28;
            this.dgvPersonnel.Size = new System.Drawing.Size(803, 482);
            this.dgvPersonnel.TabIndex = 5;
            // 
            // fmrGestionPersonnels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 521);
            this.Controls.Add(this.dgvPersonnel);
            this.Controls.Add(this.btnAbsencePerso);
            this.Controls.Add(this.btnModifierPerso);
            this.Controls.Add(this.btnSupprimerPerso);
            this.Controls.Add(this.btnAjouterPerso);
            this.Name = "fmrGestionPersonnels";
            this.Text = "Personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAjouterPerso;
        private System.Windows.Forms.Button btnSupprimerPerso;
        private System.Windows.Forms.Button btnModifierPerso;
        private System.Windows.Forms.Button btnAbsencePerso;
        private System.Windows.Forms.DataGridView dgvPersonnel;
    }
}