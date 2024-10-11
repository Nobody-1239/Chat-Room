using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using chatroom.Class;

namespace chatroom.Forms
{
    public partial class F_Main : Form
    {
        bool sidebar_expand;
        public string userName { get; set; }

        public F_Main(string username)
        {
            userName = username;
            InitializeComponent();
        }

        private void F_Main_Load(object sender, EventArgs e)
        {

        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sidebar_timer_Tick(object sender, EventArgs e)
        {
            if (sidebar_expand)
            {
                panel1.Width -= 10;
                if (panel1.Width == panel1.MinimumSize.Width)
                {
                    sidebar_expand = false;
                    sidebar_timer.Stop();
                }
            }
            else
            {
                panel1.Width += 10;
                if (panel1.Width == panel1.MaximumSize.Width)
                {
                    sidebar_expand = true;
                    sidebar_timer.Stop();
                }
            }

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            sidebar_timer.Start();
        }

        private void B_AddRoom_Click(object sender, EventArgs e)
        {
            F_Add_Room add_Room = new F_Add_Room();
            add_Room.TopLevel = false;
            add_Room.FormBorderStyle = FormBorderStyle.None;
            add_Room.Dock = DockStyle.None;
            add_Room.Location = new Point(230, 0);
            this.Controls.Clear();
            this.Controls.Add(panel1);
            this.Controls.Add(add_Room);
            add_Room.Show();
        }

        private void B_Profile_Click(object sender, EventArgs e)
        {

        }

        private void B_JoinRoom_Click(object sender, EventArgs e)
        {
            F_ChatRoom chatRoom = new F_ChatRoom(userName);
            chatRoom.TopLevel = false;
            chatRoom.FormBorderStyle = FormBorderStyle.None;
            chatRoom.Dock = DockStyle.None;
            chatRoom.Location = new Point(230, 0);
            this.Controls.Clear();
            this.Controls.Add(panel1);
            this.Controls.Add(chatRoom);
            chatRoom.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
