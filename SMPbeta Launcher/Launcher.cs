//Programmed in C#
//For more information visit: https://maxrook.nl/server

using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using Updater;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using SMPbeta_Launcher.FirstBoot;

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
            KillDup();
            TrayMenuContext();

            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            this.TransparencyKey = Color.Empty;

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"MRO");
            key.SetValue("SMPbetaInstalled", "true");
            key.SetValue("Version", version);
            key.Close();

            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(10);

            var timer = new System.Threading.Timer((e) =>
            {
                doUpdate();
            }, null, startTimeSpan, periodTimeSpan);
        }

        void KillDup()
        {
            Process process = Process.GetCurrentProcess();
            var dupl = (Process.GetProcessesByName(process.ProcessName));
            if (dupl.Length > 1)
            {
                foreach (var p in dupl)
                {
                    if (p.Id != process.Id)
                        p.Kill();
                }
            }
        }

        private void doUpdate()
        {
            //Gets raw data from the project
            System.Net.WebClient wc = new System.Net.WebClient();

            //Using this in a try/catch so the program won't crash if there is no internet.
            byte[] raw = wc.DownloadData("https://raw.githubusercontent.com/MexiMoo/SMPbeta-Launcher/master/SMPbeta%20Launcher/SMPbeta%20Launcher.csproj");

            string webData = System.Text.Encoding.UTF8.GetString(raw);

            //Extracts one line
            string GetLine(string text, int lineNo)
            {
                string[] lines = text.Replace("\r", "").Split('\n');
                return lines.Length >= lineNo ? lines[lineNo - 1] : null;
            }

            //Filters out the junk
            int startPos = webData.LastIndexOf("    <Version>") + "    <Version>".Length;
            int length = webData.IndexOf("</Version>") - startPos;
            string onlineAppVersion = webData.Substring(startPos, length);

            //Will ry to receive data from the app that is stored
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"MRO");
            if (key != null)
            {
                var AppIsInstalled = key.GetValue("SMPbetaInstalled");
                var AppVersion = key.GetValue("Version");
                key.Close();

                //Removes unused revision number from version
                string appVersionLocalRaw = (string)AppVersion.ToString();
                string appVersionLocal = appVersionLocalRaw.Remove(appVersionLocalRaw.Length - 2);

                //Compares the versions
                if (appVersionLocal != onlineAppVersion)
                {
                    InstallUpdater IU = new InstallUpdater();
                    IU.ShowDialog();
                }
                else
                {
                    //Do nothing
                }
            }
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
            if(Properties.Settings.Default.TosAccepted == false)
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
            Nav.Visible = true;
            NavInfo.Visible = false;
            Nav.Height = News.Height;
            Nav.Top = News.Top;
            Nav.Left = News.Left;
            News.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Profile1_Click(object sender, EventArgs e)
        {
            Nav.Visible = true;
            NavInfo.Visible = false;
            Nav.Height = Profile1.Height;
            Nav.Top = Profile1.Top;
            Nav.Left = Profile1.Left;
            OpenChildForm(new Profile_1(), sender);
            Profile1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Profile2_Click(object sender, EventArgs e)
        {
            Nav.Visible = true;
            NavInfo.Visible = false;
            Nav.Height = Profile2.Height;
            Nav.Top = Profile2.Top;
            Nav.Left = Profile2.Left;
            OpenChildForm(new Profile_2(), sender);
            Profile2.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Profile3_Click(object sender, EventArgs e)
        {
            Nav.Visible = true;
            NavInfo.Visible = false;
            Nav.Height = Profile3.Height;
            Nav.Top = Profile3.Top;
            Nav.Left = Profile3.Left;
            OpenChildForm(new Profile_3(), sender);
            Profile3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Nav.Visible = true;
            NavInfo.Visible = false;
            Nav.Height = Settings.Height;
            Nav.Top = Settings.Top;
            Nav.Left = Settings.Left;
            OpenChildForm(new Settings(), sender);
            Settings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Info_Click_1(object sender, EventArgs e)
        {
            NavInfo.Visible = true;
            Nav.Visible = false;
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
            if (Properties.Settings.Default.RunBG == false)
            {
                Environment.Exit(0);
            }
            else
            {
                this.Hide();
                Hidden();
                TrayMenuContext();
            }
            
        }

        void Hidden()
        {
            if (Properties.Settings.Default.BgMessage == true)
            {
                Notify_Icon.BalloonTipText = "SMPbeta has closed! It will be running in the background to check for updates.";
                Notify_Icon.ShowBalloonTip(1000);
            }
        }

        private void TrayMenuContext()
        {
            this.Notify_Icon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.Notify_Icon.ContextMenuStrip.Items.Add("Search for update", null, (s, e) => MessageBox.Show("This update is auto-enabled. The app will alway's search for an update."));
            this.Notify_Icon.ContextMenuStrip.Items.Add("Website", null, Website_Open_Click);
            this.Notify_Icon.ContextMenuStrip.Items.Add("Exit", null, (s, e) => Environment.Exit(0));
        }

        private void Website_Open_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://maxrook.nl/",
                UseShellExecute = true
            });
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
    }
}
