using System;
using System.Windows.Forms;
using VRC_Twitch_Integration.Views;

namespace VRC_Twitch_Integration
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ServerIntegration());
        }
    }
}
