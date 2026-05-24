using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPersonnelsMediatheque.Model;
using System.Windows.Forms;


namespace GestionPersonnelsMediatheque.dal
{
    public class PersonnelAccess
    {
        /// <sumary>
        /// méthode pour récupérer la liste de tous les personnels de la médiathèque.
        /// </sumary>
        /// <return> une liste de personnel </return>

        public PersonnelAccess()
        {
            // Le constructeur de la classe PersonnelAccess est utilisé pour initialiser les données nécessaires à la gestion des personnels de la médiathèque.
        }

        // méthode d'accès aux données pour la gestion des personnels de la médiathèque.
        // La méthode GetLesPersonnels est utilisée pour récupérer la liste de tous les personnels de la médiathèque à partir de la base de données.

        public List<Personnel> GetLesPersonnels()
        {

            // La liste est initialisée pour stocker les objets Personnel qui seront créés à partir des enregistrements de la base de données.
            List<Personnel> personnel = new List<Personnel>();

            // la requête SQL est définie pour sélectionner les informations de tous les personnels de la base de données.

            string reqSQL = "SELECT idpersonnel, nom, prenom, tel, mail, idservice" +
                " FROM personnel";

            // try catch pour gérer les exceptions qui peuvent survenir lors de l'exécution de la requête SQL et de la récupération des données.
            try
            {
                List<Object[]> records = Access.GetInstance().Manager.ReqSelect(reqSQL);

                if (records != null)
                {
                    foreach (Object[] record in records)//pour chaque enregistrement de la base de données, on crée un objet Personnel et on l'ajoute à la liste de personnels.
                    {
                        Personnel p = new Personnel();
                        p.idpersonnel = Convert.ToInt32(record[0]);
                        p.nom = record[1].ToString();
                        p.prenom = record[2].ToString();
                        p.tel = record[3].ToString();
                        p.mail = record[4].ToString();
                        p.idservice = Convert.ToInt32(record[5]);
                        personnel.Add(p);
                    }

                }
            }
            catch (Exception ex)
            {
                Log.Error("Erreur lors de la récupération des personnels : {Message}", ex.Message);
                MessageBox.Show("Une erreur est survenue lors de la récupération des personnels. Veuillez réessayer.");
            }
            return personnel;

        }

        //Méthode pour ajouter un personnel à la base de données en utilisant une requête SQL d'insertion. 

        public void AjouterPersonnel(Personnel p)
        {
            string reqSQL = "INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES (@nom, @prenom, @tel, @mail, @idservice)";
            try
            {
                Access.GetInstance().Manager.ReqUpdate(reqSQL,
                    new Dictionary<string, object>
                    {
                        {"@nom", p.nom },
                        {"@prenom", p.prenom },
                        {"@tel", p.tel },
                        {"@mail", p.mail },
                        {"@idservice", p.idservice }
                    });
            }
            catch (Exception ex)
            {
                Log.Error("Erreur lors de l'ajout du personnel : {Message}", ex.Message);
                MessageBox.Show("Une erreur est survenue lors de l'ajout du personnel. Veuillez réessayer.");
            }
        }



        //Méthode pour modifier les informations d'un personnel existant dans la base de données en utilisant une requête SQL de mise à jour.

        public void ModifierPersonnel(Personnel p)
        {
            string reqSQL = "UPDATE personnel SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice WHERE idpersonnel = @idpersonnel";
            try
            {
                Access.GetInstance().Manager.ReqUpdate(reqSQL,
                    new Dictionary<string, object>
                    {
                        {"@nom", p.nom },
                        {"@prenom", p.prenom },
                        {"@tel", p.tel },
                        {"@mail", p.mail },
                        {"@idservice", p.idservice },
                        {"@idpersonnel", p.idpersonnel }
                    });
            }
            catch (Exception ex)
            {
                Log.Error("Erreur lors de la modification du personnel : {Message}", ex.Message);
                MessageBox.Show("Une erreur est survenue lors de la modification du personnel. Veuillez réessayer.");
            }

        }
    }
}