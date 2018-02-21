using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Diagnostics;

namespace FW_SteamGameHosterThing
{
    class ServerConfigManager
    {
        const string configlockfilename = ".configlock";
        public ServerConfigManager()
        {
            int currentPID = System.Diagnostics.Process.GetCurrentProcess().Id;
            if (File.Exists(configlockfilename))
            {
                int configlockfilecontents = int.Parse(File.ReadAllText(configlockfilename));
                if (configlockfilecontents != currentPID)
                {
                    bool isrunning = false;
                    try
                    {
                        Process.GetProcessById(configlockfilecontents);
                        isrunning = true;
                    }
                    catch (ArgumentException)
                    {

                    }//TODO: Logging once centralized logging is in place
                    catch (InvalidOperationException)
                    {

                    }
                    if (isrunning)
                    {
                        throw new Exception("Config files are locked by a running process. Please exit that process first to avoid corruption.");
                    }
                }

            }
            File.WriteAllText(configlockfilename, currentPID.ToString());
        }

        ~ServerConfigManager()
        {
            File.Delete(configlockfilename);
        }

        public class ServerConfig 
        {
            public string Name { get; set; }
            public string FilePath { get; set; }
            public string Arguments { get; set; }
            public string LogDirectory { get; set; }

        }
    }
}
