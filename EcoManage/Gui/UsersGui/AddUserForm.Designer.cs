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
            comboBoxSecondaryUser = new ComboBox();
            checkBox1 = new CheckBox();
            textBoxPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxUserName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxFullName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonSave = new Button();
            textBoxAddress = new TextBox();
            label10 = new Label();
            textBoxEmail = new TextBox();
            label12 = new Label();
            textBoxPhone = new TextBox();
            label14 = new Label();
            groupBox3 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label21 = new Label();
            comboBoxRole = new ComboBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox16 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            // comboBoxSecondaryUser
            // 
            comboBoxSecondaryUser.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSecondaryUser.Enabled = false;
            comboBoxSecondaryUser.FormattingEnabled = true;
            comboBoxSecondaryUser.Location = new Point(6, 71);
            comboBoxSecondaryUser.Name = "comboBoxSecondaryUser";
            comboBoxSecondaryUser.Size = new Size(250, 26);
            comboBoxSecondaryUser.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(154, 22);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Is Secondary User";
            checkBox1.UseVisualStyleBackColor = true;
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
            label5.Location = new Point(89, 206);
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
            label3.Location = new Point(78, 121);
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
            label2.Location = new Point(78, 37);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxSecondaryUser);
            groupBox2.Controls.Add(checkBox1);
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
            groupBox3.Controls.Add(flowLayoutPanel1);
            groupBox3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(12, 398);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(553, 128);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Permissions";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(checkBox2);
            flowLayoutPanel1.Controls.Add(checkBox3);
            flowLayoutPanel1.Controls.Add(checkBox4);
            flowLayoutPanel1.Controls.Add(checkBox5);
            flowLayoutPanel1.Controls.Add(checkBox6);
            flowLayoutPanel1.Controls.Add(checkBox7);
            flowLayoutPanel1.Controls.Add(checkBox8);
            flowLayoutPanel1.Controls.Add(checkBox9);
            flowLayoutPanel1.Controls.Add(checkBox10);
            flowLayoutPanel1.Controls.Add(checkBox11);
            flowLayoutPanel1.Controls.Add(checkBox12);
            flowLayoutPanel1.Controls.Add(checkBox13);
            flowLayoutPanel1.Controls.Add(checkBox14);
            flowLayoutPanel1.Controls.Add(checkBox15);
            flowLayoutPanel1.Controls.Add(checkBox16);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 26);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(547, 99);
            flowLayoutPanel1.TabIndex = 0;
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
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Enabled = false;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Manager", "User", "ReadOnlyUser" });
            comboBoxRole.Location = new Point(6, 343);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(250, 26);
            comboBoxRole.TabIndex = 4;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(3, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Padding = new Padding(3);
            checkBox2.Size = new Size(57, 26);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "Add";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox3.Location = new Point(66, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Padding = new Padding(3);
            checkBox3.Size = new Size(73, 26);
            checkBox3.TabIndex = 1;
            checkBox3.Text = "Delete";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox4.Location = new Point(145, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Padding = new Padding(3);
            checkBox4.Size = new Size(56, 26);
            checkBox4.TabIndex = 2;
            checkBox4.Text = "Edit";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox5.Location = new Point(207, 3);
            checkBox5.Name = "checkBox5";
            checkBox5.Padding = new Padding(3);
            checkBox5.Size = new Size(73, 26);
            checkBox5.TabIndex = 3;
            checkBox5.Text = "Export";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox6.Location = new Point(286, 3);
            checkBox6.Name = "checkBox6";
            checkBox6.Padding = new Padding(3);
            checkBox6.Size = new Size(62, 26);
            checkBox6.TabIndex = 4;
            checkBox6.Text = "Print";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox7.Location = new Point(354, 3);
            checkBox7.Name = "checkBox7";
            checkBox7.Padding = new Padding(3);
            checkBox7.Size = new Size(77, 26);
            checkBox7.TabIndex = 5;
            checkBox7.Text = "Search";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox8.Location = new Point(3, 35);
            checkBox8.Name = "checkBox8";
            checkBox8.Padding = new Padding(3);
            checkBox8.Size = new Size(171, 26);
            checkBox8.TabIndex = 6;
            checkBox8.Text = "Search in Home Page";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox9.Location = new Point(180, 35);
            checkBox9.Name = "checkBox9";
            checkBox9.Padding = new Padding(3);
            checkBox9.Size = new Size(69, 26);
            checkBox9.TabIndex = 7;
            checkBox9.Text = "Home";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox10.Location = new Point(255, 35);
            checkBox10.Name = "checkBox10";
            checkBox10.Padding = new Padding(3);
            checkBox10.Size = new Size(134, 26);
            checkBox10.TabIndex = 8;
            checkBox10.Text = "Salary Category";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox11.Location = new Point(395, 35);
            checkBox11.Name = "checkBox11";
            checkBox11.Padding = new Padding(3);
            checkBox11.Size = new Size(101, 26);
            checkBox11.TabIndex = 9;
            checkBox11.Text = "Employees";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox12.Location = new Point(3, 67);
            checkBox12.Name = "checkBox12";
            checkBox12.Padding = new Padding(3);
            checkBox12.Size = new Size(66, 26);
            checkBox12.TabIndex = 10;
            checkBox12.Text = "Users";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox13.Location = new Point(75, 67);
            checkBox13.Name = "checkBox13";
            checkBox13.Padding = new Padding(3);
            checkBox13.Size = new Size(80, 26);
            checkBox13.TabIndex = 11;
            checkBox13.Text = "Reports";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox14.Location = new Point(161, 67);
            checkBox14.Name = "checkBox14";
            checkBox14.Padding = new Padding(3);
            checkBox14.Size = new Size(83, 26);
            checkBox14.TabIndex = 12;
            checkBox14.Text = "Settings";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox15.Location = new Point(250, 67);
            checkBox15.Name = "checkBox15";
            checkBox15.Padding = new Padding(3);
            checkBox15.Size = new Size(69, 26);
            checkBox15.TabIndex = 13;
            checkBox15.Text = "About";
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox16.Location = new Point(325, 67);
            checkBox16.Name = "checkBox16";
            checkBox16.Padding = new Padding(3);
            checkBox16.Size = new Size(61, 26);
            checkBox16.TabIndex = 14;
            checkBox16.Text = "Help";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 538);
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
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxSecondaryUser;
        private CheckBox checkBox1;
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
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox comboBoxRole;
        private Label label21;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
        private CheckBox checkBox16;
    }
}