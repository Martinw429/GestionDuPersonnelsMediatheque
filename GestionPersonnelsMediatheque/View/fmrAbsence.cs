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
    /// Interface de gestion des absences du personnel de la médiathèque.
    /// </summary>
    public partial class fmrAbsence : Form
    {
        public fmrAbsence()
        {
            InitializeComponent();
        }

        private void fmrAbsence_Load(object sender, EventArgs e)
        {

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
    }
}
