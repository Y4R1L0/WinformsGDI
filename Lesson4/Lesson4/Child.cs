using System;
using System.Windows.Forms;

namespace Lesson4
{

    public partial class Child : Form
    {
        public Form1 f = null;
        public Child(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void Child_Load(object sender, EventArgs e)
        {

        }
            public String Info{
                set
                {
                textBox2.Text = value;
                }
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            f.InfoP=textBox2.Text;
        }
    }
}
