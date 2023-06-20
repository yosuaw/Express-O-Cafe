namespace Express_O_Cafe
{
    partial class FormHapusBahan
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
            this.textBoxStokBahan = new System.Windows.Forms.TextBox();
            this.textBoxHargaBahan = new System.Windows.Forms.TextBox();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.labelStok = new System.Windows.Forms.Label();
            this.textBoxIdBahan = new System.Windows.Forms.TextBox();
            this.labelIdBahan = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.textBoxNamaBahan = new System.Windows.Forms.TextBox();
            this.labelNamaBahan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxStokBahan
            // 
            this.textBoxStokBahan.Location = new System.Drawing.Point(274, 174);
            this.textBoxStokBahan.Name = "textBoxStokBahan";
            this.textBoxStokBahan.Size = new System.Drawing.Size(87, 20);
            this.textBoxStokBahan.TabIndex = 5;
            // 
            // textBoxHargaBahan
            // 
            this.textBoxHargaBahan.Location = new System.Drawing.Point(274, 230);
            this.textBoxHargaBahan.Name = "textBoxHargaBahan";
            this.textBoxHargaBahan.Size = new System.Drawing.Size(135, 20);
            this.textBoxHargaBahan.TabIndex = 7;
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.Location = new System.Drawing.Point(425, 322);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(102, 36);
            this.buttonKosongi.TabIndex = 9;
            this.buttonKosongi.Text = "Kosongi";
            this.buttonKosongi.UseVisualStyleBackColor = true;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.Location = new System.Drawing.Point(132, 322);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(102, 36);
            this.buttonHapus.TabIndex = 8;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // labelStok
            // 
            this.labelStok.AutoSize = true;
            this.labelStok.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStok.Location = new System.Drawing.Point(118, 172);
            this.labelStok.Name = "labelStok";
            this.labelStok.Size = new System.Drawing.Size(41, 20);
            this.labelStok.TabIndex = 4;
            this.labelStok.Text = "Stok";
            // 
            // textBoxIdBahan
            // 
            this.textBoxIdBahan.Location = new System.Drawing.Point(274, 66);
            this.textBoxIdBahan.Name = "textBoxIdBahan";
            this.textBoxIdBahan.Size = new System.Drawing.Size(87, 20);
            this.textBoxIdBahan.TabIndex = 1;
            this.textBoxIdBahan.TextChanged += new System.EventHandler(this.textBoxIdBahan_TextChanged);
            // 
            // labelIdBahan
            // 
            this.labelIdBahan.AutoSize = true;
            this.labelIdBahan.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdBahan.Location = new System.Drawing.Point(118, 64);
            this.labelIdBahan.Name = "labelIdBahan";
            this.labelIdBahan.Size = new System.Drawing.Size(74, 20);
            this.labelIdBahan.TabIndex = 0;
            this.labelIdBahan.Text = "ID Bahan";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(118, 226);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(58, 22);
            this.labelHarga.TabIndex = 6;
            this.labelHarga.Text = "Harga";
            // 
            // textBoxNamaBahan
            // 
            this.textBoxNamaBahan.Location = new System.Drawing.Point(274, 118);
            this.textBoxNamaBahan.Name = "textBoxNamaBahan";
            this.textBoxNamaBahan.Size = new System.Drawing.Size(267, 20);
            this.textBoxNamaBahan.TabIndex = 3;
            // 
            // labelNamaBahan
            // 
            this.labelNamaBahan.AutoSize = true;
            this.labelNamaBahan.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBahan.Location = new System.Drawing.Point(118, 116);
            this.labelNamaBahan.Name = "labelNamaBahan";
            this.labelNamaBahan.Size = new System.Drawing.Size(99, 20);
            this.labelNamaBahan.TabIndex = 2;
            this.labelNamaBahan.Text = "Nama Bahan";
            // 
            // FormHapusBahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.textBoxStokBahan);
            this.Controls.Add(this.textBoxHargaBahan);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.labelStok);
            this.Controls.Add(this.textBoxIdBahan);
            this.Controls.Add(this.labelIdBahan);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.textBoxNamaBahan);
            this.Controls.Add(this.labelNamaBahan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHapusBahan";
            this.Text = "Hapus Bahan";
            this.Load += new System.EventHandler(this.FormHapusBahan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStokBahan;
        private System.Windows.Forms.TextBox textBoxHargaBahan;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Label labelStok;
        private System.Windows.Forms.TextBox textBoxIdBahan;
        private System.Windows.Forms.Label labelIdBahan;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.TextBox textBoxNamaBahan;
        private System.Windows.Forms.Label labelNamaBahan;
    }
}