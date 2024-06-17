namespace RaceWinFormsApp
{
    partial class GameForm
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
            pauseButton = new System.Windows.Forms.Button();
            topPanel = new System.Windows.Forms.Panel();
            coinsLabel = new System.Windows.Forms.Label();
            scoreLabel = new System.Windows.Forms.Label();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pauseButton
            // 
            pauseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pauseButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            pauseButton.Location = new System.Drawing.Point(12, 710);
            pauseButton.MaximumSize = new System.Drawing.Size(80, 40);
            pauseButton.MinimumSize = new System.Drawing.Size(80, 40);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new System.Drawing.Size(80, 40);
            pauseButton.TabIndex = 3;
            pauseButton.Text = "Pause";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.Black;
            topPanel.Controls.Add(coinsLabel);
            topPanel.Controls.Add(scoreLabel);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(384, 60);
            topPanel.TabIndex = 4;
            // 
            // coinsLabel
            // 
            coinsLabel.AutoSize = true;
            coinsLabel.BackColor = System.Drawing.Color.Transparent;
            coinsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Bold);
            coinsLabel.ForeColor = System.Drawing.Color.White;
            coinsLabel.Location = new System.Drawing.Point(226, 9);
            coinsLabel.Name = "coinsLabel";
            coinsLabel.Size = new System.Drawing.Size(109, 40);
            coinsLabel.TabIndex = 0;
            coinsLabel.Text = "Coins:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = System.Drawing.Color.Transparent;
            scoreLabel.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Bold);
            scoreLabel.ForeColor = System.Drawing.Color.White;
            scoreLabel.Location = new System.Drawing.Point(12, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(110, 40);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "Score:";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ClientSize = new System.Drawing.Size(384, 761);
            Controls.Add(topPanel);
            Controls.Add(pauseButton);
            DoubleBuffered = true;
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "GameForm";
            Text = "GameForm";
            FormClosed += GameForm_FormClosed;
            Load += GameForm_Load;
            EnabledChanged += GameForm_EnabledChanged;
            PreviewKeyDown += GameForm_PreviewKeyDown;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label coinsLabel;
    }
}