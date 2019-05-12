using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PouzdanostInformacionihSistema
{
    public partial class Zadatak : Form
    {
        public Zadatak()
        {
            InitializeComponent();
        }
        private void drawTable(int x, int y, string tableName)
        {
            int xStart = 80 + x;
            int yStart = 100 + y;
            for (int i = 0; i < Convert.ToInt32(comboBoxBrojIntervala.SelectedItem); i++)
            {
                y = 0;
                for (int j = 0;  j <  2; j++)
                {
                    TextBox txtBox = new TextBox();
                    Point p = new Point(xStart + x, yStart + y);
                    txtBox.Location = p;
                    txtBox.Width = 50;
                    txtBox.Name = "txtBox" + tableName + i + j;
                    y += 20;
                    this.Controls.Add(txtBox);
                }
            
                x += 50;
            }
        }

        private void removeTable(string tableName)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    this.Controls.Remove((TextBox)this.Controls["txtBox" + tableName + i + j]);
                }
                
            }
        }
        private void comboBoxVremeRada_SelectedIndexChanged(object sender, EventArgs e)
        {
            intervali("prva");

            removeTable("druga");
            drawTable(-7, 120, "druga");

            intervali("druga");


            removeTable("treca");
            drawTable(-7, 200, "treca");
            intervali("treca");
        }
        private void intervali(string tableName)
        {
            int k = 1;
            for (int i = 0; i < Convert.ToInt32(comboBoxBrojIntervala.SelectedItem); i++)
            {
                int interval = Convert.ToInt32(comboBoxVremeRada.Text) * k;
                ((TextBox)this.Controls["txtBox" + tableName + i + "0"]).Text = interval.ToString();
                k++;
            }

        }
        private void comboBoxBrojIntervala_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeTable("prva");
            removeTable("druga");
            removeTable("treca");
            drawTable(40,0, "prva");
            comboBoxVremeRada.Enabled = true;
        }
        private int brojOtkaza()
        {
            int suma = 0;
            for (int i = 0; i < Convert.ToInt32(comboBoxBrojIntervala.SelectedItem); i++)
            {
                suma += Convert.ToInt32(((TextBox)this.Controls["txtBoxprva" + i + "1"]).Text);
            }
            return suma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxBrojOtkaza.Text = brojOtkaza().ToString();
            nepouzdanost();
            pouzdanost();
        }

        private void nepouzdanost()
        {
            decimal sumaOtkaza = 0;
            for (int i = 0; i < Convert.ToInt32(comboBoxBrojIntervala.SelectedItem); i++)
            {
                sumaOtkaza += Convert.ToInt32(((TextBox)this.Controls["txtBoxprva" + i + "1"]).Text);
                ((TextBox)this.Controls["txtBoxdruga" + i + "1"]).Text =Math.Round((sumaOtkaza / Convert.ToDecimal(textBoxBrojOtkaza.Text)), 4).ToString();
            }

        }
        private void pouzdanost()
        {
            for (int i = 0; i < Convert.ToInt32(comboBoxBrojIntervala.SelectedItem); i++)
            {
                decimal pouzdanost = Convert.ToDecimal (((TextBox)this.Controls["txtBoxdruga" + i + "1"]).Text);
                ((TextBox)this.Controls["txtBoxtreca" + i + "1"]).Text = Math.Round(1 - pouzdanost, 4).ToString();
            }
        }
    }
}
