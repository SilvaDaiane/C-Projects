using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DublinBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dbTextBox1__TextChanged(object sender, EventArgs e)
        {

           
        }

        private void dbTextBox2__TextChanged(object sender, EventArgs e)
        {
            //if () ;
        }

        private void dbButton1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dbButton1_Click(object sender, EventArgs e)
        {

        }

        private void LklSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Process.Start("https://www.google.com/maps"); it works for a website.
          
            new Signup().Show();
        }
    }
}
