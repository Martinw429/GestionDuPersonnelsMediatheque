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
            try
            {
                //Récupérer les informations de connexion 

                string username = txtIdentifiant.Text;
                string password = txtMdp.Text;

                //Utiliser la classe ResponsableAcess pour vérifier les informations de connexion
                ResponsableAccess access = new ResponsableAccess();

                bool connexionOk = access.VerifierConnexion(username, password);

                if (connexionOk)
                {
                    // si connexion réussie, ouvrir GestionPersonnel
                    fmrGestionPersonnels gestionPersonnels = new fmrGestionPersonnels();
                    gestionPersonnels.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show(" Mot de passe ou identifiant incorrect");
                    txtIdentifiant.Clear();
                    txtMdp.Clear();
                    txtIdentifiant.Focus();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la connexion : " + ex.Message);
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
