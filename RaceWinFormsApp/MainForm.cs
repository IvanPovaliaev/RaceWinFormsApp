namespace RaceWinFormsApp
{
    public partial class MainForm : DoubleBufferedForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            _ = AudioProvider.PlayBGMAsync(@".\BGM");
            StaticData.MainForm = this;
            StaticData.ChildFormPanel = childFormPanel;
            if (Properties.Settings.Default.LastPlayerName == string.Empty)
            {
                WinFormsProvider.OpenChildForm(new UserCreationForm());
                return;
            }
            StaticData.Player = new Player(Properties.Settings.Default.LastPlayerName);
            WinFormsProvider.OpenChildForm(new MenuForm());
        }
    }
}
