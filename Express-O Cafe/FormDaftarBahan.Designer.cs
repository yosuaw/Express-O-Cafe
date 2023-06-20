namespace Express_O_Cafe
{
    partial class FormDaftarBahan
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
            this.textBoxDaftarBahan = new System.Windows.Forms.TextBox();
            this.comboBoxDaftarBahan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDaftarBahan = new System.Windows.Forms.DataGridView();
            this.panelCari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarBahan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panelCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCari.Controls.Add(this.textBoxDaftarBahan);
            this.panelCari.Controls.Add(this.comboBoxDaftarBahan);
            this.panelCari.Controls.Add(this.label2);
            this.panelCari.Location = new System.Drawing.Point(13, 14);
            this.panelCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(619, 63);
            this.panelCari.TabIndex = 0;
            // 
            // textBoxDaftarBahan
            // 
            this.textBoxDaftarBahan.Location = new System.Drawing.Point(401, 18);
            this.textBoxDaftarBahan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDaftarBahan.Name = "textBoxDaftarBahan";
            this.textBoxDaftarBahan.Size = new System.Drawing.Size(196, 20);
            this.textBoxDaftarBahan.TabIndex = 2;
            this.textBoxDaftarBahan.TextChanged += new System.EventHandler(this.textBoxDaftarBahan_TextChanged);
            // 
            // comboBoxDaftarBahan
            // 
            this.comboBoxDaftarBahan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.comboBoxDaftarBahan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDaftarBahan.FormattingEnabled = true;
            this.comboBoxDaftarBahan.Items.AddRange(new object[] {
            "Id Bahan",
            "Nama",
            "Stok",
            "Harga"});
            this.comboBoxDaftarBahan.Location = new System.Drawing.Point(220, 18);
            this.comboBoxDaftarBahan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDaftarBahan.Name = "comboBoxDaftarBahan";
            this.comboBoxDaftarBahan.Size = new System.Drawing.Size(156, 21);
            this.comboBoxDaftarBahan.TabIndex = 1;
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
            // dataGridViewDaftarBahan
            // 
            this.dataGridViewDaftarBahan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.dataGridViewDaftarBahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarBahan.Location = new System.Drawing.Point(13, 87);
            this.dataGridViewDaftarBahan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDaftarBahan.Name = "dataGridViewDaftarBahan";
            this.dataGridViewDaftarBahan.Size = new System.Drawing.Size(619, 343);
            this.dataGridViewDaftarBahan.TabIndex = 1;
            // 
            // FormDaftarBahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.dataGridViewDaftarBahan);
            this.Name = "FormDaftarBahan";
            this.Text = "Daftar Bahan";
            this.Load += new System.EventHandler(this.FormDaftarBahan_Load);
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarBahan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.TextBox textBoxDaftarBahan;
        private System.Windows.Forms.ComboBox comboBoxDaftarBahan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDaftarBahan;
    }
}