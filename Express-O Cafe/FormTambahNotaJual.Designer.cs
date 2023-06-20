namespace Express_O_Cafe
{
    partial class FormTambahNotaJual
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
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.comboBoxMetodePembayaran = new System.Windows.Forms.ComboBox();
            this.labelMetodePembayaran = new System.Windows.Forms.Label();
            this.dataGridViewNotaJual = new System.Windows.Forms.DataGridView();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.labelSub = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDiskonPersen = new System.Windows.Forms.Label();
            this.labelDiscPercent = new System.Windows.Forms.Label();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelNamaMenu = new System.Windows.Forms.Label();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.labelKode = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.comboBoxNamaMember = new System.Windows.Forms.ComboBox();
            this.labelMember = new System.Windows.Forms.Label();
            this.labelKaryawan = new System.Windows.Forms.Label();
            this.textBoxNomorNota = new System.Windows.Forms.TextBox();
            this.labelNomorNota = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNamaMenu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotaJual)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlamat.Location = new System.Drawing.Point(124, 136);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.ReadOnly = true;
            this.textBoxAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlamat.Size = new System.Drawing.Size(181, 20);
            this.textBoxAlamat.TabIndex = 9;
            // 
            // comboBoxMetodePembayaran
            // 
            this.comboBoxMetodePembayaran.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMetodePembayaran.FormattingEnabled = true;
            this.comboBoxMetodePembayaran.Location = new System.Drawing.Point(508, 41);
            this.comboBoxMetodePembayaran.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMetodePembayaran.Name = "comboBoxMetodePembayaran";
            this.comboBoxMetodePembayaran.Size = new System.Drawing.Size(118, 20);
            this.comboBoxMetodePembayaran.TabIndex = 11;
            // 
            // labelMetodePembayaran
            // 
            this.labelMetodePembayaran.AutoSize = true;
            this.labelMetodePembayaran.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetodePembayaran.Location = new System.Drawing.Point(349, 41);
            this.labelMetodePembayaran.Name = "labelMetodePembayaran";
            this.labelMetodePembayaran.Size = new System.Drawing.Size(157, 20);
            this.labelMetodePembayaran.TabIndex = 10;
            this.labelMetodePembayaran.Text = "Metode Pembayaran";
            // 
            // dataGridViewNotaJual
            // 
            this.dataGridViewNotaJual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotaJual.Location = new System.Drawing.Point(20, 228);
            this.dataGridViewNotaJual.Name = "dataGridViewNotaJual";
            this.dataGridViewNotaJual.Size = new System.Drawing.Size(606, 192);
            this.dataGridViewNotaJual.TabIndex = 26;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSubTotal.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.Location = new System.Drawing.Point(477, 206);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(150, 19);
            this.labelSubTotal.TabIndex = 25;
            this.labelSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub.Location = new System.Drawing.Point(518, 188);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(76, 16);
            this.labelSub.TabIndex = 24;
            this.labelSub.Text = "SUBTOTAL";
            // 
            // labelHarga
            // 
            this.labelHarga.BackColor = System.Drawing.Color.Transparent;
            this.labelHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHarga.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(267, 206);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(105, 19);
            this.labelHarga.TabIndex = 19;
            this.labelHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(296, 188);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 16);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "HARGA";
            // 
            // labelDiskonPersen
            // 
            this.labelDiskonPersen.BackColor = System.Drawing.Color.Transparent;
            this.labelDiskonPersen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDiskonPersen.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiskonPersen.Location = new System.Drawing.Point(435, 206);
            this.labelDiskonPersen.Name = "labelDiskonPersen";
            this.labelDiskonPersen.Size = new System.Drawing.Size(43, 19);
            this.labelDiskonPersen.TabIndex = 23;
            this.labelDiskonPersen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDiscPercent
            // 
            this.labelDiscPercent.AutoSize = true;
            this.labelDiscPercent.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscPercent.Location = new System.Drawing.Point(434, 188);
            this.labelDiscPercent.Name = "labelDiscPercent";
            this.labelDiscPercent.Size = new System.Drawing.Size(52, 16);
            this.labelDiscPercent.TabIndex = 22;
            this.labelDiscPercent.Text = "DISC%";
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJumlah.Location = new System.Drawing.Point(370, 206);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(66, 20);
            this.textBoxJumlah.TabIndex = 21;
            this.textBoxJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxJumlah.TextChanged += new System.EventHandler(this.textBoxJumlah_TextChanged);
            this.textBoxJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxJumlah_KeyDown);
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.Location = new System.Drawing.Point(376, 188);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(61, 16);
            this.labelJumlah.TabIndex = 20;
            this.labelJumlah.Text = "JUMLAH";
            // 
            // labelNamaMenu
            // 
            this.labelNamaMenu.AutoSize = true;
            this.labelNamaMenu.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaMenu.Location = new System.Drawing.Point(132, 188);
            this.labelNamaMenu.Name = "labelNamaMenu";
            this.labelNamaMenu.Size = new System.Drawing.Size(90, 16);
            this.labelNamaMenu.TabIndex = 16;
            this.labelNamaMenu.Text = "NAMA MENU";
            // 
            // textBoxKode
            // 
            this.textBoxKode.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKode.Location = new System.Drawing.Point(20, 206);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(60, 20);
            this.textBoxKode.TabIndex = 15;
            this.textBoxKode.TextChanged += new System.EventHandler(this.textBoxKode_TextChanged);
            // 
            // labelKode
            // 
            this.labelKode.AutoSize = true;
            this.labelKode.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKode.Location = new System.Drawing.Point(29, 188);
            this.labelKode.Name = "labelKode";
            this.labelKode.Size = new System.Drawing.Size(46, 16);
            this.labelKode.TabIndex = 14;
            this.labelKode.Text = "KODE";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.BackColor = System.Drawing.Color.Aqua;
            this.labelGrandTotal.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotal.Location = new System.Drawing.Point(350, 106);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(277, 50);
            this.labelGrandTotal.TabIndex = 13;
            this.labelGrandTotal.Text = "0";
            this.labelGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(121, 10);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(51, 20);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama";
            this.labelNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamat.Location = new System.Drawing.Point(16, 132);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(61, 20);
            this.labelAlamat.TabIndex = 8;
            this.labelAlamat.Text = "Alamat";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(520, 426);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(106, 40);
            this.buttonSimpan.TabIndex = 27;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // comboBoxNamaMember
            // 
            this.comboBoxNamaMember.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNamaMember.FormattingEnabled = true;
            this.comboBoxNamaMember.Location = new System.Drawing.Point(124, 105);
            this.comboBoxNamaMember.Name = "comboBoxNamaMember";
            this.comboBoxNamaMember.Size = new System.Drawing.Size(181, 20);
            this.comboBoxNamaMember.TabIndex = 7;
            this.comboBoxNamaMember.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamaMember_SelectedIndexChanged);
            // 
            // labelMember
            // 
            this.labelMember.AutoSize = true;
            this.labelMember.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMember.Location = new System.Drawing.Point(16, 102);
            this.labelMember.Name = "labelMember";
            this.labelMember.Size = new System.Drawing.Size(69, 20);
            this.labelMember.TabIndex = 6;
            this.labelMember.Text = "Member";
            // 
            // labelKaryawan
            // 
            this.labelKaryawan.AutoSize = true;
            this.labelKaryawan.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKaryawan.Location = new System.Drawing.Point(16, 10);
            this.labelKaryawan.Name = "labelKaryawan";
            this.labelKaryawan.Size = new System.Drawing.Size(82, 20);
            this.labelKaryawan.TabIndex = 0;
            this.labelKaryawan.Text = "Karyawan";
            // 
            // textBoxNomorNota
            // 
            this.textBoxNomorNota.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomorNota.Location = new System.Drawing.Point(124, 41);
            this.textBoxNomorNota.Name = "textBoxNomorNota";
            this.textBoxNomorNota.ReadOnly = true;
            this.textBoxNomorNota.Size = new System.Drawing.Size(181, 20);
            this.textBoxNomorNota.TabIndex = 3;
            // 
            // labelNomorNota
            // 
            this.labelNomorNota.AutoSize = true;
            this.labelNomorNota.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomorNota.Location = new System.Drawing.Point(16, 38);
            this.labelNomorNota.Name = "labelNomorNota";
            this.labelNomorNota.Size = new System.Drawing.Size(99, 20);
            this.labelNomorNota.TabIndex = 2;
            this.labelNomorNota.Text = "Nomor Nota";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(349, 80);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(66, 21);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "TOTAL";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(16, 72);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(64, 20);
            this.labelTanggal.TabIndex = 4;
            this.labelTanggal.Text = "Tanggal";
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(124, 72);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(181, 23);
            this.dateTimePickerTanggal.TabIndex = 5;
            this.dateTimePickerTanggal.ValueChanged += new System.EventHandler(this.dateTimePickerTanggal_ValueChanged);
            // 
            // comboBoxNamaMenu
            // 
            this.comboBoxNamaMenu.FormattingEnabled = true;
            this.comboBoxNamaMenu.Location = new System.Drawing.Point(79, 205);
            this.comboBoxNamaMenu.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNamaMenu.Name = "comboBoxNamaMenu";
            this.comboBoxNamaMenu.Size = new System.Drawing.Size(190, 21);
            this.comboBoxNamaMenu.TabIndex = 17;
            this.comboBoxNamaMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamaMenu_SelectedIndexChanged);
            this.comboBoxNamaMenu.TextChanged += new System.EventHandler(this.comboBoxNamaMenu_TextChanged);
            // 
            // FormTambahNotaJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 483);
            this.Controls.Add(this.comboBoxNamaMenu);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.comboBoxMetodePembayaran);
            this.Controls.Add(this.labelMetodePembayaran);
            this.Controls.Add(this.dataGridViewNotaJual);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.labelSub);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDiskonPersen);
            this.Controls.Add(this.labelDiscPercent);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.labelNamaMenu);
            this.Controls.Add(this.textBoxKode);
            this.Controls.Add(this.labelKode);
            this.Controls.Add(this.labelGrandTotal);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.comboBoxNamaMember);
            this.Controls.Add(this.labelMember);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.labelKaryawan);
            this.Controls.Add(this.textBoxNomorNota);
            this.Controls.Add(this.labelNomorNota);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTanggal);
            this.Name = "FormTambahNotaJual";
            this.Text = "Tambah Nota Jual";
            this.Load += new System.EventHandler(this.FormTambahNotaJual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotaJual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.ComboBox comboBoxMetodePembayaran;
        private System.Windows.Forms.Label labelMetodePembayaran;
        private System.Windows.Forms.DataGridView dataGridViewNotaJual;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDiskonPersen;
        private System.Windows.Forms.Label labelDiscPercent;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelNamaMenu;
        private System.Windows.Forms.TextBox textBoxKode;
        private System.Windows.Forms.Label labelKode;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.ComboBox comboBoxNamaMember;
        private System.Windows.Forms.Label labelMember;
        private System.Windows.Forms.Label labelKaryawan;
        private System.Windows.Forms.TextBox textBoxNomorNota;
        private System.Windows.Forms.Label labelNomorNota;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.ComboBox comboBoxNamaMenu;
    }
}