namespace StudentTracker
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // Checks for the character to be digits only (user number can only be numbers)
        private void userBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
