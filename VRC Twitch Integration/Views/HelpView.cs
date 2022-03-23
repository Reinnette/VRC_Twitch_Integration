using System;
using System.Windows.Forms;
using VRC_Twitch_Integration.Data;

namespace VRC_Twitch_Integration.Views
{
    public partial class HelpView : Form
    {
        public HelpView()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Navigation.Navigate(NavigationForms.Home);
        }

        private void btnServerPanel_Click(object sender, EventArgs e)
        {
            pnlServers.Visible = true;
            pnlParameters.Visible = false;
        }

        private void btnParametersPanel_Click(object sender, EventArgs e)
        {
            pnlServers.Visible = false;
            pnlParameters.Visible = true;
        }
    }
}
