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
        private void drawTable()
        {
            removeTable();
            int x = 80;
            int y = 0;
            for (int i = 0; i < Convert.ToInt32( comboBoxBrojIntervala.SelectedItem); i++)
            {
                y = 0;
                for (int j = 0;  j <  2; j++)
                {
                    TextBox txtBox = new TextBox();
                    Point p = new Point(80 + x, 100 + y);
                    txtBox.Location = p;
                    txtBox.Width = 50;
                    txtBox.Name = "txtBox" + i + j;
                    y += 20;
                    this.Controls.Add(txtBox);
                }
                
                x += 50;
            }
        }
        private void removeTable()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    this.Controls.Remove((TextBox)this.Controls["txtBox" + i + j]);
                }
                
            }
        }
        private void comboBoxVremeRada_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = 1;
            for (int i = 0; i < Convert.ToInt32(comboBoxBrojIntervala.SelectedItem); i++)
            {
                int interval = Convert.ToInt32(comboBoxVremeRada.Text) * k;
                ((TextBox)this.Controls["txtBox" + i + "0"]).Text = interval.ToString();
                k++;
            }
        }

        private void comboBoxBrojIntervala_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawTable();
            comboBoxVremeRada.Enabled = true;
        }
    }
}
