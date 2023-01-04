namespace login
{
    partial class transaksi
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
            this.txtunitmobil = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtnoplat = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtidmobil = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtunitmobil
            // 
            this.txtunitmobil.Location = new System.Drawing.Point(316, 280);
            this.txtunitmobil.Name = "txtunitmobil";
            this.txtunitmobil.Size = new System.Drawing.Size(171, 26);
            this.txtunitmobil.TabIndex = 26;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(123, 286);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(35, 20);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "NIK";
            // 
            // txtnoplat
            // 
            this.txtnoplat.Location = new System.Drawing.Point(316, 209);
            this.txtnoplat.Name = "txtnoplat";
            this.txtnoplat.Size = new System.Drawing.Size(171, 26);
            this.txtnoplat.TabIndex = 24;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(123, 215);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(181, 20);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "TANGGAL TRANSAKSI";
            // 
            // txtidmobil
            // 
            this.txtidmobil.Location = new System.Drawing.Point(316, 127);
            this.txtidmobil.Name = "txtidmobil";
            this.txtidmobil.Size = new System.Drawing.Size(171, 26);
            this.txtidmobil.TabIndex = 22;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(123, 133);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(121, 20);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "ID TRANSAKSI";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(392, 340);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(128, 35);
            this.btndelete.TabIndex = 44;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(247, 340);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(128, 35);
            this.btnupdate.TabIndex = 43;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(102, 340);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(128, 35);
            this.btnsave.TabIndex = 42;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 417);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtunitmobil);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtnoplat);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtidmobil);
            this.Controls.Add(this.Label1);
            this.Name = "transaksi";
            this.Text = "transaksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtunitmobil;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtnoplat;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtidmobil;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Button btnsave;
    }
}