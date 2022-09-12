using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfiniteMenu
{
    public partial class Form1 : Form
    {
        int stripCounter = 1;

        public Form1()
        {
            InitializeComponent();  
            var newItem = new ToolStripMenuItem();
            newItem.Name = stripCounter.ToString();
            newItem.Text = stripCounter.ToString();
            newItem.MouseHover += MHoover;
            toolStripMenuItem1.DropDownItems.Add(newItem);
        }

        void MHoover(object s, EventArgs e)
        {
            var newSubItem = new ToolStripMenuItem();
            newSubItem.Name = stripCounter.ToString();
            newSubItem.Text = stripCounter.ToString();
            newSubItem.Width = 10;
            var sender = s as ToolStripMenuItem;
            stripCounter++;
            newSubItem.MouseHover += MHoover;
            sender.DropDownItems.Add(newSubItem);
        }

    }
}
