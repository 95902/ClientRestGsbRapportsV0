namespace ClientRestGsbRapports
{
    partial class UserControlModifier
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlModifier));
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gcmbFamille = new Guna.UI.WinForms.GunaComboBox();
            this.gtxtEffets = new Guna.UI.WinForms.GunaTextBox();
            this.gtxtComposition = new Guna.UI.WinForms.GunaTextBox();
            this.gtxtContreIndications = new Guna.UI.WinForms.GunaTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(328, 341);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(145, 29);
            this.gunaButton1.TabIndex = 51;
            this.gunaButton1.Text = "Valider";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gcmbFamille
            // 
            this.gcmbFamille.BackColor = System.Drawing.Color.Transparent;
            this.gcmbFamille.BaseColor = System.Drawing.Color.White;
            this.gcmbFamille.BorderColor = System.Drawing.Color.Silver;
            this.gcmbFamille.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcmbFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcmbFamille.FocusedColor = System.Drawing.Color.Empty;
            this.gcmbFamille.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcmbFamille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gcmbFamille.FormattingEnabled = true;
            this.gcmbFamille.Location = new System.Drawing.Point(200, 52);
            this.gcmbFamille.Name = "gcmbFamille";
            this.gcmbFamille.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.gcmbFamille.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcmbFamille.Size = new System.Drawing.Size(273, 26);
            this.gcmbFamille.TabIndex = 50;
            this.gcmbFamille.SelectedIndexChanged += new System.EventHandler(this.gcmbFamille_SelectedIndexChanged);
            // 
            // gtxtEffets
            // 
            this.gtxtEffets.BaseColor = System.Drawing.Color.White;
            this.gtxtEffets.BorderColor = System.Drawing.Color.Silver;
            this.gtxtEffets.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtEffets.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtEffets.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gtxtEffets.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtxtEffets.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gtxtEffets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gtxtEffets.Location = new System.Drawing.Point(200, 184);
            this.gtxtEffets.Multiline = true;
            this.gtxtEffets.Name = "gtxtEffets";
            this.gtxtEffets.PasswordChar = '\0';
            this.gtxtEffets.SelectedText = "";
            this.gtxtEffets.Size = new System.Drawing.Size(273, 59);
            this.gtxtEffets.TabIndex = 49;
            // 
            // gtxtComposition
            // 
            this.gtxtComposition.BaseColor = System.Drawing.Color.White;
            this.gtxtComposition.BorderColor = System.Drawing.Color.Silver;
            this.gtxtComposition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtComposition.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtComposition.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gtxtComposition.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtxtComposition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gtxtComposition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gtxtComposition.Location = new System.Drawing.Point(200, 105);
            this.gtxtComposition.Multiline = true;
            this.gtxtComposition.Name = "gtxtComposition";
            this.gtxtComposition.PasswordChar = '\0';
            this.gtxtComposition.SelectedText = "";
            this.gtxtComposition.Size = new System.Drawing.Size(273, 55);
            this.gtxtComposition.TabIndex = 48;
            // 
            // gtxtContreIndications
            // 
            this.gtxtContreIndications.BaseColor = System.Drawing.Color.White;
            this.gtxtContreIndications.BorderColor = System.Drawing.Color.Silver;
            this.gtxtContreIndications.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtContreIndications.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtContreIndications.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gtxtContreIndications.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtxtContreIndications.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gtxtContreIndications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gtxtContreIndications.Location = new System.Drawing.Point(200, 272);
            this.gtxtContreIndications.Multiline = true;
            this.gtxtContreIndications.Name = "gtxtContreIndications";
            this.gtxtContreIndications.PasswordChar = '\0';
            this.gtxtContreIndications.SelectedText = "";
            this.gtxtContreIndications.Size = new System.Drawing.Size(273, 52);
            this.gtxtContreIndications.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.label11.Location = new System.Drawing.Point(22, 272);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Contre Indications";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.label12.Location = new System.Drawing.Point(22, 184);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Effets";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.label13.Location = new System.Drawing.Point(22, 105);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Composition";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.label14.Location = new System.Drawing.Point(22, 52);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "Nom Commercial";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.label15.Location = new System.Drawing.Point(179, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(218, 18);
            this.label15.TabIndex = 42;
            this.label15.Text = "Modifier un medicament";
            // 
            // UserControlModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gcmbFamille);
            this.Controls.Add(this.gtxtEffets);
            this.Controls.Add(this.gtxtComposition);
            this.Controls.Add(this.gtxtContreIndications);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Name = "UserControlModifier";
            this.Size = new System.Drawing.Size(492, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaComboBox gcmbFamille;
        private Guna.UI.WinForms.GunaTextBox gtxtEffets;
        private Guna.UI.WinForms.GunaTextBox gtxtComposition;
        private Guna.UI.WinForms.GunaTextBox gtxtContreIndications;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}
