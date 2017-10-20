using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockX
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbl_version.Text += Application.ProductVersion;

            foreach (var screen in Screen.AllScreens)
            {
                cbx_screens.Items.Add($"{screen.DeviceName} ({screen.Bounds.Width} x{screen.Bounds.Height})");
            }
            cbx_screens.SelectedIndex = 0;

            Lock(Screen.PrimaryScreen.Bounds, true);
        }

        private async void Lock(Rectangle bounds, bool first = false)
        {
            // Clip Cursor
            if (first)
                await Task.Delay(100);

            Cursor.Clip = bounds;

            // Move Form
            var location = Screen.AllScreens[cbx_screens.SelectedIndex].WorkingArea.Location;
            var area = Screen.AllScreens[cbx_screens.SelectedIndex].WorkingArea;
            this.Location = new Point((area.Width - this.Width) / 2 + location.X, (area.Height - this.Height) / 2 + location.Y);
        }

        private void cbx_screens_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lock(Screen.AllScreens[cbx_screens.SelectedIndex].Bounds);
        }

        private void lbl_made_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl_made.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/MisterX2000/LockX");
        }
    }
}
