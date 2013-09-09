using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathEditor
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string sourceName = "Default.html";
            string destName = "Current.html";
            string sourceFile = System.IO.Path.Combine(Application.StartupPath, sourceName);
            string destFile = System.IO.Path.Combine(Application.StartupPath, destName);
            System.IO.File.Copy(sourceFile, destFile, true);
            webBrowser1.Navigate(destFile);
        }

        private void mnuFullscreen_Click(object sender, EventArgs e)
        {
            if (TopMost == true)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
                mnuFullscreen.Checked = false;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                TopMost = true;
                mnuFullscreen.Checked = true;
            }
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
                mnuFullscreen.Checked = false;
            }
            else if (e.KeyCode == Keys.F11)
            {
                if (TopMost == true)
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                    TopMost = false;
                    mnuFullscreen.Checked = false;
                }
                else
                {
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    TopMost = true;
                    mnuFullscreen.Checked = true;
                }
            }
        }
    }
}
