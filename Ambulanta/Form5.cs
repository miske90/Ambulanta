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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string StringKonekcije = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\Ambulanta.accdb;Persist Security Info=False;");
        OleDbConnection Konekcija;
        OleDbCommand Komanda = new OleDbCommand();
        OleDbDataReader SetPodataka = null;

        public class Pacijent
        {
            public int SifPacijenta;
            public string Ime;
            public string Prezime;
            public string Adresa;
            public string BrojTelefona;
            public string JMBG;
            public string Napomena;

            public Pacijent(OleDbDataReader SetPodataka)
            {
                this.SifPacijenta = SetPodataka.GetInt32(0);
                this.Ime = SetPodataka.GetString(1);
                this.Prezime = SetPodataka.GetString(2);
                this.Adresa = SetPodataka.GetString(3);
                this.BrojTelefona = SetPodataka.GetString(4);
                this.JMBG = SetPodataka.GetString(5);
                this.Napomena = SetPodataka.GetString(6);
            }
            public override string ToString()
            {
                return Ime + " " + Prezime + " " + Adresa ;
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
            lista1.Items.Clear();
            Konekcija = new OleDbConnection(StringKonekcije);
            Konekcija.Open();
            Komanda.Connection = Konekcija;
            Komanda.CommandType = CommandType.Text;
            string sqlupit = "SELECT * FROM Pacijent";
            if (pretraga.Text != "")
            {
                sqlupit += " WHERE Ime LIKE '" + pretraga.Text + "%'";
            }
            Komanda.CommandText = sqlupit;
            SetPodataka = Komanda.ExecuteReader();

            Pacijent Pacijent1;
            while (SetPodataka.Read())
            {
                Pacijent1 = new Pacijent(SetPodataka);
                lista1.Items.Add(Pacijent1);
            }
            SetPodataka.Close();
            Konekcija.Close();
        }

        private void nov_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.ShowDialog();
        }

        private void izmena_Click(object sender, EventArgs e)
        {
            if (lista1.SelectedIndex >= 0)
            {
                Form7 frm = new Form7();
                Pacijent Pacijent1 = (Pacijent)lista1.Items[lista1.SelectedIndex];
                frm.SifPacijenta.Text = Pacijent1.SifPacijenta.ToString();
                frm.Ime.Text = Pacijent1.Ime;
                frm.Prezime.Text = Pacijent1.Prezime;
                frm.Adresa.Text = Pacijent1.Adresa;
                frm.BrojTelefona.Text = Pacijent1.BrojTelefona;
                frm.JMBG.Text = Pacijent1.JMBG;
                frm.Napomena.Text = Pacijent1.Napomena;
                frm.ShowDialog();
                ucitaj();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucitaj();
        }


    }
}
