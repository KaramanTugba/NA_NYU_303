using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahibinden_Form
{
    public partial class Admin_AnaSayfa : Form
    {
        public Admin_AnaSayfa()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void btn_1_uye_ekleme_Click(object sender, EventArgs e)
        {
            Admin_UyeEkleme UyeEkleme = new Admin_UyeEkleme();
            UyeEkleme.MdiParent = this;
            UyeEkleme.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_UyeSilme UyeSilme = new Admin_UyeSilme();
            UyeSilme.MdiParent = this;
            UyeSilme.Show();
        }
    }
}
