﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CF_DF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVeriGetir_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            dataGridView1.DataSource = model.Kitaplar.ToList();
        }
    }
}
