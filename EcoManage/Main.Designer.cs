namespace EcoManage
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            flowLayoutPanelNavBar = new FlowLayoutPanel();
            buttonHome = new Button();
            buttonSalaryCategory = new Button();
            buttonEmployees = new Button();
            buttonUsers = new Button();
            buttonReport = new Button();
            buttonSettings = new Button();
            buttonHelp = new Button();
            buttonAbout = new Button();
            panelContainer = new Panel();
            toolTip1 = new ToolTip(components);
            flowLayoutPanelNavBar.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.Controls.Add(buttonHome);
            flowLayoutPanelNavBar.Controls.Add(buttonSalaryCategory);
            flowLayoutPanelNavBar.Controls.Add(buttonEmployees);
            flowLayoutPanelNavBar.Controls.Add(buttonUsers);
            flowLayoutPanelNavBar.Controls.Add(buttonReport);
            flowLayoutPanelNavBar.Controls.Add(buttonSettings);
            flowLayoutPanelNavBar.Controls.Add(buttonHelp);
            flowLayoutPanelNavBar.Controls.Add(buttonAbout);
            flowLayoutPanelNavBar.Dock = DockStyle.Bottom;
            flowLayoutPanelNavBar.Location = new Point(0, 615);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new Padding(3);
            flowLayoutPanelNavBar.Size = new Size(1064, 66);
            flowLayoutPanelNavBar.TabIndex = 0;
            // 
            // buttonHome
            // 
            buttonHome.Image = Properties.Resources.Home_1;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(8, 8);
            buttonHome.Margin = new Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(140, 50);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "   Home";
            toolTip1.SetToolTip(buttonHome, "Main Page");
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonSalaryCategory
            // 
            buttonSalaryCategory.Image = Properties.Resources.Teacher_Hiring;
            buttonSalaryCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalaryCategory.Location = new Point(158, 8);
            buttonSalaryCategory.Margin = new Padding(5);
            buttonSalaryCategory.Name = "buttonSalaryCategory";
            buttonSalaryCategory.Size = new Size(140, 50);
            buttonSalaryCategory.TabIndex = 1;
            buttonSalaryCategory.Text = "   Salary Categ.";
            buttonSalaryCategory.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(buttonSalaryCategory, "Managing Wages or Salaries Categories");
            buttonSalaryCategory.UseVisualStyleBackColor = true;
            // 
            // buttonEmployees
            // 
            buttonEmployees.Image = Properties.Resources.Employee;
            buttonEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEmployees.Location = new Point(308, 8);
            buttonEmployees.Margin = new Padding(5);
            buttonEmployees.Name = "buttonEmployees";
            buttonEmployees.Size = new Size(140, 50);
            buttonEmployees.TabIndex = 2;
            buttonEmployees.Text = "       Employees";
            toolTip1.SetToolTip(buttonEmployees, "Adminstration of Staff ");
            buttonEmployees.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            buttonUsers.Image = Properties.Resources.Users;
            buttonUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUsers.Location = new Point(458, 8);
            buttonUsers.Margin = new Padding(5);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(140, 50);
            buttonUsers.TabIndex = 3;
            buttonUsers.Text = "   Users  ";
            toolTip1.SetToolTip(buttonUsers, "Admistration of Users ");
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonReport
            // 
            buttonReport.Image = Properties.Resources.Business_Report_1;
            buttonReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReport.Location = new Point(608, 8);
            buttonReport.Margin = new Padding(5);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(140, 50);
            buttonReport.TabIndex = 4;
            buttonReport.Text = "   Reports   ";
            toolTip1.SetToolTip(buttonReport, "Creating System  Report sheets");
            buttonReport.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            buttonSettings.Image = Properties.Resources.Settings;
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(758, 8);
            buttonSettings.Margin = new Padding(5);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(140, 50);
            buttonSettings.TabIndex = 5;
            buttonSettings.Text = " Settings  ";
            toolTip1.SetToolTip(buttonSettings, "General Settings");
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = Properties.Resources.Help;
            buttonHelp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelp.Location = new Point(8, 68);
            buttonHelp.Margin = new Padding(5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(140, 50);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "    Help";
            toolTip1.SetToolTip(buttonHelp, "See Documentation");
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            buttonAbout.Image = Properties.Resources.Info;
            buttonAbout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbout.Location = new Point(158, 68);
            buttonAbout.Margin = new Padding(5);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(140, 50);
            buttonAbout.TabIndex = 7;
            buttonAbout.Text = "About";
            toolTip1.SetToolTip(buttonAbout, "About System and Latest Updates and versions");
            buttonAbout.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1064, 615);
            panelContainer.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(panelContainer);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EcoManage";
            WindowState = FormWindowState.Maximized;
            FormClosing += Main_FormClosing;
            flowLayoutPanelNavBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelNavBar;
        private Button buttonHome;
        private Button buttonSalaryCategory;
        private Button buttonEmployees;
        private Button buttonUsers;
        private Button buttonReport;
        private Button buttonSettings;
        private Button buttonHelp;
        private Button buttonAbout;
        public Panel panelContainer;
        private ToolTip toolTip1;
    }
}
