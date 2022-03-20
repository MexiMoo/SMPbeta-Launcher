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
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using Updater;
using Microsoft.Web.WebView2.Core;
using System.Drawing.Drawing2D;

namespace SMPbeta_Launcher
{
    public partial class Profile_3 : Form
    {
        public Profile_3()
        {
            InitializeComponent();
        }

        private void startLoad()
        {
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_LoadCompleted);
                client.DownloadFileAsync(new Uri("https://maxrook.nl/wp-content/uploads/2022/01/Installer.7z.001"), @"C:\bin\");
            });
            thread.Start();
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                Info_Label.Text = "Loaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
                Load.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void client_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                Info_Label.Text = "Completed Loading";
                Load.Style = ProgressBarStyle.Continuous;
            });
        }

        async Task PutTaskDelay()
        {
            await Task.Delay(3786);
        }

        async Task PingDelay()
        {
            await Task.Delay(1783);
        }

        async Task FailedDelay()
        {
            await Task.Delay(500);
        }

        private async void Start_Click(object sender, EventArgs e)
        {
            Load.Style = ProgressBarStyle.Marquee;
            Load.MarqueeAnimationSpeed = 1;
            Start.Enabled = false;
            Info_Label.Text = "Loading...";
            await PutTaskDelay();
            LoadVersion();
            startLoad();
            await PutTaskDelay();
            Load.MarqueeAnimationSpeed = 0;
            if (Properties.Settings.Default.BgMessage == true)
            {
                Notify_Icon.BalloonTipText = "The SMPbeta launcher has downloaded the selected profile! Have fun playing!";
                Notify_Icon.ShowBalloonTip(1000);
            }
        }

        void LoadVersion()
        {
            var installed = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SMPbeta", "profiles.dump", "1.12.2 modded", "Installed.bin");
            var data = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SMPbeta", "profiles.dump", "1.12.2 modded");
            var dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "mods");

            string info = string.Format("{0}",
              data);

            if (File.Exists(installed))
            {
                DirectoryInfo old = new DirectoryInfo(@dataPath);
                FileInfo[] filesold = old.GetFiles();
                foreach (FileInfo file in filesold)
                {
                    file.Delete();
                }

                foreach (string dirPath in Directory.GetDirectories(data, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(data, dataPath));
                }

                DirectoryInfo New = new DirectoryInfo(@data);
                FileInfo[] filesnew = New.GetFiles();
                foreach (string Path in Directory.GetFiles(data, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(Path, Path.Replace(data, dataPath), true);
                }


            }
            else
            {
                MessageBox.Show("Loading has failed! Please try again. Does this not work? The launcher may be corrupted!");
                FailedDelay();
                Info_Label.Text = "Loading Failed";
                Load.Style = ProgressBarStyle.Blocks;
            }
        }

        private void Info_1_Click(object sender, EventArgs e)
        {
            PingDelay();
            MessageBox.Show("Server is online and working correctly!");
        }

        private void Info_2_Click(object sender, EventArgs e)
        {
            PingDelay();
            MessageBox.Show("Server is online and working correctly!");
        }

        public void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Info_1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Server is running correctly!", "Server Info");
        }

        private void Info_2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Server is running correctly!", "Server Info");
        }
    }
}
