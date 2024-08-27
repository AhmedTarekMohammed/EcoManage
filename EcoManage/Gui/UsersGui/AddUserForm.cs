using Eco.Core;
using Eco.Data.EF;
using EcoManage.Code.Helper;
using EcoManage.Code.Models;
using EcoManage.Gui.Loading_Gui;
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
        private readonly IDataHelper<Users> dataHelperForUser;
        private readonly IDataHelper<Roles> dataHelperForRoles;
        private readonly IDataHelper<SystemRecords> dataHelperForSystemRecords;
        private readonly Main main;
        private int Id;
        private DateTime userCreatedDate;
        private readonly UsersUserControl page;

        public AddUserForm(Main main, int id, UsersUserControl page)
        {
            InitializeComponent();
            dataHelperForUser = new UsersEF();
            dataHelperForRoles = new RolesEF();
            dataHelperForSystemRecords = new SystemRecordsEF();
            this.Owner = main;
            AddSecondryUser();
            setRoles();
            this.main=main;
            this.Id = id;
            this.page=page;
            if(Id>0)
            {
                SetDataForEdit();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxSecondaryUser_CheckedChanged(object sender, EventArgs e)
        {

            if (Code.Models.LocalUser.Role == "Admin")
            {
                //if checked == true , else = false 
                comboBoxUserId.Enabled = checkBoxSecondryUser.Checked;
            }
            else
            {
                comboBoxUserId.Enabled = false;
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
                comboBoxUserId.Enabled = false;
                checkBoxSecondryUser.Enabled = true;
                comboBoxRole.SelectedIndex = 1;
            }
            else
            {
                // User
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.Add("User");
                comboBoxRole.Items.Add("Read");
                checkBoxSecondryUser.Enabled = false;
                checkBoxSecondryUser.Checked = true;
                comboBoxUserId.Enabled = false;
                comboBoxRole.SelectedIndex = 0;
            }
        }

        private void AddSecondryUser()
        {
            comboBoxUserId.Items.Clear();
            comboBoxUserId.Items.Add(Code.Models.LocalUser.UserId);
            comboBoxUserId.SelectedIndex = 0;

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetRoleByMainRole();

        }
        private void SetRoleByMainRole()
        {
            if (comboBoxRole.SelectedItem.ToString() == "Admin")
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

        private bool IsValid()
        {
            if (
                textBoxFullName.Text.Length<4||
                textBoxPassword.Text.Length<4||
                textBoxUserName.Text.Length<4
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            //chech the fields
            if(!IsValid())
            {
                MsgHelper.ShowRequiredFields();
            }
            else
            {
                //show loading
                LoadingForm.Instance(main).Show();
                //Check connection
                if (await Task.Run(()=>dataHelperForUser.IsCanConnect()))
                {
                    //check Duplicated Item
                    string fullName = textBoxFullName.Text;
                    string userName = textBoxUserName.Text;

                    var result = await Task.Run(() => dataHelperForUser
                    .GetAllData()
                    .Where(x => x.Id !=Id)
                    .Where(x => x.FullName == fullName || x.UserName == userName)
                    .FirstOrDefault() ?? new Users());
                    if (result.Id > 0)
                    {
                        //Msg
                        LoadingForm.Instance(main).Hide();
                        MsgHelper.ShowDuplicatedItems();
                    }
                    else
                    {
                        if (Id == 0)
                        {
                            Add();
                        }
                        else
                        {
                            //Edit
                            Edit();
                        }
                    }

                    //save
                    //Add
                    
                }
                else
                {
                    LoadingForm.Instance(main).Hide();
                    MsgHelper.ShowServerError();
                }
                LoadingForm.Instance(main).Hide();



            }
        }
        private async void Add()
        {
            Users users = new Users
            {
                FullName = textBoxFullName.Text,
                Password = textBoxPassword.Text,
                UserName = textBoxUserName.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                CreatedDate = DateTime.Now.Date,
                EditedDate = DateTime.Now.Date,
                Role = comboBoxRole.SelectedItem.ToString()??"User",
                Phone = textBoxPhone.Text,
                IsSecondaryUser = checkBoxSecondryUser.Checked,
                UserId=SetUserId()
            };
            //send data to database
            var result = await Task.Run(() => dataHelperForUser.Add(users));
            if (result == "1")
            {
                //Add User Roles
                foreach (var item in flowLayoutPanel.Controls)
                {
                    CheckBox checkBox = item as CheckBox;
                    //set
                    Roles roles = new Roles
                    {
                        Key = checkBox.Name,
                        Value = checkBox.Checked,
                        UsersId = users.Id
                    };
                    //send
                    await Task.Run(() => dataHelperForRoles.Add(roles));
                }
                //success
                page.LoadData();
                ToastHelper.ShowAddToast();
                this.Close();

            }
            else
            {
                MessageBox.Show(result);
                
            }
        }
        private async void Edit()
        {
           
            Users users = new Users
            {
                Id = Id,
                FullName = textBoxFullName.Text,
                Password = textBoxPassword.Text,
                UserName = textBoxUserName.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                CreatedDate = userCreatedDate,
                EditedDate = DateTime.Now.Date,
                Role = comboBoxRole.SelectedItem.ToString()??"User",
                Phone = textBoxPhone.Text,
                IsSecondaryUser = checkBoxSecondryUser.Checked,
                UserId=SetUserId()
            };
            //send data to database
            var result = await Task.Run(() => dataHelperForUser.Edit(users));
            if (result == "1")
            {
                //Remove old User roles
                var oldroles = await Task.Run(() => dataHelperForRoles
                .GetAllData().Where(x => x.UsersId==Id).ToList()??new List<Roles>());
                foreach (var role in oldroles)
                {
                    await Task.Run(() => dataHelperForRoles.Delete(role.Id));
                }
                //Add User Roles
                foreach (var item in flowLayoutPanel.Controls)
                {
                    CheckBox checkBox = item as CheckBox;
                    //set
                    Roles roles = new Roles
                    {
                        Key = checkBox.Name,
                        Value = checkBox.Checked,
                        UsersId = users.Id
                    };
                    //send
                    await Task.Run(() => dataHelperForRoles.Add(roles));
                }
                //success
                page.LoadData();
                ToastHelper.ShowEditToast();
                this.Close();

            }
            else
            {
                MessageBox.Show(result);

            }
        }

        private string SetUserId()
        {
            if(checkBoxSecondryUser.Checked)
            {
                return comboBoxUserId.SelectedItem.ToString()??LocalUser.UserId ;
            }
            else
            {
                return Guid.NewGuid().ToString();
            }
        }
        private async void SetDataForEdit ()
        {
            //get Edit User Data
            var _user = await Task.Run(() => dataHelperForUser.Find(Id));
            if (_user != null)
            {
                textBoxFullName.Text = _user.FullName;
                textBoxPassword.Text = _user.Password;
                textBoxUserName.Text = _user.UserName;
                textBoxEmail.Text = _user.Email;
                textBoxAddress.Text = _user.Address;
                comboBoxRole.SelectedItem = _user.Role;
                checkBoxSecondryUser.Checked = _user.IsSecondaryUser;
                userCreatedDate = _user.CreatedDate;
            }
        }
    }
}
