using System.IO;

namespace CloneHeroCombinedLauncher
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            if (bool.Parse(AppDataSettings.GetSetting("AutoREmu", "false")))
            {
                runEmu(AppDataSettings.GetSetting("EmuPath", "undefined"));
                if (bool.Parse(AppDataSettings.GetSetting("AutoRCH", "false")))
                {
                    Thread.Sleep(int.Parse(AppDataSettings.GetSetting("CHDelayForEmu", "2500")));
                    runCH(AppDataSettings.GetSetting("CHPath", "undefined"));
                }
            }
            else
            {
                if (bool.Parse(AppDataSettings.GetSetting("AutoRCH", "false")))
                {
                    runCH(AppDataSettings.GetSetting("CHPath", "undefined"));
                }
            }
            // TODO: Polish, add images to buttons, add some background
            // TODO: Polish language

        }

        private void EmuButton_Click(object sender, EventArgs e)
        {
            runEmu(AppDataSettings.GetSetting("EmuPath", "undefined"));
        }

        private void CHButton_Click(object sender, EventArgs e)
        {
            if (bool.Parse(AppDataSettings.GetSetting("EmuWithCH", "false")))
            {
                runEmu(AppDataSettings.GetSetting("EmuPath", "undefined"));
                Thread.Sleep(int.Parse(AppDataSettings.GetSetting("CHDelayForEmu", "2500")));
                runCH(AppDataSettings.GetSetting("CHPath", "undefined"));
            }
            else
            {
                runCH(AppDataSettings.GetSetting("CHPath", "undefined"));
            }
        }

        private void BridgeButton_Click(object sender, EventArgs e)
        {
            if (AppDataSettings.GetSetting("BridgePath", "undefined") == "undefined")
            {
                MessageBox.Show("Bridge path is not set. Please set it in settings.");
                return;
            }
            System.Diagnostics.Process.Start(AppDataSettings.GetSetting("BridgePath", "undefined"));
        }

        private void NautilusButton_Click(object sender, EventArgs e)
        {
            if (AppDataSettings.GetSetting("NautilusPath", "undefined") == "undefined")
            {
                MessageBox.Show("Nautilus path is not set. Please set it in settings.");
                return;
            }
            System.Diagnostics.Process.Start(AppDataSettings.GetSetting("NautilusPath", "undefined"));
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
            string songsDirectory = Environment.ExpandEnvironmentVariables(AppDataSettings.GetSetting("SongsDir", "%USERPROFILE%\\Documents\\Clone Hero\\Songs\\"));
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