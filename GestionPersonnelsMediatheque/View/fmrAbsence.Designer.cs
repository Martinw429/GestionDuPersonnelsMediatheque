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
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.BackgroundImage = global::GestionPersonnelsMediatheque.Properties.Resources.RETOUR__2_;
            this.btnRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRetour.Location = new System.Drawing.Point(704, 390);
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
            this.btnModifierAbsence.Location = new System.Drawing.Point(704, 264);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(120, 120);
            this.btnModifierAbsence.TabIndex = 3;
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            this.btnModifierAbsence.Click += new System.EventHandler(this.btnModifierAbsence_Click);
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.BackgroundImage = global::GestionPersonnelsMediatheque.Properties.Resources.supprimer;
            this.btnSupprimerAbsence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(704, 138);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(120, 120);
            this.btnSupprimerAbsence.TabIndex = 2;
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            this.btnSupprimerAbsence.Click += new System.EventHandler(this.btnSupprimerAbsence_Click);
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.BackgroundImage = global::GestionPersonnelsMediatheque.Properties.Resources.ajouter_un_utilisateur;
            this.btnAjouterAbsence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjouterAbsence.Location = new System.Drawing.Point(704, 12);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(120, 120);
            this.btnAjouterAbsence.TabIndex = 1;
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            this.btnAjouterAbsence.Click += new System.EventHandler(this.btnAjouterAbsence_Click);
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.AllowUserToAddRows = false;
            this.dgvAbsence.AllowUserToDeleteRows = false;
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(13, 13);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.ReadOnly = true;
            this.dgvAbsence.RowHeadersWidth = 62;
            this.dgvAbsence.RowTemplate.Height = 28;
            this.dgvAbsence.Size = new System.Drawing.Size(685, 497);
            this.dgvAbsence.TabIndex = 5;
            // 
            // fmrAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 527);
            this.Controls.Add(this.dgvAbsence);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModifierAbsence);
            this.Controls.Add(this.btnSupprimerAbsence);
            this.Controls.Add(this.btnAjouterAbsence);
            this.Name = "fmrAbsence";
            this.Text = "Absence";
            this.Load += new System.EventHandler(this.fmrAbsence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.Button btnModifierAbsence;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dgvAbsence;
    }
}