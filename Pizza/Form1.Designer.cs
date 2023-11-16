namespace Pizza
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_betoltes = new System.Windows.Forms.Button();
            this.label_fajl = new System.Windows.Forms.Label();
            this.textBox_fajlbetoltes = new System.Windows.Forms.TextBox();
            this.listBox_pizzak = new System.Windows.Forms.ListBox();
            this.button_atlag = new System.Windows.Forms.Button();
            this.groupBox_fizetes = new System.Windows.Forms.GroupBox();
            this.radioButton_keszpenz = new System.Windows.Forms.RadioButton();
            this.radioButton_bankkartya = new System.Windows.Forms.RadioButton();
            this.checkBox_szamla = new System.Windows.Forms.CheckBox();
            this.label_szamla = new System.Windows.Forms.Label();
            this.button_hozzaad = new System.Windows.Forms.Button();
            this.textBox_db = new System.Windows.Forms.TextBox();
            this.label_db = new System.Windows.Forms.Label();
            this.button_rendeles = new System.Windows.Forms.Button();
            this.listBox_kosar = new System.Windows.Forms.ListBox();
            this.groupBox_fizetes.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_betoltes
            // 
            this.button_betoltes.BackColor = System.Drawing.Color.Tomato;
            this.button_betoltes.Location = new System.Drawing.Point(41, 72);
            this.button_betoltes.Name = "button_betoltes";
            this.button_betoltes.Size = new System.Drawing.Size(75, 23);
            this.button_betoltes.TabIndex = 0;
            this.button_betoltes.Text = "Betöltés";
            this.button_betoltes.UseVisualStyleBackColor = false;
            this.button_betoltes.Click += new System.EventHandler(this.button_betoltes_Click);
            // 
            // label_fajl
            // 
            this.label_fajl.AutoSize = true;
            this.label_fajl.Location = new System.Drawing.Point(12, 30);
            this.label_fajl.Name = "label_fajl";
            this.label_fajl.Size = new System.Drawing.Size(69, 13);
            this.label_fajl.TabIndex = 1;
            this.label_fajl.Text = "Fájl betöltése";
            // 
            // textBox_fajlbetoltes
            // 
            this.textBox_fajlbetoltes.Location = new System.Drawing.Point(12, 46);
            this.textBox_fajlbetoltes.Name = "textBox_fajlbetoltes";
            this.textBox_fajlbetoltes.Size = new System.Drawing.Size(126, 20);
            this.textBox_fajlbetoltes.TabIndex = 2;
            this.textBox_fajlbetoltes.TextChanged += new System.EventHandler(this.textBox_fajlbetoltes_TextChanged);
            // 
            // listBox_pizzak
            // 
            this.listBox_pizzak.FormattingEnabled = true;
            this.listBox_pizzak.Location = new System.Drawing.Point(12, 129);
            this.listBox_pizzak.Name = "listBox_pizzak";
            this.listBox_pizzak.Size = new System.Drawing.Size(206, 264);
            this.listBox_pizzak.TabIndex = 3;
            this.listBox_pizzak.SelectedIndexChanged += new System.EventHandler(this.listBox_pizzak_SelectedIndexChanged);
            // 
            // button_atlag
            // 
            this.button_atlag.BackColor = System.Drawing.Color.Tomato;
            this.button_atlag.Location = new System.Drawing.Point(30, 399);
            this.button_atlag.Name = "button_atlag";
            this.button_atlag.Size = new System.Drawing.Size(168, 23);
            this.button_atlag.TabIndex = 4;
            this.button_atlag.Text = "Átlagár";
            this.button_atlag.UseVisualStyleBackColor = false;
            this.button_atlag.Click += new System.EventHandler(this.button_atalagar);
            // 
            // groupBox_fizetes
            // 
            this.groupBox_fizetes.Controls.Add(this.radioButton_keszpenz);
            this.groupBox_fizetes.Controls.Add(this.radioButton_bankkartya);
            this.groupBox_fizetes.Location = new System.Drawing.Point(240, 30);
            this.groupBox_fizetes.Name = "groupBox_fizetes";
            this.groupBox_fizetes.Size = new System.Drawing.Size(200, 100);
            this.groupBox_fizetes.TabIndex = 5;
            this.groupBox_fizetes.TabStop = false;
            this.groupBox_fizetes.Text = "Mivel szeretne fizetni?";
            // 
            // radioButton_keszpenz
            // 
            this.radioButton_keszpenz.AutoSize = true;
            this.radioButton_keszpenz.Location = new System.Drawing.Point(7, 56);
            this.radioButton_keszpenz.Name = "radioButton_keszpenz";
            this.radioButton_keszpenz.Size = new System.Drawing.Size(71, 17);
            this.radioButton_keszpenz.TabIndex = 1;
            this.radioButton_keszpenz.TabStop = true;
            this.radioButton_keszpenz.Text = "Készpénz";
            this.radioButton_keszpenz.UseVisualStyleBackColor = true;
            this.radioButton_keszpenz.CheckedChanged += new System.EventHandler(this.radioButton_kezpenz_CheckedChanged);
            // 
            // radioButton_bankkartya
            // 
            this.radioButton_bankkartya.AutoSize = true;
            this.radioButton_bankkartya.Location = new System.Drawing.Point(7, 26);
            this.radioButton_bankkartya.Name = "radioButton_bankkartya";
            this.radioButton_bankkartya.Size = new System.Drawing.Size(79, 17);
            this.radioButton_bankkartya.TabIndex = 0;
            this.radioButton_bankkartya.TabStop = true;
            this.radioButton_bankkartya.Text = "Bankkártya";
            this.radioButton_bankkartya.UseVisualStyleBackColor = true;
            this.radioButton_bankkartya.CheckedChanged += new System.EventHandler(this.radioButton_bankkartya_CheckedChanged);
            // 
            // checkBox_szamla
            // 
            this.checkBox_szamla.AutoSize = true;
            this.checkBox_szamla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_szamla.Location = new System.Drawing.Point(240, 172);
            this.checkBox_szamla.Name = "checkBox_szamla";
            this.checkBox_szamla.Size = new System.Drawing.Size(47, 17);
            this.checkBox_szamla.TabIndex = 6;
            this.checkBox_szamla.Text = "Igen";
            this.checkBox_szamla.UseVisualStyleBackColor = false;
            this.checkBox_szamla.CheckedChanged += new System.EventHandler(this.checkBox_szamla_CheckedChanged);
            // 
            // label_szamla
            // 
            this.label_szamla.AutoSize = true;
            this.label_szamla.Location = new System.Drawing.Point(239, 153);
            this.label_szamla.Name = "label_szamla";
            this.label_szamla.Size = new System.Drawing.Size(79, 13);
            this.label_szamla.TabIndex = 7;
            this.label_szamla.Text = "Számlaigénylés";
            // 
            // button_hozzaad
            // 
            this.button_hozzaad.BackColor = System.Drawing.Color.Tomato;
            this.button_hozzaad.Location = new System.Drawing.Point(451, 222);
            this.button_hozzaad.Name = "button_hozzaad";
            this.button_hozzaad.Size = new System.Drawing.Size(75, 23);
            this.button_hozzaad.TabIndex = 9;
            this.button_hozzaad.Text = "Hozzáadás";
            this.button_hozzaad.UseVisualStyleBackColor = false;
            this.button_hozzaad.Click += new System.EventHandler(this.button_hozzaad_Click);
            // 
            // textBox_db
            // 
            this.textBox_db.Location = new System.Drawing.Point(370, 222);
            this.textBox_db.Name = "textBox_db";
            this.textBox_db.Size = new System.Drawing.Size(75, 20);
            this.textBox_db.TabIndex = 10;
            this.textBox_db.TextChanged += new System.EventHandler(this.textBox_db_TextChanged);
            // 
            // label_db
            // 
            this.label_db.AutoSize = true;
            this.label_db.Location = new System.Drawing.Point(238, 222);
            this.label_db.Name = "label_db";
            this.label_db.Size = new System.Drawing.Size(126, 13);
            this.label_db.TabIndex = 11;
            this.label_db.Text = "Adja meg a darabszámot:";
            // 
            // button_rendeles
            // 
            this.button_rendeles.BackColor = System.Drawing.Color.Tomato;
            this.button_rendeles.Location = new System.Drawing.Point(567, 108);
            this.button_rendeles.Name = "button_rendeles";
            this.button_rendeles.Size = new System.Drawing.Size(199, 44);
            this.button_rendeles.TabIndex = 13;
            this.button_rendeles.Text = "Rendelés";
            this.button_rendeles.UseVisualStyleBackColor = false;
            this.button_rendeles.Click += new System.EventHandler(this.button_rendeles_Click);
            // 
            // listBox_kosar
            // 
            this.listBox_kosar.FormattingEnabled = true;
            this.listBox_kosar.Location = new System.Drawing.Point(240, 259);
            this.listBox_kosar.Name = "listBox_kosar";
            this.listBox_kosar.Size = new System.Drawing.Size(265, 134);
            this.listBox_kosar.TabIndex = 14;
            this.listBox_kosar.SelectedIndexChanged += new System.EventHandler(this.listBox_kosar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza.Properties.Resources.pngtree_gourmet_pizza_top_view_black_banner_image_168253;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_kosar);
            this.Controls.Add(this.button_rendeles);
            this.Controls.Add(this.label_db);
            this.Controls.Add(this.textBox_db);
            this.Controls.Add(this.button_hozzaad);
            this.Controls.Add(this.label_szamla);
            this.Controls.Add(this.checkBox_szamla);
            this.Controls.Add(this.groupBox_fizetes);
            this.Controls.Add(this.button_atlag);
            this.Controls.Add(this.listBox_pizzak);
            this.Controls.Add(this.textBox_fajlbetoltes);
            this.Controls.Add(this.label_fajl);
            this.Controls.Add(this.button_betoltes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Pizza rendelés!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_fizetes.ResumeLayout(false);
            this.groupBox_fizetes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_betoltes;
        private System.Windows.Forms.Label label_fajl;
        private System.Windows.Forms.TextBox textBox_fajlbetoltes;
        private System.Windows.Forms.ListBox listBox_pizzak;
        private System.Windows.Forms.Button button_atlag;
        private System.Windows.Forms.GroupBox groupBox_fizetes;
        private System.Windows.Forms.RadioButton radioButton_keszpenz;
        private System.Windows.Forms.RadioButton radioButton_bankkartya;
        private System.Windows.Forms.CheckBox checkBox_szamla;
        private System.Windows.Forms.Label label_szamla;
        private System.Windows.Forms.Button button_hozzaad;
        private System.Windows.Forms.TextBox textBox_db;
        private System.Windows.Forms.Label label_db;
        private System.Windows.Forms.Button button_rendeles;
        private System.Windows.Forms.ListBox listBox_kosar;
    }
}

