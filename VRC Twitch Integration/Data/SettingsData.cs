using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRC_Twitch_Integration.Data
{
    internal class SettingsData
    {
        /// <summary>
        /// This is were the project will save its data to
        /// </summary>
        public string SavePath { get; set; }

        /// <summary>
        /// The current theme of the project
        /// </summary>
        public string Theme { get; set; }
    }
}
