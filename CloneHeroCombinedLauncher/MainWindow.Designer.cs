namespace CloneHeroCombinedLauncher
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CHButton = new Button();
            EmuButton = new Button();
            BridgeButton = new Button();
            NautilusButton = new Button();
            settingsButton = new Button();
            exitButton = new Button();
            songsButton = new Button();
            SuspendLayout();
            // 
            // CHButton
            // 
            CHButton.Location = new Point(43, 88);
            CHButton.Name = "CHButton";
            CHButton.Size = new Size(75, 23);
            CHButton.TabIndex = 0;
            CHButton.Text = "Clone Hero";
            CHButton.UseVisualStyleBackColor = true;
            CHButton.Click += CHButton_Click;
            // 
            // EmuButton
            // 
            EmuButton.Location = new Point(43, 21);
            EmuButton.Name = "EmuButton";
            EmuButton.Size = new Size(75, 49);
            EmuButton.TabIndex = 1;
            EmuButton.Text = "Controller Emulator";
            EmuButton.UseVisualStyleBackColor = true;
            EmuButton.Click += EmuButton_Click;
            // 
            // BridgeButton
            // 
            BridgeButton.Location = new Point(148, 21);
            BridgeButton.Name = "BridgeButton";
            BridgeButton.Size = new Size(75, 23);
            BridgeButton.TabIndex = 2;
            BridgeButton.Text = "Bridge";
            BridgeButton.UseVisualStyleBackColor = true;
            BridgeButton.Click += BridgeButton_Click;
            // 
            // NautilusButton
            // 
            NautilusButton.Location = new Point(148, 57);
            NautilusButton.Name = "NautilusButton";
            NautilusButton.Size = new Size(75, 23);
            NautilusButton.TabIndex = 3;
            NautilusButton.Text = "Nautilus";
            NautilusButton.UseVisualStyleBackColor = true;
            NautilusButton.Click += NautilusButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(148, 129);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(75, 23);
            settingsButton.TabIndex = 4;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(43, 129);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // songsButton
            // 
            songsButton.Location = new Point(148, 93);
            songsButton.Name = "songsButton";
            songsButton.Size = new Size(75, 23);
            songsButton.TabIndex = 6;
            songsButton.Text = "Songs";
            songsButton.UseVisualStyleBackColor = true;
            songsButton.Click += songsButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 175);
            Controls.Add(songsButton);
            Controls.Add(exitButton);
            Controls.Add(settingsButton);
            Controls.Add(NautilusButton);
            Controls.Add(BridgeButton);
            Controls.Add(EmuButton);
            Controls.Add(CHButton);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CHButton;
        private Button EmuButton;
        private Button BridgeButton;
        private Button NautilusButton;
        private Button settingsButton;
        private Button exitButton;
        private Button songsButton;
    }
}
