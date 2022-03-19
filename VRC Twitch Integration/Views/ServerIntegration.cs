using System;
using System.Windows.Forms;
using VRC_Twitch_Integration.Data;

namespace VRC_Twitch_Integration.Views
{
    public partial class ServerIntegration : Form
    {
        public ServerIntegration()
        {
            InitializeComponent();
            Instance().RegisterNavigations();

            //Start my showing the Home Screen
            Instance().Navigate(NavigationForms.Home);
        }

        private static ServerIntegration instance = null;
        public static ServerIntegration Instance()
        {  
                if (instance == null)
                    instance = new ServerIntegration();

                return instance;
        }

        private void RegisterNavigations()
        {
            foreach (var navigation in Enum.GetValues(typeof(NavigationForms)))
            {
                var form = Activator.CreateInstance(Type.GetType("VRC_Twitch_Integration.Views." + navigation)) as Form;
                form.TopLevel = false;
                pnlNavigation.Controls.Add(form);
                //form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Visible = false;
                form.Show();
            }
        }

        //TODO Why wont forms display from other forms action
        internal void Navigate(NavigationForms formName)
        {
            for (var count = 0; count < pnlNavigation.Controls.Count; count++)
            {
                var form = (pnlNavigation.Controls[count] as Form);
                if (form.Text.Equals(formName.ToString()))
                    form.Visible = true;
            }
        }
    }
}
