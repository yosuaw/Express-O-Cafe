namespace Express_O_Cafe
{
    partial class FormTambahResep
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
            this.comboBoxKodeMenu = new System.Windows.Forms.ComboBox();
            this.comboBoxIdBahan = new System.Windows.Forms.ComboBox();
            this.textBoxTakaran = new System.Windows.Forms.TextBox();
            this.labelIdBahan = new System.Windows.Forms.Label();
            this.labelIKodeMenu = new System.Windows.Forms.Label();
            this.labelTakaran = new System.Windows.Forms.Label();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxKodeMenu
            // 
            this.comboBoxKodeMenu.FormattingEnabled = true;
            this.comboBoxKodeMenu.Location = new System.Drawing.Point(327, 89);
            this.comboBoxKodeMenu.Name = "comboBoxKodeMenu";
            this.comboBoxKodeMenu.Size = new System.Drawing.Size(135, 21);
            this.comboBoxKodeMenu.TabIndex = 1;
            // 
            // comboBoxIdBahan
            // 
            this.comboBoxIdBahan.FormattingEnabled = true;
            this.comboBoxIdBahan.Location = new System.Drawing.Point(327, 140);
            this.comboBoxIdBahan.Name = "comboBoxIdBahan";
            this.comboBoxIdBahan.Size = new System.Drawing.Size(135, 21);
            this.comboBoxIdBahan.TabIndex = 3;
            // 
            // textBoxTakaran
            // 
            this.textBoxTakaran.Location = new System.Drawing.Point(327, 195);
            this.textBoxTakaran.Name = "textBoxTakaran";
            this.textBoxTakaran.Size = new System.Drawing.Size(135, 20);
            this.textBoxTakaran.TabIndex = 5;
            // 
            // labelIdBahan
            // 
            this.labelIdBahan.AutoSize = true;
            this.labelIdBahan.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdBahan.Location = new System.Drawing.Point(171, 141);
            this.labelIdBahan.Name = "labelIdBahan";
            this.labelIdBahan.Size = new System.Drawing.Size(74, 20);
            this.labelIdBahan.TabIndex = 2;
            this.labelIdBahan.Text = "ID Bahan";
            // 
            // labelIKodeMenu
            // 
            this.labelIKodeMenu.AutoSize = true;
            this.labelIKodeMenu.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIKodeMenu.Location = new System.Drawing.Point(171, 87);
            this.labelIKodeMenu.Name = "labelIKodeMenu";
            this.labelIKodeMenu.Size = new System.Drawing.Size(90, 20);
            this.labelIKodeMenu.TabIndex = 0;
            this.labelIKodeMenu.Text = "Kode Menu";
            // 
            // labelTakaran
            // 
            this.labelTakaran.AutoSize = true;
            this.labelTakaran.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTakaran.Location = new System.Drawing.Point(171, 191);
            this.labelTakaran.Name = "labelTakaran";
            this.labelTakaran.Size = new System.Drawing.Size(76, 22);
            this.labelTakaran.TabIndex = 4;
            this.labelTakaran.Text = "Takaran";
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.Location = new System.Drawing.Point(356, 288);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(106, 40);
            this.buttonKosongi.TabIndex = 7;
            this.buttonKosongi.Text = "Kosongi";
            this.buttonKosongi.UseVisualStyleBackColor = true;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(175, 288);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(106, 40);
            this.buttonTambah.TabIndex = 6;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            // 
            // FormTambahResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.comboBoxKodeMenu);
            this.Controls.Add(this.comboBoxIdBahan);
            this.Controls.Add(this.textBoxTakaran);
            this.Controls.Add(this.labelIdBahan);
            this.Controls.Add(this.labelIKodeMenu);
            this.Controls.Add(this.labelTakaran);
            this.Name = "FormTambahResep";
            this.Text = "Tambah Resep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKodeMenu;
        private System.Windows.Forms.ComboBox comboBoxIdBahan;
        private System.Windows.Forms.TextBox textBoxTakaran;
        private System.Windows.Forms.Label labelIdBahan;
        private System.Windows.Forms.Label labelIKodeMenu;
        private System.Windows.Forms.Label labelTakaran;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Button buttonTambah;
    }
}