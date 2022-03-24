using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRC_Twitch_Integration.Data
{
    public class ParameterData
    {
        private static List<string> parameters;
        public static List<string> Parameters 
        { 
            get { if (parameters == null) parameters = new List<string>(); return parameters; }
            set { parameters = value; } 
        }
    }
}
