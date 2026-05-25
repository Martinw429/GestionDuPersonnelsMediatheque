using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPersonnelsMediatheque.dal;
using GestionPersonnelsMediatheque.Model;


namespace GestionPersonnelsMediatheque.View
{
    public partial class fmrModif : Form
    {
        public fmrModif()
        {
            InitializeComponent();
            //cboServiceModif ne peut pas être modifié par l'utilisateur, il est donc défini sur DropDownList pour
            cboServiceModif.DropDownStyle = ComboBoxStyle.DropDownList;
            //appelle la méthode pour charger les services dans le comboBox de la fenêtre de modification
            ChargerServicesModif();
        }






        //méthode pour charger les services disponibles dans le ComboBox cboServiceModif de la fenêtre de modification. Cette méthode crée une liste de services avec leurs identifiants et noms, puis les associe au ComboBox pour permettre à l'utilisateur de sélectionner un service lors de la modification d'un personnel.

        private void ChargerServicesModif()
        {
            List<Service> services = new List<Service>
    {
        new Service { idService = 1, nomService = "administratif" },
        new Service { idService = 2, nomService = "médiation culturelle" },
        new Service { idService = 3, nomService = "prêt" }
    };

            cboServiceModif.DataSource = services;
            cboServiceModif.DisplayMember = "nomService";
            cboServiceModif.ValueMember = "idService";
        }

        /// <summary>
        /// Bouton pour annuler les modifications du personnel et revenir à la fenêtre de gestion des personnels sans enregistrer les modifications. Lorsque l'utilisateur clique sur ce bouton, la fenêtre de modification se ferme et la fenêtre de gestion des personnels s'affiche à nouveau.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerModif_Click(object sender, EventArgs e)
        {
            fmrGestionPersonnels gestionPersonnels = new fmrGestionPersonnels();
            gestionPersonnels.Show();
            this.Hide();
        }

        /// <summary>
        /// Bouton pour enregistrer les modifications du personnel
        /// Remplace les informations du personnel dans la base de données et dans le DataGridView 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerModif_Click(object sender, EventArgs e)
        {
            //Vérifier que tous les champs soit remplis pour pouvoir enregistrer
            //si les champs sont remplis, alors on peut enregistrer les modifications du personnel
            //les modifications du personnel sont enregistrées dans la base de données et le DataGridView est mis à jour pour refléter les changements.

            if (txtNomModif.Text != "" && txtPrenomModif.Text != "" && txtTelModif.Text != "" && txtMailModif.Text != "" && cboServiceModif.SelectedIndex != -1)
            {
                Personnel lePersonnel = new Personnel
                {
                    nom = txtNomModif.Text,
                    prenom = txtPrenomModif.Text,
                    tel = txtTelModif.Text,
                    mail = txtMailModif.Text,
                    idservice = Convert.ToInt32(cboServiceModif.SelectedValue)
                };
                //Modifier le personnel dans la base de données
                PersonnelAccess access = new PersonnelAccess();
                access.ModifierPersonnel(lePersonnel);
                //Modifier dans le DataGridView
                fmrGestionPersonnels gestionPersonnels = new fmrGestionPersonnels();
                gestionPersonnels.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
        }
    }
}
