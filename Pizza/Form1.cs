using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public string kiválasztottPizza { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Adatbetoltes();
        }

        private void Adatbetoltes()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Vesszővel tagolt CSV |*.csv|Szöveges fájl (*.txt)|*.txt|Összes fájl (*.*)|*.*";
            ofd.FilterIndex = 0;
            ofd.Title = "Adatfálj neve";
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.FileName = "Pizza.csv";

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                textBox_fajlbetoltes.Text = Path.GetFileName(ofd.FileName);
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_pizzak.Items.Add(new Pizza(sr.ReadLine()));
                    }
                }
            }
        }

        private void button_atalagar(object sender, EventArgs e)
        {
            Atlagszamitas();
        }
        public void Atlagszamitas()
        {
            double atlag = 0;
            foreach (Pizza item in listBox_pizzak.Items)
            {
                atlag += item.Par;
            }
            atlag = atlag / listBox_pizzak.Items.Count;

            MessageBox.Show($"A pizzák átlagára: {atlag.ToString("#,##0.0 Ft")}", "A pizzák átlaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void button_rendeles_Click(object sender, EventArgs e)
        {
            if (radioButton_bankkartya.Checked || radioButton_keszpenz.Checked)
            {
                if (checkBox_szamla.Checked)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
                    saveFileDialog.FileName = "Számla.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string szamla = saveFileDialog.FileName;
                        listBox_kosar.Text = Path.GetFileName(szamla);
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(szamla))
                            {
                                if (radioButton_bankkartya.Checked)
                                {
                                    sw.WriteLine("Bankkártyás fizetés.");
                                    sw.WriteLine(listBox_kosar);
                                }
                                else if (radioButton_keszpenz.Checked)
                                {
                                    sw.WriteLine("Készpénzes fizetés.");
                                    sw.WriteLine(listBox_kosar);
                                }
                            }
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show("Valami nem ok!" + Environment.NewLine + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztva fizető eszköz!");
            }
        }



        private void radioButton_bankkartya_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_kezpenz_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button_betoltes_Click(object sender, EventArgs e)
        {

        }


        private void listBox_pizzak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_pizzak.SelectedIndex != 0)
            {
                kiválasztottPizza = listBox_pizzak.SelectedItem.ToString();
            }
        }

        private void button_hozzaad_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox_db.Text, out int darabszam))
            {
  
                if (!string.IsNullOrEmpty(kiválasztottPizza))
                {
                    string kosarElem = $"{kiválasztottPizza} - {darabszam} db";
                    listBox_kosar.Items.Add(kosarElem);

                }
                else
                {
                    MessageBox.Show("Válassz ki egy pizzát!");
                }
            }
            else
            {
                MessageBox.Show("Adj meg egy érvényes számot!");
            }
            
        }
        private void checkBox_szamla_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_db_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_kosar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_fajlbetoltes_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


