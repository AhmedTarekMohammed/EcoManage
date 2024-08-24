using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoManage.Gui.HomeGui
{
    public partial class HomeUserControl : UserControl
    {
        //Single TOne Object of the user control 
        private static HomeUserControl? homeUserControl;

        public static HomeUserControl Instance()
        {
            if (homeUserControl == null)
                homeUserControl = new HomeUserControl();
            return homeUserControl;
        }
        //public static HomeUserControl Instance()
        //{
        //    return homeUserControl ?? new HomeUserControl();
        //}

        static HomeUserControl()
        {
           homeUserControl = new HomeUserControl();
        }
        public HomeUserControl()
        {
            InitializeComponent();
        }
    }
}
