namespace Express_O_Cafe
{
    partial class FormTambahNotaBeli
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
            this.dataGridViewNotaBeli = new System.Windows.Forms.DataGridView();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.labelSub = new System.Windows.Forms.Label();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelNamaBahan = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.labelKaryawan = new System.Windows.Forms.Label();
            this.textBoxNomorNota = new System.Windows.Forms.TextBox();
            this.labelNomorNota = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxNamaBahan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotaBeli)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlamat.Location = new System.Drawing.Point(121, 137);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.ReadOnly = true;
            this.textBoxAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlamat.Size = new System.Drawing.Size(181, 20);
            this.textBoxAlamat.TabIndex = 10;
            // 
            // dataGridViewNotaBeli
            // 
            this.dataGridViewNotaBeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotaBeli.Location = new System.Drawing.Point(16, 230);
            this.dataGridViewNotaBeli.Name = "dataGridViewNotaBeli";
            this.dataGridViewNotaBeli.Size = new System.Drawing.Size(606, 192);
            this.dataGridViewNotaBeli.TabIndex = 23;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSubTotal.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.Location = new System.Drawing.Point(431, 207);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(192, 19);
            this.labelSubTotal.TabIndex = 22;
            this.labelSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub.Location = new System.Drawing.Point(494, 189);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(76, 16);
            this.labelSub.TabIndex = 21;
            this.labelSub.Text = "SUBTOTAL";
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJumlah.Location = new System.Drawing.Point(367, 207);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(66, 20);
            this.textBoxJumlah.TabIndex = 20;
            this.textBoxJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxJumlah.TextChanged += new System.EventHandler(this.textBoxJumlah_TextChanged);
            this.textBoxJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxJumlah_KeyDown);
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.Location = new System.Drawing.Point(373, 189);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(61, 16);
            this.labelJumlah.TabIndex = 19;
            this.labelJumlah.Text = "JUMLAH";
            // 
            // labelNamaBahan
            // 
            this.labelNamaBahan.AutoSize = true;
            this.labelNamaBahan.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBahan.Location = new System.Drawing.Point(128, 189);
            this.labelNamaBahan.Name = "labelNamaBahan";
            this.labelNamaBahan.Size = new System.Drawing.Size(98, 16);
            this.labelNamaBahan.TabIndex = 15;
            this.labelNamaBahan.Text = "NAMA BAHAN";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(16, 207);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(60, 20);
            this.textBoxID.TabIndex = 14;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(34, 189);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 16);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "ID";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.BackColor = System.Drawing.Color.Aqua;
            this.labelGrandTotal.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotal.Location = new System.Drawing.Point(346, 73);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(277, 50);
            this.labelGrandTotal.TabIndex = 12;
            this.labelGrandTotal.Text = "0";
            this.labelGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(117, 11);
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
            this.labelAlamat.Location = new System.Drawing.Point(13, 134);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(61, 20);
            this.labelAlamat.TabIndex = 9;
            this.labelAlamat.Text = "Alamat";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(516, 428);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(106, 40);
            this.buttonSimpan.TabIndex = 0;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(121, 106);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(181, 20);
            this.comboBoxSupplier.TabIndex = 8;
            this.comboBoxSupplier.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupplier_SelectedIndexChanged);
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplier.Location = new System.Drawing.Point(13, 103);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(69, 20);
            this.labelSupplier.TabIndex = 7;
            this.labelSupplier.Text = "Supplier";
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(121, 73);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(181, 23);
            this.dateTimePickerTanggal.TabIndex = 6;
            this.dateTimePickerTanggal.ValueChanged += new System.EventHandler(this.dateTimePickerTanggal_ValueChanged);
            // 
            // labelKaryawan
            // 
            this.labelKaryawan.AutoSize = true;
            this.labelKaryawan.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKaryawan.Location = new System.Drawing.Point(13, 11);
            this.labelKaryawan.Name = "labelKaryawan";
            this.labelKaryawan.Size = new System.Drawing.Size(82, 20);
            this.labelKaryawan.TabIndex = 0;
            this.labelKaryawan.Text = "Karyawan";
            // 
            // textBoxNomorNota
            // 
            this.textBoxNomorNota.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomorNota.Location = new System.Drawing.Point(121, 43);
            this.textBoxNomorNota.Name = "textBoxNomorNota";
            this.textBoxNomorNota.ReadOnly = true;
            this.textBoxNomorNota.Size = new System.Drawing.Size(181, 20);
            this.textBoxNomorNota.TabIndex = 4;
            // 
            // labelNomorNota
            // 
            this.labelNomorNota.AutoSize = true;
            this.labelNomorNota.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomorNota.Location = new System.Drawing.Point(13, 40);
            this.labelNomorNota.Name = "labelNomorNota";
            this.labelNomorNota.Size = new System.Drawing.Size(99, 20);
            this.labelNomorNota.TabIndex = 3;
            this.labelNomorNota.Text = "Nomor Nota";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(345, 48);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(66, 21);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "TOTAL";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(13, 73);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(64, 20);
            this.labelTanggal.TabIndex = 5;
            this.labelTanggal.Text = "Tanggal";
            // 
            // labelHarga
            // 
            this.labelHarga.BackColor = System.Drawing.Color.Transparent;
            this.labelHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHarga.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(263, 207);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(105, 19);
            this.labelHarga.TabIndex = 18;
            this.labelHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(292, 189);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 16);
            this.labelPrice.TabIndex = 17;
            this.labelPrice.Text = "HARGA";
            // 
            // comboBoxNamaBahan
            // 
            this.comboBoxNamaBahan.FormattingEnabled = true;
            this.comboBoxNamaBahan.Location = new System.Drawing.Point(75, 206);
            this.comboBoxNamaBahan.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNamaBahan.Name = "comboBoxNamaBahan";
            this.comboBoxNamaBahan.Size = new System.Drawing.Size(190, 21);
            this.comboBoxNamaBahan.TabIndex = 16;
            this.comboBoxNamaBahan.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamaBahan_SelectedIndexChanged);
            this.comboBoxNamaBahan.TextChanged += new System.EventHandler(this.comboBoxNamaBahan_TextChanged);
            // 
            // FormTambahNotaBeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 483);
            this.Controls.Add(this.comboBoxNamaBahan);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.dataGridViewNotaBeli);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.labelSub);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.labelNamaBahan);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelGrandTotal);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.labelKaryawan);
            this.Controls.Add(this.textBoxNomorNota);
            this.Controls.Add(this.labelNomorNota);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTanggal);
            this.Name = "FormTambahNotaBeli";
            this.Text = "Tambah Nota Beli";
            this.Load += new System.EventHandler(this.FormTambahNotaBeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotaBeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.DataGridView dataGridViewNotaBeli;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelNamaBahan;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.Label labelKaryawan;
        private System.Windows.Forms.TextBox textBoxNomorNota;
        private System.Windows.Forms.Label labelNomorNota;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxNamaBahan;
    }
}