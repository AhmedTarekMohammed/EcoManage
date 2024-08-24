using EcoManage.Code.Helper;

namespace EcoManage
{
    public partial class Main : Form
    {
        private PageHelper pageHelper;
        public Main()
        {
            InitializeComponent();

            // Setting Home Page
            pageHelper = new PageHelper(this); // it takes page as a parameter so every time we will send this 
            pageHelper.SetPage(Gui.HomeGui.HomeUserControl.Instance());

            //From Setting in the Project so the user can set the screen prefernces for the intitialization 
            //Get and set the window state 
            SetScreenState(Properties.Settings.Default.isMaxScreen);
        }

        private void SetScreenState(bool IsMax)
        {
            if (IsMax)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveWindowState();

        }
        private void SaveWindowState()
        {
            // Save Window State , from the last settings of the user

            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.isMaxScreen = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.isMaxScreen = false;
                Properties.Settings.Default.Save();
            }

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            // Give the Singleton Object to the Setpage Method to create an Instrance of it's User Control
            pageHelper.SetPage(Gui.HomeGui.HomeUserControl.Instance());
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            pageHelper.SetPage(Gui.UsersGui.UsersUserControl.Instance(this));

        }
    }
}
