﻿namespace Express_O_Cafe
{
    partial class FormTambahJabatan
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
            this.textBoxIdJabatan = new System.Windows.Forms.TextBox();
            this.textBoxNamaJabatan = new System.Windows.Forms.TextBox();
            this.labelIdJabatan = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIdJabatan
            // 
            this.textBoxIdJabatan.Location = new System.Drawing.Point(323, 86);
            this.textBoxIdJabatan.Name = "textBoxIdJabatan";
            this.textBoxIdJabatan.Size = new System.Drawing.Size(135, 20);
            this.textBoxIdJabatan.TabIndex = 1;
            // 
            // textBoxNamaJabatan
            // 
            this.textBoxNamaJabatan.Location = new System.Drawing.Point(323, 146);
            this.textBoxNamaJabatan.Name = "textBoxNamaJabatan";
            this.textBoxNamaJabatan.Size = new System.Drawing.Size(135, 20);
            this.textBoxNamaJabatan.TabIndex = 3;
            // 
            // labelIdJabatan
            // 
            this.labelIdJabatan.AutoSize = true;
            this.labelIdJabatan.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdJabatan.Location = new System.Drawing.Point(167, 84);
            this.labelIdJabatan.Name = "labelIdJabatan";
            this.labelIdJabatan.Size = new System.Drawing.Size(81, 20);
            this.labelIdJabatan.TabIndex = 0;
            this.labelIdJabatan.Text = "Id Jabatan";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(167, 142);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(121, 22);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "Nama Jabatan";
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.Location = new System.Drawing.Point(352, 221);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(106, 40);
            this.buttonKosongi.TabIndex = 5;
            this.buttonKosongi.Text = "Kosongi";
            this.buttonKosongi.UseVisualStyleBackColor = true;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(171, 221);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(106, 40);
            this.buttonTambah.TabIndex = 4;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // FormTambahJabatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.textBoxIdJabatan);
            this.Controls.Add(this.textBoxNamaJabatan);
            this.Controls.Add(this.labelIdJabatan);
            this.Controls.Add(this.labelNama);
            this.Name = "FormTambahJabatan";
            this.Text = "Tambah Jabatan";
            this.Load += new System.EventHandler(this.FormTambahJabatan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIdJabatan;
        private System.Windows.Forms.TextBox textBoxNamaJabatan;
        private System.Windows.Forms.Label labelIdJabatan;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Button buttonTambah;
    }
}