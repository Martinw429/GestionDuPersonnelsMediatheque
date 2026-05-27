using GestionPersonnelsMediatheque.dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPersonnelsMediatheque.Model;
using GestionPersonnelsMediatheque.View;




namespace GestionPersonnelsMediatheque
{

    /// <summary>
    /// Interface de gestion des absences du personnel de la médiathèque.
    /// </summary>
    public partial class fmrAbsence : Form
    {
        public fmrAbsence()
        {
            InitializeComponent();
            AfficherAbsences();
            LoadData();
        ;
        }

        private void fmrAbsence_Load(object sender, EventArgs e)
        {
         
        }

        private void LoadData()
        {
            AbsenceAccess access = new AbsenceAccess();
            List<Absence> personnels = access.AbsencesPersonnel();
            dgvAbsence.DataSource = personnels;
            dgvAbsence.RowHeadersVisible = false;
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Sélectionner la première ligne du DataGridView pour afficher les informations du premier personnel dans les champs de saisie.
            if (dgvAbsence.Rows.Count > 0)
            {
                dgvAbsence.Rows[0].Selected = true;
            }
 

            dgvAbsence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvAbsence.Columns["idmotif"].Visible = false;
            dgvAbsence.Columns["nommotif"].HeaderText = "motif";

        }

        /// <summary>
        /// Affiche les absence des personnels de la médiathèque 
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// 

        private void AfficherAbsences()
        {
            AbsenceAccess access = new AbsenceAccess();

            List<Absence> absences = access.AbsencesPersonnel();

            dgvAbsence.DataSource = absences;

            dgvAbsence.RowHeadersVisible = false;
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAbsence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        /// <summary>
        /// Le bouton "retour" permet de revenir à la fenêtre de gestion du personnel de la médiathèque.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            fmrGestionPersonnels gestionPersonnels = new fmrGestionPersonnels();
            gestionPersonnels.Show();
            this.Hide();
        }

        private void btnAjouterAbsence_Click(object sender, EventArgs e)
        {
            //ouvre la fenêtre pour ajouter absence 
            fmrAjoutAbsence absence = new fmrAjoutAbsence();
            absence.Show();
            this.Hide();
        }

        private void btnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            // Bouton pour supprimer une absence 

            if (dgvAbsence.SelectedRows.Count > 0)// Vérifier si une ligne est sélectionnée dans le DataGridView avant de tenter de supprimer un personnel.
            {
                Absence personnel = (Absence)dgvAbsence.CurrentRow.DataBoundItem;
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette absence ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Si l'utilisateur confirme la suppression, appeler la méthode de suppression du personnel dans la base de données et mettre à jour le DataGridView pour refléter les changements.
                    PersonnelAccess access = new PersonnelAccess();
                    access.SupprimerAbsence(personnel.idPersonnel);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.");
            }

        }

        /// <summary>
        /// Bouton pour modifier les absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnModifierAbsence_Click(object sender, EventArgs e)
        {
            // informations du personnel sélectionné dans le DataGridView et les transmettre à la fenêtre de modification pour pré-remplir les champs de saisie.

            if (dgvAbsence.SelectedRows.Count > 0)
            {
                // Ouvrir une nouvelle fenêtre pour modifier les informations d'un personnel de la médiathèque que si un personnel est sélectionné dans le DataGridView
                fmrModifAbsence modif = new fmrModifAbsence();
                modif.Show();
                this.Hide();

                // Récupérer les informations du personnel sélectionné dans le DataGridView et les transmettre à la fenêtre de modification pour pré-remplir les champs de saisie.
                Absence absence = (Absence)dgvAbsence.CurrentRow.DataBoundItem;
                modif.dateDebutModifAbsence.Value = DateTime.Parse(absence.dateDebut);
                modif.dateFinAbsenceModif.Value = DateTime.Parse(absence.dateFin);
                modif.cboMotifModifAbsence.SelectedIndex = modif.cboMotifModifAbsence.FindStringExact(absence.nomMotif);

            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.");
            }

        }
    }
}
