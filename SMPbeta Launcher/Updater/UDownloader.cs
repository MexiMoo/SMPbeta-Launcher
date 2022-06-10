using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;

namespace SMPbeta_Launcher.FirstBoot
{
    public partial class UDownloader : Form
    {
        public UDownloader()
        {
            InitializeComponent();
            startDownload();
        }

        private void startDownload()
        {
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("https://github.com/MexiMoo/SMPbeta-Launcher/releases/latest/download/SMPbeta.Installer.msi"), @"SMPbeta.Installer.msi");
            });
            thread.Start();
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                this.BeginInvoke((MethodInvoker)delegate {
                    double bytesIn = double.Parse(e.BytesReceived.ToString());
                    double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                    double percentage = bytesIn / totalBytes * 100;
                    double MBR = e.BytesReceived / 1000000;
                    double MBTR = e.TotalBytesToReceive / 1000000;
                    Status.Text = "Downloaded " + MBR + "MB" + " of " + MBTR + "MB";
                    progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
                });
            }
            catch (Exception ex)
            {
                Properties.Settings.Default["DownloadAbort"] = true;
                Properties.Settings.Default.Save();
            }
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                Status.Text = "Completed";
                try
                {
                    var dataPathMods = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "test", "SMPbeta.Installer.msi");
                    System.Diagnostics.Process.Start(dataPathMods);
                    //System.Diagnostics.Process.Start("SMPbeta.Installer.msi");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("The update could not be installed. If you want to install this update, please visit the github page of the installer.");
                    this.Close();
                }
            });
        }
    }
}
