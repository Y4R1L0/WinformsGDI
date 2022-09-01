using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int counter; 
        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            button1.Text = counter.ToString(); 
            Random rnd = new Random(); 
            int numX = rnd.Next(700);
            int numY = rnd.Next(400);
            button1.Location = new Point(numX, numY);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
        Button b =sender as Button;
            button1.BackColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;
            button1.BackColor = Color.Blue; 
        }
    }
}
