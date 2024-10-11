using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatroom
{
    internal class Chat_Connection
    {
        public string ip { get; set; }

        private int _port;
        private int _Server_Port;
        public int port
        {
            get
            {
                return _port;
            }
            set
            {
                if (value > 1024)
                {
                    _port = value;
                }
                else
                {
                    MessageBox.Show("Your port must be biger than 1024", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string Server_Ip { get; set; }
        public int Server_Port
        {
            get
            {
                return _Server_Port;
            }

            set
            {
                if(value > 1024)
                {
                    _port = value;
                }
                else
                {
                    MessageBox.Show("Your port must be biger than 1024", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string server_ { get; set; }
    }
}
