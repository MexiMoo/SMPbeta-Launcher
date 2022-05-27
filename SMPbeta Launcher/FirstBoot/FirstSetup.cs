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
using Microsoft.Win32;
using SMPbeta_Launcher.FirstBoot;

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
            //FirstBootWBV();
        }

        private void Download_Start_Click(object sender, EventArgs e)
        {


            Properties.Settings.Default["TosAccepted"] = true;
            Properties.Settings.Default.Save();

            //Will try to receive data from the app that is stored
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"MRO");
            if (key != null)
            {
                var UpI = key.GetValue("UpdaterInstalled");
                key.Close();

                if (UpI != null)
                {
                    //Do Nothing
                }
                else
                {
                    InstallUpdater IU = new InstallUpdater();
                    IU.ShowDialog();
                }
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
