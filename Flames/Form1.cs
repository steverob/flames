using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlamesClass;

namespace Flames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox3.Text = "";
            this.textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text.Length == 0) || (this.textBox2.Text.Length == 0))
            {
                MessageBox.Show("Please Complete both Fields!");
            }
            else if (this.textBox1.Text == this.textBox2.Text)
            {
                MessageBox.Show("Please Enter Different Names!");
                button1_Click(sender, e);
            }
            else
            {
                flames_class flames = new flames_class(this.textBox1.Text, this.textBox2.Text);
                this.textBox3.Text = flames.FlamesMain();
            }
            
        }
    }
}
