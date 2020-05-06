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
            gtxtComposition.Text = ((Medicament)this.gcmbFamille.SelectedItem).composition.ToString();
            gtxtEffets.Text = ((Medicament)this.gcmbFamille.SelectedItem).effets.ToString();
            gtxtContreIndications.Text = ((Medicament)this.gcmbFamille.SelectedItem).contreIndications.ToString();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string gtxtIdMedicament = ((Medicament)this.gcmbFamille.SelectedItem).id.ToString();
            try
                {
                    string mdpHas = this.laSecretaire.getHashTicketMdp();
                    this.url = this.site + "medicament";
                    NameValueCollection parametres = new NameValueCollection();
                    parametres.Add("ticket", mdpHas);
                    parametres.Add("idMedicament", gtxtIdMedicament);
                    parametres.Add("effets", gtxtEffets.Text);
                    parametres.Add("contreIndications", gtxtContreIndications.Text);
                    parametres.Add("composition", gtxtComposition.Text);
                    byte[] tabByte = wb.UploadValues(url, "POST", parametres);
                    string reponse = UnicodeEncoding.UTF8.GetString(tabByte);
                    string ticket = reponse.Substring(2, reponse.Length - 2);
                    this.laSecretaire.ticket = ticket;
                    MessageBox.Show("Médicament Modifier");
                }
                catch (WebException ex)
                {
                    if (ex.Response is HttpWebResponse)
                        MessageBox.Show(((HttpWebResponse)ex.Response).StatusCode.ToString());
                }
                //Mise à jour d’un médicament(effets, contre-indications, composition ) à partir de son id
                //URL : gsbRapports / medicament
                //Paramètres: ticket =< ticket > idMedicament =< id > effets =< effets > contreIndications =< cid > composition =< compo >
                //exemple : http://localhost/restGSB/medicament
                //ticket = 4nblbv5zttybtvd3ygx idMedicament = A123 effets = aucuns contreIndications = aucune composition = très compliquée
         }

       
    }
}
