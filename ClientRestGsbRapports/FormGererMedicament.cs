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
            this.laSecretaire = s;
            InitializeComponent(); 
            string mdpHas = s.getHashTicketMdp();
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
            this.url = this.site + "familles?ticket=" + mdpHas;
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);
            this.laSecretaire.ticket = d.ticket;
            string familles = d.familles.ToString();//liste de familles
            List<Famille> l = JsonConvert.DeserializeObject<List<Famille>>(familles);
            gunaLabel5.Text ="Secrétaire"; // chargement liste Familles 
            gunaLabel3.Text = s.nom + " " + s.prenom;
            userControlAjouter1.Hide(); // Hide permet de cacher les user controller 
            userControlMedicaments1.Hide();
            userControlModifier1.Hide();
            userControlRecherchecs1.Hide();

        }

     
        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Permet de charger un liste de medicament dans le data grindview  par rapport a une sélection de famille 
            string mdpHas = this.laSecretaire.getHashTicketMdp();
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);
            this.laSecretaire.ticket = d.ticket;
            string medicament = d.medicaments.ToString();//liste de familles
            List<Medicament> M = JsonConvert.DeserializeObject<List<Medicament>>(medicament);
            
        }


        private void gunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Renvoie aux FormMedicament qui permet de faire des modifications
           
            FrmMedicaments f = new FrmMedicaments(this.leMedicament, this.laSecretaire);
            f.Show();
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            userControlRecherchecs1.Hide();
            userControlAjouter1.Hide();
            userControlModifier1.Hide();
            /////////////////////////////
            userControlMedicaments1.Show();
            userControlMedicaments1.BringToFront();// Met en premiers plan 

        }
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            userControlRecherchecs1.Hide();
            userControlMedicaments1.Hide();
            userControlModifier1.Hide();
            /////////////////////////////
            userControlAjouter1.Show();
            userControlAjouter1.BringToFront();// Met en premiers plan 
        }  
        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            userControlRecherchecs1.Hide();
            userControlMedicaments1.Hide();
            userControlAjouter1.Hide();
            /////////////////////////////
            userControlModifier1.Show();
            userControlModifier1.BringToFront();// Met en premiers plan 
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            userControlMedicaments1.Hide();
            userControlAjouter1.Hide();
            userControlModifier1.Hide();
            /////////////////////////////
            userControlRecherchecs1.Show();
            userControlRecherchecs1.BringToFront();// Met en premiers plan 
        }
       
    }
    


}
