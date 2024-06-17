namespace RaceWinFormsApp
{
    partial class PauseForm
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
            pauseLabel = new System.Windows.Forms.Label();
            resumeButton = new System.Windows.Forms.Button();
            exitButton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pauseLabel
            // 
            pauseLabel.BackColor = System.Drawing.Color.Transparent;
            pauseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            pauseLabel.Font = new System.Drawing.Font("Microsoft YaHei", 80F, System.Drawing.FontStyle.Bold);
            pauseLabel.ForeColor = System.Drawing.Color.Black;
            pauseLabel.Location = new System.Drawing.Point(0, 0);
            pauseLabel.Margin = new System.Windows.Forms.Padding(0);
            pauseLabel.Name = "pauseLabel";
            pauseLabel.Size = new System.Drawing.Size(384, 141);
            pauseLabel.TabIndex = 0;
            pauseLabel.Text = "Pause";
            pauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resumeButton
            // 
            resumeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            resumeButton.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            resumeButton.Location = new System.Drawing.Point(112, 417);
            resumeButton.Name = "resumeButton";
            resumeButton.Size = new System.Drawing.Size(160, 60);
            resumeButton.TabIndex = 3;
            resumeButton.Text = "Resume";
            resumeButton.UseVisualStyleBackColor = true;
            resumeButton.Click += rusumeButton_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            exitButton.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            exitButton.Location = new System.Drawing.Point(112, 483);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(160, 60);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.RacingFlag;
            pictureBox1.Location = new System.Drawing.Point(0, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(384, 315);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // PauseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ClientSize = new System.Drawing.Size(384, 562);
            Controls.Add(resumeButton);
            Controls.Add(pictureBox1);
            Controls.Add(exitButton);
            Controls.Add(pauseLabel);
            DoubleBuffered = true;
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "PauseForm";
            Text = "PauseForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}