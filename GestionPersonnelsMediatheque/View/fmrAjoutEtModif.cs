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
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            fmrGestionPersonnels gestionPersonnels = new fmrGestionPersonnels();
            gestionPersonnels.Show();
            this.Hide();
        }
    }
}
