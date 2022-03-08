
namespace Ders13_Form_Ado_Net
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEkle = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSil = new System.Windows.Forms.TabPage();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.cmb_Sil_Liste = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabEkle.SuspendLayout();
            this.tabSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİ EKLE";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEkle);
            this.tabControl1.Controls.Add(this.tabSil);
            this.tabControl1.Location = new System.Drawing.Point(133, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 504);
            this.tabControl1.TabIndex = 1;
            // 
            // tabEkle
            // 
            this.tabEkle.BackColor = System.Drawing.Color.Peru;
            this.tabEkle.Controls.Add(this.button1);
            this.tabEkle.Controls.Add(this.txt_TC);
            this.tabEkle.Controls.Add(this.label4);
            this.tabEkle.Controls.Add(this.txt_Tel);
            this.tabEkle.Controls.Add(this.label5);
            this.tabEkle.Controls.Add(this.txt_Soyad);
            this.tabEkle.Controls.Add(this.label3);
            this.tabEkle.Controls.Add(this.txt_Ad);
            this.tabEkle.Controls.Add(this.label2);
            this.tabEkle.Controls.Add(this.label1);
            this.tabEkle.ForeColor = System.Drawing.Color.SeaShell;
            this.tabEkle.Location = new System.Drawing.Point(4, 46);
            this.tabEkle.Name = "tabEkle";
            this.tabEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabEkle.Size = new System.Drawing.Size(456, 454);
            this.tabEkle.TabIndex = 0;
            this.tabEkle.Text = "EKLE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(88, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_TC
            // 
            this.txt_TC.BackColor = System.Drawing.Color.SeaShell;
            this.txt_TC.Location = new System.Drawing.Point(163, 273);
            this.txt_TC.MaxLength = 255;
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(191, 43);
            this.txt_TC.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "T.C.:";
            // 
            // txt_Tel
            // 
            this.txt_Tel.BackColor = System.Drawing.Color.SeaShell;
            this.txt_Tel.Location = new System.Drawing.Point(163, 216);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(191, 43);
            this.txt_Tel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefon:";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.BackColor = System.Drawing.Color.SeaShell;
            this.txt_Soyad.Location = new System.Drawing.Point(163, 157);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(191, 43);
            this.txt_Soyad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.BackColor = System.Drawing.Color.SeaShell;
            this.txt_Ad.Location = new System.Drawing.Point(163, 97);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(191, 43);
            this.txt_Ad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // tabSil
            // 
            this.tabSil.BackColor = System.Drawing.Color.Peru;
            this.tabSil.Controls.Add(this.btn_Sil);
            this.tabSil.Controls.Add(this.cmb_Sil_Liste);
            this.tabSil.Controls.Add(this.label6);
            this.tabSil.Location = new System.Drawing.Point(4, 46);
            this.tabSil.Name = "tabSil";
            this.tabSil.Padding = new System.Windows.Forms.Padding(3);
            this.tabSil.Size = new System.Drawing.Size(456, 454);
            this.tabSil.TabIndex = 1;
            this.tabSil.Text = "SİL";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(115, 276);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(203, 47);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // cmb_Sil_Liste
            // 
            this.cmb_Sil_Liste.FormattingEnabled = true;
            this.cmb_Sil_Liste.Location = new System.Drawing.Point(18, 183);
            this.cmb_Sil_Liste.Name = "cmb_Sil_Liste";
            this.cmb_Sil_Liste.Size = new System.Drawing.Size(417, 45);
            this.cmb_Sil_Liste.TabIndex = 1;
            this.cmb_Sil_Liste.Text = "Silinecek öğrenciyi seçiniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SeaShell;
            this.label6.Location = new System.Drawing.Point(18, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "ÖĞRENCİ SİLME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 827);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Öğrenci Bilgi Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEkle.ResumeLayout(false);
            this.tabEkle.PerformLayout();
            this.tabSil.ResumeLayout(false);
            this.tabSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Sil_Liste;
        private System.Windows.Forms.Button btn_Sil;
    }
}

