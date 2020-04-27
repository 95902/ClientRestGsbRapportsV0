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
    public partial class FrmNewMedicement : Form
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
        private string url;
        private Medicament leMedicament;
        public FrmNewMedicement(Secretaire s)
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
            string familles = d.familles.ToString();//liste de familles

            List<Famille> l = JsonConvert.DeserializeObject<List<Famille>>(familles);
            cmbNomFamille.DataSource = l;
            cmbNomFamille.ValueMember = "id";
            cmbNomFamille.DisplayMember = "libelle";
            /* dataGridView1.DataSource = l*/
            ;//chargement de dataGridview

        }

    }  
}
