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

            if (dateDebutAjoutAbsence.Value != null || dateFinAjoutAbsence.Value != null || cboMotifAjoutAbsence.SelectedIndex != -1)
            {
                AjouterAbsence();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }



        }


        // méthode pour gérer les ajouts seulement
        public void AjouterAbsence()
        {

            if (dateDebutAjoutAbsence.Value != null || dateFinAjoutAbsence.Value !=null || cboMotifAjoutAbsence.SelectedIndex != -1)
            {
                Absence lesAbsence = new Absence
                {
                    dateDebut = dateDebutAjoutAbsence.Value.ToString(),
                    dateFin = dateFinAjoutAbsence.Value.ToString(),
                    idMotif = Convert.ToInt32(cboMotifAjoutAbsence.SelectedValue)
                };

                AbsenceAccess access = new AbsenceAccess();
                access.AjouterAbsence(lesAbsence);

                fmrAbsence absence = new fmrAbsence(); 
                absence.Show();
                this.Hide();

                MessageBox.Show("L’absence a été ajoutée avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
        }
    }
    }

