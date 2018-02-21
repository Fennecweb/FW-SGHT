using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;



namespace FW_SteamGameHosterThing
{
    /// <summary>
    /// Wraps the server executable, exposing an interface to give it commands and extract logs.
    /// </summary>
    class GameServerWrapper
    {
        #region Variables and properties
        private ProcessStartInfo _processInfo;
        private Process _runningProcess;
        private FW_SteamGameHosterThing.ServerLogsManager.ServerLogs _serverLogs;
        public FW_SteamGameHosterThing.ServerLogsManager.ServerLogs Logs { get { return _serverLogs; } }

        public Process RunningProcess { get { return _runningProcess; } }

        public bool IsRunning
        {
            get
            {
                if (_runningProcess == null)
                    return false;

                try
                {
                    Process.GetProcessById(_runningProcess.Id);
                    return true;
                }
                catch (ArgumentException)
                {
                    return false;
                }

            }
        }
        #endregion

        public GameServerWrapper(string executableName, string arguments)
        {
            _serverLogs = new FW_SteamGameHosterThing.ServerLogsManager.ServerLogs(executableName);
            _serverLogs.WriteLog("Initializing server wrapper", DateTime.Now, FW_SteamGameHosterThing.ServerLogsManager.ServerLogs.ServerLogItem.LogItemSeverity.Debug);
            ProcessStartInfo pStartInfo = new ProcessStartInfo(executableName, arguments);
            pStartInfo.UseShellExecute = false; //don't use the shell to execute, otherwise we can't redirect std in/out/err
            pStartInfo.RedirectStandardError = true;
            pStartInfo.RedirectStandardInput = true;
            pStartInfo.RedirectStandardOutput = true; //redirect all the streams
            
            pStartInfo.CreateNoWindow = true; //hide the window
            _processInfo = pStartInfo;
            


        }
        #region Functions
        public bool Start()
        {
            if (IsRunning)
            {
                Logs.WriteLog("Not starting server; Already running", DateTime.Now, FW_SteamGameHosterThing.ServerLogsManager.ServerLogs.ServerLogItem.LogItemSeverity.Warning);
                return false;
            }

            try
            {
                Logs.WriteLog("Attempting to start server", DateTime.Now, FW_SteamGameHosterThing.ServerLogsManager.ServerLogs.ServerLogItem.LogItemSeverity.Debug);
                _runningProcess = Process.Start(_processInfo);
                _runningProcess.EnableRaisingEvents = true; //who came up with this joke? cost me like 1 hour :(
                _runningProcess.Exited += _runningProcess_Exited;
                _runningProcess.OutputDataReceived += _runningProcess_OutputDataReceived;
                _runningProcess.BeginOutputReadLine();// and at least another 30 minutes >8v
                Logs.WriteLog("Server started successfully", DateTime.Now, FW_SteamGameHosterThing.ServerLogsManager.ServerLogs.ServerLogItem.LogItemSeverity.Information);
                Logs.WriteLog("IsRunning: " + IsRunning, DateTime.Now, FW_SteamGameHosterThing.ServerLogsManager.ServerLogs.ServerLogItem.LogItemSeverity.Debug);
                return IsRunning;
            }
            catch (Exception ex)
            {
                Logs.WriteLog("Error while trying to start process: " + ex.Message, DateTime.Now, FW_SteamGameHosterThing.ServerLogsManager.ServerLogs.ServerLogItem.LogItemSeverity.Error);
                return false;
            }

        }

        void _runningProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            _serverLogs.WriteLog(e.Data, DateTime.Now, FW_SteamGameHosterThing.ServerLogsManager.ServerLogs.ServerLogItem.LogItemSeverity.Information);
        }

        void _runningProcess_Exited(object sender, EventArgs e)
        {
            Logs.WriteLog("The process has exited.", DateTime.Now, FW_SteamGameHosterThing.ServerLogsManager.ServerLogs.ServerLogItem.LogItemSeverity.Debug);
        }

        public bool Kill()
        {
            try
            {
                Logs.WriteLog("Attempting to kill executable..", DateTime.Now, FW_SteamGameHosterThing.ServerLogsManager.ServerLogs.ServerLogItem.LogItemSeverity.Debug);
                _runningProcess.Kill();
                bool success = _runningProcess.WaitForExit(5000);
                Logs.WriteLog("Killed process: " + success, DateTime.Now, FW_SteamGameHosterThing.ServerLogsManager.ServerLogs.ServerLogItem.LogItemSeverity.Information);

                return success;
            }
            catch (Exception ex)
            {
                Logs.WriteLog("Error while trying to kill process: " + ex.Message, DateTime.Now, FW_SteamGameHosterThing.ServerLogsManager.ServerLogs.ServerLogItem.LogItemSeverity.Error);
                return false;
            }
        }

        public void GiveCommand(string command)
        {
            _runningProcess.StandardInput.Write(command + Environment.NewLine);
            _runningProcess.StandardInput.Flush(); //This should work though I have not yet tested it
        }

        #endregion

        #region Internal Classes


        #endregion
    }
}
