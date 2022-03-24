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
            Instance = this;

            Instance.RegisterNavigations();

            //Start my showing the Home Screen
            Instance.DisplayForm = NavigationForms.Home;
        }

        /// <summary>
        /// Public property used to create a singleton class
        /// </summary>
        private static ServerIntegration instance = null;
        public static ServerIntegration Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServerIntegration();

                return instance;
            }
            private set
            { 
                instance = value;
            }
        }

        /// <summary>
        /// Public property used to change the active screen
        /// </summary>
        private NavigationForms displayForm;
        public NavigationForms DisplayForm
        { 
            get { return displayForm; }
            set 
            { 
                displayForm = value;

                for (var count = 0; count < pnlNavigation.Controls.Count; count++)
                {
                    (pnlNavigation.Controls[count] as Form).Visible = false;

                    switch (value)
                    {
                        case NavigationForms.Home:
                            var homeForm = pnlNavigation.Controls[count] as Home;
                            if (homeForm != null)
                                (homeForm).Visible = true;
                            break;
                        case NavigationForms.RegisterView:
                            var registerForm = pnlNavigation.Controls[count] as RegisterView;
                            if (registerForm != null)
                                (registerForm).Visible = true;
                            break;
                        case NavigationForms.SetupView:
                            var setupForm = pnlNavigation.Controls[count] as SetupView;
                            if (setupForm != null)
                                (setupForm).Visible = true;
                            break;
                        case NavigationForms.SettingsView:
                            var settingsForm = pnlNavigation.Controls[count] as SettingsView;
                            if (settingsForm != null)
                                (settingsForm).Visible = true;
                            break;
                        case NavigationForms.HelpView:
                            var helpForm = pnlNavigation.Controls[count] as HelpView;
                            if (helpForm != null)
                                (helpForm).Visible = true;
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Initalize all of the screens but hide them untill the user needs to see it
        /// </summary>
        private void RegisterNavigations()
        {
            foreach (var navigation in Enum.GetValues(typeof(NavigationForms)))
            {
                var form = Activator.CreateInstance(Type.GetType("VRC_Twitch_Integration.Views." + navigation)) as Form;
                form.TopLevel = false;
                pnlNavigation.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
                form.Visible = false;
            }
        }
    }
}
