using System.Diagnostics;
using System.Security.Principal;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Do you want to start the program!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            if (userName.Equals("hieuto123") && passWord.Equals("123456"))
            { 
                this.Hide();
                Calculator calculator = new Calculator();
                calculator.ShowDialog();
            }
            else if (userName is null && passWord is null)
            {
                MessageBox.Show("Please do not leave your account password blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Input wrong account password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
