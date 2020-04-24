namespace ClientRestGsbRapports
{
    partial class FrmNewMedicement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Composition = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbNomComercial = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtCompo = new System.Windows.Forms.TextBox();
            this.txtEffets = new System.Windows.Forms.TextBox();
            this.txtContreIndication = new System.Windows.Forms.TextBox();
            this.cmbNomFamille = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un Médicament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Comercial";
            // 
            // Composition
            // 
            this.Composition.AutoSize = true;
            this.Composition.Location = new System.Drawing.Point(78, 113);
            this.Composition.Name = "Composition";
            this.Composition.Size = new System.Drawing.Size(64, 13);
            this.Composition.TabIndex = 2;
            this.Composition.Text = "Composition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Effets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nom famille";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contre Indications";
            // 
            // cmbNomComercial
            // 
            this.cmbNomComercial.FormattingEnabled = true;
            this.cmbNomComercial.Location = new System.Drawing.Point(403, 51);
            this.cmbNomComercial.Name = "cmbNomComercial";
            this.cmbNomComercial.Size = new System.Drawing.Size(121, 21);
            this.cmbNomComercial.TabIndex = 6;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(417, 398);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // txtCompo
            // 
            this.txtCompo.Location = new System.Drawing.Point(403, 113);
            this.txtCompo.Name = "txtCompo";
            this.txtCompo.Size = new System.Drawing.Size(121, 20);
            this.txtCompo.TabIndex = 8;
            // 
            // txtEffets
            // 
            this.txtEffets.Location = new System.Drawing.Point(403, 184);
            this.txtEffets.Name = "txtEffets";
            this.txtEffets.Size = new System.Drawing.Size(121, 20);
            this.txtEffets.TabIndex = 9;
            // 
            // txtContreIndication
            // 
            this.txtContreIndication.Location = new System.Drawing.Point(403, 243);
            this.txtContreIndication.Name = "txtContreIndication";
            this.txtContreIndication.Size = new System.Drawing.Size(121, 20);
            this.txtContreIndication.TabIndex = 10;
            // 
            // cmbNomFamille
            // 
            this.cmbNomFamille.FormattingEnabled = true;
            this.cmbNomFamille.Location = new System.Drawing.Point(403, 313);
            this.cmbNomFamille.Name = "cmbNomFamille";
            this.cmbNomFamille.Size = new System.Drawing.Size(121, 21);
            this.cmbNomFamille.TabIndex = 12;
            // 
            // FrmNewMedicement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.cmbNomFamille);
            this.Controls.Add(this.txtContreIndication);
            this.Controls.Add(this.txtEffets);
            this.Controls.Add(this.txtCompo);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cmbNomComercial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Composition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNewMedicement";
            this.Text = "AjouterMedicament2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Composition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbNomComercial;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtCompo;
        private System.Windows.Forms.TextBox txtEffets;
        private System.Windows.Forms.TextBox txtContreIndication;
        private System.Windows.Forms.ComboBox cmbNomFamille;
    }
}