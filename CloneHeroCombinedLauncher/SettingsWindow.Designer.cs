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
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            openFileDialog4 = new OpenFileDialog();
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog4";
            // 
            // NautilusPathButton
            // 
            NautilusPathButton.Location = new Point(516, 143);
            NautilusPathButton.Name = "NautilusPathButton";
            NautilusPathButton.Size = new Size(24, 23);
            NautilusPathButton.TabIndex = 10;
            NautilusPathButton.Text = "...";
            NautilusPathButton.UseVisualStyleBackColor = true;
            // 
            // BridgePathButton
            // 
            BridgePathButton.Location = new Point(516, 103);
            BridgePathButton.Name = "BridgePathButton";
            BridgePathButton.Size = new Size(24, 23);
            BridgePathButton.TabIndex = 7;
            BridgePathButton.Text = "...";
            BridgePathButton.UseVisualStyleBackColor = true;
            // 
            // CHPathButton
            // 
            CHPathButton.Location = new Point(516, 63);
            CHPathButton.Name = "CHPathButton";
            CHPathButton.Size = new Size(24, 23);
            CHPathButton.TabIndex = 4;
            CHPathButton.Text = "...";
            CHPathButton.UseVisualStyleBackColor = true;
            // 
            // EmuPathButton
            // 
            EmuPathButton.Location = new Point(516, 23);
            EmuPathButton.Name = "EmuPathButton";
            EmuPathButton.Size = new Size(24, 23);
            EmuPathButton.TabIndex = 1;
            EmuPathButton.Text = "...";
            EmuPathButton.UseVisualStyleBackColor = true;
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(47, 198);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(215, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Auto-run Emulator with Clone Hero";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(47, 228);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(323, 19);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "Auto-run Clone Hero after opening Combined Launcher";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(47, 258);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(311, 19);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "Auto-run Emulator after opening Combined Launcher";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // SettingsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 293);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
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

        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private OpenFileDialog openFileDialog4;
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
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}