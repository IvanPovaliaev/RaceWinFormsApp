using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceWinFormsApp
{    
    public partial class LeaderBoardForm : Form
    {
        private BindingSource dataSource;
        public LeaderBoardForm()
        {
            InitializeComponent();
            InitializeLeaderboardTable();
        }

        private void InitializeLeaderboardTable()
        {
            var dataList = new BindingList<Player>(PlayerStorage.GetAll().OrderByDescending(player => player.Score).ToList());
            dataSource = new BindingSource(dataList, null);

            leaderboardDataGridView.DataSource = dataSource;
            leaderboardDataGridView.Columns[0].HeaderText = "Player";
            leaderboardDataGridView.Columns[1].HeaderText = "Score";
            leaderboardDataGridView.Columns[2].HeaderText = "Coins";
            leaderboardDataGridView.Columns[3].HeaderText = "Date";
            leaderboardDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            leaderboardDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            leaderboardDataGridView.DefaultCellStyle.BackColor = Color.FromArgb(204, 192, 179);
            leaderboardDataGridView.DefaultCellStyle.ForeColor = Color.Black;

            leaderboardDataGridView.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold);
            leaderboardDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold);
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            PlayerStorage.Clear();
            dataSource.Clear();
        }
        private void exportButton_Click(object sender, EventArgs e)
        {
            var sfDialog = new SaveFileDialog();
            sfDialog.FileName = "RaceGame_Leaderboard";
            sfDialog.Filter = "|*.xlsx";

            if (sfDialog.ShowDialog() != DialogResult.OK) return;

            FileProvider.ExportCollectionExcel(sfDialog.FileName, "Leaderboard", dataSource.List.Cast<Player>());

            var dialogOpen = MessageBox.Show("Open created file?", "Open created file",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogOpen != DialogResult.Yes) return;
            Task.Factory.StartNew(() =>
            {
                sfDialog.FileName.OpenCreatedFile();
            });
        }
        private void returnButton_Click(object sender, EventArgs e) => WinFormsProvider.OpenChildForm(new MenuForm());
    }
}
