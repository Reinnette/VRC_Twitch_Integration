using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRC_Twitch_Integration.Data
{
    public class ServerData
    {
        private static List<ServerInfo> registeredServers;
        public static List<ServerInfo> RegisteredServers
        {
            get { if (registeredServers == null) registeredServers = new List<ServerInfo>();  return registeredServers; }
            set { registeredServers = value; }
        }
    }

    public class ServerInfo
    {
        public string ServerName { get; set; }
        public string ServerURL { get; set; }
        public int ServerPort { get; set; }
    }
}
