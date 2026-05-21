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
        public int motif { get; set; }
    }
}
