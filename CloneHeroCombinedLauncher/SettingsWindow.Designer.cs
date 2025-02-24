namespace CloneHeroCombinedLauncher
{
    partial class SettingsWindow
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
            CHOpenDialog = new OpenFileDialog();
            EmuOpenDialog = new OpenFileDialog();
            BridgeOpenDialog = new OpenFileDialog();
            NautilusOpenDialog = new OpenFileDialog();
            NautilusPathButton = new Button();
            BridgePathButton = new Button();
            CHPathButton = new Button();
            EmuPathButton = new Button();
            NautilusPathBox = new TextBox();
            BridgePathBox = new TextBox();
            CHPathBox = new TextBox();
            EmuPathBox = new TextBox();
            NautilusPathLabel = new Label();
            BridgePathLabel = new Label();
            CHPathLabel = new Label();
            EmuPathLabel = new Label();
            EmuWithCH_CheckBox = new CheckBox();
            AutoRCH_CheckBox = new CheckBox();
            AutoREmu_CheckBox = new CheckBox();
            exitButton = new Button();
            SuspendLayout();
            // 
            // CHOpenDialog
            // 
            CHOpenDialog.FileName = "Clone Hero.exe";
            CHOpenDialog.InitialDirectory = "C:\\Program Files\\Clone Hero";
            // 
            // EmuOpenDialog
            // 
            EmuOpenDialog.FileName = "*.exe";
            EmuOpenDialog.InitialDirectory = "C:\\Program Files\\Clone Hero";
            // 
            // BridgeOpenDialog
            // 
            BridgeOpenDialog.FileName = "Bridge.exe";
            BridgeOpenDialog.InitialDirectory = "%localappdata%\\Programs\\Bridge";
            // 
            // NautilusOpenDialog
            // 
            NautilusOpenDialog.FileName = "Nautilus.exe";
            NautilusOpenDialog.InitialDirectory = "C:\\Program Files\\Clone Hero";
            // 
            // NautilusPathButton
            // 
            NautilusPathButton.Location = new Point(516, 143);
            NautilusPathButton.Name = "NautilusPathButton";
            NautilusPathButton.Size = new Size(24, 23);
            NautilusPathButton.TabIndex = 10;
            NautilusPathButton.Text = "...";
            NautilusPathButton.UseVisualStyleBackColor = true;
            NautilusPathButton.Click += NautilusPathButton_Click;
            // 
            // BridgePathButton
            // 
            BridgePathButton.Location = new Point(516, 103);
            BridgePathButton.Name = "BridgePathButton";
            BridgePathButton.Size = new Size(24, 23);
            BridgePathButton.TabIndex = 7;
            BridgePathButton.Text = "...";
            BridgePathButton.UseVisualStyleBackColor = true;
            BridgePathButton.Click += BridgePathButton_Click;
            // 
            // CHPathButton
            // 
            CHPathButton.Location = new Point(516, 63);
            CHPathButton.Name = "CHPathButton";
            CHPathButton.Size = new Size(24, 23);
            CHPathButton.TabIndex = 4;
            CHPathButton.Text = "...";
            CHPathButton.UseVisualStyleBackColor = true;
            CHPathButton.Click += CHPathButton_Click;
            // 
            // EmuPathButton
            // 
            EmuPathButton.Location = new Point(516, 23);
            EmuPathButton.Name = "EmuPathButton";
            EmuPathButton.Size = new Size(24, 23);
            EmuPathButton.TabIndex = 1;
            EmuPathButton.Text = "...";
            EmuPathButton.UseVisualStyleBackColor = true;
            EmuPathButton.Click += EmuPathButton_Click;
            // 
            // NautilusPathBox
            // 
            NautilusPathBox.Location = new Point(158, 143);
            NautilusPathBox.Name = "NautilusPathBox";
            NautilusPathBox.Size = new Size(352, 23);
            NautilusPathBox.TabIndex = 9;
            // 
            // BridgePathBox
            // 
            BridgePathBox.Location = new Point(158, 103);
            BridgePathBox.Name = "BridgePathBox";
            BridgePathBox.Size = new Size(352, 23);
            BridgePathBox.TabIndex = 6;
            // 
            // CHPathBox
            // 
            CHPathBox.Location = new Point(158, 63);
            CHPathBox.Name = "CHPathBox";
            CHPathBox.Size = new Size(352, 23);
            CHPathBox.TabIndex = 3;
            // 
            // EmuPathBox
            // 
            EmuPathBox.Location = new Point(158, 23);
            EmuPathBox.Name = "EmuPathBox";
            EmuPathBox.Size = new Size(352, 23);
            EmuPathBox.TabIndex = 0;
            // 
            // NautilusPathLabel
            // 
            NautilusPathLabel.AutoSize = true;
            NautilusPathLabel.Location = new Point(74, 147);
            NautilusPathLabel.Name = "NautilusPathLabel";
            NautilusPathLabel.Size = new Size(78, 15);
            NautilusPathLabel.TabIndex = 11;
            NautilusPathLabel.Text = "Nautilus Path";
            NautilusPathLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BridgePathLabel
            // 
            BridgePathLabel.AutoSize = true;
            BridgePathLabel.Location = new Point(84, 107);
            BridgePathLabel.Name = "BridgePathLabel";
            BridgePathLabel.Size = new Size(68, 15);
            BridgePathLabel.TabIndex = 8;
            BridgePathLabel.Text = "Bridge Path";
            BridgePathLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CHPathLabel
            // 
            CHPathLabel.AutoSize = true;
            CHPathLabel.Location = new Point(58, 67);
            CHPathLabel.Name = "CHPathLabel";
            CHPathLabel.Size = new Size(94, 15);
            CHPathLabel.TabIndex = 5;
            CHPathLabel.Text = "Clone Hero Path";
            CHPathLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EmuPathLabel
            // 
            EmuPathLabel.AutoSize = true;
            EmuPathLabel.Location = new Point(14, 27);
            EmuPathLabel.Name = "EmuPathLabel";
            EmuPathLabel.Size = new Size(138, 15);
            EmuPathLabel.TabIndex = 2;
            EmuPathLabel.Text = "Controller Emulator Path";
            EmuPathLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EmuWithCH_CheckBox
            // 
            EmuWithCH_CheckBox.AutoSize = true;
            EmuWithCH_CheckBox.Location = new Point(47, 198);
            EmuWithCH_CheckBox.Name = "EmuWithCH_CheckBox";
            EmuWithCH_CheckBox.Size = new Size(215, 19);
            EmuWithCH_CheckBox.TabIndex = 12;
            EmuWithCH_CheckBox.Text = "Auto-run Emulator with Clone Hero";
            EmuWithCH_CheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoRCH_CheckBox
            // 
            AutoRCH_CheckBox.AutoSize = true;
            AutoRCH_CheckBox.Location = new Point(47, 228);
            AutoRCH_CheckBox.Name = "AutoRCH_CheckBox";
            AutoRCH_CheckBox.Size = new Size(323, 19);
            AutoRCH_CheckBox.TabIndex = 13;
            AutoRCH_CheckBox.Text = "Auto-run Clone Hero after opening Combined Launcher";
            AutoRCH_CheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoREmu_CheckBox
            // 
            AutoREmu_CheckBox.AutoSize = true;
            AutoREmu_CheckBox.Location = new Point(47, 258);
            AutoREmu_CheckBox.Name = "AutoREmu_CheckBox";
            AutoREmu_CheckBox.Size = new Size(311, 19);
            AutoREmu_CheckBox.TabIndex = 14;
            AutoREmu_CheckBox.Text = "Auto-run Emulator after opening Combined Launcher";
            AutoREmu_CheckBox.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(478, 258);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 16;
            exitButton.Text = "Save";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += SaveButton_Click;
            // 
            // SettingsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 293);
            Controls.Add(exitButton);
            Controls.Add(AutoREmu_CheckBox);
            Controls.Add(AutoRCH_CheckBox);
            Controls.Add(EmuWithCH_CheckBox);
            Controls.Add(NautilusPathLabel);
            Controls.Add(NautilusPathButton);
            Controls.Add(NautilusPathBox);
            Controls.Add(BridgePathLabel);
            Controls.Add(BridgePathButton);
            Controls.Add(BridgePathBox);
            Controls.Add(CHPathLabel);
            Controls.Add(CHPathButton);
            Controls.Add(CHPathBox);
            Controls.Add(EmuPathLabel);
            Controls.Add(EmuPathButton);
            Controls.Add(EmuPathBox);
            Name = "SettingsWindow";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog CHOpenDialog;
        private OpenFileDialog EmuOpenDialog;
        private OpenFileDialog BridgeOpenDialog;
        private OpenFileDialog NautilusOpenDialog;
        private Button NautilusPathButton;
        private Button BridgePathButton;
        private Button CHPathButton;
        private Button EmuPathButton;
        private TextBox NautilusPathBox;
        private TextBox BridgePathBox;
        private TextBox CHPathBox;
        private TextBox EmuPathBox;
        private Label NautilusPathLabel;
        private Label BridgePathLabel;
        private Label CHPathLabel;
        private Label EmuPathLabel;
        private CheckBox EmuWithCH_CheckBox;
        private CheckBox AutoRCH_CheckBox;
        private CheckBox AutoREmu_CheckBox;
        private Button exitButton;
    }
}