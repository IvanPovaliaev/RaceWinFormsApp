namespace RaceWinFormsApp
{
    partial class SettingsForm
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
            titleLabel = new System.Windows.Forms.Label();
            acceptButton = new System.Windows.Forms.Button();
            bgmSliderControl = new SliderControl();
            bgmLabel = new System.Windows.Forms.Label();
            returnButton = new System.Windows.Forms.Button();
            soundSliderControl = new SliderControl();
            soundLabel = new System.Windows.Forms.Label();
            backPanel = new System.Windows.Forms.Panel();
            backPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            titleLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 105F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(384, 154);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Race";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceptButton
            // 
            acceptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            acceptButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            acceptButton.Location = new System.Drawing.Point(292, 515);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new System.Drawing.Size(80, 35);
            acceptButton.TabIndex = 3;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // bgmSliderControl
            // 
            bgmSliderControl.BackColor = System.Drawing.Color.WhiteSmoke;
            bgmSliderControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            bgmSliderControl.Location = new System.Drawing.Point(67, 247);
            bgmSliderControl.Name = "bgmSliderControl";
            bgmSliderControl.Size = new System.Drawing.Size(250, 20);
            bgmSliderControl.SliderColor = System.Drawing.Color.FromArgb(242, 196, 141);
            bgmSliderControl.TabIndex = 4;
            bgmSliderControl.Value = 25;
            // 
            // bgmLabel
            // 
            bgmLabel.BackColor = System.Drawing.Color.Transparent;
            bgmLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            bgmLabel.ForeColor = System.Drawing.Color.White;
            bgmLabel.Location = new System.Drawing.Point(67, 211);
            bgmLabel.Name = "bgmLabel";
            bgmLabel.Size = new System.Drawing.Size(250, 33);
            bgmLabel.TabIndex = 5;
            bgmLabel.Text = "BGM volume";
            bgmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            returnButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            returnButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            returnButton.Location = new System.Drawing.Point(206, 515);
            returnButton.Name = "returnButton";
            returnButton.Size = new System.Drawing.Size(80, 35);
            returnButton.TabIndex = 3;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // soundSliderControl
            // 
            soundSliderControl.BackColor = System.Drawing.Color.WhiteSmoke;
            soundSliderControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            soundSliderControl.Location = new System.Drawing.Point(67, 128);
            soundSliderControl.Name = "soundSliderControl";
            soundSliderControl.Size = new System.Drawing.Size(250, 20);
            soundSliderControl.SliderColor = System.Drawing.Color.FromArgb(242, 196, 141);
            soundSliderControl.TabIndex = 4;
            soundSliderControl.Value = 25;
            soundSliderControl.MouseUp += soundSliderControl_MouseUp;
            // 
            // soundLabel
            // 
            soundLabel.BackColor = System.Drawing.Color.Transparent;
            soundLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            soundLabel.ForeColor = System.Drawing.Color.White;
            soundLabel.Location = new System.Drawing.Point(67, 91);
            soundLabel.Name = "soundLabel";
            soundLabel.Size = new System.Drawing.Size(250, 34);
            soundLabel.TabIndex = 5;
            soundLabel.Text = "Sound volume";
            soundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backPanel
            // 
            backPanel.BackColor = System.Drawing.Color.FromArgb(187, 173, 160);
            backPanel.Controls.Add(soundLabel);
            backPanel.Controls.Add(bgmLabel);
            backPanel.Controls.Add(bgmSliderControl);
            backPanel.Controls.Add(soundSliderControl);
            backPanel.Dock = System.Windows.Forms.DockStyle.Top;
            backPanel.Location = new System.Drawing.Point(0, 154);
            backPanel.Name = "backPanel";
            backPanel.Size = new System.Drawing.Size(384, 355);
            backPanel.TabIndex = 6;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ClientSize = new System.Drawing.Size(384, 562);
            Controls.Add(backPanel);
            Controls.Add(returnButton);
            Controls.Add(acceptButton);
            Controls.Add(titleLabel);
            DoubleBuffered = true;
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximumSize = new System.Drawing.Size(384, 562);
            MinimumSize = new System.Drawing.Size(384, 562);
            Name = "SettingsForm";
            Text = "SettingsForm";
            backPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button acceptButton;
        private SliderControl bgmSliderControl;
        private System.Windows.Forms.Label bgmLabel;
        private System.Windows.Forms.Button returnButton;
        private SliderControl soundSliderControl;
        private System.Windows.Forms.Label soundLabel;
        private System.Windows.Forms.Panel backPanel;
    }
}