using System;
using System.Windows.Forms;

namespace Updater
{
    internal partial class Update_Notifier : Form
    {
        private IUpdater applicationInfo;

        private UpdaterXml updateInfo;

        private UpdateInfo updateInfoForm;

        internal Update_Notifier(IUpdater applicationInfo, UpdaterXml updateInfo)
        {
            InitializeComponent();

            this.applicationInfo = applicationInfo;
            this.updateInfo = updateInfo;

            this.Text = this.applicationInfo.ApplicationName + " - Update Avalable";

            if (this.applicationInfo.ApplicationIcon != null)
                this.Icon = this.applicationInfo.ApplicationIcon;

            this.Lab_Update_Avail.Text = string.Format("New Version: {0}", this.updateInfo.Version.ToString());
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Button_Det_Click(object sender, EventArgs e)
        {
            if (this.updateInfoForm == null) //Couldn't get this line to work \/ | Replaced it with an error message for now...
                //this.updateInfoForm = new Update_Notifier(this.applicationInfo, this.updateInfo);

            this.updateInfoForm.ShowDialog(this);
        }
    }
}
