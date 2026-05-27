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
    public partial class fmrModifAbsence : Form
    {
        public fmrModifAbsence()
        {
            InitializeComponent();
        }

        private void btnEnregistrerModifAbsence_Click(object sender, EventArgs e)
        {
            //Vérifier que tous les champs soit remplis pour pouvoir enregistrer
            //si les champs sont remplis, alors on peut enregistrer les modifications du personnel
            //les modifications du personnel sont enregistrées dans la base de données et le DataGridView est mis à jour pour refléter les changements.

            if (dateDebutModifAbsence.Value != null && dateFinAbsenceModif.Value != null && cboMotifModifAbsence. SelectedIndex != -1)
            {
                Absence lesAbsences = new Absence
                {
                    dateDebut = dateDebutModifAbsence.Value.ToString(),
                    dateFin = dateFinAbsenceModif.Value.ToString(),
                    idMotif = Convert.ToInt32(cboMotifModifAbsence.SelectedValue)
                };
                //Modifier le personnel dans la base de données
                AbsenceAccess access = new AbsenceAccess();
                access.ModifierAbsence(lesAbsences);
                //Modifier dans le DataGridView
                fmrAbsence gestionAbsence = new fmrAbsence();
                gestionAbsence.Show();
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
