namespace chatroom.Forms
{
    partial class F_Add_Room
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
            groupBox1 = new GroupBox();
            B_Creat_Server = new Button();
            T_Port = new TextBox();
            label2 = new Label();
            T_Ip = new TextBox();
            label1 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(B_Creat_Server);
            groupBox1.Controls.Add(T_Port);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(T_Ip);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(114, 6, 50);
            groupBox1.Location = new Point(140, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(731, 401);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADD Server";
            // 
            // B_Creat_Server
            // 
            B_Creat_Server.BackColor = Color.FromArgb(114, 6, 50);
            B_Creat_Server.ForeColor = Color.FromArgb(246, 244, 235);
            B_Creat_Server.Location = new Point(293, 290);
            B_Creat_Server.Name = "B_Creat_Server";
            B_Creat_Server.Size = new Size(183, 29);
            B_Creat_Server.TabIndex = 6;
            B_Creat_Server.Text = "Creat Server";
            B_Creat_Server.UseVisualStyleBackColor = false;
            B_Creat_Server.Click += B_Creat_Server_Click;
            // 
            // T_Port
            // 
            T_Port.Font = new Font("Times New Roman", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            T_Port.ForeColor = Color.Black;
            T_Port.Location = new Point(213, 166);
            T_Port.Name = "T_Port";
            T_Port.Size = new Size(348, 23);
            T_Port.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(114, 6, 50);
            label2.Location = new Point(104, 167);
            label2.Name = "label2";
            label2.Size = new Size(103, 22);
            label2.TabIndex = 2;
            label2.Text = "your port : ";
            // 
            // T_Ip
            // 
            T_Ip.Font = new Font("Times New Roman", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            T_Ip.ForeColor = Color.Black;
            T_Ip.Location = new Point(195, 83);
            T_Ip.Name = "T_Ip";
            T_Ip.Size = new Size(366, 23);
            T_Ip.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 81);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 0;
            label1.Text = "your ip : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(28, 70, 107);
            label3.Location = new Point(420, 544);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 4;
            // 
            // F_Add_Room
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 235);
            ClientSize = new Size(1010, 704);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_Add_Room";
            Text = "F_Add_Room";
            Load += F_Add_Room_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private TextBox T_Port;
        private Label label2;
        private TextBox T_Ip;
        private Button B_Creat_Server;
        private Label label3;
    }
}