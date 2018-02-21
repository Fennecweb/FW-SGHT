namespace FW_SteamGameHosterThing
{
    partial class GameserverControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_GameServerLaunchControl = new System.Windows.Forms.GroupBox();
            this.textBox_ServerInput = new System.Windows.Forms.TextBox();
            this.label_ServerStatus = new System.Windows.Forms.Label();
            this.textBox_ExecuteableName = new System.Windows.Forms.TextBox();
            this.textBox_ServerCommandLine = new System.Windows.Forms.TextBox();
            this.checkBox_AutoRestart = new System.Windows.Forms.CheckBox();
            this.label_ServerLogsLabel = new System.Windows.Forms.Label();
            this.richTextBox_ServerLogs = new System.Windows.Forms.RichTextBox();
            this.button_ServerStartStop = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox_GameServerLaunchControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_GameServerLaunchControl
            // 
            this.groupBox_GameServerLaunchControl.Controls.Add(this.comboBox1);
            this.groupBox_GameServerLaunchControl.Controls.Add(this.textBox_ServerInput);
            this.groupBox_GameServerLaunchControl.Controls.Add(this.label_ServerStatus);
            this.groupBox_GameServerLaunchControl.Controls.Add(this.textBox_ExecuteableName);
            this.groupBox_GameServerLaunchControl.Controls.Add(this.textBox_ServerCommandLine);
            this.groupBox_GameServerLaunchControl.Controls.Add(this.checkBox_AutoRestart);
            this.groupBox_GameServerLaunchControl.Controls.Add(this.label_ServerLogsLabel);
            this.groupBox_GameServerLaunchControl.Controls.Add(this.richTextBox_ServerLogs);
            this.groupBox_GameServerLaunchControl.Controls.Add(this.button_ServerStartStop);
            this.groupBox_GameServerLaunchControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_GameServerLaunchControl.Location = new System.Drawing.Point(0, 0);
            this.groupBox_GameServerLaunchControl.Name = "groupBox_GameServerLaunchControl";
            this.groupBox_GameServerLaunchControl.Size = new System.Drawing.Size(299, 298);
            this.groupBox_GameServerLaunchControl.TabIndex = 0;
            this.groupBox_GameServerLaunchControl.TabStop = false;
            this.groupBox_GameServerLaunchControl.Text = "Gameserver Launch Control";
            // 
            // textBox_ServerInput
            // 
            this.textBox_ServerInput.Location = new System.Drawing.Point(74, 157);
            this.textBox_ServerInput.Name = "textBox_ServerInput";
            this.textBox_ServerInput.Size = new System.Drawing.Size(214, 20);
            this.textBox_ServerInput.TabIndex = 7;
            this.textBox_ServerInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ServerInput_KeyDown);
            // 
            // label_ServerStatus
            // 
            this.label_ServerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ServerStatus.AutoSize = true;
            this.label_ServerStatus.Location = new System.Drawing.Point(211, 68);
            this.label_ServerStatus.Name = "label_ServerStatus";
            this.label_ServerStatus.Size = new System.Drawing.Size(69, 13);
            this.label_ServerStatus.TabIndex = 6;
            this.label_ServerStatus.Text = "Not initialized";
            // 
            // textBox_ExecuteableName
            // 
            this.textBox_ExecuteableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ExecuteableName.Location = new System.Drawing.Point(6, 45);
            this.textBox_ExecuteableName.Name = "textBox_ExecuteableName";
            this.textBox_ExecuteableName.Size = new System.Drawing.Size(180, 20);
            this.textBox_ExecuteableName.TabIndex = 5;
            // 
            // textBox_ServerCommandLine
            // 
            this.textBox_ServerCommandLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ServerCommandLine.Location = new System.Drawing.Point(6, 72);
            this.textBox_ServerCommandLine.MaxLength = 8128;
            this.textBox_ServerCommandLine.Multiline = true;
            this.textBox_ServerCommandLine.Name = "textBox_ServerCommandLine";
            this.textBox_ServerCommandLine.Size = new System.Drawing.Size(180, 76);
            this.textBox_ServerCommandLine.TabIndex = 4;
            // 
            // checkBox_AutoRestart
            // 
            this.checkBox_AutoRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_AutoRestart.AutoSize = true;
            this.checkBox_AutoRestart.Location = new System.Drawing.Point(205, 48);
            this.checkBox_AutoRestart.Name = "checkBox_AutoRestart";
            this.checkBox_AutoRestart.Size = new System.Drawing.Size(80, 17);
            this.checkBox_AutoRestart.TabIndex = 3;
            this.checkBox_AutoRestart.Text = "Auto restart";
            this.checkBox_AutoRestart.UseVisualStyleBackColor = true;
            // 
            // label_ServerLogsLabel
            // 
            this.label_ServerLogsLabel.AutoSize = true;
            this.label_ServerLogsLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_ServerLogsLabel.Location = new System.Drawing.Point(3, 176);
            this.label_ServerLogsLabel.Name = "label_ServerLogsLabel";
            this.label_ServerLogsLabel.Size = new System.Drawing.Size(64, 13);
            this.label_ServerLogsLabel.TabIndex = 2;
            this.label_ServerLogsLabel.Text = "Server Logs";
            // 
            // richTextBox_ServerLogs
            // 
            this.richTextBox_ServerLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_ServerLogs.Location = new System.Drawing.Point(3, 189);
            this.richTextBox_ServerLogs.Name = "richTextBox_ServerLogs";
            this.richTextBox_ServerLogs.ReadOnly = true;
            this.richTextBox_ServerLogs.Size = new System.Drawing.Size(293, 106);
            this.richTextBox_ServerLogs.TabIndex = 1;
            this.richTextBox_ServerLogs.Text = "";
            // 
            // button_ServerStartStop
            // 
            this.button_ServerStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ServerStartStop.Location = new System.Drawing.Point(210, 19);
            this.button_ServerStartStop.Name = "button_ServerStartStop";
            this.button_ServerStartStop.Size = new System.Drawing.Size(75, 23);
            this.button_ServerStartStop.TabIndex = 0;
            this.button_ServerStartStop.Text = "Start/Stop";
            this.button_ServerStartStop.UseVisualStyleBackColor = true;
            this.button_ServerStartStop.Click += new System.EventHandler(this.button_ServerStartStop_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // GameserverControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_GameServerLaunchControl);
            this.Name = "GameserverControlPanel";
            this.Size = new System.Drawing.Size(299, 298);
            this.groupBox_GameServerLaunchControl.ResumeLayout(false);
            this.groupBox_GameServerLaunchControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_GameServerLaunchControl;
        private System.Windows.Forms.Label label_ServerLogsLabel;
        private System.Windows.Forms.RichTextBox richTextBox_ServerLogs;
        private System.Windows.Forms.Button button_ServerStartStop;
        private System.Windows.Forms.CheckBox checkBox_AutoRestart;
        private System.Windows.Forms.TextBox textBox_ServerCommandLine;
        private System.Windows.Forms.Label label_ServerStatus;
        private System.Windows.Forms.TextBox textBox_ExecuteableName;
        private System.Windows.Forms.TextBox textBox_ServerInput;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
