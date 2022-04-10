
namespace SMPbeta_Launcher
{
    partial class Settings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Shaders_Import = new System.Windows.Forms.Button();
            this.Game_Shaders = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RunBG = new System.Windows.Forms.CheckBox();
            this.Update = new System.Windows.Forms.Button();
            this.Ip_Ao = new System.Windows.Forms.Button();
            this.BgMessage = new System.Windows.Forms.CheckBox();
            this.Save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ao = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 7);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1070, 88);
            this.label1.TabIndex = 4;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Shaders_Import);
            this.panel2.Controls.Add(this.Game_Shaders);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 909);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(121, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(420, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Only avalable for 1.18.1 [Modded]";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Shaders_Import
            // 
            this.Shaders_Import.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Shaders_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shaders_Import.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Shaders_Import.Location = new System.Drawing.Point(5, 582);
            this.Shaders_Import.Margin = new System.Windows.Forms.Padding(1);
            this.Shaders_Import.Name = "Shaders_Import";
            this.Shaders_Import.Size = new System.Drawing.Size(156, 29);
            this.Shaders_Import.TabIndex = 14;
            this.Shaders_Import.Text = "Import Shaders...";
            this.Shaders_Import.UseVisualStyleBackColor = true;
            this.Shaders_Import.Click += new System.EventHandler(this.Shaders_Import_Click);
            // 
            // Game_Shaders
            // 
            this.Game_Shaders.AutoSize = true;
            this.Game_Shaders.ForeColor = System.Drawing.SystemColors.Control;
            this.Game_Shaders.Location = new System.Drawing.Point(5, 21);
            this.Game_Shaders.Margin = new System.Windows.Forms.Padding(1);
            this.Game_Shaders.Name = "Game_Shaders";
            this.Game_Shaders.Size = new System.Drawing.Size(105, 19);
            this.Game_Shaders.TabIndex = 14;
            this.Game_Shaders.Text = "Enable Shaders";
            this.Game_Shaders.UseVisualStyleBackColor = true;
            this.Game_Shaders.CheckedChanged += new System.EventHandler(this.Game_Shaders_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(531, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Game Settings";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.RunBG);
            this.panel3.Controls.Add(this.Update);
            this.panel3.Controls.Add(this.Ip_Ao);
            this.panel3.Controls.Add(this.BgMessage);
            this.panel3.Controls.Add(this.Save);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(531, 95);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 909);
            this.panel3.TabIndex = 8;
            // 
            // RunBG
            // 
            this.RunBG.AutoSize = true;
            this.RunBG.Checked = true;
            this.RunBG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RunBG.ForeColor = System.Drawing.SystemColors.Control;
            this.RunBG.Location = new System.Drawing.Point(2, 84);
            this.RunBG.Margin = new System.Windows.Forms.Padding(1);
            this.RunBG.Name = "RunBG";
            this.RunBG.Size = new System.Drawing.Size(245, 19);
            this.RunBG.TabIndex = 13;
            this.RunBG.Text = "Let SMPbeta Launcher run in background\r\n";
            this.RunBG.UseVisualStyleBackColor = true;
            this.RunBG.CheckedChanged += new System.EventHandler(this.RunBG_CheckedChanged);
            // 
            // Update
            // 
            this.Update.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update.Location = new System.Drawing.Point(160, 582);
            this.Update.Margin = new System.Windows.Forms.Padding(1);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(156, 29);
            this.Update.TabIndex = 12;
            this.Update.Text = "Search for update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Ip_Ao
            // 
            this.Ip_Ao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Ip_Ao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ip_Ao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ip_Ao.Location = new System.Drawing.Point(2, 582);
            this.Ip_Ao.Margin = new System.Windows.Forms.Padding(1);
            this.Ip_Ao.Name = "Ip_Ao";
            this.Ip_Ao.Size = new System.Drawing.Size(156, 29);
            this.Ip_Ao.TabIndex = 11;
            this.Ip_Ao.Text = "Import Add-on...";
            this.Ip_Ao.UseVisualStyleBackColor = true;
            this.Ip_Ao.Click += new System.EventHandler(this.Ip_Ao_Click);
            // 
            // BgMessage
            // 
            this.BgMessage.AutoSize = true;
            this.BgMessage.Checked = true;
            this.BgMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BgMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.BgMessage.Location = new System.Drawing.Point(2, 63);
            this.BgMessage.Margin = new System.Windows.Forms.Padding(1);
            this.BgMessage.Name = "BgMessage";
            this.BgMessage.Size = new System.Drawing.Size(156, 19);
            this.BgMessage.TabIndex = 10;
            this.BgMessage.Text = "Enable System Messages";
            this.BgMessage.UseVisualStyleBackColor = true;
            this.BgMessage.CheckedChanged += new System.EventHandler(this.BgMessage_CheckedChanged);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.Turquoise;
            this.Save.Enabled = false;
            this.Save.Font = new System.Drawing.Font("Segoe UI Black", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(412, 864);
            this.Save.Margin = new System.Windows.Forms.Padding(1);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(121, 41);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English",
            "Dutch (NL) [Unsupported]"});
            this.comboBox1.Location = new System.Drawing.Point(2, 41);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "English";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(538, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Launcher Language:";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(538, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Client Settings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ao
            // 
            this.Ao.FileName = "Import Add-On";
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1070, 710);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Settings";
            this.Text = "Gsettings";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.CheckBox BgMessage;
        private System.Windows.Forms.Button Ip_Ao;
        private System.Windows.Forms.OpenFileDialog Ao;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.CheckBox RunBG;
        private System.Windows.Forms.Button Shaders_Import;
        private System.Windows.Forms.CheckBox Game_Shaders;
        private System.Windows.Forms.Label label5;
    }
}