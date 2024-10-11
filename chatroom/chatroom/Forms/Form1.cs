using chatroom.Class;
using chatroom.Forms;
using Csla.Security;

namespace chatroom
{
    public partial class F_Login : Form
    {
        I_Login login;
        C_Hash hash;
        public F_Login()
        {
            login = new C_Login();
            hash = new C_Hash();
            InitializeComponent();
        }

        private void B_Login_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                string username = hash.HashUsername(T_UserName.Text);
                string password = hash.HashPassword(T_Password.Text);

                bool loginSuccess = login.Login(username, password);

                if (loginSuccess)
                {
                    this.Hide();
                    F_Main f_Main = new F_Main(T_UserName.Text);
                    label5.ForeColor = Color.Green;
                    label5.Text = "waite a moment";
                    f_Main.Show();
                }
                else
                {
                    MessageBox.Show("username or password is wronge", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private void B_Sign_Up_Click(object sender, EventArgs e)
        {
            F_SignUp signup = new F_SignUp();
            signup.ShowDialog();
        }


        bool Check()
        {
            bool check = true;
            if (T_UserName.Text == "")
            {
                check = false;
                MessageBox.Show("please enter your user name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (T_Password.Text == "")
                {
                    check = false;
                    MessageBox.Show("please enter the password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return check;
        }


    }
}
