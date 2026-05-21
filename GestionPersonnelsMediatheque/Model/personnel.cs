using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonnelsMediatheque
{
    internal class Personnel
    {
        public int idPersonnel { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public int tel { get; set; }
        public string mail { get; set; }
        public int idService { get; set; }
    }
}
