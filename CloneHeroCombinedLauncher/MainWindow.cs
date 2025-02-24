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
            if (Settings.Default.BridgePath == "undefined")
            {
                MessageBox.Show("Bridge path is not set. Please set it in settings.");
                return;
            }
            System.Diagnostics.Process.Start(Settings.Default.BridgePath);
        }

        private void NautilusButton_Click(object sender, EventArgs e)
        {
            if (Settings.Default.NautilusPath == "undefined")
            {
                MessageBox.Show("Nautilus path is not set. Please set it in settings.");
                return;
            }
            System.Diagnostics.Process.Start(Settings.Default.NautilusPath);
        }

        public void runEmu(string rEPath)
        {
            if (rEPath == "undefined")
            {
                MessageBox.Show("Emulator path is not set. Please set it in settings.");
                return;
            }
            System.Diagnostics.Process.Start(rEPath);
        }

        public void runCH(string rCHPath)
        {
            if (rCHPath == "undefined")
            {
                MessageBox.Show("Clone Hero path is not set. Please set it in settings.");
                return;
            }
            System.Diagnostics.Process.Start(rCHPath);
        }

        private void songsButton_Click(object sender, EventArgs e)
        {
            string songsDirectory = Environment.ExpandEnvironmentVariables(Settings.Default.SongsDir);
            System.Diagnostics.Process.Start("explorer.exe", songsDirectory);
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