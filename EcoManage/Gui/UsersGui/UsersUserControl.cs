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
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoManage.Gui.UsersGui
{
    public partial class UsersUserControl : UserControl
    {
        private static UsersUserControl? usersUserControl;
        private AddUserForm addUserForm;
        private static Main _main;
        private IDataHelper<Users> dataHelper;
        private List<Users> data;
        private LoadingForm loading;

        public UsersUserControl()
        {
            InitializeComponent();
            dataHelper = new UsersEF();
            data = new List<Users>();
            // loading = new LoadingForm(_main);
            LoadData();
        }

        public static UsersUserControl Instance(Main main)
        {
            _main = main;
            return usersUserControl ?? (usersUserControl = new UsersUserControl());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (addUserForm == null || addUserForm.IsDisposed)
            {
                addUserForm = new AddUserForm(_main,0,this); // Last add to main to be owned by the main Page 
                addUserForm.Show();
            }
            else
            {
                addUserForm.Focus();
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //Check Data is not empty
            //get ID
            if (!dgvHelper.IsEmpty(dataGridView1))
            {
                int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (addUserForm == null || addUserForm.IsDisposed)
                {
                    addUserForm = new AddUserForm(_main, Id, this); // Last add to main to be owned by the main Page 
                    addUserForm.Show();
                }
                else
                {
                    addUserForm.Focus();
                }
            }
            else
            {
                MsgHelper.ShowEmptyDataGridView();
            }
            

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBoxSerach_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSerach_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public async void LoadData()
        {
            //show loading
            // loading.Show();
            LoadingForm.Instance(_main).Show();
            if (await Task.Run(() => dataHelper.IsCanConnect()))
            {
                //start connection
                if (Code.Models.LocalUser.Role == "Admin")
                {
                    //get All Data 
                    data = await Task.Run(() => dataHelper.GetAllData());
                }
                else
                {
                    //data By user 
                    data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId));

                }
                // fill data 
                dataGridView1.DataSource = data.ToList();
                Setcolumns();
                ShowEmptyDataState();
                data.Clear();
            }
            else
            {
                // no connection
                //loading.Hide();
                LoadingForm.Instance(_main).Hide();
                ShowServerErrorState();
                MsgHelper.ShowServerError();
            }

            //  loading.Hide();
            LoadingForm.Instance(_main).Hide();
            //show Empty Data 
       
        }

        private void ShowEmptyDataState()
        {
            labelStateTitle.Text = Properties.Resources.EmptyDataStateTitle;
            labelStateDescription.Text = Properties.Resources.EmptyDataStateDescription;

            panelState.Visible = dgvHelper.IsEmpty(dataGridView1);

        }
        private void ShowServerErrorState()
        {
            labelStateTitle.Text = Properties.Resources.ServerErrorTitle;
            labelStateDescription.Text = Properties.Resources.ServerErrorDescription;

            panelState.Visible = true;//  الي فوق يبقا اكيد هيعرض ديا state  قدام عدي من ال 
                                      //علشان كدا ب ترو والي فوق بيعمل check 

        }

        private void Setcolumns()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "Id";
            dataGridView1.Columns[1].HeaderCell.Value = "FullName";
            dataGridView1.Columns[2].HeaderCell.Value = "UserName";
            dataGridView1.Columns[3].HeaderCell.Value = "Password";
            dataGridView1.Columns[4].HeaderCell.Value = "Role";
            dataGridView1.Columns[5].HeaderCell.Value = "IsSecondaryUser";
            dataGridView1.Columns[6].HeaderCell.Value = "UserId";
            dataGridView1.Columns[7].HeaderCell.Value = "Phone";
            dataGridView1.Columns[8].HeaderCell.Value = "Email";
            dataGridView1.Columns[9].HeaderCell.Value = "Address";
            dataGridView1.Columns[10].HeaderCell.Value = "CreatedDate";
            dataGridView1.Columns[11].HeaderCell.Value = "EditedDate";

            //visible of coulmns
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

        }

        //private void labelState_Click(object sender, EventArgs e)
        //{

        //}

        
    }

}
