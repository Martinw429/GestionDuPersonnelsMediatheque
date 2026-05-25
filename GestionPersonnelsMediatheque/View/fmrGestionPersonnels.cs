using GestionPersonnelsMediatheque.dal;
using GestionPersonnelsMediatheque.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionPersonnelsMediatheque
{
    /// <summary>
    /// Interface de gestion des personnels de la médiathèque.
    /// </summary>
    public partial class fmrGestionPersonnels : Form
    {
        public fmrGestionPersonnels()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            //Charger les données des personnels de la médiathèque à partir de la base de données et les afficher dans le DataGridView.

            // La méthode LoadData est utilisée pour charger les données des personnels de la médiathèque à partir de la base de données et les afficher dans le DataGridView

            PersonnelAccess access = new PersonnelAccess();
            List<Personnel> personnels = access.GetLesPersonnels();
            dgvPersonnel.DataSource = personnels;
            dgvPersonnel.RowHeadersVisible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Sélectionner la première ligne du DataGridView pour afficher les informations du premier personnel dans les champs de saisie.
            if (dgvPersonnel.Rows.Count > 0)
            {
                dgvPersonnel.Rows[0].Selected = true;
            }

            // sélectionne ligne par ligne les données du personnel à afficher dans les champs de saisie lorsque l'utilisateur clique sur une ligne du DataGridView.
            dgvPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Masquer la colonne idservice dans le DataGridView, car elle n'est pas nécessaire pour l'affichage des informations du personnel.


            dgvPersonnel.Columns["idservice"].Visible = false;

            dgvPersonnel.Columns["nomService"].HeaderText = "Service";

        }

        /// <summary>
        /// Le bouton "afficher les absences du personnel" permet d'ouvrir une nouvelle fenêtre qui affiche les absences
        /// une ligne doit être sélectionnée dans le DataGridView pour pouvoir afficher les absences du personnel sélectionné. Lorsque l'utilisateur clique sur ce bouton, la fenêtre d'absence s'ouvre et affiche les absences du personnel sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbsencePerso_Click(object sender, EventArgs e)
        {
            //si une ligne est sélectionnée dans le DataGridView, alors on peut afficher les absences du personnel sélectionné

            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)dgvPersonnel.CurrentRow.DataBoundItem;
                fmrAbsence absence = new fmrAbsence();
                absence.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.");
            }
        }

        /// <summary>
        /// Le bouton "ajouter un personnel" permet d'ouvrir une nouvelle fenêtre qui permet d'ajouter un nouveau personnel à la médiathéque.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterPerso_Click(object sender, EventArgs e)
        {
            // Ouvrir une nouvelle fenêtre pour ajouter un nouveau personnel à la médiathèqe
            fmrAjout ajout = new fmrAjout();
            ajout.Show();
            this.Hide();
        }

        private void btnModifierPerso_Click(object sender, EventArgs e)
        {
            // informations du personnel sélectionné dans le DataGridView et les transmettre à la fenêtre de modification pour pré-remplir les champs de saisie.

            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                // Ouvrir une nouvelle fenêtre pour modifier les informations d'un personnel de la médiathèque que si un personnel est sélectionné dans le DataGridView
                fmrModif modif = new fmrModif();
                modif.Show();
                this.Hide();

                // Récupérer les informations du personnel sélectionné dans le DataGridView et les transmettre à la fenêtre de modification pour pré-remplir les champs de saisie.
                Personnel personnel = (Personnel)dgvPersonnel.CurrentRow.DataBoundItem;
                modif.txtNomModif.Text = personnel.nom;
                modif.txtPrenomModif.Text = personnel.prenom;
                modif.txtTelModif.Text = personnel.tel;
                modif.txtMailModif.Text = personnel.mail;
                modif.cboServiceModif.SelectedIndex = modif.cboServiceModif.FindStringExact(personnel.nomService);
                //modif.cboService.SelectedIndex = modif.cboService.FindStringExact(personnel.idservice.ToString());

               //grpAjoutEtModif.Text = "Modifier un personnel";

            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.");
            }


        }
        /// <summary>
        /// Bouton "supprimer un personnel" permet de supprimer un personnel de la médiathèque après confirmation de l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerPerso_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)// Vérifier si une ligne est sélectionnée dans le DataGridView avant de tenter de supprimer un personnel.
            {
                Personnel personnel = (Personnel)dgvPersonnel.CurrentRow.DataBoundItem;
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer " + personnel.nom + " " + personnel.prenom + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                   // Si l'utilisateur confirme la suppression, appeler la méthode de suppression du personnel dans la base de données et mettre à jour le DataGridView pour refléter les changements.
                    PersonnelAccess access = new PersonnelAccess();
                    access.SupprimerPersonnel(personnel.idpersonnel);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.");
            }

        }    

    }
}
