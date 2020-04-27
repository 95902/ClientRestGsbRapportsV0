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
    public partial class FormGererMedicament : Form
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
        private string url;
        public FormGererMedicament(Secretaire s)
        {
            InitializeComponent();
            this.laSecretaire = s;
            string mdpHas = s.getHashTicketMdp();
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
            this.dataGridView1.DataSource = null;
            this.url = this.site + "familles?ticket=" + mdpHas;
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);
            this.laSecretaire.ticket = d.ticket;
            // this.laSecretaire
            string familles = d.familles.ToString();//liste de familles

            List<Famille> l = JsonConvert.DeserializeObject<List<Famille>>(familles);

            comboBox1.DataSource = l;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "libelle";
            /* dataGridView1.DataSource = l*/
            ;//chargement de dataGridview
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string idFamille = comboBox1.SelectedValue.ToString().ToLower();
            string mdpHas = this.laSecretaire.getHashTicketMdp();
            this.url = this.site + "medicaments?ticket=" + mdpHas + "&idFamille=" + idFamille;
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);
            this.laSecretaire.ticket = d.ticket;
            // this.laSecretaire
            string medicament = d.medicaments.ToString();//liste de familles

            List<Medicament> M = JsonConvert.DeserializeObject<List<Medicament>>(medicament);
            dataGridView1.DataSource = M;


            //- -Sélectionner les médicaments d’une famille de médicament
            //    syntaxe: < nom domaine >/ gsbRapports / medicaments ? ticket =< ticket > &idFamille < id > 
            //    exemple : http://localhost/restGSB/medicaments?ticket=4nblbv5zttybtvd3ygx&nom=te



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource = null;
        //    string idFamille = comboBox1.SelectedValue.ToString();
        //    string mdpHas = this.laSecretaire.getHashTicketMdp();
        //    this.url = this.site + "medicaments?ticket=" + mdpHas + "&" + "nom=" + idFamille;
        //    string data = this.wb.DownloadString(url);
        //    dynamic d = JsonConvert.DeserializeObject(data);
        //    this.laSecretaire.ticket = d.ticket;
        //    // this.laSecretaire
        //    string medicament = d.medicaments.ToString();//liste de familles

        //    List<Medicament> M = JsonConvert.DeserializeObject<List<Medicament>>(medicament);
        //    dataGridView1.DataSource = M;
        //}


       




    }


}
