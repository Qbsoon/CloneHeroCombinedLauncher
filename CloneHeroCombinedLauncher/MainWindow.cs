namespace CloneHeroCombinedLauncher
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // TODO: Open Songs directory button
            // TODO: Settings button
            // TODO: Setting paths in Settings
            // TODO: Ask for paths at first run
            // TODO: Setting auto-launch on run with adjustable delays
            // TODO: Setting to always launch controller emulator with clone hero
            // TODO: Polish, add images to buttons, add some background
            // TODO: Polish language

        }

        private void EmuButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Settings.EmuPath);
        }

        private void CHButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Settings.CHPath);
        }

        private void BridgeButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Settings.BridgePath);
        }

        private void NautilusButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Settings.NautilusPath);
        }
    }
}
