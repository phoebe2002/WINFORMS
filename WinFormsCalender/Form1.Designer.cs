namespace WinFormsCalender
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer = new SplitContainer();
            noteTextBox = new TextBox();
            monthCalendar = new MonthCalendar();
            calenderListView = new ListView();
            dateColumHeader = new ColumnHeader();
            noteColumHeader = new ColumnHeader();
            removeButton = new Button();
            addButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            notifyIcon = new NotifyIcon(components);
            notifyIconContextMenu = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.BackColor = Color.LightSteelBlue;
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = SystemColors.ControlLight;
            splitContainer.Panel1.Controls.Add(noteTextBox);
            splitContainer.Panel1.Controls.Add(monthCalendar);
            splitContainer.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = SystemColors.ControlLight;
            splitContainer.Panel2.Controls.Add(calenderListView);
            splitContainer.Panel2.Controls.Add(removeButton);
            splitContainer.Panel2.Controls.Add(addButton);
            splitContainer.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer.Size = new Size(1010, 611);
            splitContainer.SplitterDistance = 361;
            splitContainer.TabIndex = 0;
            // 
            // noteTextBox
            // 
            noteTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            noteTextBox.Location = new Point(724, 12);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(274, 328);
            noteTextBox.TabIndex = 1;
            // 
            // monthCalendar
            // 
            monthCalendar.CalendarDimensions = new Size(2, 1);
            monthCalendar.Location = new Point(0, 0);
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            // 
            // calenderListView
            // 
            calenderListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calenderListView.Columns.AddRange(new ColumnHeader[] { dateColumHeader, noteColumHeader });
            calenderListView.FullRowSelect = true;
            calenderListView.Location = new Point(12, 54);
            calenderListView.Name = "calenderListView";
            calenderListView.Size = new Size(986, 170);
            calenderListView.TabIndex = 2;
            calenderListView.UseCompatibleStateImageBehavior = false;
            calenderListView.View = View.Details;
            // 
            // dateColumHeader
            // 
            dateColumHeader.Text = "Date";
            dateColumHeader.Width = 120;
            // 
            // noteColumHeader
            // 
            noteColumHeader.Text = "Note";
            noteColumHeader.Width = 200;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(149, 8);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(131, 40);
            removeButton.TabIndex = 1;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 8);
            addButton.Name = "addButton";
            addButton.Size = new Size(131, 40);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = notifyIconContextMenu;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Windows Forms Calender";
            notifyIcon.Visible = true;
            // 
            // notifyIconContextMenu
            // 
            notifyIconContextMenu.ImageScalingSize = new Size(28, 28);
            notifyIconContextMenu.Name = "notifyIconContextMenu";
            notifyIconContextMenu.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 611);
            Controls.Add(splitContainer);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private TextBox noteTextBox;
        private MonthCalendar monthCalendar;
        private OpenFileDialog openFileDialog1;
        private ListView calenderListView;
        private Button removeButton;
        private Button addButton;
        private ColumnHeader dateColumHeader;
        private ColumnHeader noteColumHeader;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip notifyIconContextMenu;
    }
}