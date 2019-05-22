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
                    if (j % 2 == 0)
                        txtBox.Enabled = false;
                    txtBox.Location = p;
                    txtBox.Width = 50;
                    txtBox.BorderStyle = BorderStyle.FixedSingle;
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

            puniComboIntervala();
            
        }
        private void puniComboIntervala()
        {
            comboBoxPrviInterval.Items.Clear();
            comboBoxPrviInterval.Items.Clear();

            for (int i = 1; i <= Convert.ToInt32(comboBoxBrojIntervala.SelectedItem); i++)
            {
                comboBoxPrviInterval.Items.Add(Convert.ToInt32(comboBoxVremeRada.SelectedItem)*i);
                comboBoxPrviIntervalOtkaza.Items.Add(Convert.ToInt32(comboBoxVremeRada.SelectedItem) * i);
            }
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
            resetujKontrole();
        }
        private void resetujKontrole()
        {
            comboBoxPrviIntervalOtkaza.Text = "";
            comboBoxPrviInterval.Text = "";
            comboBoxVremeRada.Text = "";

            comboBoxPrviIntervalOtkaza.Items.Clear();
            comboBoxPrviInterval.Items.Clear();
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


        private decimal verovatnocaIspravnogRada(int prvaPozicija, int drugaPozicija)
        {

            decimal drugiElement = Convert.ToDecimal(((TextBox)this.Controls["txtBoxtreca" + drugaPozicija + "1"]).Text);
            decimal prviElement = Convert.ToDecimal(((TextBox)this.Controls["txtBoxtreca" + prvaPozicija + "1"]).Text);

            return drugiElement / prviElement;

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

        private void comboBoxPrviInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDrugiInterval.Enabled = true;
            comboBoxDrugiInterval.Items.Clear();

            int velicinaIntervala = Convert.ToInt32(comboBoxVremeRada.SelectedItem);
            int selektovaniInterval = comboBoxPrviInterval.SelectedIndex + 2;

            for (int i = comboBoxPrviInterval.SelectedIndex; i < Convert.ToInt32(comboBoxBrojIntervala.SelectedItem)-1; i++)
            {
                comboBoxDrugiInterval.Items.Add(velicinaIntervala * selektovaniInterval);
                selektovaniInterval++;
            }
        }

        private void comboBoxPrviIntervalOtkaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDrugiIntervalOtkaza.Enabled = true;
            comboBoxDrugiIntervalOtkaza.Items.Clear();

            int velicinaIntervala = Convert.ToInt32(comboBoxVremeRada.SelectedItem);
            int selektovaniInterval = comboBoxPrviIntervalOtkaza.SelectedIndex + 2;

            for (int i = comboBoxPrviIntervalOtkaza.SelectedIndex; i < Convert.ToInt32(comboBoxBrojIntervala.SelectedItem) - 1; i++)
            {
                comboBoxDrugiIntervalOtkaza.Items.Add(velicinaIntervala * selektovaniInterval);
                selektovaniInterval++;
            }
        }

        private void buttonIzracunaj_Click(object sender, EventArgs e)
        {
            try
            {
                SaveScreenshot(this);
                textBoxBrojOtkaza.Text = brojOtkaza().ToString();
                nepouzdanost();
                pouzdanost();

                int velicinaIntervala = Convert.ToInt32(comboBoxVremeRada.SelectedItem);
                int drugaPozicijaRada = (Convert.ToInt32(comboBoxDrugiInterval.SelectedItem) / velicinaIntervala) - 1;
                int prvaPozicijaRada = (Convert.ToInt32(comboBoxPrviInterval.SelectedItem) / velicinaIntervala) - 1;
                labelVerovatnocaIspravnogRada.Text = Math.Round(verovatnocaIspravnogRada(prvaPozicijaRada, drugaPozicijaRada), 4).ToString();


                int drugaPozicijaOtkaza = (Convert.ToInt32(comboBoxDrugiIntervalOtkaza.SelectedItem) / velicinaIntervala) - 1;
                int prvaPozicijaOtkaza = (Convert.ToInt32(comboBoxPrviIntervalOtkaza.SelectedItem) / velicinaIntervala) - 1;
                labelVerovatnocaOtkaza.Text = Math.Round(1 - (verovatnocaIspravnogRada(prvaPozicijaOtkaza, drugaPozicijaOtkaza)), 4).ToString();


                labelSrednjeVremeDoOtkaza.Text = Math.Round(srednjeVremeDoOtkaza(), 4) + " sati".ToString();


               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate uneti sve informacije i odabrati oba intervala za racun pod v i g!");
            }
            
        }
        private static void SaveScreenshot(Form frm)
        {
            string ImagePath = string.Format(@"C:\Users\Ilhan Kalac\Desktop", DateTime.Now.Ticks);
            Bitmap Image = new Bitmap(frm.Width, frm.Height);
            frm.DrawToBitmap(Image, new Rectangle(0, 0, frm.Width, frm.Height));
            Image.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Png);
        }
        private decimal srednjeVremeDoOtkaza()
        {
            int sumaIntervala = 0;
            int brojIntervala = Convert.ToInt32(comboBoxBrojIntervala.SelectedItem) - 1;

            int[] nizIntervala = new int[brojIntervala];
            for (int i = 0; i < brojIntervala; i++)
            {
                nizIntervala[i] = Convert.ToInt32(((TextBox)this.Controls["txtBoxprva" + i + "1"]).Text);
            }

            int[] nizZbiraIntervala = new int[brojIntervala];
            nizZbiraIntervala[0] = Convert.ToInt32(textBoxBrojOtkaza.Text) - nizIntervala[0];

            sumaIntervala += nizZbiraIntervala[0];
            for (int i = 1; i < brojIntervala; i++)
            {
                nizZbiraIntervala[i] = nizZbiraIntervala[i - 1] - nizIntervala[i];
                sumaIntervala += nizZbiraIntervala[i];
            }

            return sumaIntervala / Convert.ToDecimal(textBoxBrojOtkaza.Text) * Convert.ToDecimal(comboBoxVremeRada.SelectedItem);
        }
    }
}
