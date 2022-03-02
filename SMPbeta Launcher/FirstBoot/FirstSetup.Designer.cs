
namespace SMPbeta_Launcher
{
    partial class FirstSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstSetup));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ToS_NL = new System.Windows.Forms.Button();
            this.Full_ToS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ServerLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Download_Start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.To_3 = new System.Windows.Forms.Button();
            this.Thumbnail_2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.FB = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.To_2 = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail_2)).BeginInit();
            this.FB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.ToS_NL);
            this.tabPage3.Controls.Add(this.Full_ToS);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.ServerLink);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.Download_Start);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(563, 751);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // ToS_NL
            // 
            this.ToS_NL.Location = new System.Drawing.Point(12, 365);
            this.ToS_NL.Name = "ToS_NL";
            this.ToS_NL.Size = new System.Drawing.Size(232, 44);
            this.ToS_NL.TabIndex = 8;
            this.ToS_NL.Text = "View simplified ToS (NL)";
            this.ToS_NL.UseVisualStyleBackColor = true;
            this.ToS_NL.Click += new System.EventHandler(this.ToS_NL_Click);
            // 
            // Full_ToS
            // 
            this.Full_ToS.Location = new System.Drawing.Point(12, 315);
            this.Full_ToS.Name = "Full_ToS";
            this.Full_ToS.Size = new System.Drawing.Size(232, 44);
            this.Full_ToS.TabIndex = 7;
            this.Full_ToS.Text = "View full Terms of Service";
            this.Full_ToS.UseVisualStyleBackColor = true;
            this.Full_ToS.Click += new System.EventHandler(this.Full_ToS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(244, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Terms of Service:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Location = new System.Drawing.Point(256, 315);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(295, 293);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ServerLink
            // 
            this.ServerLink.AccessibleDescription = "The website for the server!";
            this.ServerLink.AutoSize = true;
            this.ServerLink.Location = new System.Drawing.Point(311, 243);
            this.ServerLink.Name = "ServerLink";
            this.ServerLink.Size = new System.Drawing.Size(181, 20);
            this.ServerLink.TabIndex = 4;
            this.ServerLink.TabStop = true;
            this.ServerLink.Text = "https://maxrook.nl/server/";
            this.ServerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ServerLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 182);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Almost There!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Download_Start
            // 
            this.Download_Start.BackColor = System.Drawing.Color.Black;
            this.Download_Start.FlatAppearance.BorderSize = 3;
            this.Download_Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Download_Start.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Download_Start.Location = new System.Drawing.Point(6, 625);
            this.Download_Start.Name = "Download_Start";
            this.Download_Start.Size = new System.Drawing.Size(551, 120);
            this.Download_Start.TabIndex = 1;
            this.Download_Start.Text = "Agree and Download";
            this.Download_Start.UseVisualStyleBackColor = false;
            this.Download_Start.Click += new System.EventHandler(this.Download_Start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SMPbeta_Launcher.Properties.Resources.Update;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.Thumbnail_2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(563, 751);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.To_3);
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 431);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(563, 82);
            this.label8.TabIndex = 6;
            this.label8.Text = "The server is actively maintained so new content is getting added alway\'s! Bugs a" +
    "re alway\'s fixed as soon as possible to provide the best experience! ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(563, 230);
            this.label4.TabIndex = 5;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(563, 49);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enjoy Multiple Minecraft Adventures!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // To_3
            // 
            this.To_3.BackColor = System.Drawing.Color.Black;
            this.To_3.ForeColor = System.Drawing.Color.White;
            this.To_3.Location = new System.Drawing.Point(12, 367);
            this.To_3.Name = "To_3";
            this.To_3.Size = new System.Drawing.Size(539, 51);
            this.To_3.TabIndex = 2;
            this.To_3.Text = "Next";
            this.To_3.UseVisualStyleBackColor = false;
            this.To_3.Click += new System.EventHandler(this.To_3_Click);
            // 
            // Thumbnail_2
            // 
            this.Thumbnail_2.CreationProperties = null;
            this.Thumbnail_2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.Thumbnail_2.Enabled = false;
            this.Thumbnail_2.Location = new System.Drawing.Point(-37, -4);
            this.Thumbnail_2.Name = "Thumbnail_2";
            this.Thumbnail_2.Size = new System.Drawing.Size(623, 325);
            this.Thumbnail_2.Source = new System.Uri("https://maxrook.nl/wp-content/uploads/2021/12/Thumbnail_2.mp4", System.UriKind.Absolute);
            this.Thumbnail_2.TabIndex = 1;
            this.Thumbnail_2.TabStop = false;
            this.Thumbnail_2.ZoomFactor = 1D;
            // 
            // FB
            // 
            this.FB.Controls.Add(this.label7);
            this.FB.Controls.Add(this.label6);
            this.FB.Controls.Add(this.To_2);
            this.FB.Controls.Add(this.webView21);
            this.FB.Location = new System.Drawing.Point(4, 4);
            this.FB.Name = "FB";
            this.FB.Padding = new System.Windows.Forms.Padding(3);
            this.FB.Size = new System.Drawing.Size(563, 751);
            this.FB.TabIndex = 0;
            this.FB.Text = "tabPage1";
            this.FB.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(557, 54);
            this.label7.TabIndex = 5;
            this.label7.Text = "SMPbeta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(557, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Welcome to:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // To_2
            // 
            this.To_2.BackColor = System.Drawing.Color.Black;
            this.To_2.ForeColor = System.Drawing.Color.White;
            this.To_2.Location = new System.Drawing.Point(12, 687);
            this.To_2.Name = "To_2";
            this.To_2.Size = new System.Drawing.Size(539, 51);
            this.To_2.TabIndex = 3;
            this.To_2.Text = "Next";
            this.To_2.UseVisualStyleBackColor = false;
            this.To_2.Click += new System.EventHandler(this.To_2_Click);
            // 
            // webView21
            // 
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Enabled = false;
            this.webView21.Location = new System.Drawing.Point(-35, -5);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(644, 762);
            this.webView21.Source = new System.Uri("https://maxrook.nl/wp-content/uploads/2021/12/Thumbnail_1.mp4", System.UriKind.Absolute);
            this.webView21.TabIndex = 2;
            this.webView21.TabStop = false;
            this.webView21.ZoomFactor = 1D;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.FB);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-4, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(571, 784);
            this.tabControl1.TabIndex = 0;
            // 
            // FirstSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 750);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FB_1";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail_2)).EndInit();
            this.FB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Download_Start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Web.WebView2.WinForms.WebView2 Thumbnail_2;
        private System.Windows.Forms.TabPage FB;
        private System.Windows.Forms.Button To_2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button To_3;
        private System.Windows.Forms.LinkLabel ServerLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ToS_NL;
        private System.Windows.Forms.Button Full_ToS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}