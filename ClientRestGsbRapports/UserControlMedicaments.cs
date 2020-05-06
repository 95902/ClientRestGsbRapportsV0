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
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace ClientRestGsbRapports
{
    public partial class UserControlMedicaments : UserControl
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
        private string url;
        private Medicament leMedicament;
        private List<Medicament> M = new List<Medicament>();
        public UserControlMedicaments(Secretaire s)
        {
            InitializeComponent();
            
            
            
            this.laSecretaire = s;
            string mdpHas = s.getHashTicketMdp();

            
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
            this.gunaDataGridView1.DataSource = null;
            this.url = this.site + "familles?ticket=" + mdpHas;
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);
            this.laSecretaire.ticket = d.ticket;
            string familles = d.familles.ToString();//liste de familles
            List<Famille> l = JsonConvert.DeserializeObject<List<Famille>>(familles);
            gunaComboBox1.DataSource = l;
            gunaComboBox1.ValueMember= "id";
            gunaComboBox1.DisplayMember= "libelle";   
        }
        private void gunaComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            gunaDataGridView1.DataSource = null;

            string idFamille = gunaComboBox1.SelectedValue.ToString().ToLower();
            string mdpHas = this.laSecretaire.getHashTicketMdp();
            this.url = this.site + "medicaments?ticket=" + mdpHas + "&idFamille=" + idFamille;
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);
            this.laSecretaire.ticket = d.ticket;
            string medicament = d.medicaments.ToString();//liste de familles
            List<Medicament> M = JsonConvert.DeserializeObject<List<Medicament>>(medicament);
            gunaDataGridView1.DataSource = M;
                 
        }
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Medicament m = (Medicament)gunaDataGridView1.SelectedRows[0].DataBoundItem;
            FrmMedicaments f = new FrmMedicaments(m, this.laSecretaire);
            f.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\rechercheMedicament.txt"); //création du chemin du fichier 
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Medicament>)); //
            xmlSer.Serialize(stream, M);// sérialisation  de la liste 
            stream.Close();// fin du stream
            MessageBox.Show("Exportation Réussie !!");
        }

    }
}
