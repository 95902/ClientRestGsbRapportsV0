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
        private Famille laFamille;

        public FrmMajFamille(Secretaire s)
        {
            InitializeComponent();
            this.laSecretaire = s;
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
            string url = this.site + "familles?ticket=";
            string hash = this.laSecretaire.getHashTicketMdp();
            url += hash;
            string reponse = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(reponse);
            this.laSecretaire.ticket = d.ticket;
            string lesfamilles = d.familles.ToString();
            List<Famille> l = JsonConvert.DeserializeObject<List<Famille>>(lesfamilles);
            this.cmbFamille.DataSource = l;
            this.cmbFamille.ValueMember = "id";
            this.cmbFamille.DisplayMember = "libelle";

        }

        private void cmbFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            laFamille = (Famille)cmbFamille.SelectedItem;
            txtFamille.Text = this.laFamille.libelle;
            // code pour remplir le TextBox
        }

        private void btnMaj_Click(object sender, EventArgs e)
        {
            try
            {
                string url;
                url = this.site + "famille";
                NameValueCollection parametres = new NameValueCollection();
                parametres.Add("idFamille", this.laFamille.id);
                parametres.Add("libelle", this.txtFamille.Text);
                parametres.Add("ticket", this.laSecretaire.getHashTicketMdp());
                byte[] tabByte = wb.UploadValues(url, "POST", parametres);
                string reponse = UnicodeEncoding.UTF8.GetString(tabByte);
                string ticket = reponse.Substring(2, reponse.Length - 2);
                this.laSecretaire.ticket = ticket;


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
