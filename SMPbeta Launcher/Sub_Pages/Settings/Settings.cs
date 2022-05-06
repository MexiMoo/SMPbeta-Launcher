using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace SMPbeta_Launcher
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            BgMessageCB();
            RunBGc();
            RunSHc();
            this.TransparencyKey = Color.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void BgMessageCB()
        {
            if (Properties.Settings.Default.BgMessage == false)
            {
                BgMessage.CheckState = CheckState.Unchecked;
            }
            else
            {
                BgMessage.CheckState = CheckState.Checked;
            }
        }

        public void BgMessage_CheckedChanged(object sender, EventArgs e)
        {
            if (BgMessage.Checked)
            {
                Properties.Settings.Default["BgMessage"] = true;
                Properties.Settings.Default.Save();
            }
            else if (!BgMessage.Checked)
            {
                Properties.Settings.Default["BgMessage"] = false;
                Properties.Settings.Default.Save();
            }
        }

        private void Ip_Ao_Click(object sender, EventArgs e)
        {
            OpenFileDialog AO = new OpenFileDialog();
            AO.Filter = "Mexi Core Files|*.MEXI;*.MCF|SMPbeta Files|*.SMPB;*.AO|All files|*.*";
            AO.InitialDirectory = @"C:\";
            AO.RestoreDirectory = true;
            AO.Title = "Import Add-On";
            AO.ShowDialog();


            //if (Ao.ShowDialog() == DialogResult.OK)
            //string ext = Path.GetExtension(Ao.FileName);
        }

        private void RunBG_CheckedChanged(object sender, EventArgs e)
        {
            if (RunBG.Checked)
            {
                Properties.Settings.Default["RunBG"] = true;
                Properties.Settings.Default.Save();
            }
            else if (!RunBG.Checked)
            {
                Properties.Settings.Default["RunBG"] = false;
                Properties.Settings.Default.Save();
            }
        }

        void RunBGc()
        {
            if (Properties.Settings.Default.RunBG == false)
            {
                RunBG.CheckState = CheckState.Unchecked;
            }
            else
            {
                RunBG.CheckState = CheckState.Checked;
            }
        }

        private void Shaders_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog SA = new OpenFileDialog();
            SA.Filter = "Zipped archive|*.zip;*.7z|All files|*.*";
            SA.InitialDirectory = @"C:\";
            SA.RestoreDirectory = true;
            SA.Multiselect = false;
            SA.Title = "Import Shaders";
            DialogResult SAselected = SA.ShowDialog();

            string shadersFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "shaderpacks");
            string shadersOP = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "shaderpacks", SA.SafeFileName);

            if (Directory.Exists(shadersFolder) == false)
            {
                Directory.CreateDirectory(shadersFolder);
            }

            if (SAselected == DialogResult.OK)
            {
                try
                {
                    string fileName = SA.FileName;
                    File.Copy(fileName, shadersOP, true);
                    MessageBox.Show("The following shaders have been succesfully installed: " + SA.SafeFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The selected shaders failed to load: " + SA.FileName);
                }
            }
        }

        private void Game_Shaders_CheckedChanged(object sender, EventArgs e)
        {
            if (Game_Shaders.Checked)
            {
                    Properties.Settings.Default["eSH"] = true;
                    Properties.Settings.Default.Save();
            }
            else if (!Game_Shaders.Checked)
            {
                Properties.Settings.Default["eSH"] = false;
                Properties.Settings.Default.Save();
            }
        }

        void RunSHc()
        {
            if (Properties.Settings.Default.eSH == false)
            {
                Game_Shaders.CheckState = CheckState.Unchecked;
            }
            else
            {
                Game_Shaders.CheckState = CheckState.Checked;
            }
        }
    }
}
