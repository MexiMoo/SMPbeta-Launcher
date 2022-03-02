
namespace Updater
{
    partial class Update_Notifier
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lab_Update_Avail = new System.Windows.Forms.Label();
            this.Button_Det = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Updater.Properties.Resources.Update1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Lab_Update_Avail
            // 
            this.Lab_Update_Avail.AutoSize = true;
            this.Lab_Update_Avail.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Lab_Update_Avail.Location = new System.Drawing.Point(118, 9);
            this.Lab_Update_Avail.Name = "Lab_Update_Avail";
            this.Lab_Update_Avail.Size = new System.Drawing.Size(402, 60);
            this.Lab_Update_Avail.TabIndex = 1;
            this.Lab_Update_Avail.Text = "An update for the launcher is available!\r\nPress \"Update\" to update your launcher!" +
    "";
            this.Lab_Update_Avail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Det
            // 
            this.Button_Det.Location = new System.Drawing.Point(330, 113);
            this.Button_Det.Name = "Button_Det";
            this.Button_Det.Size = new System.Drawing.Size(190, 23);
            this.Button_Det.TabIndex = 2;
            this.Button_Det.Text = "Details";
            this.Button_Det.UseVisualStyleBackColor = true;
            this.Button_Det.Click += new System.EventHandler(this.Button_Det_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.Location = new System.Drawing.Point(123, 77);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(397, 33);
            this.Button_Update.TabIndex = 3;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Update_Notifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 140);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.Button_Det);
            this.Controls.Add(this.Lab_Update_Avail);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update_Notifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lab_Update_Avail;
        private System.Windows.Forms.Button Button_Det;
        private System.Windows.Forms.Button Button_Update;
    }
}