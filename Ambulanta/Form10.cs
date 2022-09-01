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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        string StringKonekcije = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\Ambulanta.accdb;Persist Security Info=False;");
        OleDbConnection Konekcija;
        OleDbCommand Komanda = new OleDbCommand();
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (Naziv.Text == "")
            {
                MessageBox.Show("Naziv je obavezan podatak");
                Naziv.Focus();
            }
            else if (Cena.Text == "")
            {
                MessageBox.Show("Cena je obavezan podatak");
                Cena.Focus();
            }

            else
            {
                Konekcija = new OleDbConnection(StringKonekcije);
                Konekcija.Open();/*Otvaranje baze podataka*/
                Komanda.Connection = Konekcija;/*Povezivanje komande i konekci*/
                Komanda.CommandType = CommandType.Text;/*Tipa komande*/
                /*formiranje SQL upita komandi*/
                string sqlupit = "UPDATE VrsteIntervencija SET Naziv='" + Naziv.Text;
                sqlupit += "', Cena='" + Cena.Text;
                sqlupit += "' WHERE SifVInt=" + SifVInt.Text;
                Komanda.CommandText = sqlupit;
                int responce = Komanda.ExecuteNonQuery();
                Konekcija.Close();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Konekcija = new OleDbConnection(StringKonekcije);
            Konekcija.Open();/*Otvaranje baze podataka*/
            Komanda.Connection = Konekcija;/*Povezivanje komande i konekcije*/
            Komanda.CommandType = CommandType.Text;/*Određivanje tipa komande*/
            /*formiranje SQL upita komandi*/
            string sqlupit = "DELETE FROM VrsteIntervencija WHERE SifVInt=" + SifVInt.Text;
            Komanda.CommandText = sqlupit;
            int responce = Komanda.ExecuteNonQuery();
            Konekcija.Close();
            this.Close();
        }

    }
}
