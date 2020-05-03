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
        public UserControlRecherchecs()
        {
            InitializeComponent();
            InitializeComponent();
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
            this.laSecretaire = new Secretaire();

        }

        private void gbtnValider_Click(object sender, EventArgs e)
        {

            string  dateDebut = gdtDateDébut.Value.ToString("yyyy-MM-dd");
            string dateFin = gtdDateFin.Value.ToString("yyyy-MM-dd");
            string mdpHas = this.laSecretaire.getHashTicketMdp();
            this.url = this.site + "medicaments?ticket=" + mdpHas + "&dateDebut=" + dateDebut+ "&dateFin="+ dateFin;
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);
            this.laSecretaire.ticket = d.ticket;
            string medicament = d.medicaments.ToString();//liste de familles
            List<Medicament> M = JsonConvert.DeserializeObject<List<Medicament>>(medicament);
            gdgvMedicament.DataSource = M;

            //-Sélectionner les médicaments offerts entre deux dates
            //  syntaxe: < nom domaine >/ gsbRapports / medicaments ? ticket =< ticket > &dateDebut<date1> & dateFin =< date2 >
            //  exemple : http://localhost/restGSB/medicaments?ticket=4nblbv5zttybtvd3ygx&dateDebut=2018-9-1&dateFin=2019-1-1
        }
    }
}
