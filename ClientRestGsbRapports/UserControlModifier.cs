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
        public UserControlModifier(Secretaire s)
        {
            InitializeComponent();
            this.laSecretaire = s;
            string mdpHas = s.getHashTicketMdp(); //  récupération du ticket
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
            this.url = this.site + "familles?ticket=" + mdpHas;//Url 
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);//Deserialisation  avec un objet dynamic
            this.laSecretaire.ticket = d.ticket;//Deserialisation du ticket  
            string familles = d.familles.ToString();//Deserialisation de la liste
            List<Famille> l = JsonConvert.DeserializeObject<List<Famille>>(familles);//liste de familles
            gcmbFamille.DataSource = l;// Chargement de la liste  
            gcmbFamille.ValueMember = "id";
            gcmbFamille.DisplayMember = "libelle";
        }
    }
}
