using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Diagnostics;

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
            var installL = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SMPbeta", "Update", "SMPbeta.Installer.msi");

            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("https://github.com/MexiMoo/SMPbeta-Launcher/releases/latest/download/SMPbeta.Installer.msi"), @installL);
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
                //Properties.Settings.Default["DownloadAbort"] = true;
                //Properties.Settings.Default.Save();
            }
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {

            this.BeginInvoke((MethodInvoker)delegate {
                Status.Text = "Completed";
                try
                {
                    var installL = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SMPbeta", "Update", "SMPbeta.Installer.msi");
                    this.Close();
                    Process installerProcess = new Process();
                    ProcessStartInfo processInfo = new ProcessStartInfo();
                    processInfo.Arguments = "/i " + installL;
                    processInfo.FileName = "msiexec";
                    processInfo.UseShellExecute = true;
                    processInfo.Verb = "runas";
                    installerProcess.StartInfo = processInfo;
                    installerProcess.Start();
                    installerProcess.WaitForExit();
                    File.Delete(@installL);

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
