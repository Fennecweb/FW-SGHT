using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FW_SteamGameHosterThing
{
    public partial class GameserverControlPanel : UserControl
    {
        private GameServerWrapper _serverInstance;


        public GameserverControlPanel()
        {
            InitializeComponent();
        }

        private void button_ServerStartStop_Click(object sender, EventArgs e)
        {
            if (_serverInstance == null)
            {
                _serverInstance = new GameServerWrapper(textBox_ExecuteableName.Text, textBox_ServerCommandLine.Text);
                richTextBox_ServerLogs.AppendText(_serverInstance.Logs.GetAllLogs());
                _serverInstance.Logs.NewLog += Logs_NewLog;
            }

            if (!_serverInstance.IsRunning)
            {
                richTextBox_ServerLogs.AppendText("Start command returned:" + _serverInstance.Start());
            }
            else
            {
                if (MessageBox.Show("The server will be killed. If you want a graceful shutdown, use the command input to tell it to quit.", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    _serverInstance.Kill();
            }
            if (_serverInstance.IsRunning)
            {
                label_ServerStatus.Text = "Running (PID " + _serverInstance.RunningProcess.Id + ")";
                button_ServerStartStop.Text = "STOP";
            }
            else
            {
                label_ServerStatus.Text = "Stopped";
                button_ServerStartStop.Text = "Start";
            }
        }

        delegate void crossThreadDelegateForLogs(FW_SteamGameHosterThing.ServerLogsManager.ServerLogs.ServerLogItem logitem);
        void Logs_NewLog(FW_SteamGameHosterThing.ServerLogsManager.ServerLogs.ServerLogItem logitem)
        {
            if (richTextBox_ServerLogs.InvokeRequired)
                richTextBox_ServerLogs.Invoke(new crossThreadDelegateForLogs(Logs_NewLog), logitem);
            else
            {
                richTextBox_ServerLogs.AppendText(logitem.ToString() + Environment.NewLine);
                richTextBox_ServerLogs.ScrollToCaret();
            }
        }

        private void textBox_ServerInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _serverInstance.GiveCommand(textBox_ServerInput.Text);
                textBox_ServerInput.Text = "";
            }
        }

        
    }
}
