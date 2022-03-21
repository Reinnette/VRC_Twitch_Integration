using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ServerIntegration.Instance.DisplayForm = NavigationForms.SettingsView;
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            ServerIntegration.Instance.DisplayForm = NavigationForms.SetupView;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ServerIntegration.Instance.DisplayForm = NavigationForms.RegisterView;
        }
    }
}
