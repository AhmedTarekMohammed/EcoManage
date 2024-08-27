namespace EcoManage.Gui.UsersGui
{
    partial class UsersUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            buttonAdd = new Button();
            flowLayoutPanelNavBar = new FlowLayoutPanel();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonExportAll = new Button();
            panel1 = new Panel();
            textBoxSerach = new TextBox();
            buttonSearch = new Button();
            dataGridView1 = new DataGridView();
            labelStateTitle = new Label();
            panelState = new Panel();
            labelStateDescription = new Label();
            btnReload = new Button();
            toolTip1 = new ToolTip(components);
            buttonExportDataGridView = new Button();
            flowLayoutPanelNavBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelState.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonAdd.Image = Properties.Resources.Add;
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 50);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "     Add";
            toolTip1.SetToolTip(buttonAdd, "Add New Data");
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.Controls.Add(buttonAdd);
            flowLayoutPanelNavBar.Controls.Add(buttonEdit);
            flowLayoutPanelNavBar.Controls.Add(buttonDelete);
            flowLayoutPanelNavBar.Controls.Add(buttonExportAll);
            flowLayoutPanelNavBar.Controls.Add(buttonExportDataGridView);
            flowLayoutPanelNavBar.Controls.Add(panel1);
            flowLayoutPanelNavBar.Dock = DockStyle.Top;
            flowLayoutPanelNavBar.Location = new Point(0, 0);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Size = new Size(1064, 57);
            flowLayoutPanelNavBar.TabIndex = 1;
            // 
            // buttonEdit
            // 
            buttonEdit.Image = Properties.Resources.Edit;
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEdit.Location = new Point(109, 3);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(100, 50);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "      Edit";
            toolTip1.SetToolTip(buttonEdit, "Edit The Current Line ");
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = Properties.Resources.Delete;
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(215, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 50);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "   Delete";
            buttonDelete.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(buttonDelete, "Delete Data. You Can Delete Many lines At The Same Time");
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonExportAll
            // 
            buttonExportAll.Image = Properties.Resources.Microsoft_Excel;
            buttonExportAll.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExportAll.Location = new Point(321, 3);
            buttonExportAll.Name = "buttonExportAll";
            buttonExportAll.Size = new Size(100, 50);
            buttonExportAll.TabIndex = 3;
            buttonExportAll.Text = "All       ";
            buttonExportAll.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(buttonExportAll, "Export All Data");
            buttonExportAll.UseVisualStyleBackColor = true;
            buttonExportAll.Click += buttonExport_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxSerach);
            panel1.Controls.Add(buttonSearch);
            panel1.Location = new Point(533, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 50);
            panel1.TabIndex = 4;
            // 
            // textBoxSerach
            // 
            textBoxSerach.Dock = DockStyle.Fill;
            textBoxSerach.Location = new Point(0, 0);
            textBoxSerach.Multiline = true;
            textBoxSerach.Name = "textBoxSerach";
            textBoxSerach.Size = new Size(268, 50);
            textBoxSerach.TabIndex = 5;
            toolTip1.SetToolTip(textBoxSerach, "Write A Search Message Or Press Search Directly To Show All The Data");
            textBoxSerach.KeyDown += textBoxSerach_KeyDown;
            // 
            // buttonSearch
            // 
            buttonSearch.Dock = DockStyle.Right;
            buttonSearch.Image = Properties.Resources.Search;
            buttonSearch.Location = new Point(268, 0);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(50, 50);
            buttonSearch.TabIndex = 4;
            buttonSearch.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(buttonSearch, "Write A Search Message Or Press Search Directly To Show All The Data");
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.Size = new Size(1064, 559);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // labelStateTitle
            // 
            labelStateTitle.BackColor = Color.White;
            labelStateTitle.Dock = DockStyle.Top;
            labelStateTitle.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStateTitle.ForeColor = Color.Gray;
            labelStateTitle.Location = new Point(0, 0);
            labelStateTitle.Name = "labelStateTitle";
            labelStateTitle.Size = new Size(509, 31);
            labelStateTitle.TabIndex = 6;
            labelStateTitle.Text = "not found data ";
            labelStateTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelState
            // 
            panelState.Anchor = AnchorStyles.None;
            panelState.BackColor = Color.White;
            panelState.Controls.Add(labelStateDescription);
            panelState.Controls.Add(labelStateTitle);
            panelState.Location = new Point(262, 264);
            panelState.Name = "panelState";
            panelState.Size = new Size(509, 166);
            panelState.TabIndex = 5;
            panelState.Visible = false;
            // 
            // labelStateDescription
            // 
            labelStateDescription.BackColor = Color.White;
            labelStateDescription.Dock = DockStyle.Top;
            labelStateDescription.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStateDescription.ForeColor = Color.DarkGray;
            labelStateDescription.Location = new Point(0, 31);
            labelStateDescription.Name = "labelStateDescription";
            labelStateDescription.Size = new Size(509, 31);
            labelStateDescription.TabIndex = 7;
            labelStateDescription.Text = "not found data ";
            labelStateDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReload.BackColor = Color.White;
            btnReload.Image = Properties.Resources.reaload;
            btnReload.ImageAlign = ContentAlignment.MiddleLeft;
            btnReload.Location = new Point(22, 548);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(53, 49);
            btnReload.TabIndex = 5;
            btnReload.Text = "   ";
            toolTip1.SetToolTip(btnReload, "Reload ");
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // buttonExportDataGridView
            // 
            buttonExportDataGridView.Image = Properties.Resources.Microsoft_Excel;
            buttonExportDataGridView.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExportDataGridView.Location = new Point(427, 3);
            buttonExportDataGridView.Name = "buttonExportDataGridView";
            buttonExportDataGridView.Size = new Size(100, 50);
            buttonExportDataGridView.TabIndex = 5;
            buttonExportDataGridView.Text = "Grid   ";
            buttonExportDataGridView.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(buttonExportDataGridView, "Export Data Grid View");
            buttonExportDataGridView.UseVisualStyleBackColor = true;
            // 
            // UsersUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReload);
            Controls.Add(panelState);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UsersUserControl";
            Size = new Size(1064, 616);
            flowLayoutPanelNavBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelState.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private FlowLayoutPanel flowLayoutPanelNavBar;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonExportAll;
        private Panel panel1;
        private TextBox textBoxSerach;
        private Button buttonSearch;
        private DataGridView dataGridView1;
        private Label labelStateTitle;
        private Panel panelState;
        private Label labelStateDescription;
        private Button btnReload;
        private ToolTip toolTip1;
        private Button buttonExportDataGridView;
    }
}
