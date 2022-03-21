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
                            if (pnlNavigation.Controls[count] as Home != null)
                                (pnlNavigation.Controls[count] as Home).Visible = true;
                            break;
                        case NavigationForms.RegisterView:
                            if (pnlNavigation.Controls[count] as RegisterView != null)
                                (pnlNavigation.Controls[count] as RegisterView).Visible = true;
                            break;
                        case NavigationForms.SetupView:
                            if (pnlNavigation.Controls[count] as SetupView != null)
                                (pnlNavigation.Controls[count] as SetupView).Visible = true;
                            break;
                        case NavigationForms.SettingsView:
                            if (pnlNavigation.Controls[count] as SettingsView != null)
                                (pnlNavigation.Controls[count] as SettingsView).Visible = true;
                            break;
                        case NavigationForms.HelpView:
                            if (pnlNavigation.Controls[count] as HelpView != null)
                                (pnlNavigation.Controls[count] as HelpView).Visible = true;
                            break;
                    }
                }
            }
        }

        private void RegisterNavigations()
        {
            foreach (var navigation in Enum.GetValues(typeof(NavigationForms)))
            {
                var form = new Form();

                switch (navigation)
                { 
                    case NavigationForms.Home:
                        form = Activator.CreateInstance(Type.GetType("VRC_Twitch_Integration.Views." + navigation)) as Home;
                        break;
                    case NavigationForms.RegisterView:
                        form = Activator.CreateInstance(Type.GetType("VRC_Twitch_Integration.Views." + navigation)) as RegisterView;
                        break;
                    case NavigationForms.SetupView:
                        form = Activator.CreateInstance(Type.GetType("VRC_Twitch_Integration.Views." + navigation)) as SetupView;
                        break;
                    case NavigationForms.SettingsView:
                        form = Activator.CreateInstance(Type.GetType("VRC_Twitch_Integration.Views." + navigation)) as SettingsView;
                        break;
                    case NavigationForms.HelpView:
                        form = Activator.CreateInstance(Type.GetType("VRC_Twitch_Integration.Views." + navigation)) as HelpView;
                        break;
                }

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
