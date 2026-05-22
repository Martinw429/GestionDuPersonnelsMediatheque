using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonnelsMediatheque.dal
{
    /// <summary>
    /// Classe d'accès aux données pour la gestion des responsables.
    /// but : gérer la connexion du responsable
    /// </summary>
    public class ResponsableAccess
    {
        /// <summary>
        /// vérifier les informations de connexion du responsable de la médiathèque.
        /// </summary>
        /// <param name="username"> Le nom d'utilisateur du responsable</param>
        /// <param name="password"> Le mot de passe du responsable</param>
        /// <returns> True si les information de connexion sont correct</returns>

        public bool VerifierConnexion(string username, string password)
        {
            bool authentificationReussie = false;

            //envoie de la requête SQL pour vérifier les informations de connexion
            string reqSQL = "SELECT login, pwd " +
             "FROM responsable " +
             "WHERE login = @login AND pwd = SHA2(@pwd, 256)";

            //remplacer les paramètres de la requête SQL par les valeurs d'entrée
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@login", username);
            parameters.Add("@pwd", password);

            //exécuter la requête SQL et récupérer les résultats

            List<Object[]> records = Access.GetInstance().Manager.ReqSelect(reqSQL, parameters);

            if (records.Count > 0)
            {
                //si les informations de connexion sont correctes, on peut récupérer les informations du responsable
                authentificationReussie = true;
            }
            else
            {
                authentificationReussie = false;
            }

                return authentificationReussie;
        }
    }
}
