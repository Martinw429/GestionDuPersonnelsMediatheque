using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonnelsMediatheque
{
    /// <summary>
    /// Classe représentant une absence d'un personnel de la médiathèque.
    /// </summary>
    public class Absence
    {
        public int idPersonnel { get; set; }
        public string dateDebut { get; set; }
        public string dateFin { get; set; }
        public int  idMotif { get; set; }

        /// <summary>
        /// nom des différents motifs d'absence
        /// </summary>
    public string nomMotif
        {
            get
            {
                switch (idMotif)
                {
                    case 1:
                        return "vacances";

                    case 2:
                        return "maladie";

                    case 3:
                        return "motif familial";

                    case 4:
                        return "congé parental";

                    default:
                        return "inconnu";
                }
            }
        }
    }
}
    
