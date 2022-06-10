using System;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace SMPbeta_Launcher
{
    public partial class FirstSetup : Form
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

        public FirstSetup()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"MRO");  
            key.SetValue("SMPbetaInstalled", "true");
            key.SetValue("Version", version);
            key.Close();
        }

        private void Download_Start_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["TosAccepted"] = true;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void To_2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void To_3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void ServerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitServerLink();
            }
            catch
            {
                System.Windows.MessageBox.Show("Can't open link!                                                                                                  Please copy the link and paste it into your browser to visit it!");
            }
        }

        private void VisitServerLink()
        {
            ServerLink.LinkVisited = true;
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://maxrook.nl/server",
                UseShellExecute = true
            });
        }

        private void Full_ToS_Click(object sender, EventArgs e)
        {
            ToS terms = new ToS();
            terms.TopMost = true;
            terms.Show();
        }

        private void ToS_NL_Click(object sender, EventArgs e)
        {
            ToS_S_NL termsSnl = new ToS_S_NL();
            termsSnl.TopMost = true;
            termsSnl.Show();
        }
    }
}
