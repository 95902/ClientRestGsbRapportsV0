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

namespace ClientRestGsbRapports
{
    public partial class UserControlRecherchecs : UserControl
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
        private string url;
        private Medicament leMedicament;
        public UserControlRecherchecs(Secretaire s)
        {
            InitializeComponent();
            wb = new WebClient();
            site = "http://localhost/restGSB/";
            laSecretaire = s;


        }
        private void gbtnValider_Click_1(object sender, EventArgs e)
        {
            string dateDebut = gunaDateTimePicker1.Value.ToString("yyyy-MM-dd");
            string datefin = gunaDateTimePicker2.Value.ToString("yyyy-MM-dd");
            string mdpHas = this.laSecretaire.getHashTicketMdp();
            this.url = this.site + "medicaments?ticket=" + mdpHas + "&dateDebut=" + dateDebut + "&dateFin=" + datefin;
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);

            this.laSecretaire.ticket = d.ticket;
            string medicament = d.medicaments.ToString();//liste de familles
            List<Medicament> M = JsonConvert.DeserializeObject<List<Medicament>>(medicament);
            gunaDataGridView1.DataSource = M;

            //-Sélectionner les médicaments offerts entre deux dates
            //      syntaxe: < nom domaine >/ gsbRapports / medicaments ? ticket =< ticket > &dateDebut<date1> & dateFin =< date2 >
            //      exemple : http://localhost/restGSB/medicaments?ticket=4nblbv5zttybtvd3ygx&dateDebut=2018-9-1&dateFin=2019-1-1

        }
    }
}
