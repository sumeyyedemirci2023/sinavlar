namespace sinav
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
            this.txtAbdDlr = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnMiktar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTlTutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAbdDlr
            // 
            this.txtAbdDlr.Location = new System.Drawing.Point(211, 28);
            this.txtAbdDlr.Name = "txtAbdDlr";
            this.txtAbdDlr.Size = new System.Drawing.Size(100, 20);
            this.txtAbdDlr.TabIndex = 0;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(211, 55);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 1;
            // 
            // btnMiktar
            // 
            this.btnMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMiktar.Location = new System.Drawing.Point(209, 91);
            this.btnMiktar.Name = "btnMiktar";
            this.btnMiktar.Size = new System.Drawing.Size(102, 38);
            this.btnMiktar.TabIndex = 2;
            this.btnMiktar.Text = "Hesapla";
            this.btnMiktar.UseVisualStyleBackColor = true;
            this.btnMiktar.Click += new System.EventHandler(this.btnMiktar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "1 ABD Doları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Miktar";
            // 
            // lblTlTutar
            // 
            this.lblTlTutar.AutoSize = true;
            this.lblTlTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTlTutar.Location = new System.Drawing.Point(43, 175);
            this.lblTlTutar.Name = "lblTlTutar";
            this.lblTlTutar.Size = new System.Drawing.Size(80, 20);
            this.lblTlTutar.TabIndex = 5;
            this.lblTlTutar.Text = "TL Tutarı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 232);
            this.Controls.Add(this.lblTlTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMiktar);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtAbdDlr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAbdDlr;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnMiktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTlTutar;
    }
}

