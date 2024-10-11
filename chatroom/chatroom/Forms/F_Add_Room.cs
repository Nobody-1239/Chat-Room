using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace chatroom.Forms
{
    public partial class F_Add_Room : Form
    {
        F_ChatRoom chatRoom;
        private List<TcpClient> clients = new List<TcpClient>();
        private TcpListener server;

        public F_Add_Room()
        {
            chatRoom = new F_ChatRoom(null);
            InitializeComponent();
        }

        private void F_Add_Room_Load(object sender, EventArgs e)
        {
            T_Ip.MaxLength = 15;
            T_Port.MaxLength = 4;
        }

        private void B_Creat_Server_Click(object sender, EventArgs e)
        {
            if (CheckValue())
            {
                server = new TcpListener(IPAddress.Parse(T_Ip.Text), Convert.ToInt32(T_Port.Text));
                server.Start();
                label3.Text = "Server created successfully\nServer is in listen mode";

                Thread serverThread = new Thread(ListenForClients);
                serverThread.IsBackground = true;
                serverThread.Start();
            }
        }

        private void ListenForClients()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                clients.Add(client);
                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.IsBackground = true;
                clientThread.Start();
            }
        }

        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            while (true)
            {
                try
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    UpdateChatRoom(message); 
                    BroadcastMessage(message);
                }
                catch
                {
                    break;
                }
            }

            clients.Remove(client);
            client.Close();
        }

        private void BroadcastMessage(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            foreach (var client in clients)
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(buffer, 0, buffer.Length);
                }
                catch
                {
                    
                }
            }
        }

        private void UpdateChatRoom(string message)
        {
            if (chatRoom.InvokeRequired)
            {
                chatRoom.Invoke(new Action(() => chatRoom.listbox(message)));
            }
            else
            {
                chatRoom.listbox(message);
            }
        }
        bool CheckValue()
        {
            if (string.IsNullOrWhiteSpace(T_Ip.Text))
            {
                label3.Text = "Please enter IP";
                return false;
            }

            if (string.IsNullOrWhiteSpace(T_Port.Text))
            {
                label3.Text = "Please enter the port";
                return false;
            }

            return true;
        }
    }
}
