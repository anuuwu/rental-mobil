namespace mobilrental
{
    partial class detailsewa
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
            this.txtnamamobil = new System.Windows.Forms.TextBox();
            this.txtnoplat = new System.Windows.Forms.TextBox();
            this.txtidmobil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnamamobil
            // 
            this.txtnamamobil.Location = new System.Drawing.Point(162, 64);
            this.txtnamamobil.Name = "txtnamamobil";
            this.txtnamamobil.Size = new System.Drawing.Size(100, 20);
            this.txtnamamobil.TabIndex = 20;
            // 
            // txtnoplat
            // 
            this.txtnoplat.Location = new System.Drawing.Point(162, 38);
            this.txtnoplat.Name = "txtnoplat";
            this.txtnoplat.Size = new System.Drawing.Size(100, 20);
            this.txtnoplat.TabIndex = 19;
            // 
            // txtidmobil
            // 
            this.txtidmobil.Location = new System.Drawing.Point(162, 12);
            this.txtidmobil.Name = "txtidmobil";
            this.txtidmobil.Size = new System.Drawing.Size(100, 20);
            this.txtidmobil.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID MOBIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID NOMOR RANGKA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID PENYEWAAN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 115);
            this.dataGridView1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 24);
            this.button1.TabIndex = 22;
            this.button1.Text = "CARI";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // detailsewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtnamamobil);
            this.Controls.Add(this.txtnoplat);
            this.Controls.Add(this.txtidmobil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "detailsewa";
            this.Text = "detailsewa";
            this.Load += new System.EventHandler(this.detailsewa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnamamobil;
        private System.Windows.Forms.TextBox txtnoplat;
        private System.Windows.Forms.TextBox txtidmobil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}