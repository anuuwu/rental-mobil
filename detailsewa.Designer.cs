namespace login
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
            this.txtnorangka = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtidsewa = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnorangka
            // 
            this.txtnorangka.Location = new System.Drawing.Point(307, 248);
            this.txtnorangka.Name = "txtnorangka";
            this.txtnorangka.Size = new System.Drawing.Size(171, 26);
            this.txtnorangka.TabIndex = 30;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(114, 254);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(104, 20);
            this.Label6.TabIndex = 29;
            this.Label6.Text = "NO RANGKA";
            // 
            // txtidsewa
            // 
            this.txtidsewa.Location = new System.Drawing.Point(307, 191);
            this.txtidsewa.Name = "txtidsewa";
            this.txtidsewa.Size = new System.Drawing.Size(171, 26);
            this.txtidsewa.TabIndex = 28;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(114, 197);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(78, 20);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "ID SEWA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "PENYEWAAN";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(379, 325);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(128, 35);
            this.btndelete.TabIndex = 46;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(232, 325);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(128, 35);
            this.btnupdate.TabIndex = 45;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(89, 325);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(128, 35);
            this.btnsave.TabIndex = 44;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // detailsewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 464);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnorangka);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtidsewa);
            this.Controls.Add(this.Label5);
            this.Name = "detailsewa";
            this.Text = "detailsewa";
            this.Load += new System.EventHandler(this.detailsewa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtnorangka;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtidsewa;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Button btnsave;
    }
}