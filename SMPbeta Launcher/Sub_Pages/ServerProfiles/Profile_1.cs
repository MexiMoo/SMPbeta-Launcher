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
using System.Runtime.InteropServices;

namespace SMPbeta_Launcher
{
    public partial class Profile_1 : Form
    {
        public Profile_1()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private void Launch_Click()
        {
            var launch = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Minecraft Launcher", "MinecraftLauncher.exe");

            if (File.Exists(launch))
            {
                Process.Start(launch);
                System.Windows.Forms.Application.Exit();
                System.Environment.Exit(1);
            }
            else
            {
                //Do Nothing
            }
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
                Load.Style = ProgressBarStyle.Marquee;
                Load.MarqueeAnimationSpeed = 1;
            });
        }

        async Task PutTaskDelay()
        {
            await Task.Delay(5000);
        }

        private async void Start_Click_1(object sender, EventArgs e)
        {
            Load.Style = ProgressBarStyle.Marquee;
            Start.Enabled = true;
            Load.MarqueeAnimationSpeed = 1;
            Info_Label.Text = "Loading...";
            await PutTaskDelay();
            startLoad();
            await PutTaskDelay();
            Load.MarqueeAnimationSpeed = 0;
            Start.Enabled = false;
            if (Properties.Settings.Default.BgMessage == true)
            {
                Notify_Icon.BalloonTipText = "The SMPbeta launcher has downloaded the selected profile! Have fun playing!";
                Notify_Icon.ShowBalloonTip(1000);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BG1_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            if (Properties.Settings.Default.BgMessage == true)
            {
                Notify_Icon.BalloonTipText = "The SMPbeta launcher has downloaded the selected profile! Have fun playing!";
                Notify_Icon.ShowBalloonTip(1000);
            }

            var ol = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Minecraft Launcher", "MinecraftLauncher.exe");

            panel1.Visible = false;
            BG1.Visible = false;

            Process proc = Process.Start(ol);
            proc.WaitForInputIdle();

            while (proc.MainWindowHandle == IntPtr.Zero)
            {
                Thread.Sleep(100);
                proc.Refresh();
            }

            SetParent(proc.MainWindowHandle, this.Handle);

            if (proc.HasExited)
            {
                this.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server is offline!", "Server Info");
        }

        private void Info_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server is running correctly!", "Server Info");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server is running correctly!", "Server Info");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server is running correctly!", "Server Info");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server is running correctly!", "Server Info");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server is running correctly!", "Server Info");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server is running correctly!", "Server Info");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server is running correctly!", "Server Info");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
