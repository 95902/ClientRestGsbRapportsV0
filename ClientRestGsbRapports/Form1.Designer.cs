namespace ClientRestGsbRapports
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesMédicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gtxtLogin = new Guna.UI.WinForms.GunaTextBox();
            this.gtxtMdp = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTileButton1 = new Guna.UI.WinForms.GunaTileButton();
            this.gbtnValider = new Guna.UI.WinForms.GunaButton();
            this.lblNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(12, 93);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(33, 13);
            this.LblLogin.TabIndex = 2;
            this.LblLogin.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.médecinsToolStripMenuItem,
            this.rapportsToolStripMenuItem,
            this.médicamentsToolStripMenuItem,
            this.visiteursToolStripMenuItem,
            this.familleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // médecinsToolStripMenuItem
            // 
            this.médecinsToolStripMenuItem.Name = "médecinsToolStripMenuItem";
            this.médecinsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.médecinsToolStripMenuItem.Text = "Médecins";
            // 
            // rapportsToolStripMenuItem
            // 
            this.rapportsToolStripMenuItem.Name = "rapportsToolStripMenuItem";
            this.rapportsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.rapportsToolStripMenuItem.Text = "Visites";
            // 
            // médicamentsToolStripMenuItem
            // 
            this.médicamentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesMédicamentsToolStripMenuItem});
            this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.médicamentsToolStripMenuItem.Text = "Médicaments";
            // 
            // gérerLesMédicamentsToolStripMenuItem
            // 
            this.gérerLesMédicamentsToolStripMenuItem.Name = "gérerLesMédicamentsToolStripMenuItem";
            this.gérerLesMédicamentsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.gérerLesMédicamentsToolStripMenuItem.Text = "Gérer les médicaments";
            this.gérerLesMédicamentsToolStripMenuItem.Click += new System.EventHandler(this.gérerLesMédicamentsToolStripMenuItem_Click);
            // 
            // visiteursToolStripMenuItem
            // 
            this.visiteursToolStripMenuItem.Name = "visiteursToolStripMenuItem";
            this.visiteursToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.visiteursToolStripMenuItem.Text = "Visiteurs";
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.ajouterToolStripMenuItem});
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.familleToolStripMenuItem.Text = "Famille";
            // 
            // voirToolStripMenuItem
            // 
            this.voirToolStripMenuItem.Name = "voirToolStripMenuItem";
            this.voirToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.voirToolStripMenuItem.Text = "Voir";
            this.voirToolStripMenuItem.Click += new System.EventHandler(this.voirToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.gtxtLogin);
            this.panel1.Controls.Add(this.gtxtMdp);
            this.panel1.Controls.Add(this.gunaTileButton1);
            this.panel1.Controls.Add(this.gbtnValider);
            this.panel1.Controls.Add(this.lblNom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 263);
            this.panel1.TabIndex = 9;
            // 
            // gtxtLogin
            // 
            this.gtxtLogin.BaseColor = System.Drawing.Color.White;
            this.gtxtLogin.BorderColor = System.Drawing.Color.Silver;
            this.gtxtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtLogin.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtLogin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.gtxtLogin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtxtLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtLogin.Location = new System.Drawing.Point(355, 85);
            this.gtxtLogin.Name = "gtxtLogin";
            this.gtxtLogin.PasswordChar = '\0';
            this.gtxtLogin.SelectedText = "";
            this.gtxtLogin.Size = new System.Drawing.Size(99, 26);
            this.gtxtLogin.TabIndex = 23;
            // 
            // gtxtMdp
            // 
            this.gtxtMdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gtxtMdp.BaseColor = System.Drawing.Color.White;
            this.gtxtMdp.BorderColor = System.Drawing.Color.Silver;
            this.gtxtMdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtMdp.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtMdp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.gtxtMdp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtxtMdp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtMdp.Location = new System.Drawing.Point(355, 149);
            this.gtxtMdp.Name = "gtxtMdp";
            this.gtxtMdp.PasswordChar = '\0';
            this.gtxtMdp.SelectedText = "";
            this.gtxtMdp.Size = new System.Drawing.Size(99, 26);
            this.gtxtMdp.TabIndex = 22;
            // 
            // gunaTileButton1
            // 
            this.gunaTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaTileButton1.AnimationSpeed = 0.03F;
            this.gunaTileButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaTileButton1.Image")));
            this.gunaTileButton1.ImageSize = new System.Drawing.Size(160, 190);
            this.gunaTileButton1.Location = new System.Drawing.Point(12, 15);
            this.gunaTileButton1.Name = "gunaTileButton1";
            this.gunaTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaTileButton1.OnHoverImage = null;
            this.gunaTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaTileButton1.OnPressedDepth = 5;
            this.gunaTileButton1.Size = new System.Drawing.Size(189, 160);
            this.gunaTileButton1.TabIndex = 21;
            this.gunaTileButton1.Text = "gunaTileButton1";
            // 
            // gbtnValider
            // 
            this.gbtnValider.AnimationHoverSpeed = 0.07F;
            this.gbtnValider.AnimationSpeed = 0.03F;
            this.gbtnValider.BackColor = System.Drawing.Color.Transparent;
            this.gbtnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtnValider.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gbtnValider.BorderColor = System.Drawing.Color.Black;
            this.gbtnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnValider.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnValider.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnValider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.gbtnValider.Image = ((System.Drawing.Image)(resources.GetObject("gbtnValider.Image")));
            this.gbtnValider.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnValider.ImageSize = new System.Drawing.Size(25, 25);
            this.gbtnValider.Location = new System.Drawing.Point(274, 205);
            this.gbtnValider.Name = "gbtnValider";
            this.gbtnValider.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.gbtnValider.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnValider.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnValider.OnHoverImage = null;
            this.gbtnValider.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnValider.Radius = 20;
            this.gbtnValider.Size = new System.Drawing.Size(135, 36);
            this.gbtnValider.TabIndex = 20;
            this.gbtnValider.Text = "Connexion";
            this.gbtnValider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnValider.Click += new System.EventHandler(this.gbtnValider_Click_1);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.lblNom.Location = new System.Drawing.Point(219, 24);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(0, 20);
            this.lblNom.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(218, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mot de passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.label4.Location = new System.Drawing.Point(218, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 287);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestion des rapports de visite";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médecinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem gérerLesMédicamentsToolStripMenuItem;
        private Guna.UI.WinForms.GunaTextBox gtxtLogin;
        private Guna.UI.WinForms.GunaTextBox gtxtMdp;
        private Guna.UI.WinForms.GunaTileButton gunaTileButton1;
        private Guna.UI.WinForms.GunaButton gbtnValider;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

