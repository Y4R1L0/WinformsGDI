using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lesson4
{
    public partial class Form1 : Form
    {   
            Child child = null;
        public String InfoP
        {
            set
            {
                textBox1.Text = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
        } 
        private void Form1_Load(object sender, EventArgs e)
        {
            child = new Child(this);
            child.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            child.Info = textBox1.Text;
        } 
    }
} 
