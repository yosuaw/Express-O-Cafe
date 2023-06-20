namespace Express_O_Cafe
{
    partial class FormDaftarKategori
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
            this.textBoxDaftarKategori = new System.Windows.Forms.TextBox();
            this.comboBoxDaftarKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDaftarKategori = new System.Windows.Forms.DataGridView();
            this.panelCari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panelCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCari.Controls.Add(this.textBoxDaftarKategori);
            this.panelCari.Controls.Add(this.comboBoxDaftarKategori);
            this.panelCari.Controls.Add(this.label2);
            this.panelCari.Location = new System.Drawing.Point(13, 14);
            this.panelCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(619, 63);
            this.panelCari.TabIndex = 0;
            // 
            // textBoxDaftarKategori
            // 
            this.textBoxDaftarKategori.Location = new System.Drawing.Point(401, 18);
            this.textBoxDaftarKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDaftarKategori.Name = "textBoxDaftarKategori";
            this.textBoxDaftarKategori.Size = new System.Drawing.Size(196, 20);
            this.textBoxDaftarKategori.TabIndex = 2;
            this.textBoxDaftarKategori.TextChanged += new System.EventHandler(this.textBoxDaftarKategori_TextChanged);
            // 
            // comboBoxDaftarKategori
            // 
            this.comboBoxDaftarKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.comboBoxDaftarKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDaftarKategori.FormattingEnabled = true;
            this.comboBoxDaftarKategori.Items.AddRange(new object[] {
            "Kode Kategori",
            "Nama Kategori"});
            this.comboBoxDaftarKategori.Location = new System.Drawing.Point(220, 18);
            this.comboBoxDaftarKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDaftarKategori.Name = "comboBoxDaftarKategori";
            this.comboBoxDaftarKategori.Size = new System.Drawing.Size(156, 21);
            this.comboBoxDaftarKategori.TabIndex = 1;
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
            // dataGridViewDaftarKategori
            // 
            this.dataGridViewDaftarKategori.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.dataGridViewDaftarKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarKategori.Location = new System.Drawing.Point(13, 87);
            this.dataGridViewDaftarKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDaftarKategori.Name = "dataGridViewDaftarKategori";
            this.dataGridViewDaftarKategori.Size = new System.Drawing.Size(619, 343);
            this.dataGridViewDaftarKategori.TabIndex = 1;
            // 
            // FormDaftarKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.dataGridViewDaftarKategori);
            this.Name = "FormDaftarKategori";
            this.Text = "Daftar Kategori";
            this.Load += new System.EventHandler(this.FormDaftarKategori_Load);
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarKategori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.TextBox textBoxDaftarKategori;
        private System.Windows.Forms.ComboBox comboBoxDaftarKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDaftarKategori;
    }
}