
namespace Sahibinden_Form
{
    partial class Admin_AnaSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_1_uye_ekleme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1_uye_ekleme
            // 
            this.btn_1_uye_ekleme.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_1_uye_ekleme.Location = new System.Drawing.Point(989, 12);
            this.btn_1_uye_ekleme.Name = "btn_1_uye_ekleme";
            this.btn_1_uye_ekleme.Size = new System.Drawing.Size(187, 42);
            this.btn_1_uye_ekleme.TabIndex = 0;
            this.btn_1_uye_ekleme.Text = "Üye Ekleme";
            this.btn_1_uye_ekleme.UseVisualStyleBackColor = true;
            this.btn_1_uye_ekleme.Click += new System.EventHandler(this.btn_1_uye_ekleme_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(989, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Üye Silme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_1_uye_ekleme);
            this.Name = "AnaSayfa";
            this.Text = "ANASAYFA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_1_uye_ekleme;
        private System.Windows.Forms.Button button1;
    }
}

