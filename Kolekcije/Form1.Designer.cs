namespace Kolekcije
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodProizvod = new System.Windows.Forms.TextBox();
            this.txtBrKotaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(31, 57);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 0;
            // 
            // txtGodProizvod
            // 
            this.txtGodProizvod.Location = new System.Drawing.Point(31, 105);
            this.txtGodProizvod.Name = "txtGodProizvod";
            this.txtGodProizvod.Size = new System.Drawing.Size(100, 20);
            this.txtGodProizvod.TabIndex = 1;
            // 
            // txtBrKotaca
            // 
            this.txtBrKotaca.Location = new System.Drawing.Point(31, 153);
            this.txtBrKotaca.Name = "txtBrKotaca";
            this.txtBrKotaca.Size = new System.Drawing.Size(100, 20);
            this.txtBrKotaca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Godina proizvodnje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Broj kotača";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kategorija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vozilo";
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnesi.Location = new System.Drawing.Point(168, 57);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(148, 164);
            this.btnUnesi.TabIndex = 9;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnObradi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObradi.Location = new System.Drawing.Point(376, 57);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(148, 164);
            this.btnObradi.TabIndex = 10;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = false;
            this.btnObradi.Click += new System.EventHandler(this.btnObradi_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.BackColor = System.Drawing.Color.LightCoral;
            this.btnIspisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIspisi.Location = new System.Drawing.Point(592, 57);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(148, 164);
            this.btnIspisi.TabIndex = 11;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = false;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Items.AddRange(new object[] {
            "Motocikl",
            "Automobil",
            "Kamion"});
            this.cmbKategorija.Location = new System.Drawing.Point(31, 202);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cmbKategorija.TabIndex = 12;
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(31, 246);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(709, 192);
            this.rtbIspis.TabIndex = 13;
            this.rtbIspis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrKotaca);
            this.Controls.Add(this.txtGodProizvod);
            this.Controls.Add(this.txtModel);
            this.Name = "Form1";
            this.Text = "Vozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodProizvod;
        private System.Windows.Forms.TextBox txtBrKotaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.RichTextBox rtbIspis;
    }
}

