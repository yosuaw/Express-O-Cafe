namespace Express_O_Cafe
{
    partial class FormTambahMenu
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
            this.dataGridViewResep = new System.Windows.Forms.DataGridView();
            this.textBoxTakaran = new System.Windows.Forms.TextBox();
            this.labelTakaran = new System.Windows.Forms.Label();
            this.comboBoxNamaBahan = new System.Windows.Forms.ComboBox();
            this.labelNamaBahan = new System.Windows.Forms.Label();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.comboBoxKategoriMenu = new System.Windows.Forms.ComboBox();
            this.textBoxHargaMenu = new System.Windows.Forms.TextBox();
            this.labelKodeKategori = new System.Windows.Forms.Label();
            this.labelKodeMenu = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.textBoxNamaMenu = new System.Windows.Forms.TextBox();
            this.labelNamaMenu = new System.Windows.Forms.Label();
            this.textBoxKodeMenu = new System.Windows.Forms.TextBox();
            this.textBoxIdBahan = new System.Windows.Forms.TextBox();
            this.labelIdBahan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResep)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResep
            // 
            this.dataGridViewResep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResep.Location = new System.Drawing.Point(21, 159);
            this.dataGridViewResep.Name = "dataGridViewResep";
            this.dataGridViewResep.Size = new System.Drawing.Size(425, 274);
            this.dataGridViewResep.TabIndex = 16;
            // 
            // textBoxTakaran
            // 
            this.textBoxTakaran.Location = new System.Drawing.Point(305, 132);
            this.textBoxTakaran.Name = "textBoxTakaran";
            this.textBoxTakaran.Size = new System.Drawing.Size(141, 20);
            this.textBoxTakaran.TabIndex = 15;
            this.textBoxTakaran.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTakaran_KeyDown);
            // 
            // labelTakaran
            // 
            this.labelTakaran.AutoSize = true;
            this.labelTakaran.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTakaran.Location = new System.Drawing.Point(311, 110);
            this.labelTakaran.Name = "labelTakaran";
            this.labelTakaran.Size = new System.Drawing.Size(135, 20);
            this.labelTakaran.TabIndex = 14;
            this.labelTakaran.Text = "Takaran (Kg or L)";
            // 
            // comboBoxNamaBahan
            // 
            this.comboBoxNamaBahan.FormattingEnabled = true;
            this.comboBoxNamaBahan.Location = new System.Drawing.Point(107, 132);
            this.comboBoxNamaBahan.Name = "comboBoxNamaBahan";
            this.comboBoxNamaBahan.Size = new System.Drawing.Size(198, 21);
            this.comboBoxNamaBahan.TabIndex = 13;
            this.comboBoxNamaBahan.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamaBahan_SelectedIndexChanged);
            this.comboBoxNamaBahan.TextChanged += new System.EventHandler(this.comboBoxNamaBahan_TextChanged);
            // 
            // labelNamaBahan
            // 
            this.labelNamaBahan.AutoSize = true;
            this.labelNamaBahan.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBahan.Location = new System.Drawing.Point(164, 110);
            this.labelNamaBahan.Name = "labelNamaBahan";
            this.labelNamaBahan.Size = new System.Drawing.Size(99, 20);
            this.labelNamaBahan.TabIndex = 12;
            this.labelNamaBahan.Text = "Nama Bahan";
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.Location = new System.Drawing.Point(494, 314);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(106, 40);
            this.buttonKosongi.TabIndex = 18;
            this.buttonKosongi.Text = "Kosongi";
            this.buttonKosongi.UseVisualStyleBackColor = true;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(494, 236);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(106, 40);
            this.buttonSimpan.TabIndex = 17;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // comboBoxKategoriMenu
            // 
            this.comboBoxKategoriMenu.FormattingEnabled = true;
            this.comboBoxKategoriMenu.Location = new System.Drawing.Point(138, 18);
            this.comboBoxKategoriMenu.Name = "comboBoxKategoriMenu";
            this.comboBoxKategoriMenu.Size = new System.Drawing.Size(135, 21);
            this.comboBoxKategoriMenu.TabIndex = 1;
            this.comboBoxKategoriMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategoriMenu_SelectedIndexChanged);
            // 
            // textBoxHargaMenu
            // 
            this.textBoxHargaMenu.Location = new System.Drawing.Point(411, 50);
            this.textBoxHargaMenu.Name = "textBoxHargaMenu";
            this.textBoxHargaMenu.Size = new System.Drawing.Size(101, 20);
            this.textBoxHargaMenu.TabIndex = 7;
            this.textBoxHargaMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelKodeKategori
            // 
            this.labelKodeKategori.AutoSize = true;
            this.labelKodeKategori.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodeKategori.Location = new System.Drawing.Point(17, 15);
            this.labelKodeKategori.Name = "labelKodeKategori";
            this.labelKodeKategori.Size = new System.Drawing.Size(117, 20);
            this.labelKodeKategori.TabIndex = 0;
            this.labelKodeKategori.Text = "Nama Kategori";
            // 
            // labelKodeMenu
            // 
            this.labelKodeMenu.AutoSize = true;
            this.labelKodeMenu.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodeMenu.Location = new System.Drawing.Point(17, 47);
            this.labelKodeMenu.Name = "labelKodeMenu";
            this.labelKodeMenu.Size = new System.Drawing.Size(90, 20);
            this.labelKodeMenu.TabIndex = 2;
            this.labelKodeMenu.Text = "Kode Menu";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(311, 46);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(95, 21);
            this.labelHarga.TabIndex = 6;
            this.labelHarga.Text = "Harga (Rp)";
            // 
            // textBoxNamaMenu
            // 
            this.textBoxNamaMenu.Location = new System.Drawing.Point(411, 18);
            this.textBoxNamaMenu.Name = "textBoxNamaMenu";
            this.textBoxNamaMenu.Size = new System.Drawing.Size(210, 20);
            this.textBoxNamaMenu.TabIndex = 5;
            // 
            // labelNamaMenu
            // 
            this.labelNamaMenu.AutoSize = true;
            this.labelNamaMenu.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaMenu.Location = new System.Drawing.Point(311, 15);
            this.labelNamaMenu.Name = "labelNamaMenu";
            this.labelNamaMenu.Size = new System.Drawing.Size(95, 20);
            this.labelNamaMenu.TabIndex = 4;
            this.labelNamaMenu.Text = "Nama Menu";
            // 
            // textBoxKodeMenu
            // 
            this.textBoxKodeMenu.Location = new System.Drawing.Point(138, 50);
            this.textBoxKodeMenu.Name = "textBoxKodeMenu";
            this.textBoxKodeMenu.Size = new System.Drawing.Size(75, 20);
            this.textBoxKodeMenu.TabIndex = 3;
            // 
            // textBoxIdBahan
            // 
            this.textBoxIdBahan.Location = new System.Drawing.Point(21, 132);
            this.textBoxIdBahan.Name = "textBoxIdBahan";
            this.textBoxIdBahan.Size = new System.Drawing.Size(86, 20);
            this.textBoxIdBahan.TabIndex = 11;
            this.textBoxIdBahan.TextChanged += new System.EventHandler(this.textBoxIdBahan_TextChanged);
            // 
            // labelIdBahan
            // 
            this.labelIdBahan.AutoSize = true;
            this.labelIdBahan.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdBahan.Location = new System.Drawing.Point(29, 110);
            this.labelIdBahan.Name = "labelIdBahan";
            this.labelIdBahan.Size = new System.Drawing.Size(72, 20);
            this.labelIdBahan.TabIndex = 10;
            this.labelIdBahan.Text = "Id Bahan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Disc (%)";
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.Location = new System.Drawing.Point(586, 50);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(35, 20);
            this.textBoxDiskon.TabIndex = 9;
            this.textBoxDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormTambahMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.textBoxDiskon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIdBahan);
            this.Controls.Add(this.textBoxIdBahan);
            this.Controls.Add(this.textBoxKodeMenu);
            this.Controls.Add(this.dataGridViewResep);
            this.Controls.Add(this.textBoxTakaran);
            this.Controls.Add(this.labelTakaran);
            this.Controls.Add(this.comboBoxNamaBahan);
            this.Controls.Add(this.labelNamaBahan);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.comboBoxKategoriMenu);
            this.Controls.Add(this.textBoxHargaMenu);
            this.Controls.Add(this.labelKodeKategori);
            this.Controls.Add(this.labelKodeMenu);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.textBoxNamaMenu);
            this.Controls.Add(this.labelNamaMenu);
            this.Name = "FormTambahMenu";
            this.Text = "Tambah Menu";
            this.Load += new System.EventHandler(this.FormTambahMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResep;
        private System.Windows.Forms.TextBox textBoxTakaran;
        private System.Windows.Forms.Label labelTakaran;
        private System.Windows.Forms.ComboBox comboBoxNamaBahan;
        private System.Windows.Forms.Label labelNamaBahan;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.ComboBox comboBoxKategoriMenu;
        private System.Windows.Forms.TextBox textBoxHargaMenu;
        private System.Windows.Forms.Label labelKodeKategori;
        private System.Windows.Forms.Label labelKodeMenu;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.TextBox textBoxNamaMenu;
        private System.Windows.Forms.Label labelNamaMenu;
        private System.Windows.Forms.TextBox textBoxKodeMenu;
        private System.Windows.Forms.TextBox textBoxIdBahan;
        private System.Windows.Forms.Label labelIdBahan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDiskon;
    }
}