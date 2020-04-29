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
    public partial class FrmMajFamille : Form
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
        private string url;

        public FrmMajFamille(Secretaire s)
        {
            InitializeComponent();
            this.laSecretaire = s;
            string mdpHas = s.getHashTicketMdp();
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
            this.url = this.site + "familles?ticket=" + mdpHas;
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);
            this.laSecretaire.ticket = d.ticket;
            // this.laSecretaire

            string familles = d.familles.ToString();

            List<Famille> l = JsonConvert.DeserializeObject<List<Famille>>(familles);
            cmbFamille.DataSource = l;
            cmbFamille.ValueMember = "id";
            cmbFamille.DisplayMember = "libelle";

        }

        private void cmbFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idFamille = cmbFamille.SelectedIndex.ToString();
            // code pour remplir le TextBox
        }

        private void btnMaj_Click(object sender, EventArgs e)
        {
            try
            {
                string mdpHas = this.laSecretaire.getHashTicketMdp();
                this.url = this.site + "famille" + mdpHas;
                NameValueCollection parametres = new NameValueCollection();
                string idFamille = cmbFamille.SelectedIndex.ToString();
                parametres.Add("ticket", mdpHas);
                parametres.Add("idFamille", idFamille);
                parametres.Add("libelle", this.txtFamille.Text);
                byte[] tabByte = wb.UploadValues(url, "POST", parametres);
                string reponse = UnicodeEncoding.UTF8.GetString(tabByte);
            

                // code pour la mise à jour
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse)
                    MessageBox.Show(((HttpWebResponse)ex.Response).StatusCode.ToString());

            }
        }
        //- Mise à jour d’une famille
        //URL : gsbRapports/famille/
        //Paramètres : ticket=<ticket> idFamille=<id> libelle=<lib> exemple : http://localhost/restGSB/famille
        //ticket=4nblbv5zttybtvd3yg idFamille = AEZ libelle=médicaments anti-inflamatoires
    }
}
