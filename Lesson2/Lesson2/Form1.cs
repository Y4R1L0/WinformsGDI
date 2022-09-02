using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Form1 : Form
    {
        DateTime timeStarted; 
        public Form1()
        {
            InitializeComponent(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timeStarted = DateTime.Now; 
        } 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            Point? newLocation = null;
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                newLocation = new Point(this.Location.X, this.Location.Y + 25);
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                newLocation = new Point(this.Location.X - 25, this.Location.Y);
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                newLocation = new Point(this.Location.X, this.Location.Y - 25);
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                newLocation = new Point(this.Location.X + 25, this.Location.Y);
            }
            if (newLocation != null)
            {
                if (Screen.PrimaryScreen.Bounds.Contains(new Rectangle(newLocation.Value, this.Size)))
                {
                    this.Location = newLocation.Value;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = (DateTime.Now - timeStarted).ToString();
        }

    } 
}
