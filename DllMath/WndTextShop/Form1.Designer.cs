
namespace WndTextShop
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
            this.lstEfektler = new System.Windows.Forms.ListBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btn_uygula = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEfektler
            // 
            this.lstEfektler.FormattingEnabled = true;
            this.lstEfektler.ItemHeight = 16;
            this.lstEfektler.Location = new System.Drawing.Point(12, 127);
            this.lstEfektler.Name = "lstEfektler";
            this.lstEfektler.Size = new System.Drawing.Size(355, 340);
            this.lstEfektler.TabIndex = 0;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(22, 26);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(345, 22);
            this.txtMesaj.TabIndex = 1;
            // 
            // btn_uygula
            // 
            this.btn_uygula.Location = new System.Drawing.Point(202, 62);
            this.btn_uygula.Name = "btn_uygula";
            this.btn_uygula.Size = new System.Drawing.Size(165, 45);
            this.btn_uygula.TabIndex = 2;
            this.btn_uygula.Text = "Uygula";
            this.btn_uygula.UseVisualStyleBackColor = true;
            this.btn_uygula.Click += new System.EventHandler(this.btn_uygula_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(37, 76);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 17);
            this.lblSonuc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 495);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btn_uygula);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.lstEfektler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEfektler;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btn_uygula;
        private System.Windows.Forms.Label lblSonuc;
    }
}

