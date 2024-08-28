using EcoManage.Code.Helper;
using EcoManage.Code.Models;
using Eco.Core;
using Eco.Data.EF;
using EcoManage.Gui.Loading_Gui;
using System.Data;

namespace EcoManage.Gui.BookThanksGui
{
    public partial class AddBookThankForm : Form
    {
        private readonly IDataHelper<BookThanks> dataHelperForBookThanks;
        private readonly IDataHelper<Employees> dataHelperForEmployees;
        private readonly IDataHelper<SystemRecords> dataHelperForSystemRecords;
        private readonly Main main;
        private int Id;
        private DateTime userCreatedDate;
        private readonly BookThankUserControl page;
        private  Employees employees;

        public AddBookThankForm(Main main, int id, BookThankUserControl page,Employees employees)
        {
            InitializeComponent();

            dataHelperForBookThanks = new BookThanksEF();
            dataHelperForSystemRecords = new SystemRecordsEF();
            dataHelperForEmployees = new EmployeesEF();

            this.Owner = main;



            this.main = main;
            this.Id = id;
            this.page = page;
            this.employees = employees;
            if (Id > 0)
            {
                SetDataForEdit();
            }

          

        }

    




        private bool IsValid()
        {
            if (
                textBoxRef.Text!=string.Empty
                )
            {
                return true;
            }
            else
            {
                return true;
            }

        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            // Check the fields
            if (!IsValid())
            {
                MsgHelper.ShowRequiredFields();
            }
            else
            {
                // Show Loading
                LoadingForm.Instance(main).Show();
                // Check Connection
                if (await Task.Run(() => dataHelperForBookThanks.IsCanConnect()))
                {
                    // Check Duplicated Item

                    string refBook = textBoxRef.Text;
                    var dateBook = dateTimePickerdate.Value.Date;

                    var result = await Task.Run(() => dataHelperForBookThanks
                    .GetDataByUser(LocalUser.UserId)
                    .Where(x => x.Id != Id)
                    .Where(x => x.Ref == refBook && x.BookThankDate== dateBook)
                    .FirstOrDefault() ?? new BookThanks());

                    if (result.Id > 0)
                    {
                        // Msg
                        LoadingForm.Instance(main).Hide();
                        MsgHelper.ShowDuplicatedItems();
                    }
                    else
                    {
                        // Add
                        if (Id == 0)
                        {
                            Add();
                        }
                        else
                        {
                            // Edit
                            Edit();
                        }
                    }


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
            // Set BookThanks
            BookThanks bookThanks = new BookThanks
            { 
                UserId = LocalUser.UserId,
                EffectValue= (int)numericUpDownEffect.Value,
                AddedDate = DateTime.Now.Date,
                BookThankDate=dateTimePickerdate.Value.Date,
                EmployeesId= employees.Id,
                Note=richTextBoxNote.Text,
                Ref=textBoxRef.Text,
            };

            // Send Data to database
            var result = await Task.Run(() => dataHelperForBookThanks.Add(bookThanks));
            if (result == "1")
            {

                // Success
                SystemRecordHelper.Add("Adding Thanks Book ",
                    $"Successfully Added The Book With ID: {bookThanks.Id}");

                // Add Data to Employees
                employees.Note = employees.Note + " | " + $"Thanks With Impact {bookThanks.EffectValue} Day With Figure{bookThanks.Ref} in {bookThanks.BookThankDate}";
                employees.NextDate=employees.NextDate.AddDays(bookThanks.EffectValue*-1);

                await Task.Run(()=>dataHelperForEmployees.Edit(employees));

                page.LoadData();
                ToastHelper.ShowAddToast();
            }
            else
            {
                // Msg Box with result
                MessageBox.Show(result);
            }
        }

        private async void Edit()
        {

            // Set BookThanks
            BookThanks bookThanks = new BookThanks
            {
                UserId = LocalUser.UserId,
                EffectValue = (int)numericUpDownEffect.Value,
                AddedDate = DateTime.Now.Date,
                BookThankDate = dateTimePickerdate.Value.Date,
                EmployeesId = employees.Id,
                Note = richTextBoxNote.Text,
                Ref = textBoxRef.Text,
                Id = Id
            };


            // Send Data to database
            var result = await Task.Run(() => dataHelperForBookThanks.Edit(bookThanks));
            if (result == "1")
            {

                // Success
                SystemRecordHelper.Add("Editing Thanks Book ",
                    $"Successfully Edited The Book With ID: {bookThanks.Id}");
                page.LoadData();
                ToastHelper.ShowEditToast();
                this.Close();
            }
            else
            {
                // Msg Box with result
                MessageBox.Show(result);
            }
        }



        private async void SetDataForEdit()
        {
            // Get Edit BookThanks Data
            var _BookThanks = await Task.Run(() => dataHelperForBookThanks.Find(Id));
            if (_BookThanks != null)
            {
                textBoxRef.Text = _BookThanks.Ref;
                numericUpDownEffect.Value=_BookThanks.EffectValue;
                richTextBoxNote.Text = _BookThanks.Note;
                dateTimePickerdate.Value = _BookThanks.BookThankDate;
           
            }
        }

        private void textBoxBookThanks_MouseLeave(object sender, EventArgs e)
        {
            if (!float.TryParse(textBoxRef.Text, out float bookThanks) || bookThanks < 0)
            {
                textBoxRef.Text = "0";
                MsgHelper.ShowNumberValid();
            }
        }

     
    }
}
