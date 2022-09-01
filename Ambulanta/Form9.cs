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
    public partial class Form9 : Form
    {
        public Form9()
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
                MessageBox.Show("ime je obavezan podatak");
                Naziv.Focus();
            }
            else
            {
                Konekcija = new OleDbConnection(StringKonekcije);/*Kreiranje instance klase*/
                Konekcija.Open();/*Otvaranje baze podataka*/
                Komanda.Connection = Konekcija;/*Povezivanje komande i konekcije*/
                Komanda.CommandType = CommandType.Text;/*Tipa komande*/
                /*formiranje SQL upita komandi*/
                string sqlupit = "INSERT INTO VrsteIntervencija (Naziv,Cena) ";
                sqlupit += "VALUES('" + Naziv.Text + "', '" + Cena.Text + "')";
                Komanda.CommandText = sqlupit;
                int responce = Komanda.ExecuteNonQuery();
                Konekcija.Close();
                this.Close();
            }
        }
    }
}
