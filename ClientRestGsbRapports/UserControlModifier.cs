using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // pour WbClient
using mdlGsbRapports;
using Newtonsoft.Json;          // pour la gestion du format Json
using System.Collections.Specialized;

namespace ClientRestGsbRapports
{
    public partial class UserControlModifier : UserControl
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
        private string url;
        private Medicament leMedicament;
        public UserControlModifier(Secretaire s,Medicament e)
        {
           
            InitializeComponent();
            leMedicament = e;
            this.laSecretaire = s;
            string mdpHas = s.getHashTicketMdp(); //  récupération du ticket
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
            this.url = this.site + " medicaments?ticket=" + mdpHas;//Url 
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);//Deserialisation  avec un objet dynamic
            this.laSecretaire.ticket = d.ticket;//Deserialisation du ticket  
            string medicaments = d.medicaments.ToString();//Deserialisation de la liste
            List<Medicament> l = JsonConvert.DeserializeObject<List<Medicament>>(medicaments);//liste de familles
            gcmbFamille.DataSource = l;// Chargement de la liste  
            gcmbFamille.ValueMember = "id";
            gcmbFamille.DisplayMember = "nomCommercial";

            //Sélectionner tous les médicaments :
            //syntaxe: < nom domaine >/ gsbRapports / medicaments ? ticket =< ticket >
            //exemple : http://localhost/restGSB/medicaments?ticket=4nblbv5zttybtvd3ygx
        }

        private void gcmbFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
           ///* g/**/txtComposition.Text =leMedicament.composition ;*/
        }
    }
}
