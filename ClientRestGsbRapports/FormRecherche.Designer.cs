namespace ClientRestGsbRapports
{
    partial class FormRecherche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecherche));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbtnValider = new Guna.UI.WinForms.GunaButton();
            this.gdgvMedicament = new Guna.UI.WinForms.GunaDataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaDateTimePicker2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gdgvMedicament)).BeginInit();
            this.SuspendLayout();
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
            this.gbtnValider.Location = new System.Drawing.Point(421, 216);
            this.gbtnValider.Name = "gbtnValider";
            this.gbtnValider.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gbtnValider.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnValider.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.gbtnValider.OnHoverImage = null;
            this.gbtnValider.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnValider.Radius = 15;
            this.gbtnValider.Size = new System.Drawing.Size(102, 28);
            this.gbtnValider.TabIndex = 49;
            this.gbtnValider.Text = "Rechercher";
            this.gbtnValider.Click += new System.EventHandler(this.gbtnValider_Click);
            // 
            // gdgvMedicament
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdgvMedicament.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdgvMedicament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdgvMedicament.BackgroundColor = System.Drawing.Color.White;
            this.gdgvMedicament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdgvMedicament.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvMedicament.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdgvMedicament.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdgvMedicament.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdgvMedicament.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdgvMedicament.EnableHeadersVisualStyles = false;
            this.gdgvMedicament.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvMedicament.Location = new System.Drawing.Point(20, 265);
            this.gdgvMedicament.Name = "gdgvMedicament";
            this.gdgvMedicament.RowHeadersVisible = false;
            this.gdgvMedicament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdgvMedicament.Size = new System.Drawing.Size(503, 174);
            this.gdgvMedicament.TabIndex = 48;
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
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(92, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(348, 40);
            this.guna2HtmlLabel1.TabIndex = 47;
            this.guna2HtmlLabel1.Text = "Recherche Medicament";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaLabel5.Location = new System.Drawing.Point(16, 75);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(137, 19);
            this.gunaLabel5.TabIndex = 46;
            this.gunaLabel5.Text = "Sélectioner une date ";
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(85, 165);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(167, 30);
            this.gunaDateTimePicker1.TabIndex = 53;
            this.gunaDateTimePicker1.Text = "dimanche 3 mai 2020";
            this.gunaDateTimePicker1.Value = new System.DateTime(2020, 5, 3, 18, 37, 51, 199);
            // 
            // gunaDateTimePicker2
            // 
            this.gunaDateTimePicker2.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker2.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker2.CustomFormat = null;
            this.gunaDateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker2.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.Location = new System.Drawing.Point(348, 165);
            this.gunaDateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker2.Name = "gunaDateTimePicker2";
            this.gunaDateTimePicker2.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.Size = new System.Drawing.Size(175, 30);
            this.gunaDateTimePicker2.TabIndex = 54;
            this.gunaDateTimePicker2.Text = "dimanche 3 mai 2020";
            this.gunaDateTimePicker2.Value = new System.DateTime(2020, 5, 3, 18, 37, 51, 199);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(17, 173);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(39, 15);
            this.gunaLabel1.TabIndex = 56;
            this.gunaLabel1.Text = "Début";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(299, 173);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(23, 15);
            this.gunaLabel2.TabIndex = 57;
            this.gunaLabel2.Text = "Fin";
            // 
            // FormRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 506);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaDateTimePicker2);
            this.Controls.Add(this.gunaDateTimePicker1);
            this.Controls.Add(this.gbtnValider);
            this.Controls.Add(this.gdgvMedicament);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.gunaLabel5);
            this.Name = "FormRecherche";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormRecherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdgvMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton gbtnValider;
        private Guna.UI.WinForms.GunaDataGridView gdgvMedicament;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}