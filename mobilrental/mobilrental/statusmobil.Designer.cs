namespace mobilrental
{
    partial class statusmobil
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
            this.txtunit = new System.Windows.Forms.TextBox();
            this.txtidmobil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "id mobil";
            // 
            // txtunit
            // 
            this.txtunit.Location = new System.Drawing.Point(65, 10);
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(100, 20);
            this.txtunit.TabIndex = 2;
            // 
            // txtidmobil
            // 
            this.txtidmobil.Location = new System.Drawing.Point(65, 41);
            this.txtidmobil.Name = "txtidmobil";
            this.txtidmobil.Size = new System.Drawing.Size(100, 20);
            this.txtidmobil.TabIndex = 3;
            // 
            // statusmobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtidmobil);
            this.Controls.Add(this.txtunit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "statusmobil";
            this.Text = "statusmobil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtunit;
        private System.Windows.Forms.TextBox txtidmobil;
    }
}