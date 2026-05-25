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
    public partial class fmrAjoutAbsence : Form
    {
        public fmrAjoutAbsence()
        {
            InitializeComponent();
        }

        private void btnAnnulerAjoutAbsence_Click(object sender, EventArgs e)
        {
            fmrAbsence absence = new fmrAbsence();
            absence.Show();
            this.Hide();

        }

        private void btnEnregistrerAjoutAbsence_Click(object sender, EventArgs e)
        {
            //Bouton pour enregistrer les absences 

            
        }


        // méthode pour gérer les ajouts seulement
        public void AjouterAbsence()
        {
            if (dateDebutAjoutAbsence.AllowDrop|| dateFinAjoutAbsence.AllowDrop || cboMotifAjoutAbsence.SelectedIndex != -1)
            {
                Absence nouvelleAbsence = new Absence();
                {
                    dateDebutAjoutAbsence = 
                    idMotif = Convert.ToInt32(cboService.SelectedValue)
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
    }
