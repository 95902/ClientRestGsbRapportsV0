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
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace ClientRestGsbRapports
{
    public partial class FrmMedicaments : Form
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
        private string url;
        private Medicament leMedicament;
        public FrmMedicaments(Medicament e, Secretaire s)
        {
            InitializeComponent();

            leMedicament = e;
            wb = new WebClient();
            site = "http://localhost/restGSB/";
            laSecretaire = s;
            txtComposition.Text += e.composition;
            txtContreIndication.Text = e.contreIndications;
            txtEffets.Text = e.effets;
            txtNonComercial.Text = e.nomCommercial;
            txtIdMedicament.Text = e.id;

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            try
            {
                string mdpHas = this.laSecretaire.getHashTicketMdp();
                this.url = this.site + "medicament";
                NameValueCollection parametres = new NameValueCollection();
                parametres.Add("ticket", mdpHas);
                parametres.Add("idMedicament", txtIdMedicament.Text );
                parametres.Add("effets", txtEffets.Text);
                parametres.Add("contreIndications", txtContreIndication.Text);
                parametres.Add("composition", txtContreIndication.Text);
                byte[] tabByte = wb.UploadValues(url, "POST", parametres);
                string reponse = UnicodeEncoding.UTF8.GetString(tabByte);
                string ticket = reponse.Substring(2, reponse.Length - 2);
                MessageBox.Show(reponse);
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
