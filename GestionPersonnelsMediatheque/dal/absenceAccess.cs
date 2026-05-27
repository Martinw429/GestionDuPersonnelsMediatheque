using GestionPersonnelsMediatheque.bddmanager;
using Serilog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonnelsMediatheque.dal
{
    /// <summary>
    /// classe d'accès aux données au gestionnaire de base de données.
    /// </summary>
    public class AbsenceAccess
    {
        //absenceAccess permet de récupérer les données d'absence du personnel sélectionner dans le DataGridView de la fenêtre de gestion des personnels et de les afficher dans la fenêtre d'absence. La méthode GetAbsencesByPersonnelId utilise une requête SQL pour récupérer les absences du personnel à partir de la base de données, puis crée une liste d'objets Absence à partir des enregistrements récupérés. Cette liste est ensuite utilisée pour afficher les absences du personnel dans la fenêtre d'absence.

        public AbsenceAccess()
        {
            // Le constructeur de la classe AbsenceAccess est utilisé pour initialiser les données nécessaires à la gestion des absences du personnel de la médiathèque.
        }

        //méthode d'accès aux données pour la gestion des absences du personnel de la médiathèque.
        public List<Absence> AbsencesPersonnel()
        {
            List<Absence> absences = new List<Absence>();
            string reqSQL = "SELECT idpersonnel, CAST(dateDebut AS CHAR), CAST(dateFin AS CHAR), idMotif" +
                " FROM absence";
            //string reqSQL = "SELECT idpersonnel, dateDebut, dateFin, idMotif FROM absence";

            try
            {
                List<Object[]> records = Access.GetInstance().Manager.ReqSelect(reqSQL);

                if (records != null)
                {
                    foreach (Object[] record in records)
                    {
                        Absence a = new Absence();

                        a.idPersonnel = Convert.ToInt32(record[0]);
                        a.dateDebut = record[1].ToString();
                        a.dateFin = record[2].ToString();
                        a.idMotif = Convert.ToInt32(record[3]);

                        absences.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return absences;
        }

        // ajouter absence (sans idPersonnel)

        public void AjouterAbsence(Absence a)
        {
            string reqSQL = "INSERT INTO absence (idpersonnel, dateDebut, dateFin, idMotif) VALUES (@dateDebut, @dateFin, @idMotif)";

            try
            {
                Access.GetInstance().Manager.ReqUpdate(reqSQL,
                    new Dictionary<string, object>
                    {
                {  "@idpersonnel", a.idPersonnel  },
                { "@dateDebut", a.dateDebut },
                { "@dateFin", a.dateFin },
                { "@idMotif", a.idMotif }
                    });
            }
            catch (Exception ex)
            {
                Log.Error("Erreur lors de l'ajout de l'absence : {Message}", ex.Message);
                MessageBox.Show("Une erreur est survenue lors de l'ajout de l'absence. Veuillez réessayer.");
            }
        }

        public void Absence(int idpersonnel)
        {
            string reqSQL = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel";
            try
            {
                Access.GetInstance().Manager.ReqUpdate(reqSQL,
                    new Dictionary<string, object>
                    {
                        {"@idpersonnel", idpersonnel }
                    });
            }
            catch (Exception ex)
            {
                Log.Error("Erreur lors de la suppression du personnel : {Message}", ex.Message);
                MessageBox.Show("Une erreur est survenue lors de la suppression du personnel. Veuillez réessayer.");
            }
        }

        public void ModifierAbsence(Absence p)
        { 
            string reqSQL = "UPDATE absence SET idpersonnel = @idpersonnel, datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif WHERE idpersonnel = @idpersonnel";
            try
            {
                Access.GetInstance().Manager.ReqUpdate(reqSQL,
                    new Dictionary<string, object>
                    {
                        {"@idpersonnel", p.idPersonnel },
                        {"@datedebut", p.dateDebut },
                        {"@datefin", p.dateFin },
                        {"@idmotif", p.idMotif },
                    });
            }
            catch (Exception ex)
            {
                Log.Error("Erreur lors de la modification du : {Message}", ex.Message);
                MessageBox.Show("Une erreur est survenue lors de la modification du personnel. Veuillez réessayer.");
            }

        }


    }
}