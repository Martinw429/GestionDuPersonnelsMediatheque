using GestionPersonnelsMediatheque.dal;
using GestionPersonnelsMediatheque.Model;
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
    public partial class fmrAjout : Form
    {
        public fmrAjout()
        {
            InitializeComponent();
            //cboService ne peut pas être modifié par l'utilisateur, il doit sélectionner un service parmi les options disponibles dans le ComboBox. Cela garantit que les données saisies sont cohérentes et conformes aux services existants dans la base de données.
            cboService.DropDownStyle = ComboBoxStyle.DropDownList;
            //Appeler la méthode pour charger les services disponibles dans le ComboBox cboService.
            ChargerServices();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            fmrGestionPersonnels gestionPersonnels = new fmrGestionPersonnels();
            gestionPersonnels.Show();
            this.Hide();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //bouton pour enregistrer l'ajout du personnel à condition que tous les champs soient remplis, sinon un message d'erreur s'affiche pour demander à l'utilisateur de remplir tous les champs.
            if (txtNom.Text != "" || txtPrenom.Text != "" || txtTel.Text != "" || txtMail.Text != "" || cboService.SelectedIndex != -1)
            {
                AjouterPersonnel();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

        }


        // méthode pour gérer les ajouts seulement
        public void AjouterPersonnel()
        {
            if (txtNom.Text != "" && txtPrenom.Text != "" && txtTel.Text != "" && txtMail.Text != "" && cboService.SelectedIndex != -1)
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
        }

        //méthode pour charger les services disponibles dans le ComboBox cboService. Cette méthode crée une liste de services avec leurs identifiants et noms, puis les associe au ComboBox pour permettre à l'utilisateur de sélectionner un service lors de l'ajout d'un personnel.
        private void ChargerServices()
        {
            List<Service> services = new List<Service>
    {
        new Service { idService = 1, nomService = "administratif" },
        new Service { idService = 2, nomService = "médiation culturelle" },
        new Service { idService = 3, nomService = "prêt" }
    };

            cboService.DataSource = services;
            cboService.DisplayMember = "nomService";
            cboService.ValueMember = "idService";

        }
    }
}
