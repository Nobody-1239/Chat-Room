namespace chatroom.Forms
{
    partial class F_ChatRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ChatRoom));
            L_Chat = new ListView();
            T_Message = new TextBox();
            B_Send_Message = new Button();
            SuspendLayout();
            // 
            // L_Chat
            // 
            L_Chat.BackgroundImage = (Image)resources.GetObject("L_Chat.BackgroundImage");
            L_Chat.BackgroundImageTiled = true;
            L_Chat.Font = new Font("2  Davat", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 178);
            L_Chat.ForeColor = Color.Black;
            L_Chat.HoverSelection = true;
            L_Chat.ImeMode = ImeMode.On;
            L_Chat.Location = new Point(65, 33);
            L_Chat.Name = "L_Chat";
            L_Chat.Size = new Size(844, 560);
            L_Chat.TabIndex = 1;
            L_Chat.UseCompatibleStateImageBehavior = false;
            L_Chat.View = View.Tile;
            // 
            // T_Message
            // 
            T_Message.BackColor = SystemColors.Window;
            T_Message.ImeMode = ImeMode.Off;
            T_Message.Location = new Point(65, 599);
            T_Message.Name = "T_Message";
            T_Message.Size = new Size(734, 27);
            T_Message.TabIndex = 2;
            T_Message.Text = "Message";
            T_Message.Click += T_Message_Click;
            // 
            // B_Send_Message
            // 
            B_Send_Message.Cursor = Cursors.Hand;
            B_Send_Message.FlatStyle = FlatStyle.Flat;
            B_Send_Message.Image = Properties.Resources._10050280161607043060_20;
            B_Send_Message.Location = new Point(805, 599);
            B_Send_Message.Name = "B_Send_Message";
            B_Send_Message.Size = new Size(104, 27);
            B_Send_Message.TabIndex = 3;
            B_Send_Message.Text = "Send";
            B_Send_Message.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Send_Message.UseVisualStyleBackColor = true;
            B_Send_Message.Click += B_Send_Message_Click;
            // 
            // F_ChatRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(246, 244, 235);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1010, 704);
            Controls.Add(B_Send_Message);
            Controls.Add(T_Message);
            Controls.Add(L_Chat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_ChatRoom";
            StartPosition = FormStartPosition.Manual;
            Text = "Chatroom";
            Load += F_ChatRoom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView L_Chat;
        private TextBox T_Message;
        private Button B_Send_Message;
    }
}