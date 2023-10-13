using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ambulanta
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ambulantaDataSet1.Intervencija' table. You can move, or remove it, as needed.
            this.intervencijaTableAdapter1.Fill(this.ambulantaDataSet1.Intervencija);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            intervencijaTableAdapter1.Update(ambulantaDataSet1.Intervencija);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Procitano.Text = "";
            Procitano.AppendText("Ukupno selektovanih celija: " + DataGrid.SelectedCells.Count.ToString() + "\n");
            foreach (DataGridViewCell celija in DataGrid.SelectedCells)
            {
                Procitano.AppendText("Red: " + celija.RowIndex.ToString() +
                 ", kolona: " + celija.ColumnIndex.ToString() +
                 ", vrednost celije: " + celija.Value + "\n");
            }
        }
    }
}
