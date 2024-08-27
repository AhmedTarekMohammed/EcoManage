namespace EcoManage.Gui.UsersGui
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            comboBoxRole = new ComboBox();
            label21 = new Label();
            textBoxPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxUserName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxFullName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxUserId = new ComboBox();
            checkBoxSecondaryUser = new CheckBox();
            groupBox2 = new GroupBox();
            buttonSave = new Button();
            textBoxAddress = new TextBox();
            label10 = new Label();
            textBoxEmail = new TextBox();
            label12 = new Label();
            textBoxPhone = new TextBox();
            label14 = new Label();
            groupBox3 = new GroupBox();
            flowLayoutPanel = new FlowLayoutPanel();
            checkBoxAdd = new CheckBox();
            checkBoxDelete = new CheckBox();
            checkBoxEdit = new CheckBox();
            checkBoxExport = new CheckBox();
            checkBoxPrint = new CheckBox();
            checkBoxSearch = new CheckBox();
            checkBoxSearchHP = new CheckBox();
            checkBoxHome = new CheckBox();
            checkBoxSalary = new CheckBox();
            checkBoxEmployees = new CheckBox();
            checkBoxUsers = new CheckBox();
            checkBoxReport = new CheckBox();
            checkBoxSetting = new CheckBox();
            checkBoxAbout = new CheckBox();
            checkBoxHelp = new CheckBox();
            checkBoxRetirees = new CheckBox();
            checkBoxRecords = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxFullName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 386);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Info ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(6, 343);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(250, 26);
            comboBoxRole.TabIndex = 4;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 307);
            label21.Name = "label21";
            label21.Size = new Size(154, 18);
            label21.TabIndex = 9;
            label21.Text = "General Permissions";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(6, 254);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(250, 26);
            textBoxPassword.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(84, 206);
            label5.Name = "label5";
            label5.Size = new Size(14, 18);
            label5.TabIndex = 7;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 224);
            label6.Name = "label6";
            label6.Size = new Size(86, 18);
            label6.TabIndex = 6;
            label6.Text = "Password :";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(6, 169);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(250, 26);
            textBoxUserName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(84, 121);
            label3.Name = "label3";
            label3.Size = new Size(14, 18);
            label3.TabIndex = 4;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 139);
            label4.Name = "label4";
            label4.Size = new Size(95, 18);
            label4.TabIndex = 3;
            label4.Text = "User Name :";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(6, 85);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(250, 26);
            textBoxFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(84, 41);
            label2.Name = "label2";
            label2.Size = new Size(14, 18);
            label2.TabIndex = 1;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(86, 18);
            label1.TabIndex = 0;
            label1.Text = "Full Name :";
            // 
            // comboBoxUserId
            // 
            comboBoxUserId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserId.Enabled = false;
            comboBoxUserId.FormattingEnabled = true;
            comboBoxUserId.Location = new Point(6, 71);
            comboBoxUserId.Name = "comboBoxUserId";
            comboBoxUserId.Size = new Size(250, 26);
            comboBoxUserId.TabIndex = 6;
            // 
            // checkBoxSecondaryUser
            // 
            checkBoxSecondaryUser.AutoSize = true;
            checkBoxSecondaryUser.Location = new Point(16, 37);
            checkBoxSecondaryUser.Name = "checkBoxSecondaryUser";
            checkBoxSecondaryUser.Size = new Size(154, 22);
            checkBoxSecondaryUser.TabIndex = 5;
            checkBoxSecondaryUser.Text = "Is Secondary User";
            checkBoxSecondaryUser.UseVisualStyleBackColor = true;
            checkBoxSecondaryUser.CheckedChanged += checkBoxSecondaryUser_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxUserId);
            groupBox2.Controls.Add(checkBoxSecondaryUser);
            groupBox2.Controls.Add(buttonSave);
            groupBox2.Controls.Add(textBoxAddress);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBoxPhone);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new Point(303, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 386);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Other Info ";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ControlLight;
            buttonSave.Image = Properties.Resources.Save;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(6, 330);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(250, 50);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(6, 281);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(250, 26);
            textBoxAddress.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 251);
            label10.Name = "label10";
            label10.Size = new Size(75, 18);
            label10.TabIndex = 6;
            label10.Text = "Address :";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(6, 212);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(250, 26);
            textBoxEmail.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 182);
            label12.Name = "label12";
            label12.Size = new Size(118, 18);
            label12.TabIndex = 3;
            label12.Text = "Email Address :";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(6, 142);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(250, 26);
            textBoxPhone.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 112);
            label14.Name = "label14";
            label14.Size = new Size(120, 18);
            label14.TabIndex = 0;
            label14.Text = "Phone Number :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel);
            groupBox3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(12, 398);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(558, 157);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Permissions";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(checkBoxAdd);
            flowLayoutPanel.Controls.Add(checkBoxDelete);
            flowLayoutPanel.Controls.Add(checkBoxEdit);
            flowLayoutPanel.Controls.Add(checkBoxExport);
            flowLayoutPanel.Controls.Add(checkBoxPrint);
            flowLayoutPanel.Controls.Add(checkBoxSearch);
            flowLayoutPanel.Controls.Add(checkBoxSearchHP);
            flowLayoutPanel.Controls.Add(checkBoxHome);
            flowLayoutPanel.Controls.Add(checkBoxSalary);
            flowLayoutPanel.Controls.Add(checkBoxEmployees);
            flowLayoutPanel.Controls.Add(checkBoxUsers);
            flowLayoutPanel.Controls.Add(checkBoxReport);
            flowLayoutPanel.Controls.Add(checkBoxSetting);
            flowLayoutPanel.Controls.Add(checkBoxAbout);
            flowLayoutPanel.Controls.Add(checkBoxHelp);
            flowLayoutPanel.Controls.Add(checkBoxRetirees);
            flowLayoutPanel.Controls.Add(checkBoxRecords);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(3, 26);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(552, 128);
            flowLayoutPanel.TabIndex = 0;
            // 
            // checkBoxAdd
            // 
            checkBoxAdd.AutoSize = true;
            checkBoxAdd.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxAdd.Location = new Point(3, 3);
            checkBoxAdd.Name = "checkBoxAdd";
            checkBoxAdd.Padding = new Padding(3);
            checkBoxAdd.Size = new Size(57, 26);
            checkBoxAdd.TabIndex = 0;
            checkBoxAdd.Text = "Add";
            checkBoxAdd.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelete
            // 
            checkBoxDelete.AutoSize = true;
            checkBoxDelete.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxDelete.Location = new Point(66, 3);
            checkBoxDelete.Name = "checkBoxDelete";
            checkBoxDelete.Padding = new Padding(3);
            checkBoxDelete.Size = new Size(73, 26);
            checkBoxDelete.TabIndex = 1;
            checkBoxDelete.Text = "Delete";
            checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxEdit
            // 
            checkBoxEdit.AutoSize = true;
            checkBoxEdit.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxEdit.Location = new Point(145, 3);
            checkBoxEdit.Name = "checkBoxEdit";
            checkBoxEdit.Padding = new Padding(3);
            checkBoxEdit.Size = new Size(56, 26);
            checkBoxEdit.TabIndex = 2;
            checkBoxEdit.Text = "Edit";
            checkBoxEdit.UseVisualStyleBackColor = true;
            // 
            // checkBoxExport
            // 
            checkBoxExport.AutoSize = true;
            checkBoxExport.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxExport.Location = new Point(207, 3);
            checkBoxExport.Name = "checkBoxExport";
            checkBoxExport.Padding = new Padding(3);
            checkBoxExport.Size = new Size(73, 26);
            checkBoxExport.TabIndex = 3;
            checkBoxExport.Text = "Export";
            checkBoxExport.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrint
            // 
            checkBoxPrint.AutoSize = true;
            checkBoxPrint.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxPrint.Location = new Point(286, 3);
            checkBoxPrint.Name = "checkBoxPrint";
            checkBoxPrint.Padding = new Padding(3);
            checkBoxPrint.Size = new Size(62, 26);
            checkBoxPrint.TabIndex = 4;
            checkBoxPrint.Text = "Print";
            checkBoxPrint.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearch
            // 
            checkBoxSearch.AutoSize = true;
            checkBoxSearch.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxSearch.Location = new Point(354, 3);
            checkBoxSearch.Name = "checkBoxSearch";
            checkBoxSearch.Padding = new Padding(3);
            checkBoxSearch.Size = new Size(77, 26);
            checkBoxSearch.TabIndex = 5;
            checkBoxSearch.Text = "Search";
            checkBoxSearch.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearchHP
            // 
            checkBoxSearchHP.AutoSize = true;
            checkBoxSearchHP.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxSearchHP.Location = new Point(3, 35);
            checkBoxSearchHP.Name = "checkBoxSearchHP";
            checkBoxSearchHP.Padding = new Padding(3);
            checkBoxSearchHP.Size = new Size(171, 26);
            checkBoxSearchHP.TabIndex = 6;
            checkBoxSearchHP.Text = "Search in Home Page";
            checkBoxSearchHP.UseVisualStyleBackColor = true;
            // 
            // checkBoxHome
            // 
            checkBoxHome.AutoSize = true;
            checkBoxHome.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxHome.Location = new Point(180, 35);
            checkBoxHome.Name = "checkBoxHome";
            checkBoxHome.Padding = new Padding(3);
            checkBoxHome.Size = new Size(69, 26);
            checkBoxHome.TabIndex = 7;
            checkBoxHome.Text = "Home";
            checkBoxHome.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalary
            // 
            checkBoxSalary.AutoSize = true;
            checkBoxSalary.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxSalary.Location = new Point(255, 35);
            checkBoxSalary.Name = "checkBoxSalary";
            checkBoxSalary.Padding = new Padding(3);
            checkBoxSalary.Size = new Size(134, 26);
            checkBoxSalary.TabIndex = 8;
            checkBoxSalary.Text = "Salary Category";
            checkBoxSalary.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmployees
            // 
            checkBoxEmployees.AutoSize = true;
            checkBoxEmployees.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxEmployees.Location = new Point(395, 35);
            checkBoxEmployees.Name = "checkBoxEmployees";
            checkBoxEmployees.Padding = new Padding(3);
            checkBoxEmployees.Size = new Size(101, 26);
            checkBoxEmployees.TabIndex = 9;
            checkBoxEmployees.Text = "Employees";
            checkBoxEmployees.UseVisualStyleBackColor = true;
            // 
            // checkBoxUsers
            // 
            checkBoxUsers.AutoSize = true;
            checkBoxUsers.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxUsers.Location = new Point(3, 67);
            checkBoxUsers.Name = "checkBoxUsers";
            checkBoxUsers.Padding = new Padding(3);
            checkBoxUsers.Size = new Size(66, 26);
            checkBoxUsers.TabIndex = 10;
            checkBoxUsers.Text = "Users";
            checkBoxUsers.UseVisualStyleBackColor = true;
            // 
            // checkBoxReport
            // 
            checkBoxReport.AutoSize = true;
            checkBoxReport.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxReport.Location = new Point(75, 67);
            checkBoxReport.Name = "checkBoxReport";
            checkBoxReport.Padding = new Padding(3);
            checkBoxReport.Size = new Size(80, 26);
            checkBoxReport.TabIndex = 11;
            checkBoxReport.Text = "Reports";
            checkBoxReport.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetting
            // 
            checkBoxSetting.AutoSize = true;
            checkBoxSetting.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxSetting.Location = new Point(161, 67);
            checkBoxSetting.Name = "checkBoxSetting";
            checkBoxSetting.Padding = new Padding(3);
            checkBoxSetting.Size = new Size(83, 26);
            checkBoxSetting.TabIndex = 12;
            checkBoxSetting.Text = "Settings";
            checkBoxSetting.UseVisualStyleBackColor = true;
            // 
            // checkBoxAbout
            // 
            checkBoxAbout.AutoSize = true;
            checkBoxAbout.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxAbout.Location = new Point(250, 67);
            checkBoxAbout.Name = "checkBoxAbout";
            checkBoxAbout.Padding = new Padding(3);
            checkBoxAbout.Size = new Size(69, 26);
            checkBoxAbout.TabIndex = 13;
            checkBoxAbout.Text = "About";
            checkBoxAbout.UseVisualStyleBackColor = true;
            // 
            // checkBoxHelp
            // 
            checkBoxHelp.AutoSize = true;
            checkBoxHelp.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxHelp.Location = new Point(325, 67);
            checkBoxHelp.Name = "checkBoxHelp";
            checkBoxHelp.Padding = new Padding(3);
            checkBoxHelp.Size = new Size(61, 26);
            checkBoxHelp.TabIndex = 14;
            checkBoxHelp.Text = "Help";
            checkBoxHelp.UseVisualStyleBackColor = true;
            // 
            // checkBoxRetirees
            // 
            checkBoxRetirees.AutoSize = true;
            checkBoxRetirees.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxRetirees.Location = new Point(392, 67);
            checkBoxRetirees.Name = "checkBoxRetirees";
            checkBoxRetirees.Padding = new Padding(3);
            checkBoxRetirees.Size = new Size(84, 26);
            checkBoxRetirees.TabIndex = 15;
            checkBoxRetirees.Text = "Retirees";
            checkBoxRetirees.UseVisualStyleBackColor = true;
            // 
            // checkBoxRecords
            // 
            checkBoxRecords.AutoSize = true;
            checkBoxRecords.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxRecords.Location = new Point(3, 99);
            checkBoxRecords.Name = "checkBoxRecords";
            checkBoxRecords.Padding = new Padding(3);
            checkBoxRecords.Size = new Size(79, 26);
            checkBoxRecords.TabIndex = 16;
            checkBoxRecords.Text = "records";
            checkBoxRecords.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 557);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit User";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxUserId;
        private CheckBox checkBoxSecondaryUser;
        private TextBox textBoxPassword;
        private Label label5;
        private Label label6;
        private TextBox textBoxUserName;
        private Label label3;
        private Label label4;
        private TextBox textBoxFullName;
        private GroupBox groupBox2;
        private TextBox textBoxAddress;
        private Label label10;
        private TextBox textBoxEmail;
        private Label label12;
        private TextBox textBoxPhone;
        private Label label14;
        private GroupBox groupBox3;
        private Button buttonSave;
        private FlowLayoutPanel flowLayoutPanel;
        private ComboBox comboBoxRole;
        private Label label21;
        private CheckBox checkBoxAdd;
        private CheckBox checkBoxDelete;
        private CheckBox checkBoxEdit;
        private CheckBox checkBoxExport;
        private CheckBox checkBoxPrint;
        private CheckBox checkBoxSearch;
        private CheckBox checkBoxSearchHP;
        private CheckBox checkBoxHome;
        private CheckBox checkBoxSalary;
        private CheckBox checkBoxEmployees;
        private CheckBox checkBoxUsers;
        private CheckBox checkBoxReport;
        private CheckBox checkBoxSetting;
        private CheckBox checkBoxAbout;
        private CheckBox checkBoxHelp;
        private CheckBox checkBoxRetirees;
        private CheckBox checkBoxRecords;
    }
}