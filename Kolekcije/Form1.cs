using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcije
{
    public partial class Form1 : Form
    {
        List<Vozilo> list = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                Vozilo podatak = new Vozilo(txtModel.Text, (txtGodProizvod.Text), txtBrKotaca.Text, cmbKategorija.Text);
                list.Add(podatak);
                txtModel.Clear();
                txtGodProizvod.Clear();
                txtBrKotaca.Clear();


            }
            catch (Exception greska)
            {
                MessageBox.Show("Pogrešan unos!\r\n" +
                    greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtModel == null)
            {
                MessageBox.Show("Pogrešan unos!\r\n" + "Greška", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            rtbIspis.Text = "Model " + "\t\tGodina proizvodnje" + "\t\tBroj kotaca" + "\t\t Kategorija\r\n";
            foreach (Vozilo podatak in list)
            {
                rtbIspis.AppendText(podatak.ToString() + "\r\n");

            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            foreach (Vozilo podatak in list)
            {
                if (podatak.Kotaci == "2")
                {
                    podatak.Dodatak = "Motocikli";
                }

                else if (podatak.Kotaci == "4")
                {
                    podatak.Dodatak = "Automobil";
                }
                else 
                {
                    podatak.Dodatak = "Kamion";
                }


            }
        }
    }
}
