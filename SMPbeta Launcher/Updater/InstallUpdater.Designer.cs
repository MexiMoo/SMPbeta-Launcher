namespace SMPbeta_Launcher.FirstBoot
{
    partial class InstallUpdater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallUpdater));
            this.imagePanel = new System.Windows.Forms.Panel();
            this.Image = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.oldVersion = new System.Windows.Forms.Button();
            this.versionPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.newVersion = new System.Windows.Forms.Button();
            this.spacer_1 = new System.Windows.Forms.Panel();
            this.spacer_2 = new System.Windows.Forms.Panel();
            this.spacerMain_1 = new System.Windows.Forms.Panel();
            this.uInputPanel = new System.Windows.Forms.Panel();
            this.nVersionRN = new System.Windows.Forms.LinkLabel();
            this.installYes = new System.Windows.Forms.Button();
            this.installNo = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.versionPanel.SuspendLayout();
            this.uInputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.Image);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(300, 100);
            this.imagePanel.TabIndex = 0;
            // 
            // Image
            // 
            this.Image.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Image.Image = global::SMPbeta_Launcher.Properties.Resources.Update;
            this.Image.Location = new System.Drawing.Point(0, 20);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(300, 80);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(0, 100);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(300, 50);
            this.Title.TabIndex = 1;
            this.Title.Text = "There is an update available!\r\n";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oldVersion
            // 
            this.oldVersion.BackColor = System.Drawing.Color.Black;
            this.oldVersion.Dock = System.Windows.Forms.DockStyle.Left;
            this.oldVersion.ForeColor = System.Drawing.Color.IndianRed;
            this.oldVersion.Location = new System.Drawing.Point(5, 0);
            this.oldVersion.Name = "oldVersion";
            this.oldVersion.Size = new System.Drawing.Size(75, 37);
            this.oldVersion.TabIndex = 2;
            this.oldVersion.Text = "oVersion";
            this.oldVersion.UseVisualStyleBackColor = false;
            // 
            // versionPanel
            // 
            this.versionPanel.Controls.Add(this.label2);
            this.versionPanel.Controls.Add(this.newVersion);
            this.versionPanel.Controls.Add(this.oldVersion);
            this.versionPanel.Controls.Add(this.spacer_1);
            this.versionPanel.Controls.Add(this.spacer_2);
            this.versionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.versionPanel.Location = new System.Drawing.Point(0, 250);
            this.versionPanel.Name = "versionPanel";
            this.versionPanel.Size = new System.Drawing.Size(300, 37);
            this.versionPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(80, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Old version / New version";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newVersion
            // 
            this.newVersion.BackColor = System.Drawing.Color.Black;
            this.newVersion.Dock = System.Windows.Forms.DockStyle.Right;
            this.newVersion.ForeColor = System.Drawing.Color.LimeGreen;
            this.newVersion.Location = new System.Drawing.Point(220, 0);
            this.newVersion.Name = "newVersion";
            this.newVersion.Size = new System.Drawing.Size(75, 37);
            this.newVersion.TabIndex = 3;
            this.newVersion.Text = "nVersion";
            this.newVersion.UseVisualStyleBackColor = false;
            // 
            // spacer_1
            // 
            this.spacer_1.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer_1.Location = new System.Drawing.Point(295, 0);
            this.spacer_1.Name = "spacer_1";
            this.spacer_1.Size = new System.Drawing.Size(5, 37);
            this.spacer_1.TabIndex = 4;
            // 
            // spacer_2
            // 
            this.spacer_2.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacer_2.Location = new System.Drawing.Point(0, 0);
            this.spacer_2.Name = "spacer_2";
            this.spacer_2.Size = new System.Drawing.Size(5, 37);
            this.spacer_2.TabIndex = 4;
            // 
            // spacerMain_1
            // 
            this.spacerMain_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacerMain_1.Location = new System.Drawing.Point(0, 150);
            this.spacerMain_1.Name = "spacerMain_1";
            this.spacerMain_1.Size = new System.Drawing.Size(300, 100);
            this.spacerMain_1.TabIndex = 5;
            // 
            // uInputPanel
            // 
            this.uInputPanel.Controls.Add(this.nVersionRN);
            this.uInputPanel.Controls.Add(this.installYes);
            this.uInputPanel.Controls.Add(this.installNo);
            this.uInputPanel.Controls.Add(this.questionLabel);
            this.uInputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uInputPanel.Location = new System.Drawing.Point(0, 350);
            this.uInputPanel.Name = "uInputPanel";
            this.uInputPanel.Size = new System.Drawing.Size(300, 150);
            this.uInputPanel.TabIndex = 6;
            // 
            // nVersionRN
            // 
            this.nVersionRN.Dock = System.Windows.Forms.DockStyle.Top;
            this.nVersionRN.Location = new System.Drawing.Point(0, 30);
            this.nVersionRN.Name = "nVersionRN";
            this.nVersionRN.Size = new System.Drawing.Size(300, 74);
            this.nVersionRN.TabIndex = 3;
            this.nVersionRN.TabStop = true;
            this.nVersionRN.Text = "See release notes of new version";
            this.nVersionRN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nVersionRN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nVersionRN_LinkClicked);
            // 
            // installYes
            // 
            this.installYes.BackColor = System.Drawing.Color.LimeGreen;
            this.installYes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.installYes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.installYes.Location = new System.Drawing.Point(202, 107);
            this.installYes.Name = "installYes";
            this.installYes.Size = new System.Drawing.Size(95, 40);
            this.installYes.TabIndex = 2;
            this.installYes.Text = "Yes";
            this.installYes.UseVisualStyleBackColor = false;
            this.installYes.Click += new System.EventHandler(this.installYes_Click);
            // 
            // installNo
            // 
            this.installNo.BackColor = System.Drawing.Color.IndianRed;
            this.installNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.installNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.installNo.Location = new System.Drawing.Point(5, 107);
            this.installNo.Name = "installNo";
            this.installNo.Size = new System.Drawing.Size(95, 40);
            this.installNo.TabIndex = 1;
            this.installNo.Text = "No";
            this.installNo.UseVisualStyleBackColor = false;
            this.installNo.Click += new System.EventHandler(this.installNo_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.questionLabel.Location = new System.Drawing.Point(0, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(300, 30);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Do you want to install the update?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstallUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.uInputPanel);
            this.Controls.Add(this.versionPanel);
            this.Controls.Add(this.spacerMain_1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.imagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallUpdater";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update!";
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.versionPanel.ResumeLayout(false);
            this.uInputPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button oldVersion;
        private System.Windows.Forms.Panel versionPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newVersion;
        private System.Windows.Forms.Panel spacer_1;
        private System.Windows.Forms.Panel spacer_2;
        private System.Windows.Forms.Panel spacerMain_1;
        private System.Windows.Forms.Panel uInputPanel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button installYes;
        private System.Windows.Forms.Button installNo;
        private System.Windows.Forms.LinkLabel nVersionRN;
    }
}