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
    public partial class UserControlAjouter : UserControl
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
        private string url;
        private Medicament leMedicament;
        public UserControlAjouter(Secretaire s)
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
            gunaComboBox1.DataSource = l;// Chargement de la liste  
            gunaComboBox1.ValueMember = "id";
            gunaComboBox1.DisplayMember = "libelle";
        }

        private void gbtnValider_Click(object sender, EventArgs e)
        {

            if (textIdMedicament.Text == String.Empty || gtxtNomCommercial.Text == String.Empty 
                || gtxtEffets.Text == String.Empty || gtxtContreIndications.Text == String.Empty
                || gtxtComposition.Text == String.Empty )
            {
                MessageBox.Show("Veuillez remplire tous les champs");
            }
            //if (gunaComboBox1.SelectedValue.ToString != gunaComboBox1.SelectedValue  )
            //{

            //}


            else { 


            try  // code pour l'ajout d'un medicament 
            {
                this.url = this.site + "medicaments"; // url 
                NameValueCollection parametres = new NameValueCollection(); // 
                string mdpHas = this.laSecretaire.getHashTicketMdp();// récupération du ticket
                string idFamille = gunaComboBox1.SelectedValue.ToString();// récupération de idFamille
                parametres.Add("ticket", mdpHas);//
                parametres.Add("idMedicament", this.textIdMedicament.Text.ToUpper());
                parametres.Add("nomCommercial", this.gtxtNomCommercial.Text);
                parametres.Add("effets", this.gtxtEffets.Text);
                parametres.Add("contreIndications", this.gtxtContreIndications.Text);
                parametres.Add("composition", this.gtxtComposition.Text);
                parametres.Add("idFamille", idFamille);
                byte[] tabByte = wb.UploadValues(url, "POST", parametres);
                string reponse = UnicodeEncoding.UTF8.GetString(tabByte);
                string ticket = reponse.Substring(2, reponse.Length - 2);
                MessageBox.Show("Médicament ajouté");


            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse)
                    MessageBox.Show(((HttpWebResponse)ex.Response).StatusCode.ToString());
            }

            //    Ajout d’un médicament
            //URL: gsbRapports / medicaments
            //Paramètres: ticket =< ticket > idMedicament =< id > effets =< effets > contreIndications =< cid > composition =< compo idFamille =< id >
            //     exemple : http://localhost/restGSB/medicaments
            //    ticket = 4nblbv5zttybtvd3ygx idMedicament = RET12 effets = aucuns contreIndications = aucunes composition = beaucoup de composants
            //    idFamille = A
            }
        }

    
    }
}
