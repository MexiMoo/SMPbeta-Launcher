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
            this.ButtonBox = new System.Windows.Forms.Panel();
            this.UL = new System.Windows.Forms.LinkLabel();
            this.Un = new System.Windows.Forms.Button();
            this.Uy = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.ButtonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonBox
            // 
            this.ButtonBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonBox.Controls.Add(this.UL);
            this.ButtonBox.Controls.Add(this.Un);
            this.ButtonBox.Controls.Add(this.Uy);
            this.ButtonBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonBox.Location = new System.Drawing.Point(0, 210);
            this.ButtonBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ButtonBox.Name = "ButtonBox";
            this.ButtonBox.Size = new System.Drawing.Size(923, 115);
            this.ButtonBox.TabIndex = 0;
            // 
            // UL
            // 
            this.UL.AutoSize = true;
            this.UL.Location = new System.Drawing.Point(29, 36);
            this.UL.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.UL.Name = "UL";
            this.UL.Size = new System.Drawing.Size(232, 41);
            this.UL.TabIndex = 2;
            this.UL.TabStop = true;
            this.UL.Text = "Updater Licence";
            this.UL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UL_LinkClicked);
            // 
            // Un
            // 
            this.Un.Location = new System.Drawing.Point(515, 25);
            this.Un.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Un.Name = "Un";
            this.Un.Size = new System.Drawing.Size(182, 63);
            this.Un.TabIndex = 1;
            this.Un.Text = "No";
            this.Un.UseVisualStyleBackColor = true;
            this.Un.Click += new System.EventHandler(this.Un_Click);
            // 
            // Uy
            // 
            this.Uy.Location = new System.Drawing.Point(712, 25);
            this.Uy.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Uy.Name = "Uy";
            this.Uy.Size = new System.Drawing.Size(182, 63);
            this.Uy.TabIndex = 0;
            this.Uy.Text = "Yes";
            this.Uy.UseVisualStyleBackColor = true;
            this.Uy.Click += new System.EventHandler(this.Uy_Click);
            // 
            // Info
            // 
            this.Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info.Location = new System.Drawing.Point(0, 0);
            this.Info.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(923, 210);
            this.Info.TabIndex = 1;
            this.Info.Text = resources.GetString("Info.Text");
            // 
            // InstallUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(923, 325);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.ButtonBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallUpdater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Updater?";
            this.ButtonBox.ResumeLayout(false);
            this.ButtonBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonBox;
        private System.Windows.Forms.LinkLabel UL;
        private System.Windows.Forms.Button Un;
        private System.Windows.Forms.Button Uy;
        private System.Windows.Forms.Label Info;
    }
}