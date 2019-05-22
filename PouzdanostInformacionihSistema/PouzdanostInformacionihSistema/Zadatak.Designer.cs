namespace PouzdanostInformacionihSistema
{
    partial class Zadatak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zadatak));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBrojOtkaza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBoxVremeRada = new System.Windows.Forms.ComboBox();
            this.comboBoxBrojIntervala = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonIzracunaj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPrviInterval = new System.Windows.Forms.ComboBox();
            this.comboBoxDrugiInterval = new System.Windows.Forms.ComboBox();
            this.labelVerovatnocaIspravnogRada = new System.Windows.Forms.Label();
            this.labelVerovatnocaOtkaza = new System.Windows.Forms.Label();
            this.comboBoxDrugiIntervalOtkaza = new System.Windows.Forms.ComboBox();
            this.comboBoxPrviIntervalOtkaza = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSrednjeVremeDoOtkaza = new System.Windows.Forms.Label();
            this.btnScreenShot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "U intervalima vremena po ";
            // 
            // textBoxBrojOtkaza
            // 
            this.textBoxBrojOtkaza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBrojOtkaza.Enabled = false;
            this.textBoxBrojOtkaza.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrojOtkaza.Location = new System.Drawing.Point(462, 67);
            this.textBoxBrojOtkaza.Name = "textBoxBrojOtkaza";
            this.textBoxBrojOtkaza.Size = new System.Drawing.Size(58, 14);
            this.textBoxBrojOtkaza.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "časova beležen je broj otkaza N =  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "elemenata i dobijeni su sljedeci podaci.";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(58, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(103, 21);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Vreme rada ti [h]";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(58, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(103, 21);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Broj otkaza Δn(ti)";
            // 
            // comboBoxVremeRada
            // 
            this.comboBoxVremeRada.Enabled = false;
            this.comboBoxVremeRada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxVremeRada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVremeRada.FormattingEnabled = true;
            this.comboBoxVremeRada.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "1000",
            "10000",
            "100000"});
            this.comboBoxVremeRada.Location = new System.Drawing.Point(189, 64);
            this.comboBoxVremeRada.Name = "comboBoxVremeRada";
            this.comboBoxVremeRada.Size = new System.Drawing.Size(63, 24);
            this.comboBoxVremeRada.TabIndex = 7;
            this.comboBoxVremeRada.SelectedIndexChanged += new System.EventHandler(this.comboBoxVremeRada_SelectedIndexChanged);
            // 
            // comboBoxBrojIntervala
            // 
            this.comboBoxBrojIntervala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBrojIntervala.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrojIntervala.FormattingEnabled = true;
            this.comboBoxBrojIntervala.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBoxBrojIntervala.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBoxBrojIntervala.Location = new System.Drawing.Point(13, 100);
            this.comboBoxBrojIntervala.Name = "comboBoxBrojIntervala";
            this.comboBoxBrojIntervala.Size = new System.Drawing.Size(39, 24);
            this.comboBoxBrojIntervala.TabIndex = 8;
            this.comboBoxBrojIntervala.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrojIntervala_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Potrebno je odrediti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "a) Nepouzdanost u trenutku vremena t";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "b) Pouzdanost u trenutku t";
            // 
            // buttonIzracunaj
            // 
            this.buttonIzracunaj.BackColor = System.Drawing.Color.Transparent;
            this.buttonIzracunaj.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonIzracunaj.FlatAppearance.BorderSize = 0;
            this.buttonIzracunaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIzracunaj.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzracunaj.Image = ((System.Drawing.Image)(resources.GetObject("buttonIzracunaj.Image")));
            this.buttonIzracunaj.Location = new System.Drawing.Point(790, 351);
            this.buttonIzracunaj.Name = "buttonIzracunaj";
            this.buttonIzracunaj.Size = new System.Drawing.Size(113, 115);
            this.buttonIzracunaj.TabIndex = 12;
            this.buttonIzracunaj.Text = "Izračunaj";
            this.buttonIzracunaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIzracunaj.UseVisualStyleBackColor = false;
            this.buttonIzracunaj.Click += new System.EventHandler(this.buttonIzracunaj_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "v) Verovatnoću ispravnog rada u intervalu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(391, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "časova rada = ";
            // 
            // comboBoxPrviInterval
            // 
            this.comboBoxPrviInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPrviInterval.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrviInterval.FormattingEnabled = true;
            this.comboBoxPrviInterval.Location = new System.Drawing.Point(249, 356);
            this.comboBoxPrviInterval.Name = "comboBoxPrviInterval";
            this.comboBoxPrviInterval.Size = new System.Drawing.Size(63, 24);
            this.comboBoxPrviInterval.TabIndex = 15;
            this.comboBoxPrviInterval.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrviInterval_SelectedIndexChanged);
            // 
            // comboBoxDrugiInterval
            // 
            this.comboBoxDrugiInterval.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.comboBoxDrugiInterval.Enabled = false;
            this.comboBoxDrugiInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDrugiInterval.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDrugiInterval.FormattingEnabled = true;
            this.comboBoxDrugiInterval.Location = new System.Drawing.Point(327, 356);
            this.comboBoxDrugiInterval.Name = "comboBoxDrugiInterval";
            this.comboBoxDrugiInterval.Size = new System.Drawing.Size(58, 24);
            this.comboBoxDrugiInterval.TabIndex = 16;
            // 
            // labelVerovatnocaIspravnogRada
            // 
            this.labelVerovatnocaIspravnogRada.AutoSize = true;
            this.labelVerovatnocaIspravnogRada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerovatnocaIspravnogRada.Location = new System.Drawing.Point(483, 357);
            this.labelVerovatnocaIspravnogRada.Name = "labelVerovatnocaIspravnogRada";
            this.labelVerovatnocaIspravnogRada.Size = new System.Drawing.Size(18, 19);
            this.labelVerovatnocaIspravnogRada.TabIndex = 17;
            this.labelVerovatnocaIspravnogRada.Text = "0";
            // 
            // labelVerovatnocaOtkaza
            // 
            this.labelVerovatnocaOtkaza.AutoSize = true;
            this.labelVerovatnocaOtkaza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerovatnocaOtkaza.Location = new System.Drawing.Point(483, 400);
            this.labelVerovatnocaOtkaza.Name = "labelVerovatnocaOtkaza";
            this.labelVerovatnocaOtkaza.Size = new System.Drawing.Size(18, 19);
            this.labelVerovatnocaOtkaza.TabIndex = 22;
            this.labelVerovatnocaOtkaza.Text = "0";
            // 
            // comboBoxDrugiIntervalOtkaza
            // 
            this.comboBoxDrugiIntervalOtkaza.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.comboBoxDrugiIntervalOtkaza.Enabled = false;
            this.comboBoxDrugiIntervalOtkaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDrugiIntervalOtkaza.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDrugiIntervalOtkaza.FormattingEnabled = true;
            this.comboBoxDrugiIntervalOtkaza.Location = new System.Drawing.Point(327, 399);
            this.comboBoxDrugiIntervalOtkaza.Name = "comboBoxDrugiIntervalOtkaza";
            this.comboBoxDrugiIntervalOtkaza.Size = new System.Drawing.Size(58, 24);
            this.comboBoxDrugiIntervalOtkaza.TabIndex = 21;
            // 
            // comboBoxPrviIntervalOtkaza
            // 
            this.comboBoxPrviIntervalOtkaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPrviIntervalOtkaza.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrviIntervalOtkaza.FormattingEnabled = true;
            this.comboBoxPrviIntervalOtkaza.Location = new System.Drawing.Point(249, 399);
            this.comboBoxPrviIntervalOtkaza.Name = "comboBoxPrviIntervalOtkaza";
            this.comboBoxPrviIntervalOtkaza.Size = new System.Drawing.Size(63, 24);
            this.comboBoxPrviIntervalOtkaza.TabIndex = 20;
            this.comboBoxPrviIntervalOtkaza.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrviIntervalOtkaza_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(391, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "časova rada = ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "g) Verovatnoću otkaza u intervalu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "d) Srednje vreme rada do otkaza =  ";
            // 
            // labelSrednjeVremeDoOtkaza
            // 
            this.labelSrednjeVremeDoOtkaza.AutoSize = true;
            this.labelSrednjeVremeDoOtkaza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSrednjeVremeDoOtkaza.Location = new System.Drawing.Point(216, 443);
            this.labelSrednjeVremeDoOtkaza.Name = "labelSrednjeVremeDoOtkaza";
            this.labelSrednjeVremeDoOtkaza.Size = new System.Drawing.Size(18, 19);
            this.labelSrednjeVremeDoOtkaza.TabIndex = 24;
            this.labelSrednjeVremeDoOtkaza.Text = "0";
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnScreenShot.FlatAppearance.BorderSize = 0;
            this.btnScreenShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreenShot.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenShot.ForeColor = System.Drawing.Color.Gray;
            this.btnScreenShot.Image = ((System.Drawing.Image)(resources.GetObject("btnScreenShot.Image")));
            this.btnScreenShot.Location = new System.Drawing.Point(765, 2);
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(162, 81);
            this.btnScreenShot.TabIndex = 25;
            this.btnScreenShot.Text = "Snimi rezultat";
            this.btnScreenShot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnScreenShot.UseVisualStyleBackColor = true;
            this.btnScreenShot.Click += new System.EventHandler(this.btnScreenShot_Click);
            // 
            // Zadatak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 490);
            this.Controls.Add(this.btnScreenShot);
            this.Controls.Add(this.labelSrednjeVremeDoOtkaza);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelVerovatnocaOtkaza);
            this.Controls.Add(this.comboBoxDrugiIntervalOtkaza);
            this.Controls.Add(this.comboBoxPrviIntervalOtkaza);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelVerovatnocaIspravnogRada);
            this.Controls.Add(this.comboBoxDrugiInterval);
            this.Controls.Add(this.comboBoxPrviInterval);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonIzracunaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxBrojIntervala);
            this.Controls.Add(this.comboBoxVremeRada);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBrojOtkaza);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zadatak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pouzdanost informacionih sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBrojOtkaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBoxVremeRada;
        private System.Windows.Forms.ComboBox comboBoxBrojIntervala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonIzracunaj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPrviInterval;
        private System.Windows.Forms.ComboBox comboBoxDrugiInterval;
        private System.Windows.Forms.Label labelVerovatnocaIspravnogRada;
        private System.Windows.Forms.Label labelVerovatnocaOtkaza;
        private System.Windows.Forms.ComboBox comboBoxDrugiIntervalOtkaza;
        private System.Windows.Forms.ComboBox comboBoxPrviIntervalOtkaza;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSrednjeVremeDoOtkaza;
        private System.Windows.Forms.Button btnScreenShot;
    }
}

