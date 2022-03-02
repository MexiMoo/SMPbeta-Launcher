
namespace SMPbeta_Launcher
{
    partial class ToS_S_NL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToS_S_NL));
            this.File_NL_ToS = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // File_NL_ToS
            // 
            this.File_NL_ToS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.File_NL_ToS.Location = new System.Drawing.Point(0, 0);
            this.File_NL_ToS.Name = "File_NL_ToS";
            this.File_NL_ToS.Size = new System.Drawing.Size(482, 653);
            this.File_NL_ToS.TabIndex = 0;
            this.File_NL_ToS.Text = resources.GetString("File_NL_ToS.Text");
            this.File_NL_ToS.TextChanged += new System.EventHandler(this.File_NL_ToS_TextChanged);
            // 
            // ToS_S_NL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.File_NL_ToS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ToS_S_NL";
            this.Text = "Terms of Service (Simplified - NL)";
            this.Load += new System.EventHandler(this.ToS_S_NL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox File_NL_ToS;
    }
}