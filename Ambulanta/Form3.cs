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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string StringKonekcije = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\Ambulanta.accdb;Persist Security Info=False;");
        OleDbConnection Konekcija;
        OleDbCommand Komanda = new OleDbCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            if (Ime.Text == "")
            {
                MessageBox.Show("Ime je obavezan podatak");
                Ime.Focus();
            }
            else if (Prezime.Text == "")
            {
                MessageBox.Show("Prezime je obavezan podatak");
                Prezime.Focus();
            }
            else if (Specijalizacija.Text == "")
            {
                MessageBox.Show("Specijalizacija je obavezan podatak");
                Specijalizacija.Focus();
            }
            else
            {
                Konekcija = new OleDbConnection(StringKonekcije);
                Konekcija.Open();/*Otvaranje baze podataka*/
                Komanda.Connection = Konekcija;/*Povezivanje komande i konekci*/
                Komanda.CommandType = CommandType.Text;/*Tipa komande*/
                /*formiranje SQL upita komandi*/
                string sqlupit = "UPDATE Doktor SET Ime='" + Ime.Text;
                sqlupit += "', Prezime='" + Prezime.Text + "', Specijalizacija='" + Specijalizacija.Text;
                sqlupit += "' WHERE SifDoktora=" + SifDoktora.Text;
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
            string sqlupit = "DELETE FROM Doktor WHERE SifDoktora=" + SifDoktora.Text;
            Komanda.CommandText = sqlupit;
            int responce = Komanda.ExecuteNonQuery();
            Konekcija.Close();
            this.Close();
        }
    }
}
