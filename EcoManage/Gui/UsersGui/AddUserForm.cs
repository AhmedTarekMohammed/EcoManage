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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
