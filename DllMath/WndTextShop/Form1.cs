using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDK;

namespace WndTextShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, ISDK> efektler = new Dictionary<string, ISDK>();

        private void btn_uygula_Click(object sender, EventArgs e)
        {
            ISDK efekt = efektler[lstEfektler.SelectedItem.ToString()];
            lblSonuc.Text = efekt.Islem(txtMesaj.Text);
                   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string dosya in Directory.GetFiles(@"C:\Users\303TUGBA_SABAH\source\repos\DllMath\WndTextShop\bin\Debug\Plugin"))
            {   //MessageBox.Show(dosya);
                Assembly asm = Assembly.LoadFrom(dosya);//dosyaları ram 
                foreach (Type type in asm.GetTypes())
                {
                    // MessageBox.Show(type.Name);

                    object obj = Activator.CreateInstance(type);//
                    ISDK efekt = (ISDK)obj;
                    efektler.Add(efekt.EklentiAdi, efekt);
                    lstEfektler.Items.Add(efekt.EklentiAdi);
                }
    }
        }


    }
}
