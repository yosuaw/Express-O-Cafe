namespace Express_O_Cafe
{
    partial class FormDaftarMenu
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
            this.textBoxDaftarMenu = new System.Windows.Forms.TextBox();
            this.comboBoxDaftarMenu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDaftarMenu = new System.Windows.Forms.DataGridView();
            this.panelCari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panelCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCari.Controls.Add(this.textBoxDaftarMenu);
            this.panelCari.Controls.Add(this.comboBoxDaftarMenu);
            this.panelCari.Controls.Add(this.label2);
            this.panelCari.Location = new System.Drawing.Point(13, 14);
            this.panelCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(619, 63);
            this.panelCari.TabIndex = 0;
            // 
            // textBoxDaftarMenu
            // 
            this.textBoxDaftarMenu.Location = new System.Drawing.Point(401, 18);
            this.textBoxDaftarMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDaftarMenu.Name = "textBoxDaftarMenu";
            this.textBoxDaftarMenu.Size = new System.Drawing.Size(196, 20);
            this.textBoxDaftarMenu.TabIndex = 2;
            this.textBoxDaftarMenu.TextChanged += new System.EventHandler(this.textBoxDaftarMenu_TextChanged);
            // 
            // comboBoxDaftarMenu
            // 
            this.comboBoxDaftarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.comboBoxDaftarMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDaftarMenu.FormattingEnabled = true;
            this.comboBoxDaftarMenu.Items.AddRange(new object[] {
            "Kode Menu",
            "Nama",
            "Harga",
            "Kode Kategori",
            "Nama Kategori",
            "Diskon(%)"});
            this.comboBoxDaftarMenu.Location = new System.Drawing.Point(220, 18);
            this.comboBoxDaftarMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDaftarMenu.Name = "comboBoxDaftarMenu";
            this.comboBoxDaftarMenu.Size = new System.Drawing.Size(156, 21);
            this.comboBoxDaftarMenu.TabIndex = 1;
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
            // dataGridViewDaftarMenu
            // 
            this.dataGridViewDaftarMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.dataGridViewDaftarMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarMenu.Location = new System.Drawing.Point(13, 87);
            this.dataGridViewDaftarMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDaftarMenu.Name = "dataGridViewDaftarMenu";
            this.dataGridViewDaftarMenu.Size = new System.Drawing.Size(619, 343);
            this.dataGridViewDaftarMenu.TabIndex = 1;
            // 
            // FormDaftarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.dataGridViewDaftarMenu);
            this.Name = "FormDaftarMenu";
            this.Text = "Daftar Menu";
            this.Load += new System.EventHandler(this.FormDaftarMenu_Load);
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.TextBox textBoxDaftarMenu;
        private System.Windows.Forms.ComboBox comboBoxDaftarMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDaftarMenu;
    }
}