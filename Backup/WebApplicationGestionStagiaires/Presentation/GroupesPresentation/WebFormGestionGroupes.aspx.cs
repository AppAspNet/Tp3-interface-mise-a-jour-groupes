using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationGestionStagiaires.Operations.GroupesOperations;

namespace WebApplicationGestionStagiaires.Presentation.GroupesPresentation
{
    public partial class WebFormGestionGroupes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            this.Actualiser();
        }

        private void Actualiser(){

            GridView1.DataSource = GroupesOperations.Afficher();
            GridView1.DataBind();

            this.ChargerGroupe(GroupesOperations.Debut());
        
        }

        protected void btNouveau_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            lblDateCréation.Text = DateTime.Now.ToShortTimeString() ;
            lblDateModification.Text = "";
        }

        protected void btEnregistrer_Click(object sender, EventArgs e)
        {
            Groupe g = new Groupe();
            g.Nom = txtNom.Text;
            GroupesOperations.Ajouter(g);
            this.Actualiser();
        }

        protected void btDebut_Click(object sender, EventArgs e)
        {
            Groupe g = GroupesOperations.Debut();
            this.ChargerGroupe(g);

        }

        private void ChargerGroupe(Groupe g)
        {
            if (g != null)
            {
                this.lblId.Text = g.Id.ToString();
                this.txtNom.Text = g.Nom;
                this.lblDateCréation.Text = g.DateCréation.ToShortTimeString();
                this.lblDateModification.Text = g.DateModification.ToShortTimeString();
            }
        }

        protected void bPrecedent_Click(object sender, EventArgs e)
        {
            Groupe g = GroupesOperations.Precedent(int.Parse(lblId.Text));
            this.ChargerGroupe(g);
        }

        protected void btSuivnt_Click(object sender, EventArgs e)
        {
            Groupe g = GroupesOperations.Suivant(int.Parse(lblId.Text));
            this.ChargerGroupe(g);
        }

        protected void btFin_Click(object sender, EventArgs e)
        {
            Groupe g = GroupesOperations.Fin();
            this.ChargerGroupe(g);
        }

        protected void brSupprimer_Click(object sender, EventArgs e)
        {
            GroupesOperations.Supprimer(int.Parse(lblId.Text));
            this.Actualiser();
        }

        protected void btModifier_Click(object sender, EventArgs e)
        {
            Groupe g = new Groupe();
            g.Id = int.Parse(lblId.Text);
            g.Nom = txtNom.Text;
            GroupesOperations.Modifier(g);
            this.Actualiser();
        }

        
    }
}