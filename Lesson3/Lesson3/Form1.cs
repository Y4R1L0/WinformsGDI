using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int k = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            k++;  
            toolStripStatusLabel1.Text= $"Steps: {k}";
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
