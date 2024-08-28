using Eco.Data.EF;
using EcoManage.Gui.UsersGui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoManage
{
    partial class StartForm : Form
    {
        private DBContext db;
        public StartForm()
        {
            InitializeComponent();
            Code.Helper.ConStringHelper.SetConString();
        }

        private void linkLabelSetServer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show Settings From
           // Gui.SettingsGui.SettingForm settingForm = new Gui.SettingsGui.SettingForm();
          //  settingForm.Show();
        }

        private void linkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private async void timerStart_Tick(object sender, EventArgs e)
        {
            db = new DBContext();

            // Check the con
            labelState.Text = "Connecting ...";
            if(await db.Database.CanConnectAsync())
            {
                // Show Login From
                timerStart.Enabled = false;
               // LoginForm loginForm = new LoginForm();
               // loginForm.Show();
                this.Hide();
            }
            else
            {
                panelSettings.Visible = true;
                labelState.Text = "Connection Failed.... We will Try To Connect in a few Moments ";
            }
        }
    }
}
