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
        private Medicament leMedicament;
        public FormGererMedicament(Secretaire s)  
        {
            InitializeComponent();
            this.laSecretaire = s;
            string mdpHas = s.getHashTicketMdp();
            
            //Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel1, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
            this.gunaDataGridView1.DataSource = null;
            this.url = this.site + "familles?ticket=" + mdpHas;
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);
            this.laSecretaire.ticket = d.ticket;
            // this.laSecretaire
            string familles = d.familles.ToString();//liste de familles
            List<Famille> l = JsonConvert.DeserializeObject<List<Famille>>(familles);
            gunaComboBox1.DataSource = l;
            gunaComboBox1.ValueMember= "id";
            gunaComboBox1.DisplayMember= "libelle"; 
         
            /* dataGridView1.DataSource = l*/
            //chargement de dataGridview
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNewMedicement f = new FrmNewMedicement(this.laSecretaire);
            f.Show();
        }
        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gunaDataGridView1.DataSource = null;

            string idFamille = gunaComboBox1.SelectedValue.ToString().ToLower();
            string mdpHas = this.laSecretaire.getHashTicketMdp();
            this.url = this.site + "medicaments?ticket=" + mdpHas + "&idFamille=" + idFamille;
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);
            this.laSecretaire.ticket = d.ticket;
            // this.laSecretaire
            string medicament = d.medicaments.ToString();//liste de familles
            List<Medicament> M = JsonConvert.DeserializeObject<List<Medicament>>(medicament);
            gunaDataGridView1.DataSource = M;
        }

     

        private void gunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.leMedicament = (Medicament)this.gunaDataGridView1.CurrentRow.DataBoundItem;
            FrmMedicaments f = new FrmMedicaments(this.leMedicament, this.laSecretaire);
            f.Show();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {

        }
    }


}
