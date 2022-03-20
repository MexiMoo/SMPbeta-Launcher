﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Updater
{
    public class Updater
    {
        private IUpdater applicationInfo;
        private BackgroundWorker bgWorker;

        public Updater(IUpdater applicationInfo)
        {
            this.applicationInfo = applicationInfo;

            this.bgWorker = new BackgroundWorker();
            this.bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
        }

        public void DoUpdate()
        {
            if (!this.bgWorker.IsBusy)
                this.bgWorker.RunWorkerAsync(this.applicationInfo);
        }

        public void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            IUpdater application = (IUpdater)e.Argument;

            if (!UpdaterXml.ExistsOnServer(application.UpdateXmlLocation))
                e.Cancel = true;
            else
                e.Result = UpdaterXml.Parse(application.UpdateXmlLocation, application.ApplicationID);
        }

        public void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                UpdaterXml update = (UpdaterXml)e.Result;

                if (update != null && update.IsNewerThan(this.applicationInfo.ApplicationAssembly.GetName().Version))
                {
                    if (new Update_Notifier(this.applicationInfo, update).ShowDialog(this.applicationInfo.Context) == DialogResult.Yes)
                        this.DownloadUpdate(update);
                }
            }
        }

        private void DownloadUpdate(UpdaterXml update)
        {
            UpdateDownloader form = new UpdateDownloader(update.Uri, update.MD5, this.applicationInfo.ApplicationIcon);
            DialogResult result = form.ShowDialog(this.applicationInfo.Context);

            if (result == DialogResult.OK)
            {
                string currentPath = this.applicationInfo.ApplicationAssembly.Location;
                string newPath = Path.GetDirectoryName(currentPath) + "\\" + update.FileName;

                UpdateApplication(form.TempFilePath, currentPath, newPath, update.LaunchArgs);

                Application.Exit();
            }
            else if (result == DialogResult.Abort)
            {
                MessageBox.Show("The update download was stopped.\nThis program has not been modified.", "Update Download Stoped", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("There was a problem downloading the update.\nPlease try again later.", "Update Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateApplication(string tempFilePath, string currentPath, string newPath, string launchArgs)
        {
            string argument = "/C Choice /C Y /N /D Y /T 4 & Del /F /Q \"{0}\" & Choice /C Y /N /D Y /T 2 & Move /Y \"{1}\" \"{2}\" & Start \"\" /D \"{3}\" \"{4}\" {5}";

            ProcessStartInfo info = new ProcessStartInfo();
            info.Arguments = string.Format(argument, currentPath, tempFilePath, newPath, Path.GetDirectoryName(newPath), Path.GetFileName(newPath), launchArgs);
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.FileName = "cmd.exe";
            Process.Start(info);
        }
    }
}
