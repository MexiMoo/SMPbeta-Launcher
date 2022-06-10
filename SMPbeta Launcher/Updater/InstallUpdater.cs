using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SMPbeta_Launcher.FirstBoot
{
    public partial class InstallUpdater : Form
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

        public InstallUpdater()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            loadInfo();
        }

        public void loadInfo()
        {
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            //Gets raw data from the project
            System.Net.WebClient wc = new System.Net.WebClient();

            //Using this in a <try/catch> so the program won't crash if there is no internet.
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

            oldVersion.Text = version.Remove(version.Length - 2);
            newVersion.Text = onlineAppVersion;
        }

        private void nVersionRN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/MexiMoo/SMPbeta-Launcher/releases/latest",
                UseShellExecute = true
            });
        }

        private void installYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UD = new UDownloader();
            UD.Closed += (s, args) => this.Close();
            UD.ShowDialog();
        }

        private void installNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
