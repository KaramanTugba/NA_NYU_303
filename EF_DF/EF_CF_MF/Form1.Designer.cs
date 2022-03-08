
namespace EF_CF_MF
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLazy = new System.Windows.Forms.Button();
            this.btnEager = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnFilmAra = new System.Windows.Forms.Button();
            this.btnBulSil = new System.Windows.Forms.Button();
            this.btnBulGuncelle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLazy
            // 
            this.btnLazy.Location = new System.Drawing.Point(30, 63);
            this.btnLazy.Name = "btnLazy";
            this.btnLazy.Size = new System.Drawing.Size(130, 32);
            this.btnLazy.TabIndex = 2;
            this.btnLazy.Text = "Lazy";
            this.btnLazy.UseVisualStyleBackColor = true;
            this.btnLazy.Click += new System.EventHandler(this.btnLazy_Click);
            // 
            // btnEager
            // 
            this.btnEager.Location = new System.Drawing.Point(184, 63);
            this.btnEager.Name = "btnEager";
            this.btnEager.Size = new System.Drawing.Size(130, 32);
            this.btnEager.TabIndex = 3;
            this.btnEager.Text = "Eager";
            this.btnEager.UseVisualStyleBackColor = true;
            this.btnEager.Click += new System.EventHandler(this.btnEager_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(346, 45);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(97, 69);
            this.btnKategoriEkle.TabIndex = 4;
            this.btnKategoriEkle.Text = "KATEGORİ EKLE";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnFilmAra
            // 
            this.btnFilmAra.Location = new System.Drawing.Point(449, 45);
            this.btnFilmAra.Name = "btnFilmAra";
            this.btnFilmAra.Size = new System.Drawing.Size(97, 69);
            this.btnFilmAra.TabIndex = 5;
            this.btnFilmAra.Text = "FİLM ARA";
            this.btnFilmAra.UseVisualStyleBackColor = true;
            this.btnFilmAra.Click += new System.EventHandler(this.btnFilmAra_Click);
            // 
            // btnBulSil
            // 
            this.btnBulSil.Location = new System.Drawing.Point(552, 45);
            this.btnBulSil.Name = "btnBulSil";
            this.btnBulSil.Size = new System.Drawing.Size(97, 69);
            this.btnBulSil.TabIndex = 6;
            this.btnBulSil.Text = "BUL VE SİL";
            this.btnBulSil.UseVisualStyleBackColor = true;
            this.btnBulSil.Click += new System.EventHandler(this.btnBulSil_Click);
            // 
            // btnBulGuncelle
            // 
            this.btnBulGuncelle.Location = new System.Drawing.Point(655, 45);
            this.btnBulGuncelle.Name = "btnBulGuncelle";
            this.btnBulGuncelle.Size = new System.Drawing.Size(97, 69);
            this.btnBulGuncelle.TabIndex = 7;
            this.btnBulGuncelle.Text = "BUL VE GÜNCELLE";
            this.btnBulGuncelle.UseVisualStyleBackColor = true;
            this.btnBulGuncelle.Click += new System.EventHandler(this.btnBulGuncelle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "ARA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 435);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBulGuncelle);
            this.Controls.Add(this.btnBulSil);
            this.Controls.Add(this.btnFilmAra);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.btnEager);
            this.Controls.Add(this.btnLazy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLazy;
        private System.Windows.Forms.Button btnEager;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnFilmAra;
        private System.Windows.Forms.Button btnBulSil;
        private System.Windows.Forms.Button btnBulGuncelle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

