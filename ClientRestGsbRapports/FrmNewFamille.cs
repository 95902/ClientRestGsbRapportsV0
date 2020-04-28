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
    public partial class FrmNewFamille : Form
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
        private string url;
       
        public FrmNewFamille(Secretaire s)
        {
            InitializeComponent();
            this.laSecretaire = s;
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";


        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
                this.url = this.site + "familles";
                NameValueCollection parametres = new NameValueCollection();
                string mdpHas = this.laSecretaire.getHashTicketMdp();
                parametres.Add("ticket", mdpHas);
                parametres.Add("idFamille", this.txtId.Text);
                parametres.Add("libelle", this.txtLibelle.Text);
                byte[] tabByte = wb.UploadValues(url, "POST", parametres);
                string reponse = UnicodeEncoding.UTF8.GetString(tabByte);
                string ticket = reponse.Substring(2, reponse.Length - 2);
                MessageBox.Show(reponse);
                // code pour l'ajout d'une famille

            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse)
                    MessageBox.Show(((HttpWebResponse)ex.Response).StatusCode.ToString());

            }
        }
            //        Ajout d’une famille
            //URL : gsbRapports/familles
            //Paramètres : ticket=<ticket> idFamille=<id> libelle=<lib> exemple : http://localhost/restGSB/famille
            //ticket=4nblbv5zttybtvd3ygx idFamille = FDE21 libelle=médicaments anti-inflamatoires
    }
}
