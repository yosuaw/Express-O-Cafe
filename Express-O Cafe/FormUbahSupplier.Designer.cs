namespace Express_O_Cafe
{
    partial class FormUbahSupplier
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
            this.textBoxNomorTeleponSupplier = new System.Windows.Forms.TextBox();
            this.labelNomorTelepon = new System.Windows.Forms.Label();
            this.textBoxAlamatSupplier = new System.Windows.Forms.TextBox();
            this.textBoxIdSupplier = new System.Windows.Forms.TextBox();
            this.labelIdSupplier = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.textBoxNamaSupplier = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNomorTeleponSupplier
            // 
            this.textBoxNomorTeleponSupplier.Location = new System.Drawing.Point(275, 280);
            this.textBoxNomorTeleponSupplier.Name = "textBoxNomorTeleponSupplier";
            this.textBoxNomorTeleponSupplier.Size = new System.Drawing.Size(185, 20);
            this.textBoxNomorTeleponSupplier.TabIndex = 7;
            // 
            // labelNomorTelepon
            // 
            this.labelNomorTelepon.AutoSize = true;
            this.labelNomorTelepon.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomorTelepon.Location = new System.Drawing.Point(119, 279);
            this.labelNomorTelepon.Name = "labelNomorTelepon";
            this.labelNomorTelepon.Size = new System.Drawing.Size(94, 20);
            this.labelNomorTelepon.TabIndex = 6;
            this.labelNomorTelepon.Text = "No. Telepon";
            // 
            // textBoxAlamatSupplier
            // 
            this.textBoxAlamatSupplier.Location = new System.Drawing.Point(275, 133);
            this.textBoxAlamatSupplier.Multiline = true;
            this.textBoxAlamatSupplier.Name = "textBoxAlamatSupplier";
            this.textBoxAlamatSupplier.Size = new System.Drawing.Size(267, 111);
            this.textBoxAlamatSupplier.TabIndex = 5;
            // 
            // textBoxIdSupplier
            // 
            this.textBoxIdSupplier.Location = new System.Drawing.Point(275, 28);
            this.textBoxIdSupplier.Name = "textBoxIdSupplier";
            this.textBoxIdSupplier.Size = new System.Drawing.Size(88, 20);
            this.textBoxIdSupplier.TabIndex = 1;
            this.textBoxIdSupplier.TextChanged += new System.EventHandler(this.textBoxIdSupplier_TextChanged);
            // 
            // labelIdSupplier
            // 
            this.labelIdSupplier.AutoSize = true;
            this.labelIdSupplier.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdSupplier.Location = new System.Drawing.Point(119, 26);
            this.labelIdSupplier.Name = "labelIdSupplier";
            this.labelIdSupplier.Size = new System.Drawing.Size(90, 20);
            this.labelIdSupplier.TabIndex = 0;
            this.labelIdSupplier.Text = "ID Supplier";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamat.Location = new System.Drawing.Point(119, 133);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(67, 22);
            this.labelAlamat.TabIndex = 4;
            this.labelAlamat.Text = "Alamat";
            // 
            // textBoxNamaSupplier
            // 
            this.textBoxNamaSupplier.Location = new System.Drawing.Point(275, 80);
            this.textBoxNamaSupplier.Name = "textBoxNamaSupplier";
            this.textBoxNamaSupplier.Size = new System.Drawing.Size(173, 20);
            this.textBoxNamaSupplier.TabIndex = 3;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(119, 78);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(115, 20);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "Nama Supplier";
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.Location = new System.Drawing.Point(421, 363);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(106, 40);
            this.buttonKosongi.TabIndex = 9;
            this.buttonKosongi.Text = "Kosongi";
            this.buttonKosongi.UseVisualStyleBackColor = true;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.Location = new System.Drawing.Point(146, 367);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(102, 36);
            this.buttonUbah.TabIndex = 8;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = true;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // FormUbahSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.textBoxNomorTeleponSupplier);
            this.Controls.Add(this.labelNomorTelepon);
            this.Controls.Add(this.textBoxAlamatSupplier);
            this.Controls.Add(this.textBoxIdSupplier);
            this.Controls.Add(this.labelIdSupplier);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.textBoxNamaSupplier);
            this.Controls.Add(this.labelNama);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUbahSupplier";
            this.Text = "Ubah Supplier";
            this.Load += new System.EventHandler(this.FormUbahSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNomorTeleponSupplier;
        private System.Windows.Forms.Label labelNomorTelepon;
        private System.Windows.Forms.TextBox textBoxAlamatSupplier;
        private System.Windows.Forms.TextBox textBoxIdSupplier;
        private System.Windows.Forms.Label labelIdSupplier;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.TextBox textBoxNamaSupplier;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Button buttonUbah;
    }
}