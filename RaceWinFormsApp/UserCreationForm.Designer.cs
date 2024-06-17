namespace RaceWinFormsApp
{
    partial class UserCreationForm
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
            playerNameTextBox = new System.Windows.Forms.TextBox();
            enterPlayerLabel = new System.Windows.Forms.Label();
            returnButton = new System.Windows.Forms.Button();
            acceptButton = new System.Windows.Forms.Button();
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
            titleLabel.Size = new System.Drawing.Size(384, 180);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Race";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerNameTextBox
            // 
            playerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            playerNameTextBox.BackColor = System.Drawing.Color.FromArgb(204, 192, 179);
            playerNameTextBox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            playerNameTextBox.ForeColor = System.Drawing.Color.FromArgb(119, 116, 101);
            playerNameTextBox.Location = new System.Drawing.Point(43, 151);
            playerNameTextBox.Name = "playerNameTextBox";
            playerNameTextBox.PlaceholderText = "Enter player name";
            playerNameTextBox.Size = new System.Drawing.Size(305, 30);
            playerNameTextBox.TabIndex = 3;
            playerNameTextBox.Text = "NoName";
            playerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enterPlayerLabel
            // 
            enterPlayerLabel.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold);
            enterPlayerLabel.ForeColor = System.Drawing.Color.White;
            enterPlayerLabel.Location = new System.Drawing.Point(43, 111);
            enterPlayerLabel.Name = "enterPlayerLabel";
            enterPlayerLabel.Size = new System.Drawing.Size(305, 37);
            enterPlayerLabel.TabIndex = 4;
            enterPlayerLabel.Text = "Enter player name:";
            enterPlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            returnButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            returnButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            returnButton.Location = new System.Drawing.Point(12, 515);
            returnButton.Name = "returnButton";
            returnButton.Size = new System.Drawing.Size(80, 35);
            returnButton.TabIndex = 5;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // acceptButton
            // 
            acceptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            acceptButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            acceptButton.Location = new System.Drawing.Point(292, 515);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new System.Drawing.Size(80, 35);
            acceptButton.TabIndex = 6;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // backPanel
            // 
            backPanel.BackColor = System.Drawing.Color.FromArgb(187, 173, 160);
            backPanel.Controls.Add(playerNameTextBox);
            backPanel.Controls.Add(enterPlayerLabel);
            backPanel.Dock = System.Windows.Forms.DockStyle.Top;
            backPanel.Location = new System.Drawing.Point(0, 180);
            backPanel.Name = "backPanel";
            backPanel.Size = new System.Drawing.Size(384, 329);
            backPanel.TabIndex = 7;
            // 
            // UserCreationForm
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
            Name = "UserCreationForm";
            Text = "UserCreationForm";
            backPanel.ResumeLayout(false);
            backPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label enterPlayerLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Panel backPanel;
    }
}