﻿using System;
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
    }
}
