
namespace SMPbeta_Launcher
{
    partial class News
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
            this.News_Content = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.News_Content)).BeginInit();
            this.SuspendLayout();
            // 
            // News_Content
            // 
            this.News_Content.CreationProperties = null;
            this.News_Content.DefaultBackgroundColor = System.Drawing.Color.White;
            this.News_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.News_Content.Location = new System.Drawing.Point(0, 0);
            this.News_Content.Name = "News_Content";
            this.News_Content.Size = new System.Drawing.Size(1214, 756);
            this.News_Content.Source = new System.Uri("https://maxrook.nl/server/launcher/news", System.UriKind.Absolute);
            this.News_Content.TabIndex = 0;
            this.News_Content.ZoomFactor = 1D;
            // 
            // News
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 756);
            this.Controls.Add(this.News_Content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "News";
            this.Text = "News";
            ((System.ComponentModel.ISupportInitialize)(this.News_Content)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 News_Content;
    }
}