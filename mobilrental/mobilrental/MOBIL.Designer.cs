namespace mobilrental
{
    partial class MOBIL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidmobil = new System.Windows.Forms.TextBox();
            this.txtnoplat = new System.Windows.Forms.TextBox();
            this.txtnamamobil = new System.Windows.Forms.TextBox();
            this.txtmerkmobil = new System.Windows.Forms.TextBox();
            this.txthargasewa = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID MOBIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NO PLAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAMA MOBIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MERK MOBIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "HARGA SEWA";
            // 
            // txtidmobil
            // 
            this.txtidmobil.Location = new System.Drawing.Point(99, 13);
            this.txtidmobil.Name = "txtidmobil";
            this.txtidmobil.Size = new System.Drawing.Size(100, 20);
            this.txtidmobil.TabIndex = 5;
            // 
            // txtnoplat
            // 
            this.txtnoplat.Location = new System.Drawing.Point(99, 48);
            this.txtnoplat.Name = "txtnoplat";
            this.txtnoplat.Size = new System.Drawing.Size(100, 20);
            this.txtnoplat.TabIndex = 6;
            // 
            // txtnamamobil
            // 
            this.txtnamamobil.Location = new System.Drawing.Point(99, 83);
            this.txtnamamobil.Name = "txtnamamobil";
            this.txtnamamobil.Size = new System.Drawing.Size(100, 20);
            this.txtnamamobil.TabIndex = 7;
            // 
            // txtmerkmobil
            // 
            this.txtmerkmobil.Location = new System.Drawing.Point(99, 119);
            this.txtmerkmobil.Name = "txtmerkmobil";
            this.txtmerkmobil.Size = new System.Drawing.Size(100, 20);
            this.txtmerkmobil.TabIndex = 8;
            // 
            // txthargasewa
            // 
            this.txthargasewa.Location = new System.Drawing.Point(99, 154);
            this.txthargasewa.Name = "txthargasewa";
            this.txthargasewa.Size = new System.Drawing.Size(100, 20);
            this.txthargasewa.TabIndex = 9;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(18, 188);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(99, 188);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(180, 188);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // MOBIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 261);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txthargasewa);
            this.Controls.Add(this.txtmerkmobil);
            this.Controls.Add(this.txtnamamobil);
            this.Controls.Add(this.txtnoplat);
            this.Controls.Add(this.txtidmobil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MOBIL";
            this.Text = "MOBIL";
            this.Load += new System.EventHandler(this.MOBIL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidmobil;
        private System.Windows.Forms.TextBox txtnoplat;
        private System.Windows.Forms.TextBox txtnamamobil;
        private System.Windows.Forms.TextBox txtmerkmobil;
        private System.Windows.Forms.TextBox txthargasewa;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
    }
}