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
        public FrmMedicaments(Medicament e, Secretaire s)
        {      
            InitializeComponent();
            leMedicament = e;
            wb = new WebClient();
            site = "http://localhost/restGSB/";
            laSecretaire = s;
            gtxtComposition.Text += e.composition;
            gtxtContreIndications.Text = e.contreIndications;
            gtxtEffets.Text = e.effets;
            gtxtNomComercial.Text = e.nomCommercial;
            gtxtIdMedicament.Text = e.id;
                   

        }

        //private void btnModifier_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        string mdpHas = this.laSecretaire.getHashTicketMdp();
        //        this.url = this.site + "medicament";
        //        NameValueCollection parametres = new NameValueCollection();
        //        parametres.Add("ticket", mdpHas);
        //        parametres.Add("idMedicament", gtxtIdMedicament.Text );
        //        parametres.Add("effets", gtxtEffets.Text);
        //        parametres.Add("contreIndications", gtxtContreIndications.Text);
        //        parametres.Add("composition", gtxtComposition.Text);
        //        byte[] tabByte = wb.UploadValues(url, "POST", parametres);
        //        string reponse = UnicodeEncoding.UTF8.GetString(tabByte);
        //        string ticket = reponse.Substring(2, reponse.Length - 2);
        //        MessageBox.Show(reponse);
        //    }
        //    catch (WebException ex)
        //    {
        //        if (ex.Response is HttpWebResponse)
        //            MessageBox.Show(((HttpWebResponse)ex.Response).StatusCode.ToString());
        //    }
        //    //Mise à jour d’un médicament(effets, contre-indications, composition ) à partir de son id
        //    //URL : gsbRapports / medicament
        //    //Paramètres: ticket =< ticket > idMedicament =< id > effets =< effets > contreIndications =< cid > composition =< compo >
        //    //exemple : http://localhost/restGSB/medicament
        //    //ticket = 4nblbv5zttybtvd3ygx idMedicament = A123 effets = aucuns contreIndications = aucune composition = très compliquée
        //}

       

        private void gbtnMiseAJours_Click(object sender, EventArgs e)
        {
            try
            {
                string mdpHas = this.laSecretaire.getHashTicketMdp();
                this.url = this.site + "medicament";
                NameValueCollection parametres = new NameValueCollection();
                parametres.Add("ticket", mdpHas);
                parametres.Add("idMedicament", gtxtIdMedicament.Text);
                parametres.Add("effets", gtxtEffets.Text);
                parametres.Add("contreIndications", gtxtContreIndications.Text);
                parametres.Add("composition", gtxtComposition.Text);
                byte[] tabByte = wb.UploadValues(url, "POST", parametres);
                string reponse = UnicodeEncoding.UTF8.GetString(tabByte);
                string ticket = reponse.Substring(2, reponse.Length - 2);
                this.laSecretaire.ticket = ticket;





                MessageBox.Show(reponse);
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse)
                    MessageBox.Show(((HttpWebResponse)ex.Response).StatusCode.ToString());
            }
            //Mise à jour d’un médicament(effets, contre-indications, composition ) à partir de son id
            //URL : gsbRapports / medicament
            //Paramètres: ticket =< ticket > idMedicament =< id > effets =< effets > contreIndications =< cid > composition =< compo >
            //exemple : http://localhost/restGSB/medicament
            //ticket = 4nblbv5zttybtvd3ygx idMedicament = A123 effets = aucuns contreIndications = aucune composition = très compliquée
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void gunaDateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime d = gunaDateTimePicker1.Value;
            gunaLabel1.Text = d.ToString();
        }
    }
}
