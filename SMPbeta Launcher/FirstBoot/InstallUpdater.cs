using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SMPbeta_Launcher.FirstBoot
{
    public partial class InstallUpdater : Form
    {
        public InstallUpdater()
        {
            InitializeComponent();
        }

        private void UL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/MexiMoo/MRO-Updater/blob/main/LICENSE",
                UseShellExecute = true
            });
        }

        private void Uy_Click(object sender, EventArgs e)
        {
            UDownloader UD = new UDownloader();
            UD.Show();
            this.Close();
        }

        private void Un_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
