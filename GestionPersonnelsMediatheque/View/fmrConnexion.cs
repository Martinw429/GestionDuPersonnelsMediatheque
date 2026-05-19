using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonnelsMediatheque
{
    /// <summary>
    /// Interface de connexion pour le responsable de la médiathèque.
    /// </summary>

    public partial class fmrConnexion : Form
    {
        /// <summary>
        /// Interface de connexion pour le responsable de la médiathèque.
        /// </summary>
        public fmrConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            //Récupérer les informations de connexion
            string username = txtIdentifiant.Text;
            string password = txtMdp.Text;
            //Vérifier les informations de connexion
            if (username == "admin" && password == "admin123") //modifier pour gérer la base de données
            {
                //Connexion réussie, ouvrir GestionPersonnel
                fmrGestionPersonnels gestionPersonnels = new fmrGestionPersonnels();
                gestionPersonnels.Show();
                this.Hide();
            }
            else
            {
                //Connexion échouée, afficher un message d'erreur
                MessageBox.Show("Identifiant ou mot de passe incorrect.");
                txtIdentifiant.Clear();
                txtIdentifiant.Focus();
                txtMdp.Clear();
            }
        }

        /// <summary>
        /// Le focus est mis sur le champ d'identifiant lors du chargement de l'interface de connexion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmrConnexion_Load(object sender, EventArgs e)
        {
            txtIdentifiant.Focus();
        }

        /// <summary>
        /// l'utilisateur peut appuyer sur la touche "Entrée" pour déclencher l'événement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnConnexion_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Enter)
            {
                btnConnexion_Click(null, null);
            }

        }
    }
}
