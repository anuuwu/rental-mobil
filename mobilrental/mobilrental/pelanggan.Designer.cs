namespace mobilrental
{
    partial class pelanggan
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
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtmerkmobil = new System.Windows.Forms.TextBox();
            this.txtnamamobil = new System.Windows.Forms.TextBox();
            this.txtnoplat = new System.Windows.Forms.TextBox();
            this.txtidmobil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(189, 190);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 25;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(108, 190);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(27, 190);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // txtmerkmobil
            // 
            this.txtmerkmobil.Location = new System.Drawing.Point(164, 133);
            this.txtmerkmobil.Name = "txtmerkmobil";
            this.txtmerkmobil.Size = new System.Drawing.Size(100, 20);
            this.txtmerkmobil.TabIndex = 21;
            // 
            // txtnamamobil
            // 
            this.txtnamamobil.Location = new System.Drawing.Point(164, 97);
            this.txtnamamobil.Name = "txtnamamobil";
            this.txtnamamobil.Size = new System.Drawing.Size(100, 20);
            this.txtnamamobil.TabIndex = 20;
            // 
            // txtnoplat
            // 
            this.txtnoplat.Location = new System.Drawing.Point(164, 62);
            this.txtnoplat.Name = "txtnoplat";
            this.txtnoplat.Size = new System.Drawing.Size(100, 20);
            this.txtnoplat.TabIndex = 19;
            // 
            // txtidmobil
            // 
            this.txtidmobil.Location = new System.Drawing.Point(164, 27);
            this.txtidmobil.Name = "txtidmobil";
            this.txtidmobil.Size = new System.Drawing.Size(100, 20);
            this.txtidmobil.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ALAMAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "NOMOR KONTAK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "NAMA PELANGGAN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID PELANGGAN";
            // 
            // pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtmerkmobil);
            this.Controls.Add(this.txtnamamobil);
            this.Controls.Add(this.txtnoplat);
            this.Controls.Add(this.txtidmobil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "pelanggan";
            this.Text = "pelanggan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtmerkmobil;
        private System.Windows.Forms.TextBox txtnamamobil;
        private System.Windows.Forms.TextBox txtnoplat;
        private System.Windows.Forms.TextBox txtidmobil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}