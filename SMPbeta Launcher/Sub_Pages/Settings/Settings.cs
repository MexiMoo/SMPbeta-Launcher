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
            this.TransparencyKey = Color.Empty;
        }

        private void modernUIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void UI_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QJ_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("QuickJoin means: 'Quick Join' duh. But what does it do? Well, for example you join the HUB, Minecraft pre-loads the required pass-trough's and handshake protocols so you can join much faster on slow network!", "What the hell is this?");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
