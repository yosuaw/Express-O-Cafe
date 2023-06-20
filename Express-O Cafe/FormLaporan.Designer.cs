namespace Express_O_Cafe
{
    partial class FormLaporan
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
            this.panelCari = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBulan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonBulan = new System.Windows.Forms.RadioButton();
            this.comboBoxTahun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonTahun = new System.Windows.Forms.RadioButton();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelJumlahTransaksi = new System.Windows.Forms.Label();
            this.labelJumlahPenjualan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelNamaMenu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPendapatan = new System.Windows.Forms.Label();
            this.labelPengeluaran = new System.Windows.Forms.Label();
            this.labelKeuntungan = new System.Windows.Forms.Label();
            this.labelBulanPenjualan = new System.Windows.Forms.Label();
            this.labelBulanTerbanyak = new System.Windows.Forms.Label();
            this.panelCari.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panelCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCari.Controls.Add(this.label3);
            this.panelCari.Controls.Add(this.comboBoxBulan);
            this.panelCari.Controls.Add(this.label1);
            this.panelCari.Controls.Add(this.radioButtonBulan);
            this.panelCari.Controls.Add(this.comboBoxTahun);
            this.panelCari.Controls.Add(this.label2);
            this.panelCari.Controls.Add(this.radioButtonTahun);
            this.panelCari.Location = new System.Drawing.Point(13, 14);
            this.panelCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(619, 63);
            this.panelCari.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bulan:";
            // 
            // comboBoxBulan
            // 
            this.comboBoxBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBulan.FormattingEnabled = true;
            this.comboBoxBulan.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.comboBoxBulan.Location = new System.Drawing.Point(491, 30);
            this.comboBoxBulan.Name = "comboBoxBulan";
            this.comboBoxBulan.Size = new System.Drawing.Size(115, 21);
            this.comboBoxBulan.TabIndex = 6;
            this.comboBoxBulan.SelectedIndexChanged += new System.EventHandler(this.comboBoxBulan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tahun:";
            // 
            // radioButtonBulan
            // 
            this.radioButtonBulan.AutoSize = true;
            this.radioButtonBulan.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBulan.Location = new System.Drawing.Point(256, 20);
            this.radioButtonBulan.Name = "radioButtonBulan";
            this.radioButtonBulan.Size = new System.Drawing.Size(68, 22);
            this.radioButtonBulan.TabIndex = 1;
            this.radioButtonBulan.TabStop = true;
            this.radioButtonBulan.Text = "Bulan";
            this.radioButtonBulan.UseVisualStyleBackColor = true;
            this.radioButtonBulan.CheckedChanged += new System.EventHandler(this.radioButtonBulan_CheckedChanged);
            // 
            // comboBoxTahun
            // 
            this.comboBoxTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTahun.FormattingEnabled = true;
            this.comboBoxTahun.Location = new System.Drawing.Point(346, 30);
            this.comboBoxTahun.Name = "comboBoxTahun";
            this.comboBoxTahun.Size = new System.Drawing.Size(115, 21);
            this.comboBoxTahun.TabIndex = 4;
            this.comboBoxTahun.SelectedIndexChanged += new System.EventHandler(this.comboBoxTahun_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Berdasarkan :";
            // 
            // radioButtonTahun
            // 
            this.radioButtonTahun.AutoSize = true;
            this.radioButtonTahun.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTahun.Location = new System.Drawing.Point(179, 20);
            this.radioButtonTahun.Name = "radioButtonTahun";
            this.radioButtonTahun.Size = new System.Drawing.Size(71, 22);
            this.radioButtonTahun.TabIndex = 2;
            this.radioButtonTahun.TabStop = true;
            this.radioButtonTahun.Text = "Tahun";
            this.radioButtonTahun.UseVisualStyleBackColor = true;
            this.radioButtonTahun.CheckedChanged += new System.EventHandler(this.radioButtonTahun_CheckedChanged);
            // 
            // buttonCetak
            // 
            this.buttonCetak.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.Location = new System.Drawing.Point(535, 401);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(106, 40);
            this.buttonCetak.TabIndex = 17;
            this.buttonCetak.Text = "Cetak";
            this.buttonCetak.UseVisualStyleBackColor = true;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Transaksi Jual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jumlah Penjualan Menu Terbanyak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "LAPORAN TRANSAKSI";
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(287, 104);
            this.labelJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJudul.MinimumSize = new System.Drawing.Size(88, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(92, 16);
            this.labelJudul.TabIndex = 2;
            this.labelJudul.Text = "Tahun/Bulan";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelJumlahTransaksi
            // 
            this.labelJumlahTransaksi.BackColor = System.Drawing.Color.Aqua;
            this.labelJumlahTransaksi.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlahTransaksi.Location = new System.Drawing.Point(263, 135);
            this.labelJumlahTransaksi.Name = "labelJumlahTransaksi";
            this.labelJumlahTransaksi.Size = new System.Drawing.Size(212, 32);
            this.labelJumlahTransaksi.TabIndex = 4;
            this.labelJumlahTransaksi.Text = "0";
            this.labelJumlahTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelJumlahPenjualan
            // 
            this.labelJumlahPenjualan.BackColor = System.Drawing.Color.Aqua;
            this.labelJumlahPenjualan.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlahPenjualan.Location = new System.Drawing.Point(263, 174);
            this.labelJumlahPenjualan.Name = "labelJumlahPenjualan";
            this.labelJumlahPenjualan.Size = new System.Drawing.Size(212, 32);
            this.labelJumlahPenjualan.TabIndex = 6;
            this.labelJumlahPenjualan.Text = "0";
            this.labelJumlahPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nama Penjualan Menu Terbanyak";
            // 
            // labelNamaMenu
            // 
            this.labelNamaMenu.BackColor = System.Drawing.Color.Aqua;
            this.labelNamaMenu.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaMenu.Location = new System.Drawing.Point(263, 214);
            this.labelNamaMenu.Name = "labelNamaMenu";
            this.labelNamaMenu.Size = new System.Drawing.Size(212, 32);
            this.labelNamaMenu.TabIndex = 8;
            this.labelNamaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 267);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Pendapatan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Pengeluaran";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 350);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Keuntungan";
            // 
            // labelPendapatan
            // 
            this.labelPendapatan.BackColor = System.Drawing.Color.Aqua;
            this.labelPendapatan.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendapatan.Location = new System.Drawing.Point(263, 254);
            this.labelPendapatan.Name = "labelPendapatan";
            this.labelPendapatan.Size = new System.Drawing.Size(212, 32);
            this.labelPendapatan.TabIndex = 10;
            this.labelPendapatan.Text = "0";
            this.labelPendapatan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPengeluaran
            // 
            this.labelPengeluaran.BackColor = System.Drawing.Color.Aqua;
            this.labelPengeluaran.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPengeluaran.Location = new System.Drawing.Point(263, 295);
            this.labelPengeluaran.Name = "labelPengeluaran";
            this.labelPengeluaran.Size = new System.Drawing.Size(212, 32);
            this.labelPengeluaran.TabIndex = 12;
            this.labelPengeluaran.Text = "0";
            this.labelPengeluaran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelKeuntungan
            // 
            this.labelKeuntungan.BackColor = System.Drawing.Color.Aqua;
            this.labelKeuntungan.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeuntungan.Location = new System.Drawing.Point(263, 337);
            this.labelKeuntungan.Name = "labelKeuntungan";
            this.labelKeuntungan.Size = new System.Drawing.Size(212, 32);
            this.labelKeuntungan.TabIndex = 14;
            this.labelKeuntungan.Text = "0";
            this.labelKeuntungan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBulanPenjualan
            // 
            this.labelBulanPenjualan.AutoSize = true;
            this.labelBulanPenjualan.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBulanPenjualan.Location = new System.Drawing.Point(34, 390);
            this.labelBulanPenjualan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBulanPenjualan.Name = "labelBulanPenjualan";
            this.labelBulanPenjualan.Size = new System.Drawing.Size(210, 16);
            this.labelBulanPenjualan.TabIndex = 15;
            this.labelBulanPenjualan.Text = "Bulan Dengan Penjualan Terbanyak";
            // 
            // labelBulanTerbanyak
            // 
            this.labelBulanTerbanyak.BackColor = System.Drawing.Color.Aqua;
            this.labelBulanTerbanyak.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBulanTerbanyak.Location = new System.Drawing.Point(263, 377);
            this.labelBulanTerbanyak.Name = "labelBulanTerbanyak";
            this.labelBulanTerbanyak.Size = new System.Drawing.Size(212, 32);
            this.labelBulanTerbanyak.TabIndex = 16;
            this.labelBulanTerbanyak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.labelBulanTerbanyak);
            this.Controls.Add(this.labelBulanPenjualan);
            this.Controls.Add(this.labelKeuntungan);
            this.Controls.Add(this.labelPengeluaran);
            this.Controls.Add(this.labelPendapatan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelNamaMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelJumlahPenjualan);
            this.Controls.Add(this.labelJumlahTransaksi);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.panelCari);
            this.Name = "FormLaporan";
            this.Text = "Laporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTahun;
        private System.Windows.Forms.ComboBox comboBoxBulan;
        private System.Windows.Forms.RadioButton radioButtonTahun;
        private System.Windows.Forms.RadioButton radioButtonBulan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelJumlahTransaksi;
        private System.Windows.Forms.Label labelJumlahPenjualan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelNamaMenu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelPendapatan;
        private System.Windows.Forms.Label labelPengeluaran;
        private System.Windows.Forms.Label labelKeuntungan;
        private System.Windows.Forms.Label labelBulanPenjualan;
        private System.Windows.Forms.Label labelBulanTerbanyak;
    }
}