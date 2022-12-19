namespace mobilrental
{
    partial class penyewaan
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
            this.btndeletep = new System.Windows.Forms.Button();
            this.btnupdatep = new System.Windows.Forms.Button();
            this.btnsavep = new System.Windows.Forms.Button();
            this.txtidpelanggan = new System.Windows.Forms.TextBox();
            this.txttglkembali = new System.Windows.Forms.TextBox();
            this.txttglsewa = new System.Windows.Forms.TextBox();
            this.txtidsewa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndeletep
            // 
            this.btndeletep.Location = new System.Drawing.Point(189, 179);
            this.btndeletep.Name = "btndeletep";
            this.btndeletep.Size = new System.Drawing.Size(75, 23);
            this.btndeletep.TabIndex = 25;
            this.btndeletep.Text = "DELETE";
            this.btndeletep.UseVisualStyleBackColor = true;
            // 
            // btnupdatep
            // 
            this.btnupdatep.Location = new System.Drawing.Point(108, 179);
            this.btnupdatep.Name = "btnupdatep";
            this.btnupdatep.Size = new System.Drawing.Size(75, 23);
            this.btnupdatep.TabIndex = 24;
            this.btnupdatep.Text = "UPDATE";
            this.btnupdatep.UseVisualStyleBackColor = true;
            // 
            // btnsavep
            // 
            this.btnsavep.Location = new System.Drawing.Point(27, 179);
            this.btnsavep.Name = "btnsavep";
            this.btnsavep.Size = new System.Drawing.Size(75, 23);
            this.btnsavep.TabIndex = 23;
            this.btnsavep.Text = "SAVE";
            this.btnsavep.UseVisualStyleBackColor = true;
            // 
            // txtidpelanggan
            // 
            this.txtidpelanggan.Location = new System.Drawing.Point(137, 137);
            this.txtidpelanggan.Name = "txtidpelanggan";
            this.txtidpelanggan.Size = new System.Drawing.Size(100, 20);
            this.txtidpelanggan.TabIndex = 21;
            // 
            // txttglkembali
            // 
            this.txttglkembali.Location = new System.Drawing.Point(137, 101);
            this.txttglkembali.Name = "txttglkembali";
            this.txttglkembali.Size = new System.Drawing.Size(100, 20);
            this.txttglkembali.TabIndex = 20;
            // 
            // txttglsewa
            // 
            this.txttglsewa.Location = new System.Drawing.Point(137, 66);
            this.txttglsewa.Name = "txttglsewa";
            this.txttglsewa.Size = new System.Drawing.Size(100, 20);
            this.txttglsewa.TabIndex = 19;
            // 
            // txtidsewa
            // 
            this.txtidsewa.Location = new System.Drawing.Point(137, 31);
            this.txtidsewa.Name = "txtidsewa";
            this.txtidsewa.Size = new System.Drawing.Size(100, 20);
            this.txtidsewa.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID PELANGGAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "TGL KEMBALI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "TANGGAL SEWA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID SEWA";
            // 
            // penyewaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btndeletep);
            this.Controls.Add(this.btnupdatep);
            this.Controls.Add(this.btnsavep);
            this.Controls.Add(this.txtidpelanggan);
            this.Controls.Add(this.txttglkembali);
            this.Controls.Add(this.txttglsewa);
            this.Controls.Add(this.txtidsewa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "penyewaan";
            this.Text = "penyewaan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndeletep;
        private System.Windows.Forms.Button btnupdatep;
        private System.Windows.Forms.Button btnsavep;
        private System.Windows.Forms.TextBox txtidpelanggan;
        private System.Windows.Forms.TextBox txttglkembali;
        private System.Windows.Forms.TextBox txttglsewa;
        private System.Windows.Forms.TextBox txtidsewa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}