namespace login
{
    partial class Home
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
            this.btnmobil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpelanggan = new System.Windows.Forms.Button();
            this.btntrans = new System.Windows.Forms.Button();
            this.btnpenyewaan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmobil
            // 
            this.btnmobil.Location = new System.Drawing.Point(53, 334);
            this.btnmobil.Name = "btnmobil";
            this.btnmobil.Size = new System.Drawing.Size(102, 41);
            this.btnmobil.TabIndex = 2;
            this.btnmobil.Text = "Mobil";
            this.btnmobil.UseVisualStyleBackColor = true;
            this.btnmobil.Click += new System.EventHandler(this.btnmobil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome ";
            // 
            // btnpelanggan
            // 
            this.btnpelanggan.Location = new System.Drawing.Point(193, 334);
            this.btnpelanggan.Name = "btnpelanggan";
            this.btnpelanggan.Size = new System.Drawing.Size(102, 41);
            this.btnpelanggan.TabIndex = 3;
            this.btnpelanggan.Text = "Pelanggan";
            this.btnpelanggan.UseVisualStyleBackColor = true;
            this.btnpelanggan.Click += new System.EventHandler(this.btnpelanggan_Click);
            // 
            // btntrans
            // 
            this.btntrans.Location = new System.Drawing.Point(347, 334);
            this.btntrans.Name = "btntrans";
            this.btntrans.Size = new System.Drawing.Size(102, 41);
            this.btntrans.TabIndex = 4;
            this.btntrans.Text = "Transaksi";
            this.btntrans.UseVisualStyleBackColor = true;
            this.btntrans.Click += new System.EventHandler(this.btntrans_Click);
            // 
            // btnpenyewaan
            // 
            this.btnpenyewaan.Location = new System.Drawing.Point(498, 334);
            this.btnpenyewaan.Name = "btnpenyewaan";
            this.btnpenyewaan.Size = new System.Drawing.Size(102, 41);
            this.btnpenyewaan.TabIndex = 5;
            this.btnpenyewaan.Text = "Penyewaan";
            this.btnpenyewaan.UseVisualStyleBackColor = true;
            this.btnpenyewaan.Click += new System.EventHandler(this.btnpenyewaan_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 501);
            this.Controls.Add(this.btnpenyewaan);
            this.Controls.Add(this.btntrans);
            this.Controls.Add(this.btnpelanggan);
            this.Controls.Add(this.btnmobil);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmobil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpelanggan;
        private System.Windows.Forms.Button btntrans;
        private System.Windows.Forms.Button btnpenyewaan;
    }
}