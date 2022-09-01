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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        string StringKonekcije = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\Ambulanta.accdb;Persist Security Info=False;");
        OleDbConnection Konekcija;
        OleDbCommand Komanda = new OleDbCommand();
        OleDbDataReader SetPodataka = null;

        public class VrsteIntervencija
        { 
            public int SifVInt;
            public string Naziv;
            public string Cena;
            

            public VrsteIntervencija(OleDbDataReader SetPodataka)
            {
                this.SifVInt = SetPodataka.GetInt32(0);
                this.Naziv = SetPodataka.GetString(1);
                this.Cena = SetPodataka.GetString(2);
               
            }
            public override string ToString()
            {
                return Naziv + " " + Cena + " "  ;
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
            lista2.Items.Clear();
            Konekcija = new OleDbConnection(StringKonekcije);
            Konekcija.Open();
            Komanda.Connection = Konekcija;
            Komanda.CommandType = CommandType.Text;
            string sqlupit = "SELECT * FROM VrsteIntervencija";
            if (pretraga.Text != "")
            {
                sqlupit += " WHERE SifVInt LIKE '" + pretraga.Text + "%'";
            }
            Komanda.CommandText = sqlupit;
            SetPodataka = Komanda.ExecuteReader();

            VrsteIntervencija Intervencija1;
            while (SetPodataka.Read())
            {
                Intervencija1 = new VrsteIntervencija(SetPodataka);
                lista2.Items.Add(Intervencija1);
            }
            SetPodataka.Close();
            Konekcija.Close();
        }

        private void nov_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.ShowDialog();
        }

        private void izmena_Click(object sender, EventArgs e)
        {
            if (lista2.SelectedIndex >= 0)
            {
                Form10 frm = new Form10();
                VrsteIntervencija VrsteIntervencija1 = (VrsteIntervencija)lista2.Items[lista2.SelectedIndex];
                frm.SifVInt.Text = VrsteIntervencija1.SifVInt.ToString();
                frm.Naziv.Text = VrsteIntervencija1.Naziv;
                frm.Cena.Text =VrsteIntervencija1.Cena;
                
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
