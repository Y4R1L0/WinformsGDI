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
        private Int32 counter; 
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            counter++;
            button1.Text = counter.ToString(); 
            Random rnd = new Random();
            Int32 numX = rnd.Next(300);
            Int32 numY = rnd.Next(100);
            button1.Location = new Point(numX, numY);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button b = sender as Button;
            button1.BackColor = Color.Yellow;
        }
        private Int32 counter2;
        Int32 X, Y, X2, Y2;
        Button MakeButton;
        Boolean buttonReleased = true;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!buttonReleased)
            {

                if (MakeButton != null)
                {
                    var newLocationX = 0;
                    var newLocationY = 0;
                    if (e.X - X2 > 0)
                    {
                        X = e.X - X2;
                        newLocationX = X2;
                    }
                    else
                    {
                        newLocationX = e.X;
                        X = Math.Abs(X2 - e.X);
                    }
                    if (e.Y - Y2 > 0)
                    {
                        Y = e.Y - Y2;
                        newLocationY = Y2;
                    }
                    else
                    {
                        newLocationY = e.Y;
                        Y = Math.Abs(Y2 - e.Y);
                    }
                    MakeButton.Size = new Size(X, Y);
                    MakeButton.Location = new Point(newLocationX, newLocationY);
                }
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            X = 0;
            Y = 0;
            X2 = e.X;
            Y2 = e.Y;

            buttonReleased = false;
            MakeButton = new Button
            {
                Location = new Point(X2, Y2),
                Size = new Size(X, Y)
            };
            this.Controls.Add(MakeButton);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            buttonReleased = true;
            counter2++;
            MakeButton.Text = counter2.ToString();
        }
    }
}
