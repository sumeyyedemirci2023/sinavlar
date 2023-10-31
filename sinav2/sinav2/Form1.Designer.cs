namespace sinav2
{
    partial class Form1
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
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtBfiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTakTut = new System.Windows.Forms.Label();
            this.tbTaksitSay = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksitSay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(114, 6);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 20);
            this.txtAdet.TabIndex = 0;
            // 
            // txtBfiyat
            // 
            this.txtBfiyat.Location = new System.Drawing.Point(114, 55);
            this.txtBfiyat.Name = "txtBfiyat";
            this.txtBfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtBfiyat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birim Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Taksit Sayisi";
            // 
            // lblTakTut
            // 
            this.lblTakTut.AutoSize = true;
            this.lblTakTut.Location = new System.Drawing.Point(24, 198);
            this.lblTakTut.Name = "lblTakTut";
            this.lblTakTut.Size = new System.Drawing.Size(75, 13);
            this.lblTakTut.TabIndex = 5;
            this.lblTakTut.Text = "Taksit Tutarı : ";
            this.lblTakTut.Click += new System.EventHandler(this.lblTakTut_Click);
            // 
            // tbTaksitSay
            // 
            this.tbTaksitSay.Location = new System.Drawing.Point(125, 111);
            this.tbTaksitSay.Maximum = 6;
            this.tbTaksitSay.Minimum = 1;
            this.tbTaksitSay.Name = "tbTaksitSay";
            this.tbTaksitSay.Size = new System.Drawing.Size(104, 45);
            this.tbTaksitSay.TabIndex = 6;
            this.tbTaksitSay.Value = 1;
            this.tbTaksitSay.Scroll += new System.EventHandler(this.tbTaksitSay_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 242);
            this.Controls.Add(this.tbTaksitSay);
            this.Controls.Add(this.lblTakTut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBfiyat);
            this.Controls.Add(this.txtAdet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksitSay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtBfiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTakTut;
        private System.Windows.Forms.TrackBar tbTaksitSay;
    }
}

