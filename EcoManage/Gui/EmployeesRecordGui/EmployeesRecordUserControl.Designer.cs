namespace EcoManage.Gui.EmployeesRecordGui
{
    partial class EmployeesRecordUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            flowLayoutPanelNavBar = new FlowLayoutPanel();
            buttonDelete = new Button();
            buttonExportAll = new Button();
            buttonExportDataGridView = new Button();
            panel1 = new Panel();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            dataGridView1 = new DataGridView();
            labelStateTitle = new Label();
            panelState = new Panel();
            labelStateDescription = new Label();
            buttonRefresh = new Button();
            toolTip1 = new ToolTip(components);
            buttonPrev = new Button();
            buttonNext = new Button();
            comboBoxNoOfPages = new ComboBox();
            panel2 = new Panel();
            labelNofOfItmes = new Label();
            flowLayoutPanelNavBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelState.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.Controls.Add(buttonDelete);
            flowLayoutPanelNavBar.Controls.Add(buttonExportAll);
            flowLayoutPanelNavBar.Controls.Add(buttonExportDataGridView);
            flowLayoutPanelNavBar.Controls.Add(panel1);
            flowLayoutPanelNavBar.Dock = DockStyle.Top;
            flowLayoutPanelNavBar.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelNavBar.Location = new Point(0, 0);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new Padding(5);
            flowLayoutPanelNavBar.Size = new Size(1062, 67);
            flowLayoutPanelNavBar.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = Properties.Resources.Delete;
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(8, 8);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.RightToLeft = RightToLeft.No;
            buttonDelete.Size = new Size(100, 50);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = " Delete";
            buttonDelete.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(buttonDelete, "Delete Data, you can delete more than one row ");
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonExportAll
            // 
            buttonExportAll.Image = Properties.Resources.icons8_microsoft_excel_2019_32px;
            buttonExportAll.ImageAlign = ContentAlignment.MiddleRight;
            buttonExportAll.Location = new Point(114, 8);
            buttonExportAll.Name = "buttonExportAll";
            buttonExportAll.Size = new Size(100, 50);
            buttonExportAll.TabIndex = 3;
            buttonExportAll.Text = "     All";
            buttonExportAll.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(buttonExportAll, "Export All Data");
            buttonExportAll.UseVisualStyleBackColor = true;
            buttonExportAll.Click += buttonExport_Click;
            // 
            // buttonExportDataGridView
            // 
            buttonExportDataGridView.Image = Properties.Resources.icons8_Microsoft_Excel_32px;
            buttonExportDataGridView.ImageAlign = ContentAlignment.MiddleRight;
            buttonExportDataGridView.Location = new Point(220, 8);
            buttonExportDataGridView.Name = "buttonExportDataGridView";
            buttonExportDataGridView.RightToLeft = RightToLeft.Yes;
            buttonExportDataGridView.Size = new Size(100, 50);
            buttonExportDataGridView.TabIndex = 5;
            buttonExportDataGridView.Text = "   Grid";
            buttonExportDataGridView.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(buttonExportDataGridView, "Export Data Grid");
            buttonExportDataGridView.UseVisualStyleBackColor = true;
            buttonExportDataGridView.Click += buttonExportDataGridView_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(buttonSearch);
            panel1.Location = new Point(326, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 50);
            panel1.TabIndex = 4;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 13F);
            textBoxSearch.Location = new Point(0, 0);
            textBoxSearch.Margin = new Padding(0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(298, 32);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxSearch, "Write a Search Statment or hit the serch button to get all the data");
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // buttonSearch
            // 
            buttonSearch.Dock = DockStyle.Right;
            buttonSearch.Image = Properties.Resources.Search;
            buttonSearch.Location = new Point(298, 0);
            buttonSearch.Margin = new Padding(0);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(50, 50);
            buttonSearch.TabIndex = 4;
            toolTip1.SetToolTip(buttonSearch, "Write a Search Statment or hit the serch button to get all the data");
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Size = new Size(1062, 539);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // labelStateTitle
            // 
            labelStateTitle.BackColor = Color.White;
            labelStateTitle.Dock = DockStyle.Top;
            labelStateTitle.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            labelStateTitle.ForeColor = Color.Gray;
            labelStateTitle.Location = new Point(0, 0);
            labelStateTitle.Name = "labelStateTitle";
            labelStateTitle.Size = new Size(493, 37);
            labelStateTitle.TabIndex = 5;
            labelStateTitle.Text = "Status Message";
            labelStateTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelState
            // 
            panelState.Anchor = AnchorStyles.None;
            panelState.BackColor = Color.White;
            panelState.Controls.Add(labelStateDescription);
            panelState.Controls.Add(labelStateTitle);
            panelState.Location = new Point(285, 279);
            panelState.Name = "panelState";
            panelState.Size = new Size(493, 125);
            panelState.TabIndex = 5;
            panelState.Visible = false;
            // 
            // labelStateDescription
            // 
            labelStateDescription.BackColor = Color.White;
            labelStateDescription.Dock = DockStyle.Top;
            labelStateDescription.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            labelStateDescription.ForeColor = Color.LightGray;
            labelStateDescription.Location = new Point(0, 37);
            labelStateDescription.Name = "labelStateDescription";
            labelStateDescription.RightToLeft = RightToLeft.No;
            labelStateDescription.Size = new Size(493, 37);
            labelStateDescription.TabIndex = 6;
            labelStateDescription.Text = "State Description";
            labelStateDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRefresh.Image = Properties.Resources.icons8_sync_32px;
            buttonRefresh.Location = new Point(8, 541);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(50, 50);
            buttonRefresh.TabIndex = 5;
            toolTip1.SetToolTip(buttonRefresh, "Refresh");
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonPrev
            // 
            buttonPrev.Image = Properties.Resources.icons8_chevron_right_32px;
            buttonPrev.Location = new Point(167, 0);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(50, 50);
            buttonPrev.TabIndex = 6;
            toolTip1.SetToolTip(buttonPrev, "Previous Page");
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // buttonNext
            // 
            buttonNext.Image = Properties.Resources.icons8_chevron_left_32px;
            buttonNext.Location = new Point(0, 0);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(50, 50);
            buttonNext.TabIndex = 7;
            toolTip1.SetToolTip(buttonNext, "Next Page");
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // comboBoxNoOfPages
            // 
            comboBoxNoOfPages.BackColor = Color.White;
            comboBoxNoOfPages.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNoOfPages.Font = new Font("Microsoft Sans Serif", 13F);
            comboBoxNoOfPages.FormattingEnabled = true;
            comboBoxNoOfPages.Location = new Point(59, 9);
            comboBoxNoOfPages.Name = "comboBoxNoOfPages";
            comboBoxNoOfPages.Size = new Size(105, 34);
            comboBoxNoOfPages.TabIndex = 8;
            toolTip1.SetToolTip(comboBoxNoOfPages, "Number of Pages");
            comboBoxNoOfPages.SelectedIndexChanged += comboBoxNoOfPages_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labelNofOfItmes);
            panel2.Controls.Add(buttonNext);
            panel2.Controls.Add(comboBoxNoOfPages);
            panel2.Controls.Add(buttonPrev);
            panel2.Location = new Point(732, 541);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 50);
            panel2.TabIndex = 6;
            // 
            // labelNofOfItmes
            // 
            labelNofOfItmes.BackColor = Color.White;
            labelNofOfItmes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            labelNofOfItmes.ForeColor = Color.IndianRed;
            labelNofOfItmes.Location = new Point(223, 6);
            labelNofOfItmes.Name = "labelNofOfItmes";
            labelNofOfItmes.Size = new Size(89, 37);
            labelNofOfItmes.TabIndex = 9;
            labelNofOfItmes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EmployeesRecordUserControl
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(buttonRefresh);
            Controls.Add(panelState);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new Font("Microsoft Sans Serif", 12F);
            Margin = new Padding(4, 6, 4, 6);
            Name = "EmployeesRecordUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1062, 606);
            flowLayoutPanelNavBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelState.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelNavBar;
        private Button buttonDelete;
        private Button buttonExportAll;
        private Panel panel1;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private DataGridView dataGridView1;
        private Label labelStateTitle;
        private Panel panelState;
        private Label labelStateDescription;
        private Button buttonRefresh;
        private ToolTip toolTip1;
        private Button buttonExportDataGridView;
        private Panel panel2;
        private Button buttonNext;
        private Button buttonPrev;
        private ComboBox comboBoxNoOfPages;
        private Label labelNofOfItmes;
    }
}
