namespace login
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
            this.label5 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txttglblk = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txttglsewa = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtidsewa = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "PENYEWAAN";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(356, 377);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(128, 35);
            this.btndelete.TabIndex = 41;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(208, 377);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(128, 35);
            this.btnupdate.TabIndex = 40;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(66, 377);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(128, 35);
            this.btnsave.TabIndex = 39;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // txttglblk
            // 
            this.txttglblk.Location = new System.Drawing.Point(313, 287);
            this.txttglblk.Name = "txttglblk";
            this.txttglblk.Size = new System.Drawing.Size(171, 26);
            this.txttglblk.TabIndex = 36;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(88, 293);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(160, 20);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "TANGGAL KEMBALI";
            // 
            // txttglsewa
            // 
            this.txttglsewa.Location = new System.Drawing.Point(313, 227);
            this.txttglsewa.Name = "txttglsewa";
            this.txttglsewa.Size = new System.Drawing.Size(171, 26);
            this.txttglsewa.TabIndex = 34;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(88, 233);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(138, 20);
            this.Label2.TabIndex = 33;
            this.Label2.Text = "TANGGAL SEWA";
            // 
            // txtidsewa
            // 
            this.txtidsewa.Location = new System.Drawing.Point(313, 174);
            this.txtidsewa.Name = "txtidsewa";
            this.txtidsewa.Size = new System.Drawing.Size(171, 26);
            this.txtidsewa.TabIndex = 32;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(88, 180);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(78, 20);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "ID SEWA";
            // 
            // penyewaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 490);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txttglblk);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txttglsewa);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtidsewa);
            this.Controls.Add(this.Label1);
            this.Name = "penyewaan";
            this.Text = "penyewaan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.TextBox txttglblk;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txttglsewa;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtidsewa;
        internal System.Windows.Forms.Label Label1;
    }
}