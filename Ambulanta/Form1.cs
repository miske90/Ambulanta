using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ambulanta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string StringKonekcije = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\Ambulanta.accdb;Persist Security Info=False;");
        OleDbConnection Konekcija;
        OleDbCommand Komanda = new OleDbCommand();
        OleDbDataReader SetPodataka = null;

        public class Doktor
        {
            public int SifDoktora;
            public string Ime;
            public string Prezime;
            public string Specijalizacija;

            public Doktor(OleDbDataReader SetPodataka)
            {
                this.SifDoktora = SetPodataka.GetInt32(0);
                this.Ime = SetPodataka.GetString(1);
                this.Prezime = SetPodataka.GetString(2);
                this.Specijalizacija = SetPodataka.GetString(3);
            }
            public override string ToString()
            {
                return Ime + " " + Prezime + " " + Specijalizacija;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                ucitaj();
            }
        }

        private void ucitaj()
        {
            lista.Items.Clear();
            Konekcija = new OleDbConnection(StringKonekcije);
            Konekcija.Open();
            Komanda.Connection = Konekcija;
            Komanda.CommandType = CommandType.Text;
            string sqlupit = "SELECT * FROM Doktor";
            if (pretraga.Text != "")
            {
                sqlupit += " WHERE Ime LIKE '" + pretraga.Text + "%'";
            }
            Komanda.CommandText = sqlupit;
            SetPodataka = Komanda.ExecuteReader();

            Doktor Doktor1;
            while (SetPodataka.Read())
            {
                Doktor1 = new Doktor(SetPodataka);
                lista.Items.Add(Doktor1);
            }
            SetPodataka.Close();
            Konekcija.Close();
        }

        private void nov_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            ucitaj();
        }

        private void Izmena_Click(object sender, EventArgs e)
        {
            if (lista.SelectedIndex >= 0)
            {
                Form3 frm = new Form3();
                Doktor Doktor1 = (Doktor)lista.Items[lista.SelectedIndex];
                frm.SifDoktora.Text = Doktor1.SifDoktora.ToString();
                frm.Ime.Text = Doktor1.Ime;
                frm.Prezime.Text = Doktor1.Prezime;
                frm.Specijalizacija.Text = Doktor1.Specijalizacija.ToString();
                frm.ShowDialog();
                ucitaj();
            }
        }

        private void pretraga_Click(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucitaj();
        }

      
    }
}
