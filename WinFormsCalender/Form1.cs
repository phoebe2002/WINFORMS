using System.Xml.Serialization;

namespace WinFormsCalender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string date = monthCalendar.SelectionStart.ToShortDateString();
            string note = noteTextBox.Text;
            ListViewItem newItem = new ListViewItem(new[] { date, note });
            calenderListView.Items.Add(newItem);
            // calendaristView.Items.Add(newItem);
            noteTextBox.Text = "";
            notifyIcon.ShowBalloonTip(1000, "Item added", "Added new event", ToolTipIcon.Info); // this shows a notification

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in calenderListView.SelectedItems)
                calenderListView.Items.Remove(item);

        }

        private void calenderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = calenderListView.SelectedItems.Count > 0;
        }
        private void ExitContextMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIconContextMenu.Items.Add("Exit", null, ExitContextMenu_Click);
        }
    }
}