namespace Express_O_Cafe
{
    partial class FormDaftarKaryawan
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
            this.textBoxDaftarKaryawan = new System.Windows.Forms.TextBox();
            this.comboBoxDaftarKaryawan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDaftarKaryawan = new System.Windows.Forms.DataGridView();
            this.panelCari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarKaryawan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panelCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCari.Controls.Add(this.textBoxDaftarKaryawan);
            this.panelCari.Controls.Add(this.comboBoxDaftarKaryawan);
            this.panelCari.Controls.Add(this.label2);
            this.panelCari.Location = new System.Drawing.Point(13, 14);
            this.panelCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(619, 63);
            this.panelCari.TabIndex = 0;
            // 
            // textBoxDaftarKaryawan
            // 
            this.textBoxDaftarKaryawan.Location = new System.Drawing.Point(401, 18);
            this.textBoxDaftarKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDaftarKaryawan.Name = "textBoxDaftarKaryawan";
            this.textBoxDaftarKaryawan.Size = new System.Drawing.Size(196, 20);
            this.textBoxDaftarKaryawan.TabIndex = 2;
            this.textBoxDaftarKaryawan.TextChanged += new System.EventHandler(this.textBoxDaftarKaryawan_TextChanged);
            // 
            // comboBoxDaftarKaryawan
            // 
            this.comboBoxDaftarKaryawan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.comboBoxDaftarKaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDaftarKaryawan.FormattingEnabled = true;
            this.comboBoxDaftarKaryawan.Items.AddRange(new object[] {
            "Kode Karyawan",
            "Nama",
            "Alamat",
            "Tanggal Lahir",
            "Gaji",
            "Username",
            "Id Jabatan",
            "Nama Jabatan"});
            this.comboBoxDaftarKaryawan.Location = new System.Drawing.Point(220, 18);
            this.comboBoxDaftarKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDaftarKaryawan.Name = "comboBoxDaftarKaryawan";
            this.comboBoxDaftarKaryawan.Size = new System.Drawing.Size(156, 21);
            this.comboBoxDaftarKaryawan.TabIndex = 1;
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
            // dataGridViewDaftarKaryawan
            // 
            this.dataGridViewDaftarKaryawan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.dataGridViewDaftarKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarKaryawan.Location = new System.Drawing.Point(13, 87);
            this.dataGridViewDaftarKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDaftarKaryawan.Name = "dataGridViewDaftarKaryawan";
            this.dataGridViewDaftarKaryawan.Size = new System.Drawing.Size(619, 343);
            this.dataGridViewDaftarKaryawan.TabIndex = 1;
            // 
            // FormDaftarKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.dataGridViewDaftarKaryawan);
            this.Name = "FormDaftarKaryawan";
            this.Text = "Daftar Karyawan";
            this.Load += new System.EventHandler(this.FormDaftarKaryawan_Load);
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarKaryawan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.TextBox textBoxDaftarKaryawan;
        private System.Windows.Forms.ComboBox comboBoxDaftarKaryawan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDaftarKaryawan;
    }
}