//Programmed in C# and C++
//For more information visit: https://maxrook.nl/server

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Timers;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using Updater;
using System.Runtime.InteropServices;

namespace SMPbeta_Launcher
{
    public partial class Launcher : Form, IUpdater
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        private Form activeForm;

        public Launcher()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            ExtNews();
            FirstBoot();

            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            this.TransparencyKey = Color.Empty;
        }

        #region Updater
        public string ApplicationName
        {
            get { return "SMPbeta Launcher"; }
        }

        public string ApplicationID
        {
            get { return "SMPbeta Launcher"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("https://maxrook.nl/server/launcher/update/update.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }
        #endregion

        void FirstBoot()
        {
            var FS = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SMPbeta", "bin", "FB.bin");

            string info = string.Format("{0}",
              FS);

            if (File.Exists(FS))
            {
                using (FirstSetup Fs = new FirstSetup())
                {
                    if (Fs.ShowDialog() == DialogResult.OK)
                    {
                        this.WindowState = FormWindowState.Maximized;
                    }
                }
            }
            else
            {
                //Do Nothing
            }
        }

        private void News_Click(object sender, EventArgs e)
        {
            ExtNews();
            OpenChildForm(new News(), sender);
        }

        private void ExtNews()
        {
            Nav.Height = News.Height;
            Nav.Top = News.Top;
            Nav.Left = News.Left;
            News.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Profile1_Click(object sender, EventArgs e)
        {
            Nav.Height = Profile1.Height;
            Nav.Top = Profile1.Top;
            Nav.Left = Profile1.Left;
            OpenChildForm(new Profile_1(), sender);
            Profile1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Profile2_Click(object sender, EventArgs e)
        {
            Nav.Height = Profile2.Height;
            Nav.Top = Profile2.Top;
            Nav.Left = Profile2.Left;
            OpenChildForm(new Profile_2(), sender);
            Profile2.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Profile3_Click(object sender, EventArgs e)
        {
            Nav.Height = Profile3.Height;
            Nav.Top = Profile3.Top;
            Nav.Left = Profile3.Left;
            OpenChildForm(new Profile_3(), sender);
            Profile3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Nav.Height = Settings.Height;
            Nav.Top = Settings.Top;
            Nav.Left = Settings.Left;
            OpenChildForm(new Settings(), sender);
            Settings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Info_Click_1(object sender, EventArgs e)
        {
            Nav.Height = Info.Height;
            Nav.Top = Info.Top;
            Nav.Left = Info.Left;
            OpenChildForm(new Info(), sender);
            Info.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void News_Leave(object sender, EventArgs e)
        {
            News.BackColor = Color.FromArgb(37, 37, 37);
        }

        private void Profile1_Leave(object sender, EventArgs e)
        {
            Profile1.BackColor = Color.FromArgb(37, 37, 37);
        }

        private void Profile2_Leave(object sender, EventArgs e)
        {
            Profile2.BackColor = Color.FromArgb(37, 37, 37);
        }

        private void Profile3_Leave(object sender, EventArgs e)
        {
            Profile3.BackColor = Color.FromArgb(37, 37, 37);
        }

        private void Settings_Leave(object sender, EventArgs e)
        {
            Settings.BackColor = Color.FromArgb(37, 37, 37);
        }

        private void Info_Leave_1(object sender, EventArgs e)
        {
            Info.BackColor = Color.FromArgb(37, 37, 37);
        }

        private void Close_MouseClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ChildPanel.Controls.Add(childForm);
            this.ChildPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ChildPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
