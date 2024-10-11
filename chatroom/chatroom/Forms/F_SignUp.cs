using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatroom.Forms
{
    public partial class F_SignUp : Form
    {
        I_SignUp signUp;
        C_Hash hash;
        public F_SignUp()
        {
            hash = new C_Hash();
            signUp = new C_SignUp();
            InitializeComponent();
        }

        private void F_SignUp_Load(object sender, EventArgs e)
        {

        }
        private void B_SignUp_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                string username = hash.HashUsername(T_User_Name.Text);
                string password = hash.HashPassword(T_Password.Text);
                string email = T_Email.Text;

                bool Check_Repetive_Account = signUp.Check_Repitive(username);

                if (Check_Repetive_Account)
                {
                    MessageBox.Show("this username is invalid", "try another username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    signUp.SignUp(username, password, email);

                    MessageBox.Show("account add successful");
                    this.Close();
                }
            }
        }


        bool Check()
        {
            bool check = true;

            if (T_User_Name.Text == "")
            {
                check = false;
                MessageBox.Show("enter your username", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (T_Password.Text == "")
                {
                    check = false;
                    MessageBox.Show("enter your username", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (T_Email.Text == "")
                    {
                        check = false;
                        MessageBox.Show("enter your username", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return check;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
