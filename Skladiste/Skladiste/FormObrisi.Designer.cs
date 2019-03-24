namespace Skladiste
{
    partial class FormObrisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObrisi));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.obrisiUnesenuKolicinuBtn = new System.Windows.Forms.Button();
            this.obrisiCijeliProizvodBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 22);
            this.textBox1.TabIndex = 0;
            // 
            // obrisiUnesenuKolicinuBtn
            // 
            this.obrisiUnesenuKolicinuBtn.Location = new System.Drawing.Point(153, 17);
            this.obrisiUnesenuKolicinuBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.obrisiUnesenuKolicinuBtn.Name = "obrisiUnesenuKolicinuBtn";
            this.obrisiUnesenuKolicinuBtn.Size = new System.Drawing.Size(167, 34);
            this.obrisiUnesenuKolicinuBtn.TabIndex = 1;
            this.obrisiUnesenuKolicinuBtn.Text = "Obriši unesnu količinu";
            this.obrisiUnesenuKolicinuBtn.UseVisualStyleBackColor = true;
            this.obrisiUnesenuKolicinuBtn.Click += new System.EventHandler(this.obrisiUnesenuKolicinuBtn_Click);
            // 
            // obrisiCijeliProizvodBtn
            // 
            this.obrisiCijeliProizvodBtn.Location = new System.Drawing.Point(77, 194);
            this.obrisiCijeliProizvodBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obrisiCijeliProizvodBtn.Name = "obrisiCijeliProizvodBtn";
            this.obrisiCijeliProizvodBtn.Size = new System.Drawing.Size(170, 38);
            this.obrisiCijeliProizvodBtn.TabIndex = 2;
            this.obrisiCijeliProizvodBtn.Text = "Obriši cijeli proizvod";
            this.obrisiCijeliProizvodBtn.UseVisualStyleBackColor = true;
            this.obrisiCijeliProizvodBtn.Click += new System.EventHandler(this.obrisiCijeliProizvodBtn_Click);
            // 
            // FormObrisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 242);
            this.Controls.Add(this.obrisiCijeliProizvodBtn);
            this.Controls.Add(this.obrisiUnesenuKolicinuBtn);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormObrisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obriši";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button obrisiUnesenuKolicinuBtn;
        private System.Windows.Forms.Button obrisiCijeliProizvodBtn;
    }
}