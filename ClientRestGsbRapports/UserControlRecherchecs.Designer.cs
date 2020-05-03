namespace ClientRestGsbRapports
{
    partial class UserControlRecherchecs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlRecherchecs));
            this.gtdDateFin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gdtDateDébut = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gdgvMedicament = new Guna.UI.WinForms.GunaDataGridView();
            this.gbtnValider = new Guna.UI.WinForms.GunaButton();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gdgvMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gtdDateFin
            // 
            this.gtdDateFin.CheckedState.Parent = this.gtdDateFin;
            this.gtdDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.gtdDateFin.HoverState.Parent = this.gtdDateFin;
            this.gtdDateFin.Location = new System.Drawing.Point(346, 172);
            this.gtdDateFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gtdDateFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gtdDateFin.Name = "gtdDateFin";
            this.gtdDateFin.ShadowDecoration.Parent = this.gtdDateFin;
            this.gtdDateFin.Size = new System.Drawing.Size(184, 28);
            this.gtdDateFin.TabIndex = 0;
            this.gtdDateFin.Value = new System.DateTime(2020, 5, 2, 14, 26, 35, 604);
            // 
            // gdtDateDébut
            // 
            this.gdtDateDébut.BaseColor = System.Drawing.Color.White;
            this.gdtDateDébut.BorderColor = System.Drawing.Color.Silver;
            this.gdtDateDébut.CustomFormat = "yyyy. MM. dd";
            this.gdtDateDébut.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gdtDateDébut.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdtDateDébut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gdtDateDébut.ForeColor = System.Drawing.Color.Black;
            this.gdtDateDébut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gdtDateDébut.Location = new System.Drawing.Point(99, 172);
            this.gdtDateDébut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gdtDateDébut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gdtDateDébut.Name = "gdtDateDébut";
            this.gdtDateDébut.OnHoverBaseColor = System.Drawing.Color.White;
            this.gdtDateDébut.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdtDateDébut.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdtDateDébut.OnPressedColor = System.Drawing.Color.Black;
            this.gdtDateDébut.Size = new System.Drawing.Size(155, 30);
            this.gdtDateDébut.TabIndex = 1;
            this.gdtDateDébut.Text = "2020. 05. 02";
            this.gdtDateDébut.Value = new System.DateTime(2020, 5, 2, 14, 26, 48, 159);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaLabel1.Location = new System.Drawing.Point(23, 115);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(137, 19);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Sélectioner une date ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(99, 21);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(348, 40);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Recherche Medicament";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaLabel2.Location = new System.Drawing.Point(303, 180);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(27, 19);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Fin";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaLabel3.Location = new System.Drawing.Point(23, 180);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(47, 19);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Début";
            // 
            // gdgvMedicament
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gdgvMedicament.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gdgvMedicament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdgvMedicament.BackgroundColor = System.Drawing.Color.White;
            this.gdgvMedicament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdgvMedicament.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvMedicament.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdgvMedicament.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gdgvMedicament.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdgvMedicament.DefaultCellStyle = dataGridViewCellStyle6;
            this.gdgvMedicament.EnableHeadersVisualStyles = false;
            this.gdgvMedicament.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvMedicament.Location = new System.Drawing.Point(27, 274);
            this.gdgvMedicament.Name = "gdgvMedicament";
            this.gdgvMedicament.RowHeadersVisible = false;
            this.gdgvMedicament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdgvMedicament.Size = new System.Drawing.Size(503, 174);
            this.gdgvMedicament.TabIndex = 6;
            this.gdgvMedicament.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gdgvMedicament.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvMedicament.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdgvMedicament.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdgvMedicament.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdgvMedicament.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdgvMedicament.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdgvMedicament.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvMedicament.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdgvMedicament.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdgvMedicament.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgvMedicament.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdgvMedicament.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdgvMedicament.ThemeStyle.HeaderStyle.Height = 4;
            this.gdgvMedicament.ThemeStyle.ReadOnly = false;
            this.gdgvMedicament.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvMedicament.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvMedicament.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgvMedicament.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgvMedicament.ThemeStyle.RowsStyle.Height = 22;
            this.gdgvMedicament.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvMedicament.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gbtnValider
            // 
            this.gbtnValider.AnimationHoverSpeed = 0.07F;
            this.gbtnValider.AnimationSpeed = 0.03F;
            this.gbtnValider.BackColor = System.Drawing.Color.Transparent;
            this.gbtnValider.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.gbtnValider.BorderColor = System.Drawing.Color.Black;
            this.gbtnValider.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnValider.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnValider.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnValider.ForeColor = System.Drawing.Color.White;
            this.gbtnValider.Image = ((System.Drawing.Image)(resources.GetObject("gbtnValider.Image")));
            this.gbtnValider.ImageSize = new System.Drawing.Size(13, 13);
            this.gbtnValider.Location = new System.Drawing.Point(428, 225);
            this.gbtnValider.Name = "gbtnValider";
            this.gbtnValider.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gbtnValider.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnValider.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.gbtnValider.OnHoverImage = null;
            this.gbtnValider.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnValider.Radius = 15;
            this.gbtnValider.Size = new System.Drawing.Size(102, 28);
            this.gbtnValider.TabIndex = 43;
            this.gbtnValider.Text = "Rechercher";
            this.gbtnValider.Click += new System.EventHandler(this.gbtnValider_Click);
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataSource = typeof(mdlGsbRapports.Medicament);
            // 
            // familleBindingSource
            // 
            this.familleBindingSource.DataSource = typeof(mdlGsbRapports.Famille);
            // 
            // UserControlRecherchecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbtnValider);
            this.Controls.Add(this.gdgvMedicament);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gdtDateDébut);
            this.Controls.Add(this.gtdDateFin);
            this.Name = "UserControlRecherchecs";
            this.Size = new System.Drawing.Size(551, 493);
            ((System.ComponentModel.ISupportInitialize)(this.gdgvMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker gtdDateFin;
        private Guna.UI.WinForms.GunaDateTimePicker gdtDateDébut;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDataGridView gdgvMedicament;
        private Guna.UI.WinForms.GunaButton gbtnValider;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private System.Windows.Forms.BindingSource familleBindingSource;
    }
}
