using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW_SteamGameHosterThing
{
    public class ServerLogsManager
    {
        public ServerLogsManager()
        {
        }

        public class ServerLogs
        {
            private string _name;
            private List<ServerLogItem> _logs;

            public delegate void newLogNotifyDel(ServerLogItem logitem);
            public event newLogNotifyDel NewLog;

            public List<ServerLogItem> Logs { get { return _logs; } }


            public ServerLogs(string name = "FW server logger")
            {
                _name = name;
                _logs = new List<ServerLogItem>();
                WriteLog("Logger " + name + " initialized", DateTime.Now, ServerLogItem.LogItemSeverity.Debug);
            }

            public void WriteLog(string log, DateTime timestamp, ServerLogItem.LogItemSeverity severity)
            {
                ServerLogItem logitem = new ServerLogItem(log, timestamp, severity);
                _logs.Add(logitem);
                if (NewLog != null)
                    NewLog(logitem);
            }

            public string GetAllLogs()
            {
                StringBuilder output = new StringBuilder();
                foreach (var item in Logs)
                {
                    output.AppendLine(item.ToString());
                }
                return output.ToString();
            }


            public class ServerLogItem
            {
                public string Log { get; set; }
                public LogItemSeverity Severity { get; set; }
                public DateTime Timestamp { get; set; }


                public ServerLogItem() { }
                public ServerLogItem(string log, DateTime timestamp, LogItemSeverity severity)
                {
                    Log = log;
                    Severity = severity;
                    Timestamp = timestamp;
                }


                public enum LogItemSeverity
                {
                    Debug, Information, Warning, Error, Critical
                }

                public override string ToString()
                {
                    return Timestamp.ToLongTimeString() + "|" + Severity.ToString() + "|" + Log;
                }
            }
        }
    }
}
