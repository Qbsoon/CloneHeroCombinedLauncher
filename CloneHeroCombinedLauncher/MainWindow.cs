using System.IO;

namespace CloneHeroCombinedLauncher
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            if (Settings.Default.AutoREmu)
            {
                runEmu(Settings.Default.EmuPath);
                if (Settings.Default.AutoRCH)
                {
                    Thread.Sleep(Settings.Default.CHDelayForEmu);
                    runCH(Settings.Default.CHPath);
                }
            }
            else
            {
                if (Settings.Default.AutoRCH)
                {
                    runCH(Settings.Default.CHPath);
                }
            }
            // TODO: Open Songs directory button
            // TODO: Settings button
            // TODO: Ask for paths at first run
            // TODO: Polish, add images to buttons, add some background
            // TODO: Polish language

        }

        private void EmuButton_Click(object sender, EventArgs e)
        {
            runEmu(Settings.Default.EmuPath);
        }

        private void CHButton_Click(object sender, EventArgs e)
        {
            if (Settings.Default.EmuWithCH)
            {
                runEmu(Settings.Default.EmuPath);
                Thread.Sleep(Settings.Default.CHDelayForEmu);
                runCH(Settings.Default.CHPath);
            }
            else
            {
                runCH(Settings.Default.CHPath);
            }
        }

        private void BridgeButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Settings.Default.BridgePath);
        }

        private void NautilusButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Settings.Default.NautilusPath);
        }

        public void runEmu(string rEPath)
        {
            System.Diagnostics.Process.Start(rEPath);
        }

        public void runCH(string rCHPath)
        {
            System.Diagnostics.Process.Start(rCHPath);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsWindow SW_Instance = new SettingsWindow();
            SW_Instance.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}