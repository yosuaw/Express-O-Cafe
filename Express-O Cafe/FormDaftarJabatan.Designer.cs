namespace Express_O_Cafe
{
    partial class FormDaftarJabatan
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
            this.textBoxDaftarJabatan = new System.Windows.Forms.TextBox();
            this.comboBoxDaftarJabatan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDaftarJabatan = new System.Windows.Forms.DataGridView();
            this.panelCari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarJabatan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panelCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCari.Controls.Add(this.textBoxDaftarJabatan);
            this.panelCari.Controls.Add(this.comboBoxDaftarJabatan);
            this.panelCari.Controls.Add(this.label2);
            this.panelCari.Location = new System.Drawing.Point(13, 14);
            this.panelCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(619, 63);
            this.panelCari.TabIndex = 0;
            // 
            // textBoxDaftarJabatan
            // 
            this.textBoxDaftarJabatan.Location = new System.Drawing.Point(401, 18);
            this.textBoxDaftarJabatan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDaftarJabatan.Name = "textBoxDaftarJabatan";
            this.textBoxDaftarJabatan.Size = new System.Drawing.Size(196, 20);
            this.textBoxDaftarJabatan.TabIndex = 2;
            this.textBoxDaftarJabatan.TextChanged += new System.EventHandler(this.textBoxDaftarJabatan_TextChanged);
            // 
            // comboBoxDaftarJabatan
            // 
            this.comboBoxDaftarJabatan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.comboBoxDaftarJabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDaftarJabatan.FormattingEnabled = true;
            this.comboBoxDaftarJabatan.Items.AddRange(new object[] {
            "Id Jabatan",
            "Nama"});
            this.comboBoxDaftarJabatan.Location = new System.Drawing.Point(220, 18);
            this.comboBoxDaftarJabatan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDaftarJabatan.Name = "comboBoxDaftarJabatan";
            this.comboBoxDaftarJabatan.Size = new System.Drawing.Size(156, 21);
            this.comboBoxDaftarJabatan.TabIndex = 1;
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
            // dataGridViewDaftarJabatan
            // 
            this.dataGridViewDaftarJabatan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.dataGridViewDaftarJabatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarJabatan.Location = new System.Drawing.Point(13, 87);
            this.dataGridViewDaftarJabatan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDaftarJabatan.Name = "dataGridViewDaftarJabatan";
            this.dataGridViewDaftarJabatan.Size = new System.Drawing.Size(619, 343);
            this.dataGridViewDaftarJabatan.TabIndex = 1;
            // 
            // FormDaftarJabatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.dataGridViewDaftarJabatan);
            this.Name = "FormDaftarJabatan";
            this.Text = "Daftar Jabatan";
            this.Load += new System.EventHandler(this.FormDaftarJabatan_Load);
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarJabatan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.TextBox textBoxDaftarJabatan;
        private System.Windows.Forms.ComboBox comboBoxDaftarJabatan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDaftarJabatan;
    }
}