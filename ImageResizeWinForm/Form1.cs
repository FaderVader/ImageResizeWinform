using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResizeWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetDefaultValues();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ProcessFolder(txtSourceFolder.Text, txtDestinationFolder.Text, (int)nudHeigth.Value);
        }

        private void SetDefaultValues()
        {
            txtSourceFolder.Text = Properties.Settings.Default.DefaultSourcePath;
            txtDestinationFolder.Text = Properties.Settings.Default.DefaultSavePath;
            nudHeigth.Value = Properties.Settings.Default.DefaultHeight;
        }
    }
}
