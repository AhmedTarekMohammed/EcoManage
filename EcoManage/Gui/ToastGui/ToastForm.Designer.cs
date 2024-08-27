namespace EcoManage.Gui.ToastGui
{
    partial class ToastForm
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            labelTitle = new Label();
            labelDescription = new Label();
            timerToast = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Notification;
            pictureBox1.Location = new Point(345, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(12, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(121, 35);
            labelTitle.TabIndex = 1;
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelTitle.Click += label1_Click;
            // 
            // labelDescription
            // 
            labelDescription.Anchor = AnchorStyles.Top;
            labelDescription.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(12, 48);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(201, 35);
            labelDescription.TabIndex = 2;
            labelDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerToast
            // 
            timerToast.Enabled = true;
            timerToast.Interval = 2000;
            timerToast.Tick += timerToast_Tick;
            // 
            // ToastForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(459, 85);
            Controls.Add(labelDescription);
            Controls.Add(labelTitle);
            Controls.Add(pictureBox1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ToastForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Toast";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelTitle;
        private Label labelDescription;
        private System.Windows.Forms.Timer timerToast;
    }
}