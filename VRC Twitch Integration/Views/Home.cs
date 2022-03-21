using System;
using System.Windows.Forms;
using VRC_Twitch_Integration.Data;

namespace VRC_Twitch_Integration.Views
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Navigation.Navigate(NavigationForms.SettingsView);
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            Navigation.Navigate(NavigationForms.SetupView);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Navigation.Navigate(NavigationForms.RegisterView);
        }
    }
}
