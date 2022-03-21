using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRC_Twitch_Integration.Data
{
    internal class SetupData
    {
        //Holds the list of all configured or setup events 
        //Inboud server, 
        public List<SetupFieldData> setupData = new List<SetupFieldData>();
    }

    public class SetupFieldData
    { 
        public ServerData InboundServer { get; set; }
        public List<string> InboundParameters { get; set; }
        public ServerData OutboundServer { get; set; }
        public List<string> OutboundParameters { get; set; }
        public List<string> Conditions { get; set; }
    }
}
