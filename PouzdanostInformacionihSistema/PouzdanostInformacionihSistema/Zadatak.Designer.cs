﻿namespace PouzdanostInformacionihSistema
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBoxVremeRada = new System.Windows.Forms.ComboBox();
            this.comboBoxBrojIntervala = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "U intervalima vremena po ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(407, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "časova beležen je broj otkaza N =  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "elemenata i dobijeni su sljedeci podaci.";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(91, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Vreme rada ti [h]";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(70, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(91, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Broj otkaza Δn(ti)";
            // 
            // comboBoxVremeRada
            // 
            this.comboBoxVremeRada.Enabled = false;
            this.comboBoxVremeRada.FormattingEnabled = true;
            this.comboBoxVremeRada.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000",
            "100000",
            "1000000"});
            this.comboBoxVremeRada.Location = new System.Drawing.Point(702, 64);
            this.comboBoxVremeRada.Name = "comboBoxVremeRada";
            this.comboBoxVremeRada.Size = new System.Drawing.Size(63, 21);
            this.comboBoxVremeRada.TabIndex = 7;
            this.comboBoxVremeRada.SelectedIndexChanged += new System.EventHandler(this.comboBoxVremeRada_SelectedIndexChanged);
            // 
            // comboBoxBrojIntervala
            // 
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
            this.comboBoxBrojIntervala.Size = new System.Drawing.Size(51, 21);
            this.comboBoxBrojIntervala.TabIndex = 8;
            this.comboBoxBrojIntervala.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrojIntervala_SelectedIndexChanged);
            // 
            // Zadatak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 490);
            this.Controls.Add(this.comboBoxBrojIntervala);
            this.Controls.Add(this.comboBoxVremeRada);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Zadatak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pouzdanost informacionih sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBoxVremeRada;
        private System.Windows.Forms.ComboBox comboBoxBrojIntervala;
    }
}

