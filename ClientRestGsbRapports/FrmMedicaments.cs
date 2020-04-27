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
        public FrmMedicaments(Medicament e)
        {
            InitializeComponent();

            this.leMedicament = e;
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
            this.laSecretaire = new Secretaire();
            this.txtComposition.Text += e.composition;
            this.txtContreIndication.Text = e.contreIndications;
            this.txtEffets.Text = e.effets;
            this.txtNonComercial.Text = e.nomCommercial;

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            try
            {
                string mdpHas = this.laSecretaire.getHashTicketMdp();
                this.url = this.site + "medicaments?ticket=" + mdpHas;
                NameValueCollection parametres = new NameValueCollection();
                parametres.Add("ticket", mdpHas);
                parametres.Add("idMedicament",leMedicament.id );
                parametres.Add("effets", this.txtEffets.Text);
                parametres.Add("contreIndications", this.txtContreIndication.Text);
                parametres.Add("composition", this.txtContreIndication.Text);

                byte[] tabByte = wb.UploadValues(url, "POST", parametres);
                string reponse = UnicodeEncoding.UTF8.GetString(tabByte);
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse)
                    MessageBox.Show("mise a jour");
            }

        }
    }
}
