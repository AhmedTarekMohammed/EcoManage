using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoManage.Gui.UsersGui
{
    public partial class AddUserForm : Form
    {
        public AddUserForm(Main main)
        {
            InitializeComponent();
            this.Owner = main;
            AddSecondryUser();
            setRoles();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkSecandryUser_CheckedChanged(object sender, EventArgs e)
        {

            if (Code.Models.LocalUser.Role == "Admin")
            {
                //if checked == true , else = false 
                comboBoxSecondaryUser.Enabled = chkSecandryUser.Checked;
            }
            else
            {
                comboBoxSecondaryUser.Enabled = false;
            }

        }

        private void setRoles()
        {
            if (Code.Models.LocalUser.Role == "Admin")
            {
                //Admin
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.Add("Admin");
                comboBoxRole.Items.Add("User");
                comboBoxRole.Items.Add("Read");
                comboBoxSecondaryUser.Enabled = false;
                chkSecandryUser.Enabled = true;
                comboBoxRole.SelectedIndex = 1;
            }
            else
            {
                // User
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.Add("User");
                comboBoxRole.Items.Add("Read");
                chkSecandryUser.Enabled = false;
                chkSecandryUser.Checked = true;
                comboBoxSecondaryUser.Enabled = false;
                comboBoxRole.SelectedIndex = 0;
            }
        }

        private void AddSecondryUser()
        {
            comboBoxSecondaryUser.Items.Clear();
            comboBoxSecondaryUser.Items.Add(Code.Models.LocalUser.UserId);
            comboBoxSecondaryUser.SelectedIndex = 0;

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetRoleByMainRole();

        }
        private void SetRoleByMainRole()
        {
            if(comboBoxRole.SelectedItem.ToString() == "Admin")
            {
                checkBoxAdd.Checked = true;
                checkBoxDelete.Checked = true;
                checkBoxAbout.Checked = true;
               checkBoxEdit. Checked = true;
                checkBoxExport.Checked = true;
                checkBoxPrint.Checked = true;
               checkBoxSearch .Checked = true;
               checkBoxSearchHP.Checked = true;
                checkBoxHome.Checked = true;
               checkBoxSalary.Checked = true;
                checkBoxEmployees.Checked = true;
                checkBoxUsers.Checked = true;
                checkBoxReport.Checked = true;
                checkBoxSetting.Checked = true;
                checkBoxHelp.Checked = true;
                checkBoxRetirees.Checked = true;
               checkBoxRecords .Checked = true;



            }
            else if (comboBoxRole.SelectedItem.ToString() == "User")
            {
                checkBoxAdd.Checked = true;
                checkBoxDelete.Checked = true;
                checkBoxAbout.Checked = true;
                checkBoxEdit.Checked = true;
                checkBoxExport.Checked = true;
                checkBoxPrint.Checked = true;
                checkBoxSearch.Checked = true;
                checkBoxSearchHP.Checked = true;
                checkBoxHome.Checked = true;
                checkBoxSalary.Checked = true;
                checkBoxEmployees.Checked = true;
                checkBoxUsers.Checked = true;
                checkBoxReport.Checked = true;
                checkBoxSetting.Checked = true;
                checkBoxHelp.Checked = true;
                checkBoxRetirees.Checked = true;
                checkBoxRecords.Checked = true;


            }
            else //Read
            {
                checkBoxAdd.Checked = false;
                checkBoxDelete.Checked = false;
                checkBoxAbout.Checked = true;
                checkBoxEdit.Checked = false;
                checkBoxExport.Checked = true;
                checkBoxPrint.Checked = true;
                checkBoxSearch.Checked = true;
                checkBoxSearchHP.Checked = true;
                checkBoxHome.Checked = true;
                checkBoxSalary.Checked = true;
                checkBoxEmployees.Checked = true;
                checkBoxUsers.Checked = false;
                checkBoxReport.Checked = true;
                checkBoxSetting.Checked = true;
                checkBoxHelp.Checked = true;
                checkBoxRetirees.Checked = true;
                checkBoxRecords.Checked = true;


            }
        }
    }
}
