using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boolean
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.DimGray;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.FromArgb(64,64,64);
        }
    }
}
