namespace Express_O_Cafe
{
    partial class FormDaftarSupplier
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
            this.textBoxDaftarSupplier = new System.Windows.Forms.TextBox();
            this.comboBoxDaftarSupplier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDaftarSupplier = new System.Windows.Forms.DataGridView();
            this.panelCari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panelCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCari.Controls.Add(this.textBoxDaftarSupplier);
            this.panelCari.Controls.Add(this.comboBoxDaftarSupplier);
            this.panelCari.Controls.Add(this.label2);
            this.panelCari.Location = new System.Drawing.Point(13, 14);
            this.panelCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(619, 63);
            this.panelCari.TabIndex = 0;
            // 
            // textBoxDaftarSupplier
            // 
            this.textBoxDaftarSupplier.Location = new System.Drawing.Point(401, 18);
            this.textBoxDaftarSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDaftarSupplier.Name = "textBoxDaftarSupplier";
            this.textBoxDaftarSupplier.Size = new System.Drawing.Size(196, 20);
            this.textBoxDaftarSupplier.TabIndex = 2;
            this.textBoxDaftarSupplier.TextChanged += new System.EventHandler(this.textBoxDaftarSupplier_TextChanged);
            // 
            // comboBoxDaftarSupplier
            // 
            this.comboBoxDaftarSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.comboBoxDaftarSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDaftarSupplier.FormattingEnabled = true;
            this.comboBoxDaftarSupplier.Items.AddRange(new object[] {
            "Id Supplier",
            "Nama",
            "Alamat",
            "Nomor Telepon"});
            this.comboBoxDaftarSupplier.Location = new System.Drawing.Point(220, 18);
            this.comboBoxDaftarSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDaftarSupplier.Name = "comboBoxDaftarSupplier";
            this.comboBoxDaftarSupplier.Size = new System.Drawing.Size(156, 21);
            this.comboBoxDaftarSupplier.TabIndex = 1;
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
            // dataGridViewDaftarSupplier
            // 
            this.dataGridViewDaftarSupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.dataGridViewDaftarSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarSupplier.Location = new System.Drawing.Point(13, 87);
            this.dataGridViewDaftarSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDaftarSupplier.Name = "dataGridViewDaftarSupplier";
            this.dataGridViewDaftarSupplier.Size = new System.Drawing.Size(619, 343);
            this.dataGridViewDaftarSupplier.TabIndex = 1;
            // 
            // FormDaftarSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.dataGridViewDaftarSupplier);
            this.Name = "FormDaftarSupplier";
            this.Text = "Daftar Supplier";
            this.Load += new System.EventHandler(this.FormDaftarSupplier_Load);
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.TextBox textBoxDaftarSupplier;
        private System.Windows.Forms.ComboBox comboBoxDaftarSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDaftarSupplier;
    }
}