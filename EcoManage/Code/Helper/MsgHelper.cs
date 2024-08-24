using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoManage.Code.Helper
{
    public static class MsgHelper
    {
        public static void ShowServerError()
        {
            
            MessageBox.Show("Sorry,It seems you have a trouble connecting , Please try Again",
                 "No Connection Availabe to Complete "
                 , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowRequiredFields()
        {
           
            MessageBox.Show("All Fields with * are REQUIRED . Please Make sure to Fill them and Try Again",
            "Required Fields"
            , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowDuplicatedItems()
        {
            
            MessageBox.Show(" Data Already Exist.Make Sure to Change the Data from any of these Fields and Try Again",
                "Repeated Data"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowEmptyDataGridView()
        {
          
            MessageBox.Show("Fields should be filled to Complete this Process ",
               "No Data Enterd"
               , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowDeleteSelectRow()
        {
        
            MessageBox.Show("For Deletion Integration Sensitivity ,please select Entire ROW",
              "Executing Delete"
              , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool ShowDeleteDialog()
        {
           
            var result = MessageBox.Show("Do you Really want to delete ? Data can't be retrieved  ",
                 "Executing Delete"
                 , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ShowNumberValid()
        {
         
            MessageBox.Show("Please Enter Numeric Value ",
                 "Incorrect Entry "
                 , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

