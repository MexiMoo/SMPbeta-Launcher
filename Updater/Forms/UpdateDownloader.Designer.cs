
namespace Updater
{
    partial class UpdateDownloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lab_Downloading = new System.Windows.Forms.Label();
            this.Download_Progress = new System.Windows.Forms.ProgressBar();
            this.Lab_Progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lab_Downloading
            // 
            this.Lab_Downloading.AutoSize = true;
            this.Lab_Downloading.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.Lab_Downloading.Location = new System.Drawing.Point(2, 35);
            this.Lab_Downloading.Name = "Lab_Downloading";
            this.Lab_Downloading.Size = new System.Drawing.Size(396, 50);
            this.Lab_Downloading.TabIndex = 0;
            this.Lab_Downloading.Text = "Downloading Update...\r\n";
            this.Lab_Downloading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Download_Progress
            // 
            this.Download_Progress.Location = new System.Drawing.Point(12, 105);
            this.Download_Progress.Name = "Download_Progress";
            this.Download_Progress.Size = new System.Drawing.Size(377, 23);
            this.Download_Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Download_Progress.TabIndex = 1;
            // 
            // Lab_Progress
            // 
            this.Lab_Progress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Lab_Progress.Location = new System.Drawing.Point(12, 131);
            this.Lab_Progress.Name = "Lab_Progress";
            this.Lab_Progress.Size = new System.Drawing.Size(377, 13);
            this.Lab_Progress.TabIndex = 2;
            this.Lab_Progress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UpdateDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 177);
            this.Controls.Add(this.Lab_Progress);
            this.Controls.Add(this.Download_Progress);
            this.Controls.Add(this.Lab_Downloading);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Downloading Update";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateDownloader_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Downloading;
        private System.Windows.Forms.ProgressBar Download_Progress;
        private System.Windows.Forms.Label Lab_Progress;
    }
}