using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationGestionStagiaires.Operations.GroupesOperations
{
    public class Groupe
    {
        private String nom;

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private DateTime dateCréation;

        public DateTime DateCréation
        {
            get { return dateCréation; }
            set { dateCréation = value; }
        }
        private DateTime dateModification;

        public DateTime DateModification
        {
            get { return dateModification; }
            set { dateModification = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Groupe()
        {
          
        }

        public Groupe(int id,string nom,DateTime dateCréation)
        {
            this.Id = id;
            this.Nom = nom;
            this.DateCréation = dateCréation;
        }
    }
}