using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloneHeroCombinedLauncher
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
            EmuPathBox.Text = AppDataSettings.GetSetting("EmuPath", "undefined");
            CHPathBox.Text = AppDataSettings.GetSetting("CHPath", "undefined");
            BridgePathBox.Text = AppDataSettings.GetSetting("BridgePath", "undefined");
            NautilusPathBox.Text = AppDataSettings.GetSetting("NautilusPath", "undefined");
            EmuWithCH_CheckBox.Checked = bool.Parse(AppDataSettings.GetSetting("EmuWithCH", "false"));
            AutoREmu_CheckBox.Checked = bool.Parse(AppDataSettings.GetSetting("AutoREmu", "false"));
            AutoRCH_CheckBox.Checked = bool.Parse(AppDataSettings.GetSetting("AutoRCH", "false"));
        }

        private void EmuPathButton_Click(object sender, EventArgs e)
        {
            EmuOpenDialog.ShowDialog();
            EmuPathBox.Text = EmuOpenDialog.FileName;
        }

        private void CHPathButton_Click(object sender, EventArgs e)
        {
            CHOpenDialog.ShowDialog();
            CHPathBox.Text = CHOpenDialog.FileName;
        }

        private void BridgePathButton_Click(object sender, EventArgs e)
        {
            BridgeOpenDialog.ShowDialog();
            BridgePathBox.Text = BridgeOpenDialog.FileName;
        }

        private void NautilusPathButton_Click(object sender, EventArgs e)
        {
            NautilusOpenDialog.ShowDialog();
            NautilusPathBox.Text = NautilusOpenDialog.FileName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AppDataSettings.SetSetting("EmuPath", EmuPathBox.Text);
            AppDataSettings.SetSetting("CHPath", CHPathBox.Text);
            AppDataSettings.SetSetting("BridgePath", BridgePathBox.Text);
            AppDataSettings.SetSetting("NautilusPath", NautilusPathBox.Text);
            AppDataSettings.SetSetting("EmuWithCH", EmuWithCH_CheckBox.Checked);
            AppDataSettings.SetSetting("AutoREmu", AutoREmu_CheckBox.Checked);
            AppDataSettings.SetSetting("AutoRCH", AutoRCH_CheckBox.Checked);
            this.Close();
        }
    }
}