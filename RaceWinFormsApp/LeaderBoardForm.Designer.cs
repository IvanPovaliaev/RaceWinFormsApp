namespace RaceWinFormsApp
{
    partial class LeaderBoardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            titleLabel = new System.Windows.Forms.Label();
            returnButton = new System.Windows.Forms.Button();
            exportButton = new System.Windows.Forms.Button();
            leaderboardDataGridView = new System.Windows.Forms.DataGridView();
            clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)leaderboardDataGridView).BeginInit();
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
            // returnButton
            // 
            returnButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            returnButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            returnButton.Location = new System.Drawing.Point(292, 515);
            returnButton.Name = "returnButton";
            returnButton.Size = new System.Drawing.Size(80, 35);
            returnButton.TabIndex = 5;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // exportButton
            // 
            exportButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            exportButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            exportButton.Location = new System.Drawing.Point(206, 515);
            exportButton.Name = "exportButton";
            exportButton.Size = new System.Drawing.Size(80, 35);
            exportButton.TabIndex = 6;
            exportButton.Text = "Export...";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // leaderboardDataGridView
            // 
            leaderboardDataGridView.AllowUserToAddRows = false;
            leaderboardDataGridView.AllowUserToDeleteRows = false;
            leaderboardDataGridView.AllowUserToOrderColumns = true;
            leaderboardDataGridView.AllowUserToResizeRows = false;
            leaderboardDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            leaderboardDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            leaderboardDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(187, 173, 160);
            leaderboardDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            leaderboardDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(119, 116, 101);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(250, 248, 239);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            leaderboardDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            leaderboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            leaderboardDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            leaderboardDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            leaderboardDataGridView.GridColor = System.Drawing.Color.FromArgb(187, 173, 160);
            leaderboardDataGridView.Location = new System.Drawing.Point(0, 180);
            leaderboardDataGridView.Name = "leaderboardDataGridView";
            leaderboardDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(250, 248, 239);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(250, 248, 239);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            leaderboardDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            leaderboardDataGridView.RowHeadersVisible = false;
            leaderboardDataGridView.Size = new System.Drawing.Size(384, 330);
            leaderboardDataGridView.TabIndex = 7;
            // 
            // clearButton
            // 
            clearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            clearButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            clearButton.Location = new System.Drawing.Point(12, 516);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(80, 35);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // LeaderBoardForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ClientSize = new System.Drawing.Size(384, 562);
            Controls.Add(leaderboardDataGridView);
            Controls.Add(returnButton);
            Controls.Add(clearButton);
            Controls.Add(exportButton);
            Controls.Add(titleLabel);
            DoubleBuffered = true;
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximumSize = new System.Drawing.Size(384, 562);
            MinimumSize = new System.Drawing.Size(384, 562);
            Name = "LeaderBoardForm";
            Text = "UserCreationForm";
            ((System.ComponentModel.ISupportInitialize)leaderboardDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.DataGridView leaderboardDataGridView;
        private System.Windows.Forms.Button clearButton;
    }
}