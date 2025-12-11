namespace Lab7
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;

        public Form2(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;

            // Form2 displays login success
            loginAffirm.Text = "Logged in successfully.";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Update Form1 when logging out
            parentForm.SetLogoutMessage("Logged out successfully!");

            // Close this form
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
