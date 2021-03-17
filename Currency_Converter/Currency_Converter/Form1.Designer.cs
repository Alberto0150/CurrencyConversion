
namespace Currency_Converter
{
    partial class Aplikasi
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
            this.judul = new System.Windows.Forms.Label();
            this.NilaiIDR = new System.Windows.Forms.Label();
            this.Rupiah = new System.Windows.Forms.TextBox();
            this.JenisKonversi = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Hasil = new System.Windows.Forms.Label();
            this.konversiHasil = new System.Windows.Forms.Label();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.Location = new System.Drawing.Point(119, 48);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(523, 37);
            this.judul.TabIndex = 1;
            this.judul.Text = "IDR Currency Converter";
            // 
            // NilaiIDR
            // 
            this.NilaiIDR.AutoSize = true;
            this.NilaiIDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NilaiIDR.Location = new System.Drawing.Point(174, 114);
            this.NilaiIDR.Name = "NilaiIDR";
            this.NilaiIDR.Size = new System.Drawing.Size(160, 37);
            this.NilaiIDR.TabIndex = 2;
            this.NilaiIDR.Text = "Nilai IDR :";
            // 
            // Rupiah
            // 
            this.Rupiah.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rupiah.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Rupiah.Location = new System.Drawing.Point(375, 111);
            this.Rupiah.Name = "Rupiah";
            this.Rupiah.Size = new System.Drawing.Size(168, 44);
            this.Rupiah.TabIndex = 3;
            // 
            // JenisKonversi
            // 
            this.JenisKonversi.AutoSize = true;
            this.JenisKonversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JenisKonversi.Location = new System.Drawing.Point(93, 180);
            this.JenisKonversi.Name = "JenisKonversi";
            this.JenisKonversi.Size = new System.Drawing.Size(241, 37);
            this.JenisKonversi.TabIndex = 4;
            this.JenisKonversi.Text = "Jenis Konversi :";
            this.JenisKonversi.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.comboBox2.Location = new System.Drawing.Point(375, 180);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 45);
            this.comboBox2.TabIndex = 6;
            // 
            // Hasil
            // 
            this.Hasil.AutoSize = true;
            this.Hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hasil.Location = new System.Drawing.Point(378, 255);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(0, 37);
            this.Hasil.TabIndex = 7;
            // 
            // konversiHasil
            // 
            this.konversiHasil.AutoSize = true;
            this.konversiHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konversiHasil.Location = new System.Drawing.Point(44, 255);
            this.konversiHasil.Name = "konversiHasil";
            this.konversiHasil.Size = new System.Drawing.Size(299, 37);
            this.konversiHasil.TabIndex = 8;
            this.konversiHasil.Text = "Hasil nilai konversi :";
            // 
            // buttonUbah
            // 
            this.buttonUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.Location = new System.Drawing.Point(532, 181);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(127, 44);
            this.buttonUbah.TabIndex = 9;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = true;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // Aplikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 366);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.konversiHasil);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.JenisKonversi);
            this.Controls.Add(this.Rupiah);
            this.Controls.Add(this.NilaiIDR);
            this.Controls.Add(this.judul);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Aplikasi";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Label NilaiIDR;
        private System.Windows.Forms.TextBox Rupiah;
        private System.Windows.Forms.Label JenisKonversi;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label Hasil;
        private System.Windows.Forms.Label konversiHasil;
        private System.Windows.Forms.Button buttonUbah;
    }
}

