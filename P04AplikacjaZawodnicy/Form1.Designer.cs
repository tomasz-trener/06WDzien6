
namespace P04AplikacjaZawodnicy
{
    partial class Form1
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWzrost = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 51);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(312, 264);
            this.lbDane.TabIndex = 0;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 12);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(400, 48);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(177, 20);
            this.txtImie.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imie";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Location = new System.Drawing.Point(341, 77);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(53, 13);
            this.lblNazwisko.TabIndex = 5;
            this.lblNazwisko.Text = "Nazwisko";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(400, 74);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(177, 20);
            this.txtNazwisko.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kraj";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(400, 100);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(177, 20);
            this.txtKraj.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DataUr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Waga";
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(400, 152);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(177, 20);
            this.txtWaga.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wzrost";
            // 
            // txtWzrost
            // 
            this.txtWzrost.Location = new System.Drawing.Point(400, 178);
            this.txtWzrost.Name = "txtWzrost";
            this.txtWzrost.Size = new System.Drawing.Size(177, 20);
            this.txtWzrost.TabIndex = 12;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(502, 204);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 14;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(400, 127);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(177, 20);
            this.dtpData.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 321);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWzrost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWaga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWzrost;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}

