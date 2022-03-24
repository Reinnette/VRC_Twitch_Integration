using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRC_Twitch_Integration.Views;

namespace VRC_Twitch_Integration.Data
{
    internal class Navigation
    {
        public static void Navigate(NavigationForms navigation)
        {
            ServerIntegration.Instance.DisplayForm = navigation;
        }
    }

    public enum NavigationForms
    { 
        Home,
        RegisterView,
        SetupView,
        SettingsView,
        HelpView
    }
}
