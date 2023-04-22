namespace WinForms_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome " + nameTextBox.Text); // this just displays the welcome message
            if (this.ValidateChildren())
                MessageBox.Show("Welcome " + nameTextBox.Text); // displays welcome message after validating
        }

        private void nameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (nameTextBox.Text.Length == 0 || nameTextBox.Text.Length > 6)
            {
                nameErrorProvider.SetError(nameTextBox,
                "Name must contain from 1 to 6 characters");
                e.Cancel = true;
                return;
            }
            nameErrorProvider.SetError(nameTextBox, string.Empty);
            e.Cancel = false;
        }
    }
}