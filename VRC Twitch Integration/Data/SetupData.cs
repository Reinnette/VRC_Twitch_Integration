using System.Collections.Generic;

namespace VRC_Twitch_Integration.Data
{
    /// <summary>
    /// This class is populated on startup getting the data saved on disk
    /// </summary>
    public class SetupData
    {
        //Holds the list of all configured or setup events 
        //Inboud server, 
        private static List<SetupFieldData> rowData;
        public static List<SetupFieldData> RowData
        {
            get
            {
                if (rowData == null)
                    rowData = new List<SetupFieldData>();

                return rowData;
            }
            set { }
        }
    }

    public class SetupFieldData
    {
        public SetupFieldData()
        { 
        }

        public string InboundServer { get; set; }
        public string InboundParameters { get; set; }
        public string OutboundServer { get; set; }
        public string OutboundParameters { get; set; }
        public string Conditions { get; set; }
    }
}
