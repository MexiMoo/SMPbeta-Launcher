//Programmed in C# and C++
//For more information visit: https://maxrook.nl/server

namespace SMPbeta_Launcher
{
    partial class Launcher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {

        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.ControlBar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Spacer_Close = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_1 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Button();
            this.Nav = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.Button();
            this.Profile3 = new System.Windows.Forms.Button();
            this.Profile2 = new System.Windows.Forms.Button();
            this.Profile1 = new System.Windows.Forms.Button();
            this.News = new System.Windows.Forms.Button();
            this.Button_Position = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Notify_Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ControlBar.SuspendLayout();
            this.Menu.SuspendLayout();
            this.Button_Position.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ChildPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlBar
            // 
            this.ControlBar.BackColor = System.Drawing.Color.Black;
            this.ControlBar.Controls.Add(this.label3);
            this.ControlBar.Controls.Add(this.Minimize);
            this.ControlBar.Controls.Add(this.Close);
            this.ControlBar.Controls.Add(this.Spacer_Close);
            this.ControlBar.Controls.Add(this.label1);
            this.ControlBar.Controls.Add(this.Name_1);
            this.ControlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBar.Location = new System.Drawing.Point(0, 0);
            this.ControlBar.Margin = new System.Windows.Forms.Padding(2);
            this.ControlBar.Name = "ControlBar";
            this.ControlBar.Size = new System.Drawing.Size(1174, 16);
            this.ControlBar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(122, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "BETA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Minimize
            // 
            this.Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Nirmala UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minimize.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Minimize.Location = new System.Drawing.Point(1122, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(20, 16);
            this.Minimize.TabIndex = 4;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimize_MouseClick);
            // 
            // Close
            // 
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Nirmala UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Close.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Close.Location = new System.Drawing.Point(1142, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(20, 16);
            this.Close.TabIndex = 3;
            this.Close.Text = "x";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_MouseClick);
            // 
            // Spacer_Close
            // 
            this.Spacer_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Spacer_Close.Location = new System.Drawing.Point(1162, 0);
            this.Spacer_Close.Margin = new System.Windows.Forms.Padding(2);
            this.Spacer_Close.Name = "Spacer_Close";
            this.Spacer_Close.Size = new System.Drawing.Size(12, 16);
            this.Spacer_Close.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(56, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Launcher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Name_1
            // 
            this.Name_1.AutoSize = true;
            this.Name_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Name_1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_1.ForeColor = System.Drawing.SystemColors.Window;
            this.Name_1.Location = new System.Drawing.Point(0, 0);
            this.Name_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name_1.Name = "Name_1";
            this.Name_1.Size = new System.Drawing.Size(61, 15);
            this.Name_1.TabIndex = 0;
            this.Name_1.Text = "SMPbeta";
            this.Name_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Menu.Controls.Add(this.Info);
            this.Menu.Controls.Add(this.Nav);
            this.Menu.Controls.Add(this.Settings);
            this.Menu.Controls.Add(this.Profile3);
            this.Menu.Controls.Add(this.Profile2);
            this.Menu.Controls.Add(this.Profile1);
            this.Menu.Controls.Add(this.News);
            this.Menu.Controls.Add(this.Button_Position);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 16);
            this.Menu.Margin = new System.Windows.Forms.Padding(2);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(104, 710);
            this.Menu.TabIndex = 1;
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Info.FlatAppearance.BorderSize = 0;
            this.Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Info.ImageKey = "(none)";
            this.Info.Location = new System.Drawing.Point(0, 638);
            this.Info.Margin = new System.Windows.Forms.Padding(2);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(104, 36);
            this.Info.TabIndex = 8;
            this.Info.Text = "Info";
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Info.UseVisualStyleBackColor = false;
            this.Info.Click += new System.EventHandler(this.Info_Click_1);
            this.Info.Leave += new System.EventHandler(this.Info_Leave_1);
            // 
            // Nav
            // 
            this.Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Nav.Location = new System.Drawing.Point(0, 121);
            this.Nav.Margin = new System.Windows.Forms.Padding(2);
            this.Nav.Name = "Nav";
            this.Nav.Size = new System.Drawing.Size(2, 80);
            this.Nav.TabIndex = 7;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Settings.ImageKey = "(none)";
            this.Settings.Location = new System.Drawing.Point(0, 674);
            this.Settings.Margin = new System.Windows.Forms.Padding(2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(104, 36);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            this.Settings.Leave += new System.EventHandler(this.Settings_Leave);
            // 
            // Profile3
            // 
            this.Profile3.BackColor = System.Drawing.Color.Transparent;
            this.Profile3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profile3.FlatAppearance.BorderSize = 0;
            this.Profile3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile3.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Profile3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Profile3.Location = new System.Drawing.Point(0, 202);
            this.Profile3.Margin = new System.Windows.Forms.Padding(2);
            this.Profile3.Name = "Profile3";
            this.Profile3.Size = new System.Drawing.Size(104, 34);
            this.Profile3.TabIndex = 5;
            this.Profile3.Text = "1.12.2 [Modded]";
            this.Profile3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile3.UseVisualStyleBackColor = false;
            this.Profile3.Click += new System.EventHandler(this.Profile3_Click);
            this.Profile3.Leave += new System.EventHandler(this.Profile3_Leave);
            // 
            // Profile2
            // 
            this.Profile2.BackColor = System.Drawing.Color.Transparent;
            this.Profile2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profile2.FlatAppearance.BorderSize = 0;
            this.Profile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile2.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Profile2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Profile2.Location = new System.Drawing.Point(0, 168);
            this.Profile2.Margin = new System.Windows.Forms.Padding(2);
            this.Profile2.Name = "Profile2";
            this.Profile2.Size = new System.Drawing.Size(104, 34);
            this.Profile2.TabIndex = 4;
            this.Profile2.Text = "1.18.1 [Modded]";
            this.Profile2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile2.UseVisualStyleBackColor = false;
            this.Profile2.Click += new System.EventHandler(this.Profile2_Click);
            this.Profile2.Leave += new System.EventHandler(this.Profile2_Leave);
            // 
            // Profile1
            // 
            this.Profile1.BackColor = System.Drawing.Color.Transparent;
            this.Profile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profile1.FlatAppearance.BorderSize = 0;
            this.Profile1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Profile1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Profile1.Location = new System.Drawing.Point(0, 134);
            this.Profile1.Margin = new System.Windows.Forms.Padding(2);
            this.Profile1.Name = "Profile1";
            this.Profile1.Size = new System.Drawing.Size(104, 34);
            this.Profile1.TabIndex = 3;
            this.Profile1.Text = "1.18.1";
            this.Profile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile1.UseVisualStyleBackColor = false;
            this.Profile1.Click += new System.EventHandler(this.Profile1_Click);
            this.Profile1.Leave += new System.EventHandler(this.Profile1_Leave);
            // 
            // News
            // 
            this.News.BackColor = System.Drawing.Color.Transparent;
            this.News.Dock = System.Windows.Forms.DockStyle.Top;
            this.News.FlatAppearance.BorderSize = 0;
            this.News.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.News.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.News.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.News.Location = new System.Drawing.Point(0, 100);
            this.News.Margin = new System.Windows.Forms.Padding(2);
            this.News.Name = "News";
            this.News.Size = new System.Drawing.Size(104, 34);
            this.News.TabIndex = 2;
            this.News.Text = "News";
            this.News.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.News.UseVisualStyleBackColor = false;
            this.News.Click += new System.EventHandler(this.News_Click);
            this.News.Leave += new System.EventHandler(this.News_Leave);
            // 
            // Button_Position
            // 
            this.Button_Position.Controls.Add(this.pictureBox1);
            this.Button_Position.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Position.Location = new System.Drawing.Point(0, 0);
            this.Button_Position.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Position.Name = "Button_Position";
            this.Button_Position.Size = new System.Drawing.Size(104, 100);
            this.Button_Position.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ChildPanel
            // 
            this.ChildPanel.Controls.Add(this.label2);
            this.ChildPanel.Location = new System.Drawing.Point(104, 16);
            this.ChildPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(1070, 710);
            this.ChildPanel.TabIndex = 2;
            this.ChildPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChildPanel_Paint);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1070, 710);
            this.label2.TabIndex = 0;
            this.label2.Text = "Use the sidebar to start exploring!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Notify_Icon
            // 
            this.Notify_Icon.BalloonTipTitle = "SMPbeta Launcher";
            this.Notify_Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify_Icon.Icon")));
            this.Notify_Icon.Text = "SMPbeta Launcher";
            this.Notify_Icon.Visible = true;
            // 
            // Launcher
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1174, 726);
            this.Controls.Add(this.ChildPanel);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.ControlBar);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1174, 726);
            this.MinimumSize = new System.Drawing.Size(1174, 726);
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMPbeta Launcher";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Launcher_FormClosed);
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.ControlBar.ResumeLayout(false);
            this.ControlBar.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Button_Position.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ChildPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlBar;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_1;
        private System.Windows.Forms.Panel Nav;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Profile3;
        private System.Windows.Forms.Button Profile2;
        private System.Windows.Forms.Button Profile1;
        private System.Windows.Forms.Button News;
        private System.Windows.Forms.Panel Button_Position;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel Spacer_Close;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel ChildPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon Notify_Icon;
    }
}

