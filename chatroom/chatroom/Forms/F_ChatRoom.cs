using chatroom.Class;
using Csla.Security;
using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace chatroom.Forms
{
    public partial class F_ChatRoom : Form
    {
        C_Message MESSAGE;
        Chat_Connection connection_info;
        Form get_info;
        TextBox T_ip;
        TextBox T_port;
        Button B_Connection;
        TcpClient client;
        NetworkStream stream;
        public string UserName { get; set; }
        public F_ChatRoom(string username)
        {
            UserName = username;
            MESSAGE = new C_Message();
            connection_info = new Chat_Connection();
            get_info = new Form
            {
                Size = new Size(300, 300),
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                Text = "Enter IP and Port"
            };

            T_ip = new TextBox
            {
                Size = new Size(200, 25),
                Location = new Point(0, 40),
                Text = "ip",
                MaxLength = 15
            };
            T_port = new TextBox
            {
                Size = new Size(200, 25),
                Location = new Point(0, 90),
                Text = "port"
            };

            B_Connection = new Button
            {
                Size = new Size(100, 35),
                Location = new Point(75, 170),
                Text = "Connect",
            };
            B_Connection.Click += new EventHandler(B_Connection_Click);

            InitializeComponent();
        }

        private void F_ChatRoom_Load(object sender, EventArgs e)
        {
            get_info.Controls.Add(T_ip);
            get_info.Controls.Add(T_port);
            get_info.Controls.Add(B_Connection);
            get_info.ShowDialog();
            
        }

        public void B_Connection_Click(object sender, EventArgs e)
        {
            if (CheckValue())
            {
                connection_info.ip = T_ip.Text;
                connection_info.port = Convert.ToInt32(T_port.Text);
                try
                {
                    client = new TcpClient(connection_info.ip, connection_info.port);
                    stream = client.GetStream();
                    get_info.Close();
                    Thread receiveThread = new Thread(ReceiveMessage);
                    receiveThread.IsBackground = true;
                    receiveThread.Start();
                }
                catch
                {
                    MessageBox.Show("Server is offline. Try later.");
                }
            }
        }

        private void B_Send_Message_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(T_Message.Text) && T_Message.Text != "Message")
            {
                try
                {
                    MESSAGE.Message_Text = $"{UserName} \t: {T_Message.Text}";
                    byte[] buffer = Encoding.UTF8.GetBytes(MESSAGE.Message_Text);
                    stream.Write(buffer, 0, buffer.Length);
                    T_Message.Text = null;
                    T_Message.Text = "Message";
                }
                catch
                {
                    MessageBox.Show("please connect to server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (L_Chat.Items.Count > 0)
            {
                L_Chat.EnsureVisible(L_Chat.Items.Count - 1);
            }
        }

        private void ReceiveMessage()
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                try
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    UpdateListBox(message);
                }
                catch
                {
                    break;
                }
            }
            CloseConnection();
        }

        private void UpdateListBox(string text)
        {
            if (L_Chat.InvokeRequired)
            {
                L_Chat.Invoke(new Action(() => listbox(text)));
            }
            else
            {
                listbox(text);
            }

        }

        public void listbox(string text)
        {
            L_Chat.Items.Add(text);
            L_Chat.Items.Add(string.Empty);
        }



        private void CloseConnection()
        {
            stream?.Close();
            client?.Close();
        }

        bool CheckValue()
        {
            if (string.IsNullOrWhiteSpace(T_ip.Text))
            {
                MessageBox.Show("Please enter an IP address.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(T_port.Text))
            {
                MessageBox.Show("Please enter a port number.");
                return false;
            }

            return true;
        }

        private void T_Message_Click(object sender, EventArgs e)
        {
            T_Message.Clear();
        }
    }
}
