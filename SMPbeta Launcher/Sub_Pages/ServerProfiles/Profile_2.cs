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
using System.IO.Compression;
using System.Net;
using System.Diagnostics;
using Updater;
using Microsoft.Web.WebView2.Core;
using System.Drawing.Drawing2D;

namespace SMPbeta_Launcher
{
    public partial class Profile_2 : Form
    {
        public Profile_2()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var launch = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Minecraft Launcher", "MinecraftLauncher.exe");
            var installed = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "mods", "SMPbeta", "InstalledNEW.bin");
            var serverFiles = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Max Rook (MexiMux)", "SMPbeta Launcher", "Content", "Install Modded New.msi");

            var i = new Process();
            i.StartInfo = new ProcessStartInfo(serverFiles)
            {
                UseShellExecute = true
            };

            if (File.Exists(serverFiles))
            {
                if (File.Exists(installed))
                {
                    Process.Start(launch);
                    System.Windows.Forms.Application.Exit();
                    System.Environment.Exit(1);
                }
                else
                {
                    i.Start();
                    MessageBox.Show("When the installer is done installing, press ok.", "Installing Mods...");
                    Process.Start(launch);
                    System.Windows.Forms.Application.Exit();
                    System.Environment.Exit(1);
                }
            }
            else
            {
                //Do Nothing
            }
        }

        private void Info_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server is running correctly!", "Server Info");
        }

        private void Info_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server is running correctly!", "Server Info");
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startLoad()
        {
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_LoadCompleted);
                client.DownloadFileAsync(new Uri("https://maxrook.nl/wp-content/uploads/2022/01/Installer.7z.001"), @"C:\bin\");
            });
            thread.Start();
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                Info_Label.Text = "Loaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
                Load.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void client_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                Info_Label.Text = "Completed Loading";
                Load.Style = ProgressBarStyle.Marquee;
                Load.MarqueeAnimationSpeed = 1;
            });
        }

        async Task PutTaskDelay()
        {
            await Task.Delay(5000);
        }

        async Task FailedDelay()
        {
            await Task.Delay(500);
        }

        private async void Start_Click_2(object sender, EventArgs e)
        {
            Load.Style = ProgressBarStyle.Marquee;
            Load.MarqueeAnimationSpeed = 1;
            Start.Enabled = false;
            Info_Label.Text = "Loading...";
            await PutTaskDelay();
            startLoad();
            await PutTaskDelay();
            LoadVersion();
            Environment.Exit(0);
        }

        void LoadVersion()
        {
            var installedmods = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SMPbeta", "profiles.dump", "1.18.x modded");
            var installed = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SMPbeta", "profiles.dump", "1.18.x modded", "Installed.bin");

            var dataPathMods = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "mods");
            var dataPathConfig = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "config");
            var dataPathSaves = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "saves");

            var installedC = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SMPbeta", "profiles.dump", "1.18.x modded", "config");
            var installedM = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SMPbeta", "profiles.dump", "1.18.x modded", "mods");
            var installedS = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SMPbeta", "profiles.dump", "1.18.x modded", "saves");


            string dataPathModsstr = string.Format("{0}",
              dataPathMods);

            if (File.Exists(installed))
            {
                //Mods Folder
                DirectoryInfo old = new DirectoryInfo(@dataPathMods);
                FileInfo[] filesold = old.GetFiles();
                foreach (FileInfo file in filesold)
                {
                    file.Delete();
                }

                foreach (string dirPath in Directory.GetDirectories(installedM, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(installedM, dataPathMods));
                }

                DirectoryInfo NewM = new DirectoryInfo(@installedM);
                FileInfo[] filesnewM = NewM.GetFiles();
                foreach (string Path in Directory.GetFiles(installedM, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(Path, Path.Replace(installedM, dataPathMods), true);
                }


                //Config Folder
                foreach (string dirPath in Directory.GetDirectories(installedC, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(installedC, dataPathConfig));
                }

                DirectoryInfo NewC = new DirectoryInfo(@installedC);
                FileInfo[] filesnewC = NewC.GetFiles();
                foreach (string Path in Directory.GetFiles(installedC, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(Path, Path.Replace(installedC, dataPathConfig), true);
                }

                //Saves Folder
                foreach (string dirPath in Directory.GetDirectories(installedS, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(installedS, dataPathSaves));
                }

                DirectoryInfo NewS = new DirectoryInfo(@installedS);
                FileInfo[] filesnewS = NewS.GetFiles();
                foreach (string Path in Directory.GetFiles(installedS, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(Path, Path.Replace(installedS, dataPathSaves), true);
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

        private void label6_Click(object sender, EventArgs e)
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
