namespace Express_O_Cafe
{
    partial class FormHapusMenu
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
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKodeMenu = new System.Windows.Forms.TextBox();
            this.dataGridViewResep = new System.Windows.Forms.DataGridView();
            this.comboBoxKategoriMenu = new System.Windows.Forms.ComboBox();
            this.textBoxHargaMenu = new System.Windows.Forms.TextBox();
            this.labelKodeKategori = new System.Windows.Forms.Label();
            this.labelKodeMenu = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.textBoxNamaMenu = new System.Windows.Forms.TextBox();
            this.labelNamaMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResep)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.Location = new System.Drawing.Point(498, 318);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(106, 40);
            this.buttonKosongi.TabIndex = 12;
            this.buttonKosongi.Text = "Kosongi";
            this.buttonKosongi.UseVisualStyleBackColor = true;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.Location = new System.Drawing.Point(498, 205);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(106, 40);
            this.buttonHapus.TabIndex = 11;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.Location = new System.Drawing.Point(590, 62);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(35, 20);
            this.textBoxDiskon.TabIndex = 9;
            this.textBoxDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Disc (%)";
            // 
            // textBoxKodeMenu
            // 
            this.textBoxKodeMenu.Location = new System.Drawing.Point(142, 62);
            this.textBoxKodeMenu.Name = "textBoxKodeMenu";
            this.textBoxKodeMenu.Size = new System.Drawing.Size(75, 20);
            this.textBoxKodeMenu.TabIndex = 3;
            this.textBoxKodeMenu.TextChanged += new System.EventHandler(this.textBoxKodeMenu_TextChanged);
            // 
            // dataGridViewResep
            // 
            this.dataGridViewResep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResep.Location = new System.Drawing.Point(25, 130);
            this.dataGridViewResep.Name = "dataGridViewResep";
            this.dataGridViewResep.Size = new System.Drawing.Size(425, 303);
            this.dataGridViewResep.TabIndex = 10;
            // 
            // comboBoxKategoriMenu
            // 
            this.comboBoxKategoriMenu.FormattingEnabled = true;
            this.comboBoxKategoriMenu.Location = new System.Drawing.Point(142, 21);
            this.comboBoxKategoriMenu.Name = "comboBoxKategoriMenu";
            this.comboBoxKategoriMenu.Size = new System.Drawing.Size(135, 21);
            this.comboBoxKategoriMenu.TabIndex = 1;
            // 
            // textBoxHargaMenu
            // 
            this.textBoxHargaMenu.Location = new System.Drawing.Point(415, 62);
            this.textBoxHargaMenu.Name = "textBoxHargaMenu";
            this.textBoxHargaMenu.Size = new System.Drawing.Size(101, 20);
            this.textBoxHargaMenu.TabIndex = 7;
            this.textBoxHargaMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelKodeKategori
            // 
            this.labelKodeKategori.AutoSize = true;
            this.labelKodeKategori.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodeKategori.Location = new System.Drawing.Point(21, 18);
            this.labelKodeKategori.Name = "labelKodeKategori";
            this.labelKodeKategori.Size = new System.Drawing.Size(117, 20);
            this.labelKodeKategori.TabIndex = 0;
            this.labelKodeKategori.Text = "Nama Kategori";
            // 
            // labelKodeMenu
            // 
            this.labelKodeMenu.AutoSize = true;
            this.labelKodeMenu.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodeMenu.Location = new System.Drawing.Point(21, 58);
            this.labelKodeMenu.Name = "labelKodeMenu";
            this.labelKodeMenu.Size = new System.Drawing.Size(90, 20);
            this.labelKodeMenu.TabIndex = 2;
            this.labelKodeMenu.Text = "Kode Menu";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(315, 58);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(95, 21);
            this.labelHarga.TabIndex = 6;
            this.labelHarga.Text = "Harga (Rp)";
            // 
            // textBoxNamaMenu
            // 
            this.textBoxNamaMenu.Location = new System.Drawing.Point(415, 21);
            this.textBoxNamaMenu.Name = "textBoxNamaMenu";
            this.textBoxNamaMenu.Size = new System.Drawing.Size(210, 20);
            this.textBoxNamaMenu.TabIndex = 5;
            // 
            // labelNamaMenu
            // 
            this.labelNamaMenu.AutoSize = true;
            this.labelNamaMenu.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaMenu.Location = new System.Drawing.Point(315, 18);
            this.labelNamaMenu.Name = "labelNamaMenu";
            this.labelNamaMenu.Size = new System.Drawing.Size(95, 20);
            this.labelNamaMenu.TabIndex = 4;
            this.labelNamaMenu.Text = "Nama Menu";
            // 
            // FormHapusMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.textBoxDiskon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKodeMenu);
            this.Controls.Add(this.dataGridViewResep);
            this.Controls.Add(this.comboBoxKategoriMenu);
            this.Controls.Add(this.textBoxHargaMenu);
            this.Controls.Add(this.labelKodeKategori);
            this.Controls.Add(this.labelKodeMenu);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.textBoxNamaMenu);
            this.Controls.Add(this.labelNamaMenu);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.buttonHapus);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHapusMenu";
            this.Text = "Hapus Menu";
            this.Load += new System.EventHandler(this.FormHapusMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.TextBox textBoxDiskon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKodeMenu;
        private System.Windows.Forms.DataGridView dataGridViewResep;
        private System.Windows.Forms.ComboBox comboBoxKategoriMenu;
        private System.Windows.Forms.TextBox textBoxHargaMenu;
        private System.Windows.Forms.Label labelKodeKategori;
        private System.Windows.Forms.Label labelKodeMenu;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.TextBox textBoxNamaMenu;
        private System.Windows.Forms.Label labelNamaMenu;
    }
}