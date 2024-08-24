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
    public partial class UsersUserControl : UserControl
    {
        private static readonly UsersUserControl? usersUserControl;
        private AddUserForm addUserForm;
        private static Main _main;

        public UsersUserControl()
        {
            InitializeComponent();
        }

        public static UsersUserControl Instance(Main main)
        {
            _main= main;
            return usersUserControl ?? new UsersUserControl();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (addUserForm == null || addUserForm.IsDisposed)
            { 
                addUserForm = new AddUserForm(_main); // Last add to main to be owned by the main Page 
                addUserForm.Show();
            }
            else
            {
                addUserForm.Focus();
            }
           
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

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

        private void textBoxSerach_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSerach_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
