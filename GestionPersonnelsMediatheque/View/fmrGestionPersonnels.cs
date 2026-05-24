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
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbsencePerso_Click(object sender, EventArgs e)
        {
            fmrAbsence absence = new fmrAbsence();
            absence.Show();
            this.Hide();
        }

        /// <summary>
        /// Le bouton "ajouter un personnel" permet d'ouvrir une nouvelle fenêtre qui permet d'ajouter un nouveau personnel à la médiathéque.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterPerso_Click(object sender, EventArgs e)
        {
            // Ouvrir une nouvelle fenêtre pour ajouter un nouveau personnel à la médiathèqe
            fmrAjoutEtModif ajout = new fmrAjoutEtModif();
            ajout.Show();
            this.Hide();
        }

        private void btnModifierPerso_Click(object sender, EventArgs e)
        {
            // informations du personnel sélectionné dans le DataGridView et les transmettre à la fenêtre de modification pour pré-remplir les champs de saisie.

            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                // Ouvrir une nouvelle fenêtre pour modifier les informations d'un personnel de la médiathèque que si un personnel est sélectionné dans le DataGridView
                fmrAjoutEtModif modif = new fmrAjoutEtModif();
                modif.Show();
                this.Hide();

                // Récupérer les informations du personnel sélectionné dans le DataGridView et les transmettre à la fenêtre de modification pour pré-remplir les champs de saisie.
                Personnel personnel = (Personnel)dgvPersonnel.CurrentRow.DataBoundItem;
                modif.txtNom.Text = personnel.nom;
                modif.txtPrenom.Text = personnel.prenom;
                modif.txtTel.Text = personnel.tel;
                modif.txtMail.Text = personnel.mail;
                modif.cboService.SelectedIndex = modif.cboService.FindStringExact(personnel.nomService);
                //modif.cboService.SelectedIndex = modif.cboService.FindStringExact(personnel.idservice.ToString());

                // La méthode FindStringExact est utilisée pour trouver l'index de l'élément dans le ComboBox qui correspond à l'idservice du personnel sélectionné, afin de pré-sélectionner le service correspondant dans la fenêtre de modification.


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
                   // Si l'utilisateur confirme la suppression, appeler la méthode de suppression du personnel dans la base de données et rafraîchir le DataGridView pour refléter les changements.
                    PersonnelAccess access = new PersonnelAccess();
                    access.GetLesPersonnels().Remove(personnel);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.");
            }

        }

        /// <summary>
        /// Demande de suppression d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      /*  private void BtnDemandeSupprDev_Click(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count > 0)
            {
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + developpeur.Nom + " " + developpeur.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelDeveloppeur(developpeur);
                    RemplirListeDeveloppeurs();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }*/







        /// <summary>
        ///  Demande de modification d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*private void BtnDemandeModifDev_Click(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count > 0)
            {
                EnCourseModifDeveloppeur(true);
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                txtNom.Text = developpeur.Nom;
                txtPrenom.Text = developpeur.Prenom;
                txtTel.Text = developpeur.Tel;
                txtMail.Text = developpeur.Mail;
                cboProfil.SelectedIndex = cboProfil.FindStringExact(developpeur.Profil.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }*/
    }
}
