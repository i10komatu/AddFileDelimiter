﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AddFileDelimiter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                string text;
                text = Regex.Replace(textBox1.Text, "\"", "");
                text = Regex.Replace(text, @"\\", @"\\");
                Clipboard.SetText(text);
            }
            this.Close();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
    }
}
