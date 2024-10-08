﻿namespace EcoManage.Gui.EmployeesGui
{
    partial class AddEmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeesForm));
            groupBox1 = new GroupBox();
            label15 = new Label();
            label13 = new Label();
            label12 = new Label();
            dateTimePickerLastPromotion = new DateTimePicker();
            comboBoxEmpState = new ComboBox();
            label14 = new Label();
            comboBoxJobTitle = new ComboBox();
            label2 = new Label();
            textBoxFullName = new TextBox();
            label11 = new Label();
            label1 = new Label();
            buttonSave = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            buttonUpgrade = new Button();
            buttonAutoCal = new Button();
            buttonNew = new Button();
            groupBox4 = new GroupBox();
            richTextBoxNote = new RichTextBox();
            groupBox3 = new GroupBox();
            dateTimePickerNextDate = new DateTimePicker();
            numericUpDownNextStage = new NumericUpDown();
            numericUpDownNextDegree = new NumericUpDown();
            textBoxNextSalary = new TextBox();
            label7 = new Label();
            label8 = new Label();
            labelSalryCurrency = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            dateTimePickerCurrentDate = new DateTimePicker();
            numericUpDownCurrentStage = new NumericUpDown();
            numericUpDownCurrentDegree = new NumericUpDown();
            textBoxCurrentSalary = new TextBox();
            label6 = new Label();
            label5 = new Label();
            labelSBonusCurrency = new Label();
            label3 = new Label();
            label4 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNextStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNextDegree).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCurrentStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCurrentDegree).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dateTimePickerLastPromotion);
            groupBox1.Controls.Add(comboBoxEmpState);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(comboBoxJobTitle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxFullName);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(23, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1018, 149);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Basic Information";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Right;
            label15.AutoSize = true;
            label15.ForeColor = Color.Red;
            label15.Location = new Point(744, 26);
            label15.Name = "label15";
            label15.Size = new Size(20, 25);
            label15.TabIndex = 7;
            label15.Text = "*";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Right;
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(478, 26);
            label13.Name = "label13";
            label13.Size = new Size(20, 25);
            label13.TabIndex = 7;
            label13.Text = "*";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Right;
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(104, 26);
            label12.Name = "label12";
            label12.Size = new Size(20, 25);
            label12.TabIndex = 7;
            label12.Text = "*";
            // 
            // dateTimePickerLastPromotion
            // 
            dateTimePickerLastPromotion.Anchor = AnchorStyles.Right;
            dateTimePickerLastPromotion.Format = DateTimePickerFormat.Short;
            dateTimePickerLastPromotion.Location = new Point(797, 68);
            dateTimePickerLastPromotion.Name = "dateTimePickerLastPromotion";
            dateTimePickerLastPromotion.Size = new Size(191, 30);
            dateTimePickerLastPromotion.TabIndex = 6;
            // 
            // comboBoxEmpState
            // 
            comboBoxEmpState.Anchor = AnchorStyles.Right;
            comboBoxEmpState.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxEmpState.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxEmpState.FormattingEnabled = true;
            comboBoxEmpState.Items.AddRange(new object[] { "Bonus", "Promotion", "Bonus In progress", "Promotion In progress", "Stopped", "Under Revision" });
            comboBoxEmpState.Location = new Point(585, 68);
            comboBoxEmpState.Name = "comboBoxEmpState";
            comboBoxEmpState.Size = new Size(179, 33);
            comboBoxEmpState.TabIndex = 4;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Right;
            label14.AutoSize = true;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(585, 28);
            label14.Name = "label14";
            label14.Size = new Size(166, 25);
            label14.TabIndex = 2;
            label14.Text = "Employee Status:";
            // 
            // comboBoxJobTitle
            // 
            comboBoxJobTitle.Anchor = AnchorStyles.Right;
            comboBoxJobTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxJobTitle.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxJobTitle.FormattingEnabled = true;
            comboBoxJobTitle.Location = new Point(390, 68);
            comboBoxJobTitle.Name = "comboBoxJobTitle";
            comboBoxJobTitle.Size = new Size(179, 33);
            comboBoxJobTitle.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(390, 26);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 2;
            label2.Text = "Job Title :";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Anchor = AnchorStyles.Left;
            textBoxFullName.Location = new Point(6, 68);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(363, 30);
            textBoxFullName.TabIndex = 3;
            textBoxFullName.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Right;
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(797, 28);
            label11.Name = "label11";
            label11.Size = new Size(199, 25);
            label11.TabIndex = 2;
            label11.Text = "Last Promotion Date :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 2;
            label1.Text = "Full Name:";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Right;
            buttonSave.ForeColor = Color.Black;
            buttonSave.Image = Properties.Resources.icons8_save_32px;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(860, 10);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(178, 60);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1062, 756);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1054, 718);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bonus and Promotions";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonUpgrade);
            panel1.Controls.Add(buttonAutoCal);
            panel1.Controls.Add(buttonNew);
            panel1.Controls.Add(buttonSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 637);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 78);
            panel1.TabIndex = 5;
            // 
            // buttonUpgrade
            // 
            buttonUpgrade.Anchor = AnchorStyles.Left;
            buttonUpgrade.ForeColor = Color.Black;
            buttonUpgrade.Image = Properties.Resources.icons8_save_32px;
            buttonUpgrade.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpgrade.Location = new Point(5, 10);
            buttonUpgrade.Name = "buttonUpgrade";
            buttonUpgrade.Size = new Size(259, 60);
            buttonUpgrade.TabIndex = 4;
            buttonUpgrade.Text = "Exucte Promotion and Bonus";
            buttonUpgrade.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonUpgrade.UseVisualStyleBackColor = true;
            buttonUpgrade.Click += buttonUpgrade_Click;
            // 
            // buttonAutoCal
            // 
            buttonAutoCal.Anchor = AnchorStyles.Right;
            buttonAutoCal.ForeColor = Color.Black;
            buttonAutoCal.Image = Properties.Resources.icons8_save_32px;
            buttonAutoCal.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAutoCal.Location = new Point(455, 10);
            buttonAutoCal.Name = "buttonAutoCal";
            buttonAutoCal.Size = new Size(211, 60);
            buttonAutoCal.TabIndex = 4;
            buttonAutoCal.Text = "Auto Calculate";
            buttonAutoCal.UseVisualStyleBackColor = true;
            buttonAutoCal.Click += buttonAutoCal_Click;
            // 
            // buttonNew
            // 
            buttonNew.Anchor = AnchorStyles.Right;
            buttonNew.ForeColor = Color.Black;
            buttonNew.Image = Properties.Resources.icons8_save_32px;
            buttonNew.ImageAlign = ContentAlignment.MiddleLeft;
            buttonNew.Location = new Point(672, 10);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(178, 60);
            buttonNew.TabIndex = 4;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(richTextBoxNote);
            groupBox4.ForeColor = Color.Blue;
            groupBox4.Location = new Point(23, 473);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1018, 146);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Notes";
            // 
            // richTextBoxNote
            // 
            richTextBoxNote.Dock = DockStyle.Fill;
            richTextBoxNote.Location = new Point(3, 26);
            richTextBoxNote.Name = "richTextBoxNote";
            richTextBoxNote.Size = new Size(1012, 117);
            richTextBoxNote.TabIndex = 0;
            richTextBoxNote.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dateTimePickerNextDate);
            groupBox3.Controls.Add(numericUpDownNextStage);
            groupBox3.Controls.Add(numericUpDownNextDegree);
            groupBox3.Controls.Add(textBoxNextSalary);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(labelSalryCurrency);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(23, 318);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1018, 149);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Next Bonus";
            // 
            // dateTimePickerNextDate
            // 
            dateTimePickerNextDate.Anchor = AnchorStyles.Left;
            dateTimePickerNextDate.Format = DateTimePickerFormat.Short;
            dateTimePickerNextDate.Location = new Point(665, 76);
            dateTimePickerNextDate.Name = "dateTimePickerNextDate";
            dateTimePickerNextDate.Size = new Size(323, 30);
            dateTimePickerNextDate.TabIndex = 6;
            // 
            // numericUpDownNextStage
            // 
            numericUpDownNextStage.Anchor = AnchorStyles.Right;
            numericUpDownNextStage.Location = new Point(284, 78);
            numericUpDownNextStage.Name = "numericUpDownNextStage";
            numericUpDownNextStage.Size = new Size(150, 30);
            numericUpDownNextStage.TabIndex = 5;
            numericUpDownNextStage.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownNextStage.ValueChanged += numericUpDownNextStage_ValueChanged;
            // 
            // numericUpDownNextDegree
            // 
            numericUpDownNextDegree.Anchor = AnchorStyles.Right;
            numericUpDownNextDegree.Location = new Point(470, 78);
            numericUpDownNextDegree.Name = "numericUpDownNextDegree";
            numericUpDownNextDegree.Size = new Size(150, 30);
            numericUpDownNextDegree.TabIndex = 5;
            numericUpDownNextDegree.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownNextDegree.ValueChanged += numericUpDownNextDegree_ValueChanged;
            // 
            // textBoxNextSalary
            // 
            textBoxNextSalary.Anchor = AnchorStyles.Right;
            textBoxNextSalary.Location = new Point(22, 78);
            textBoxNextSalary.Name = "textBoxNextSalary";
            textBoxNextSalary.Size = new Size(223, 30);
            textBoxNextSalary.TabIndex = 3;
            textBoxNextSalary.Text = "0";
            textBoxNextSalary.TextAlign = HorizontalAlignment.Center;
            textBoxNextSalary.MouseLeave += textBoxNextSalary_MouseLeave;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(665, 36);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 2;
            label7.Text = "Date :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(284, 36);
            label8.Name = "label8";
            label8.Size = new Size(70, 25);
            label8.TabIndex = 2;
            label8.Text = "Stage:";
            // 
            // labelSalryCurrency
            // 
            labelSalryCurrency.Anchor = AnchorStyles.Right;
            labelSalryCurrency.AutoSize = true;
            labelSalryCurrency.ForeColor = Color.Gray;
            labelSalryCurrency.Location = new Point(172, 36);
            labelSalryCurrency.Name = "labelSalryCurrency";
            labelSalryCurrency.Size = new Size(53, 25);
            labelSalryCurrency.TabIndex = 2;
            labelSalryCurrency.Text = "EGP";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(22, 36);
            label9.Name = "label9";
            label9.Size = new Size(124, 25);
            label9.TabIndex = 2;
            label9.Text = "Next Salary :";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(478, 36);
            label10.Name = "label10";
            label10.Size = new Size(87, 25);
            label10.TabIndex = 2;
            label10.Text = "Degree :";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dateTimePickerCurrentDate);
            groupBox2.Controls.Add(numericUpDownCurrentStage);
            groupBox2.Controls.Add(numericUpDownCurrentDegree);
            groupBox2.Controls.Add(textBoxCurrentSalary);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(labelSBonusCurrency);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(23, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1018, 149);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Bonus";
            // 
            // dateTimePickerCurrentDate
            // 
            dateTimePickerCurrentDate.Anchor = AnchorStyles.Right;
            dateTimePickerCurrentDate.Format = DateTimePickerFormat.Short;
            dateTimePickerCurrentDate.Location = new Point(665, 81);
            dateTimePickerCurrentDate.Name = "dateTimePickerCurrentDate";
            dateTimePickerCurrentDate.Size = new Size(323, 30);
            dateTimePickerCurrentDate.TabIndex = 6;
            // 
            // numericUpDownCurrentStage
            // 
            numericUpDownCurrentStage.Anchor = AnchorStyles.Right;
            numericUpDownCurrentStage.Location = new Point(284, 81);
            numericUpDownCurrentStage.Name = "numericUpDownCurrentStage";
            numericUpDownCurrentStage.Size = new Size(150, 30);
            numericUpDownCurrentStage.TabIndex = 5;
            numericUpDownCurrentStage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCurrentStage.ValueChanged += numericUpDownCurrentStage_ValueChanged;
            // 
            // numericUpDownCurrentDegree
            // 
            numericUpDownCurrentDegree.Anchor = AnchorStyles.Right;
            numericUpDownCurrentDegree.Location = new Point(470, 81);
            numericUpDownCurrentDegree.Name = "numericUpDownCurrentDegree";
            numericUpDownCurrentDegree.Size = new Size(150, 30);
            numericUpDownCurrentDegree.TabIndex = 5;
            numericUpDownCurrentDegree.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCurrentDegree.ValueChanged += numericUpDownCurrentDegree_ValueChanged;
            // 
            // textBoxCurrentSalary
            // 
            textBoxCurrentSalary.Anchor = AnchorStyles.Left;
            textBoxCurrentSalary.Location = new Point(22, 81);
            textBoxCurrentSalary.Name = "textBoxCurrentSalary";
            textBoxCurrentSalary.Size = new Size(223, 30);
            textBoxCurrentSalary.TabIndex = 3;
            textBoxCurrentSalary.Text = "0";
            textBoxCurrentSalary.TextAlign = HorizontalAlignment.Center;
            textBoxCurrentSalary.MouseLeave += textBoxCurrentSalary_MouseLeave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(665, 41);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 2;
            label6.Text = "Date :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(284, 41);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 2;
            label5.Text = "Stage:";
            // 
            // labelSBonusCurrency
            // 
            labelSBonusCurrency.Anchor = AnchorStyles.Right;
            labelSBonusCurrency.AutoSize = true;
            labelSBonusCurrency.ForeColor = Color.Gray;
            labelSBonusCurrency.Location = new Point(172, 42);
            labelSBonusCurrency.Name = "labelSBonusCurrency";
            labelSBonusCurrency.Size = new Size(53, 25);
            labelSBonusCurrency.TabIndex = 2;
            labelSBonusCurrency.Text = "EGP";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 42);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 2;
            label3.Text = "Current Salary:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(470, 41);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 2;
            label4.Text = "Degree :";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1054, 723);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Apprecication Letters";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1054, 723);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Holidays";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1054, 723);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Absent Days";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1054, 723);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Bonus system Records";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // AddEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 756);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            Name = "AddEmployeesForm";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit Employee";
            Load += AddEmployeesForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNextStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNextDegree).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCurrentStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCurrentDegree).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonSave;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label2;
        private TextBox textBoxFullName;
        private Label label1;
        private Panel panel1;
        private ComboBox comboBoxJobTitle;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDownCurrentDegree;
        private Label label3;
        private Label label4;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePickerNextDate;
        private NumericUpDown numericUpDownNextStage;
        private NumericUpDown numericUpDownNextDegree;
        private TextBox textBoxNextSalary;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePickerCurrentDate;
        private NumericUpDown numericUpDownCurrentStage;
        private TextBox textBoxCurrentSalary;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePickerLastPromotion;
        private Label label11;
        private GroupBox groupBox4;
        private RichTextBox richTextBoxNote;
        private Label labelSalryCurrency;
        private Label labelSBonusCurrency;
        private Label label13;
        private Label label12;
        private Label label15;
        private ComboBox comboBoxEmpState;
        private Label label14;
        private Button buttonAutoCal;
        private Button buttonNew;
        private Button buttonUpgrade;
    }
}