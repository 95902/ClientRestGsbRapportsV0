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
using System.Xml.Serialization;
using System.IO;

namespace ClientRestGsbRapports
{
    public partial class UserControlRecherchecs : UserControl
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
        private string url;
        private Medicament leMedicament;
        private List<Medicament> M = new List<Medicament>();


        public UserControlRecherchecs(Secretaire s)
        {
            
            InitializeComponent();
            wb = new WebClient();
            site = "http://localhost/restGSB/";
            laSecretaire = s;
            

        }
        public void gbtnValider_Click_1(object sender, EventArgs e)
        {
            string dateDebut = gunaDateTimePicker1.Value.ToString("yyyy-MM-dd");
            string datefin = gunaDateTimePicker2.Value.ToString("yyyy-MM-dd");
            string mdpHas = this.laSecretaire.getHashTicketMdp();
            this.url = this.site + "medicaments?ticket=" + mdpHas + "&dateDebut=" + dateDebut + "&dateFin=" + datefin;
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);

            this.laSecretaire.ticket = d.ticket;
            string medicament = d.medicaments.ToString();//liste de familles
             M = JsonConvert.DeserializeObject<List<Medicament>>(medicament);
            gunaDataGridView1.DataSource = M;

            //-Sélectionner les médicaments offerts entre deux dates
            //      syntaxe: < nom domaine >/ gsbRapports / medicaments ? ticket =< ticket > &dateDebut<date1> & dateFin =< date2 >
            //      exemple : http://localhost/restGSB/medicaments?ticket=4nblbv5zttybtvd3ygx&dateDebut=2018-9-1&dateFin=2019-1-1

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\rechercheMedicament.txt"); //création du chemin du fichier 
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Medicament>)); //
            xmlSer.Serialize(stream,M );// sérialisation  de la liste 
            stream.Close();// fin du stream
            MessageBox.Show("Exportation Réussie !!");
            
        }
    }
}
