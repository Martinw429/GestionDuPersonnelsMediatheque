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
    }
}
