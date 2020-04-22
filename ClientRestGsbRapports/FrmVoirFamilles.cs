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


namespace ClientRestGsbRapports
{
    public partial class FrmVoirFamilles : Form
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire=new Secretaire ();
        private string url;
     
        public FrmVoirFamilles(Secretaire s)
        {
            InitializeComponent();
            this.wb = new WebClient();
            laSecretaire.getHashTicketMdp();
            this.site = "http://localhost/restGSB/";
            this.url = this.site+ "familles?ticket="+ laSecretaire.getHashTicketMdp();
            string data = this.wb.DownloadString(url);
            List<Famille> f = JsonConvert.DeserializeObject<List<Famille>>(data);
            listBox1.DataSource = f;
            listBox1.ValueMember = "id";
            listBox1.DisplayMember = "libelle";
            // code ici
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
