using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationGestionStagiaires.Operations.GroupesOperations
{
    public class GroupesOperations
    {
        private static List<Groupe> ListeGroupes = new List<Groupe>();
        private static int Nbr = 0;
        public static void Ajouter(Groupe g) {
            g.DateCréation = DateTime.Now;
            g.Id = ++Nbr;
            ListeGroupes.Add(g);
            
        }
        public static void Supprimer(int id) {

            for (int i = 0; i < ListeGroupes.Count; i++)
            {
                Groupe g = (Groupe)ListeGroupes[i];
                if (g.Id == id)
                    ListeGroupes.Remove(g);
            }
        }
        public static void Modifier(Groupe groupe){

        for (int i = 0; i < ListeGroupes.Count; i++)
            {
                Groupe g = (Groupe)ListeGroupes[i];
                if (g.Id == groupe.Id){
                 g.Nom = groupe.Nom;
                 g.DateModification = DateTime.Now;
                
                }
                    
            }
        
        
        }
        public static List<Groupe> Afficher() {

            return ListeGroupes;
        
        }

        public static Groupe Debut()
        {
            if (ListeGroupes.Count > 0)
                return ListeGroupes[0];
            else
                return null;
        }

        public static Groupe Suivant(int id)
        {

            for (int i = 0; i < ListeGroupes.Count; i++)
            {
                Groupe g = (Groupe)ListeGroupes[i];
                if (g.Id == id)
                    return ListeGroupes[i + 1];
            }
            return null;
        }

        public static Groupe Precedent(int id)
        {
            for (int i = 0; i < ListeGroupes.Count; i++)
            {
                Groupe g = (Groupe)ListeGroupes[i];
                if (g.Id == id)
                    return ListeGroupes[i- 1];
            }
            return null;
        }

        public static Groupe Fin()
        {
            return ListeGroupes[ListeGroupes.Count - 1];
        }
    }
}