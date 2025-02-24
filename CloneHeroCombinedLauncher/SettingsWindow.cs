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
            EmuPathBox.Text = Settings.Default.EmuPath;
            CHPathBox.Text = Settings.Default.CHPath;
            BridgePathBox.Text = Settings.Default.BridgePath;
            NautilusPathBox.Text = Settings.Default.NautilusPath;
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
            Settings.Default.EmuPath = EmuPathBox.Text;
            Settings.Default.CHPath = CHPathBox.Text;
            Settings.Default.BridgePath = BridgePathBox.Text;
            Settings.Default.NautilusPath = NautilusPathBox.Text;
            Settings.Default.EmuWithCH = EmuWithCH_CheckBox.Checked;
            Settings.Default.AutoREmu = AutoREmu_CheckBox.Checked;
            Settings.Default.AutoRCH = AutoRCH_CheckBox.Checked;
            Settings.Default.Save();
            this.Close();
        }
    }
}