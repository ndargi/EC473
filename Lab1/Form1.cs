﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void painter(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Nicholas Michael Dargi", Font, Brushes.Black, 100, 100);
        }
    }
}
