using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Timers;
using System.Data;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using Updater;
using Microsoft.Web.WebView2.Core;
using WMPLib;
using System.Runtime.InteropServices;

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
            //FirstBootWBV();
        }

        private void Download_Start_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["TosAccepted"] = true;
            Properties.Settings.Default.Save();
            End_FB_Click();
        }

        void FirstBootWBV()
        {
            var wbv = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SMPbeta", "bin", "WBV.bin");
            var wbvApp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SMPbeta", "Req", "MicrosoftEdgeWebview2Setup.exe");

            string info = string.Format("{0}",
              wbv);

            if (File.Exists(wbv))
            {
                Process.Start(wbvApp);
                File.Delete(wbv);
                System.Windows.MessageBox.Show("The launcher will now close for settings to take effect! You can reopen the launcher after this message!");
                System.Windows.Forms.Application.Exit();
                System.Environment.Exit(1);
            }
            else
            {
                //Do Nothing
            }
        }

        private void End_FB_Click()
        {
            var PSetup = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Max Rook (MexiMux)", "SMPbeta Launcher", "Content", "Res Installer.msi");
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(PSetup)
            {
                UseShellExecute = true
            };

            var delProfiles = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "launcher_profiles.json");

            if (File.Exists(delProfiles))
            {
                File.Delete(delProfiles);
            }
            else
            {
                //Do Nothing
            }

            if (File.Exists(PSetup))
            {
                System.Windows.MessageBox.Show("Please complete the setup process that will pop up to install all of the needed resources. To proceed press 'OK'");
                p.Start();
                //Process.Start(PSetup);
                System.Windows.MessageBox.Show("The launcher will now close for settings to take effect! You can reopen the launcher after this message!");
                System.Windows.Forms.Application.Exit();
                System.Environment.Exit(1);
            }
            else
            {
                //Do Nothing
            }

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ServerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitServerLink();
            }
            catch (Exception ex)
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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
