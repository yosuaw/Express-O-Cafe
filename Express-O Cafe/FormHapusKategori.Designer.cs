namespace Express_O_Cafe
{
    partial class FormHapusKategori
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
            this.textBoxKodeKategori = new System.Windows.Forms.TextBox();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.textBoxNamaKategori = new System.Windows.Forms.TextBox();
            this.labelKodeKategori = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKodeKategori
            // 
            this.textBoxKodeKategori.Location = new System.Drawing.Point(326, 87);
            this.textBoxKodeKategori.Name = "textBoxKodeKategori";
            this.textBoxKodeKategori.Size = new System.Drawing.Size(135, 20);
            this.textBoxKodeKategori.TabIndex = 1;
            this.textBoxKodeKategori.TextChanged += new System.EventHandler(this.textBoxKodeKategori_TextChanged);
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.Location = new System.Drawing.Point(359, 245);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(102, 36);
            this.buttonKosongi.TabIndex = 5;
            this.buttonKosongi.Text = "Kosongi";
            this.buttonKosongi.UseVisualStyleBackColor = true;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.Location = new System.Drawing.Point(174, 245);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(102, 36);
            this.buttonHapus.TabIndex = 4;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // textBoxNamaKategori
            // 
            this.textBoxNamaKategori.Location = new System.Drawing.Point(326, 147);
            this.textBoxNamaKategori.Name = "textBoxNamaKategori";
            this.textBoxNamaKategori.Size = new System.Drawing.Size(135, 20);
            this.textBoxNamaKategori.TabIndex = 3;
            // 
            // labelKodeKategori
            // 
            this.labelKodeKategori.AutoSize = true;
            this.labelKodeKategori.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodeKategori.Location = new System.Drawing.Point(170, 85);
            this.labelKodeKategori.Name = "labelKodeKategori";
            this.labelKodeKategori.Size = new System.Drawing.Size(112, 20);
            this.labelKodeKategori.TabIndex = 0;
            this.labelKodeKategori.Text = "Kode Kategori";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(170, 143);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(57, 22);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "Nama";
            // 
            // FormHapusKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.textBoxKodeKategori);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.textBoxNamaKategori);
            this.Controls.Add(this.labelKodeKategori);
            this.Controls.Add(this.labelNama);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHapusKategori";
            this.Text = "Hapus Kategori";
            this.Load += new System.EventHandler(this.FormHapusKategori_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKodeKategori;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.TextBox textBoxNamaKategori;
        private System.Windows.Forms.Label labelKodeKategori;
        private System.Windows.Forms.Label labelNama;
    }
}