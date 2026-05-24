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

namespace GestionPersonnelsMediatheque.View
{
    public partial class fmrAjoutEtModif : Form
    {
        public fmrAjoutEtModif()
        {
            InitializeComponent();
            //cboService ne peut pas être modifié par l'utilisateur, il doit sélectionner un service parmi les options disponibles dans le ComboBox. Cela garantit que les données saisies sont cohérentes et conformes aux services existants dans la base de données.
            cboService.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            fmrGestionPersonnels gestionPersonnels = new fmrGestionPersonnels();
            gestionPersonnels.Show();
            this.Hide();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Si le but est d'ajouter un nouveau personnel, vérifier que tous les champs sont remplis avant d'enregistrer les informations du personnel dans la base de données. Si un champ est vide, afficher un message d'erreur demandant à l'utilisateur de remplir tous les champs.
            // en utilisant la méthode AjouterPersonnel de la classe PersonnelAccess pour ajouter le nouveau personnel à la base de données, puis mettre à jour le DataGridView dans la fenêtre de gestion des personnels pour refléter les changements.

            if (txtNom.Text != "" || txtPrenom.Text != "" || txtTel.Text != "" || txtMail.Text != "" || cboService.SelectedIndex != -1)
            {
                Personnel lePersonnel = new Personnel
                {
                    nom = txtNom.Text,
                    prenom = txtPrenom.Text,
                    tel = txtTel.Text,
                    mail = txtMail.Text,
                    idservice = Convert.ToInt32(cboService.SelectedValue)
                };
                //Ajouter le personnel dans la base de données
                PersonnelAccess access = new PersonnelAccess();
                access.AjouterPersonnel(lePersonnel);
                //Ajouter dans le DataGridView
                fmrGestionPersonnels gestionPersonnels = new fmrGestionPersonnels();
                gestionPersonnels.Show();
                this.Hide();
                // Afficher un message de confirmation indiquant que le personnel a été ajouté avec succès.
                MessageBox.Show("Le personnel a été ajouté avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }


            // Si le but est de modifier les informations d'un personnel existant, vérifier que tous les champs sont remplis avant d'enregistrer les modifications dans la base de données. Si un champ est vide, afficher un message d'erreur demandant à l'utilisateur de remplir tous les champs.
            // en utilisant la méthode ModifierPersonnel de la classe PersonnelAccess pour enregistrer les modifications dans la base de données, puis mettre à jour le DataGridView dans la fenêtre de gestion des personnels pour refléter les changements.

            if (txtNom.Text != "" || txtPrenom.Text != "" || txtTel.Text != "" || txtMail.Text != "" || cboService.SelectedIndex != -1)
            {
                Personnel lePersonnel = new Personnel
                {
                    nom = txtNom.Text,
                    prenom = txtPrenom.Text,
                    tel = txtTel.Text,
                    mail = txtMail.Text,
                    idservice = Convert.ToInt32(cboService.SelectedValue)
                };
                //Modifier le personnel dans la base de données
                PersonnelAccess access = new PersonnelAccess();
                access.ModifierPersonnel(lePersonnel);
                //Ajouter dans le DataGridView
                fmrGestionPersonnels gestionPersonnels = new fmrGestionPersonnels();
                gestionPersonnels.Show();
                this.Hide();
                // Afficher un message de confirmation indiquant que les modifications ont été enregistrées avec succès.
                MessageBox.Show("Les modifications ont été enregistrées avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
        }
    }
}
