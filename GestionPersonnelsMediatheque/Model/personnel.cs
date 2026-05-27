using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPersonnelsMediatheque.dal;

namespace GestionPersonnelsMediatheque
{
    public class Personnel
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        /// 

        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idservice = idservice;
        }

        public Personnel()
        {
            //Constructeur par défaut pour permettre la création d'instances de Personnel sans fournir de paramètres.
        }


        public int idpersonnel { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string tel { get; set; }
        public string mail { get; set; }
        public int idservice { get; set; }

        /// <summary>
        /// nom des différents service
        /// </summary>
        public string nomService
        {
            get
            {
                switch (idservice)
                {
                    case 1:
                        return "administratif";

                    case 2:
                        return "médiation culturelle";

                    case 3:
                        return "prêt";

                    default:
                        return "inconnu";
                }
            }
        }
    }
}
