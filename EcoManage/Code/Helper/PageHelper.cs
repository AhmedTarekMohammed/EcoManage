using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoManage.Code.Helper
{
    public class PageHelper
    {
        private readonly Main main;

        public PageHelper(Main main)
        {
            this.main = main;
        }
        //set new page 
        public void SetPage(UserControl pageUserControl)
        {
            //get current page 
            var oldPage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();

            // remove the old page if it exists anyways
            if (oldPage != null && oldPage!=pageUserControl)
            {
                main.panelContainer.Controls.Remove(oldPage);
            }

            //add new page 
            if (oldPage != pageUserControl)
            {
                pageUserControl.Dock = DockStyle.Fill;
                main.panelContainer.Controls.Add(pageUserControl);
            }
        }
    }
}
