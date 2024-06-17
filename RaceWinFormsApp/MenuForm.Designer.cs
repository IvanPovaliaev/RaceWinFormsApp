namespace RaceWinFormsApp
{
    partial class MenuForm
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
            startButton = new System.Windows.Forms.Button();
            settingsButton = new System.Windows.Forms.Button();
            exitButton = new System.Windows.Forms.Button();
            helpButton = new System.Windows.Forms.Button();
            leaderBoardButton = new System.Windows.Forms.Button();
            changePlayerButton = new System.Windows.Forms.Button();
            playerLabel = new System.Windows.Forms.Label();
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
            // startButton
            // 
            startButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            startButton.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            startButton.Location = new System.Drawing.Point(112, 249);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(160, 50);
            startButton.TabIndex = 3;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            settingsButton.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            settingsButton.Location = new System.Drawing.Point(112, 361);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new System.Drawing.Size(160, 50);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            exitButton.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            exitButton.Location = new System.Drawing.Point(112, 417);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(160, 50);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // helpButton
            // 
            helpButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            helpButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            helpButton.Location = new System.Drawing.Point(292, 515);
            helpButton.Name = "helpButton";
            helpButton.Size = new System.Drawing.Size(80, 35);
            helpButton.TabIndex = 3;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // leaderBoardButton
            // 
            leaderBoardButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            leaderBoardButton.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            leaderBoardButton.Location = new System.Drawing.Point(112, 305);
            leaderBoardButton.Name = "leaderBoardButton";
            leaderBoardButton.Size = new System.Drawing.Size(160, 50);
            leaderBoardButton.TabIndex = 3;
            leaderBoardButton.Text = "Results";
            leaderBoardButton.UseVisualStyleBackColor = true;
            leaderBoardButton.Click += leaderBoardButton_Click;
            // 
            // changePlayerButton
            // 
            changePlayerButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            changePlayerButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            changePlayerButton.Location = new System.Drawing.Point(112, 515);
            changePlayerButton.Name = "changePlayerButton";
            changePlayerButton.Size = new System.Drawing.Size(160, 35);
            changePlayerButton.TabIndex = 3;
            changePlayerButton.Text = "Change player";
            changePlayerButton.UseVisualStyleBackColor = true;
            changePlayerButton.Click += changePlayerButton_Click;
            // 
            // playerLabel
            // 
            playerLabel.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            playerLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            playerLabel.ForeColor = System.Drawing.Color.White;
            playerLabel.Location = new System.Drawing.Point(0, 146);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new System.Drawing.Size(384, 34);
            playerLabel.TabIndex = 4;
            playerLabel.Text = "Player: NoName";
            playerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ClientSize = new System.Drawing.Size(368, 523);
            Controls.Add(playerLabel);
            Controls.Add(exitButton);
            Controls.Add(changePlayerButton);
            Controls.Add(helpButton);
            Controls.Add(leaderBoardButton);
            Controls.Add(settingsButton);
            Controls.Add(startButton);
            Controls.Add(titleLabel);
            DoubleBuffered = true;
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximumSize = new System.Drawing.Size(384, 562);
            MinimumSize = new System.Drawing.Size(384, 562);
            Name = "MenuForm";
            Text = "MenuForm";
            FormClosed += MenuForm_FormClosed;
            Load += MenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button leaderBoardButton;
        private System.Windows.Forms.Button changePlayerButton;
        private System.Windows.Forms.Label playerLabel;
    }
}