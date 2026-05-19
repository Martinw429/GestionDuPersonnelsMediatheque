namespace GestionPersonnelsMediatheque
{
    partial class fmrAbsence
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
            this.lstAbsence = new System.Windows.Forms.ListBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAbsence
            // 
            this.lstAbsence.FormattingEnabled = true;
            this.lstAbsence.ItemHeight = 20;
            this.lstAbsence.Location = new System.Drawing.Point(13, 13);
            this.lstAbsence.Name = "lstAbsence";
            this.lstAbsence.Size = new System.Drawing.Size(283, 504);
            this.lstAbsence.TabIndex = 0;
            // 
            // btnRetour
            // 
            this.btnRetour.BackgroundImage = global::GestionPersonnelsMediatheque.Properties.Resources.RETOUR__2_;
            this.btnRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRetour.Location = new System.Drawing.Point(302, 391);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(120, 120);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnModifierAbsence
            // 
            this.btnModifierAbsence.BackgroundImage = global::GestionPersonnelsMediatheque.Properties.Resources.modifier;
            this.btnModifierAbsence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModifierAbsence.Location = new System.Drawing.Point(302, 265);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(120, 120);
            this.btnModifierAbsence.TabIndex = 3;
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.BackgroundImage = global::GestionPersonnelsMediatheque.Properties.Resources.supprimer;
            this.btnSupprimerAbsence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(302, 139);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(120, 120);
            this.btnSupprimerAbsence.TabIndex = 2;
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.BackgroundImage = global::GestionPersonnelsMediatheque.Properties.Resources.ajouter_un_utilisateur;
            this.btnAjouterAbsence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjouterAbsence.Location = new System.Drawing.Point(302, 12);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(120, 120);
            this.btnAjouterAbsence.TabIndex = 1;
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // fmrAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 527);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModifierAbsence);
            this.Controls.Add(this.btnSupprimerAbsence);
            this.Controls.Add(this.btnAjouterAbsence);
            this.Controls.Add(this.lstAbsence);
            this.Name = "fmrAbsence";
            this.Text = "Absence";
            this.Load += new System.EventHandler(this.fmrAbsence_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAbsence;
        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.Button btnModifierAbsence;
        private System.Windows.Forms.Button btnRetour;
    }
}