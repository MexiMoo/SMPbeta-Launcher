using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using Updater;

namespace SMPbeta_Launcher
{
    public partial class Info : Form, IUpdater
    {
        public Info()
        {
            this.Enabled = true;
            InitializeComponent();
            this.CR_Version.Text = this.ApplicationAssembly.GetName().Version.ToString();
            this.TransparencyKey = Color.Empty;
            this.Enabled = true;
        }

        public string ApplicationName
        {
            get { return "SMPbeta Launcher"; }
        }

        public string ApplicationID
        {
            get { return "SMPbeta Launcher"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("https://maxrook.nl/server/launcher/update/update.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }

        #region InstalledButtons
        private void Installed_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SMPbeta Server Connection Drivers  |  Version 1.2.6  |  A program that installs the corresponding drivers on your device to make a stable connection to the SMPbeta servers and request and download the required files.  |  © 2021-2022 Max Rook (MexiMux)  |  All rights reserved");
        }

        private void Installed_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SMPbeta Server Dependencies  |  Version 2.0.3  |  A program that installs the corresponding drivers to automaticly grab files from the SMPbeta servers and installs them.  |  © 2021-2022 Max Rook (MexiMux)  |  All rights reserved");
        }

        private void Installed_3_Click(object sender, EventArgs e)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            MessageBox.Show("SMPbeta Modded Client Installer  |  Version " + version + "  |  A program that handles the installation of the modded client and profiles for the modded servers.  |  © 2021-2022 Max Rook (MexiMux)  |  All rights reserved");
        }

        private void Installed_4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minecraft 1.18.1  |  Version 1.18.1  |  Minecraft Java Edition  |  © 2022 Mojang  |  All rights reserved");
        }

        private void Installed_5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minecraft 1.12.2 [Forge]  |  Version 1.12.2  |  Minecraft Java Edition [Forge]  |  © 2022 Mojang & Forge  |  All rights reserved");
        }

        private void Installed_6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minecraft 1.18.1 [Forge]  |  Version 1.18.1  |  Minecraft Java Edition [Forge]  |  © 2022 Mojang & Forge  |  All rights reserved");
        }

        private void Installed_7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minecraft 1.18.1 [Spigot]  |  Version 1.18.1  |  Minecraft Java Edition [Spigot] |  © 2022 Mojang & Spigot  |  All rights reserved");
        }

        private void Installed_8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SMPbeta Diag  |  Version 1.0.6 |  A program that collects info from the client for further development of bug fixes.  |  © 2021-2022 Max Rook (MexiMux)  |  All rights reserved");
        }

        private void Installed_9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SMPbeta Integrated Updater  |  Version 1.0.1 |  An internal updater to update the client with one click of a button.  |  © 2021-2022 Max Rook (MexiMux)  |  All rights reserved");
        }
        #endregion

        private void Website_Info_1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "http://meximux.com",
                UseShellExecute = true
            });
        }

        private void Website_Info_2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://maxrook.nl/",
                UseShellExecute = true
            });
        }

        private void Info_Copy_Button_Click(object sender, EventArgs e)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            string copy = @"SMPbeta Launcher
            Version " + version + @"
            SMPbetaLauncher.1.Release/" + version + @"+23621.595
            SMPbeta custom code, logo's and music
            Distro 18.1.2:5003
             
            Installed Version: Distributed - Release
             
            Required Installed components:
            SMPbeta Server Connection Drivers
            SMPbeta Server Dependencies [Updates and Checks] (Included= Shaders)
            SMPbeta Integrated Updater
            SMPbeta Modded Client Installer
            SMPbeta Diag [Diagnostics]

            Required Minecraft versions:
            Minecraft 1.18.1
            Minecraft 1.12.2
            Minecraft 1.18.1 [Forge]
            Minecraft 1.18.1 [Spigot]
            Minecraft 1.12.2 [Forge]

            Installed Minecraft versions:
            Minecraft 1.18.1
            Minecraft 1.12.2
            Minecraft 1.18.1 [Forge]
            Minecraft 1.18.1 [Spigot]
            Minecraft 1.12.2 [Forge]

            Software compiled on:
            10-6-2022

            Build License:
            Max Rook (MexiMux)

            Company:
            Max Rook (MexiMux)

            Signed:
            Yes

            Build Software:
            Microsoft Visual Studio 2022

            .NET version:
            .NET 6

            Language:
            C#

            Website:
            https://maxrook.nl, http://meximux.com/

            Copyright:
            © 2021-2022 Max Rook (MexiMux)
            All rights reserved";

            System.Windows.Forms.Clipboard.SetText(copy);
            MessageBox.Show("Info copied to clipboard!");
        }

        private void ToS_Revoke_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Changed your mind about accepting our terms of service? Understandable. Do you want to revoke your agreement to our terms of service?                                                                                                          (You have to agree again to our terms of service to use this program again!)", "Revoke Terms", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default["TosAccepted"] = false;
                Properties.Settings.Default.Save();
                System.Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                //Do nothing here...
            }
        }

        private void CrashCL_Click(object sender, EventArgs e)
        {
            throw new Exception("(CEx17) Intentional Crash!");
        }

        private void License_Terms_Click(object sender, EventArgs e)
        {
            ToS tos = new ToS();
            tos.TopMost = true;
            tos.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.Enabled = true;
        }

        private void Info_Content_Paint(object sender, PaintEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
