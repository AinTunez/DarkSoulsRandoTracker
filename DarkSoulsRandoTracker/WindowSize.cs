using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSItemTracker
{
    public partial class WindowSize : Form
    {
        private GUI gui;

        public WindowSize(GUI g)
        {
            InitializeComponent();
            gui = g;
            widthUpDown.Value = gui.Width;
            heightUpDown.Value = gui.Height;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            gui.Width = (int) widthUpDown.Value;
            gui.Height = (int) heightUpDown.Value;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
