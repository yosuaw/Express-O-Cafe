namespace Express_O_Cafe
{
    partial class FormDaftarNotaBeli
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
            this.textBoxDaftarNotaBeli = new System.Windows.Forms.TextBox();
            this.comboBoxDaftarNotaBeli = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDaftarNotaBeli = new System.Windows.Forms.DataGridView();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.panelCari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarNotaBeli)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panelCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCari.Controls.Add(this.textBoxDaftarNotaBeli);
            this.panelCari.Controls.Add(this.comboBoxDaftarNotaBeli);
            this.panelCari.Controls.Add(this.label2);
            this.panelCari.Location = new System.Drawing.Point(13, 14);
            this.panelCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(619, 63);
            this.panelCari.TabIndex = 0;
            // 
            // textBoxDaftarNotaBeli
            // 
            this.textBoxDaftarNotaBeli.Location = new System.Drawing.Point(404, 23);
            this.textBoxDaftarNotaBeli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDaftarNotaBeli.Name = "textBoxDaftarNotaBeli";
            this.textBoxDaftarNotaBeli.Size = new System.Drawing.Size(196, 20);
            this.textBoxDaftarNotaBeli.TabIndex = 2;
            this.textBoxDaftarNotaBeli.TextChanged += new System.EventHandler(this.textBoxDaftarNotaBeli_TextChanged);
            // 
            // comboBoxDaftarNotaBeli
            // 
            this.comboBoxDaftarNotaBeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.comboBoxDaftarNotaBeli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDaftarNotaBeli.FormattingEnabled = true;
            this.comboBoxDaftarNotaBeli.Items.AddRange(new object[] {
            "Nomor Nota",
            "Tanggal",
            "ID Supplier",
            "Nama Supplier",
            "Alamat Supplier",
            "Kode Karyawan",
            "Nama Karyawan"});
            this.comboBoxDaftarNotaBeli.Location = new System.Drawing.Point(220, 23);
            this.comboBoxDaftarNotaBeli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDaftarNotaBeli.Name = "comboBoxDaftarNotaBeli";
            this.comboBoxDaftarNotaBeli.Size = new System.Drawing.Size(156, 21);
            this.comboBoxDaftarNotaBeli.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Berdasarkan :";
            // 
            // dataGridViewDaftarNotaBeli
            // 
            this.dataGridViewDaftarNotaBeli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.dataGridViewDaftarNotaBeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarNotaBeli.Location = new System.Drawing.Point(13, 87);
            this.dataGridViewDaftarNotaBeli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDaftarNotaBeli.Name = "dataGridViewDaftarNotaBeli";
            this.dataGridViewDaftarNotaBeli.Size = new System.Drawing.Size(619, 328);
            this.dataGridViewDaftarNotaBeli.TabIndex = 1;
            // 
            // buttonCetak
            // 
            this.buttonCetak.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.Location = new System.Drawing.Point(526, 423);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(106, 40);
            this.buttonCetak.TabIndex = 2;
            this.buttonCetak.Text = "Cetak";
            this.buttonCetak.UseVisualStyleBackColor = true;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // FormDaftarNotaBeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 472);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.dataGridViewDaftarNotaBeli);
            this.Name = "FormDaftarNotaBeli";
            this.Text = "Daftar Nota Beli";
            this.Load += new System.EventHandler(this.FormDaftarNotaBeli_Load);
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarNotaBeli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.TextBox textBoxDaftarNotaBeli;
        private System.Windows.Forms.ComboBox comboBoxDaftarNotaBeli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDaftarNotaBeli;
        private System.Windows.Forms.Button buttonCetak;
    }
}