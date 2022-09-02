using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateButtons();
        } 
        Random random = new Random();
        Int32 M = 5;
        Int32 N = 5;
        Int32 x = 50;
        Int32 y = 10;

        private void CreateButtons()
        {
            for (Int32 i = 0; i < M; i++)
            {
                for (Int32 j = 0; j < N; j++)
                {

                    var button = new Button();
                    button.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    button.Location = new Point(i * x + i * y, j * x + j * y);
                    button.Size = new Size(x, x);
                    button.Text = ((i + 1) * (j + 1)).ToString();
                    button.Click += new EventHandler(ButtonRemove);
                    this.Controls.Add(button);
                }
            }
        }
        private void ButtonRemove(object sender, EventArgs e)
        {
            Controls.Remove((Button)sender);
        }

    }
}
