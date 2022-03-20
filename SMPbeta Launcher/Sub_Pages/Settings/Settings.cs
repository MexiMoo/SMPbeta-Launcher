using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMPbeta_Launcher
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            BgMessageCB();
            RunBGc();
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

        private void Update_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
    }
}
