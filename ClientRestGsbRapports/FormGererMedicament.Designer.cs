﻿namespace ClientRestGsbRapports
{
    partial class FormGererMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGererMedicament));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(19, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(15, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir famille medicament";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(290, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(338, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 528);
            this.panel2.TabIndex = 14;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(114, 20);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(62, 28);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "G S B";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.gunaAdvenceButton3);
            this.panel1.Controls.Add(this.gunaAdvenceButton2);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaAdvenceButton1);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 528);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.guna2Panel1.Controls.Add(this.gunaLabel1);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(221, 64);
            this.guna2Panel1.TabIndex = 4;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageOffsetX = 15;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(14, 14);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.gunaAdvenceButton1.LineLeft = 5;
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(0, 196);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnPressedDepth = 0;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(221, 60);
            this.gunaAdvenceButton1.TabIndex = 4;
            this.gunaAdvenceButton1.Text = "MEDICAMENTS";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(12, 93);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(69, 17);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Statut     :";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(83, 137);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(79, 17);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "gunaLabel3";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(12, 137);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(57, 17);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Bonjour";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(83, 93);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(68, 17);
            this.gunaLabel5.TabIndex = 8;
            this.gunaLabel5.Text = "Secretaire";
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.gunaAdvenceButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.Image")));
            this.gunaAdvenceButton2.ImageOffsetX = 15;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(14, 14);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.gunaAdvenceButton2.LineLeft = 5;
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(0, 260);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnPressedDepth = 0;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(221, 60);
            this.gunaAdvenceButton2.TabIndex = 9;
            this.gunaAdvenceButton2.Text = "MEDICAMENTS";
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.gunaAdvenceButton3.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.CheckedImage")));
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.gunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.gunaAdvenceButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.Image")));
            this.gunaAdvenceButton3.ImageOffsetX = 15;
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(14, 14);
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.gunaAdvenceButton3.LineLeft = 5;
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(0, 326);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnPressedDepth = 0;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(221, 60);
            this.gunaAdvenceButton3.TabIndex = 10;
            this.gunaAdvenceButton3.Text = "MEDICAMENTS";
            // 
            // FormGererMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGererMedicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGererMedicament";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
    }
}