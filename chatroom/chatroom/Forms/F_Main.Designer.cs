namespace chatroom.Forms
{
    partial class F_Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            panel1 = new Panel();
            Menu = new Button();
            B_Exit = new Button();
            B_JoinRoom = new Button();
            B_AddRoom = new Button();
            sidebar_timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(114, 6, 50);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(Menu);
            panel1.Controls.Add(B_Exit);
            panel1.Controls.Add(B_JoinRoom);
            panel1.Controls.Add(B_AddRoom);
            panel1.Location = new Point(-1, -3);
            panel1.MaximumSize = new Size(231, 708);
            panel1.MinimumSize = new Size(41, 708);
            panel1.Name = "panel1";
            panel1.Size = new Size(41, 708);
            panel1.TabIndex = 0;
            // 
            // Menu
            // 
            Menu.BackgroundImageLayout = ImageLayout.Center;
            Menu.FlatStyle = FlatStyle.Flat;
            Menu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Menu.ForeColor = Color.White;
            Menu.Image = Properties.Resources._11391845771556280999_32;
            Menu.ImageAlign = ContentAlignment.MiddleLeft;
            Menu.Location = new Point(0, 3);
            Menu.Name = "Menu";
            Menu.Size = new Size(236, 65);
            Menu.TabIndex = 8;
            Menu.Text = "Menu";
            Menu.UseVisualStyleBackColor = true;
            Menu.Click += Menu_Click;
            // 
            // B_Exit
            // 
            B_Exit.BackgroundImageLayout = ImageLayout.Center;
            B_Exit.FlatStyle = FlatStyle.Flat;
            B_Exit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Exit.ForeColor = Color.White;
            B_Exit.Image = Properties.Resources.rsz_18610531421560147113_64;
            B_Exit.ImageAlign = ContentAlignment.MiddleLeft;
            B_Exit.Location = new Point(2, 216);
            B_Exit.Name = "B_Exit";
            B_Exit.Size = new Size(236, 65);
            B_Exit.TabIndex = 7;
            B_Exit.Text = "EXIT";
            B_Exit.UseVisualStyleBackColor = true;
            B_Exit.Click += B_Exit_Click;
            // 
            // B_JoinRoom
            // 
            B_JoinRoom.BackgroundImageLayout = ImageLayout.Center;
            B_JoinRoom.FlatStyle = FlatStyle.Flat;
            B_JoinRoom.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_JoinRoom.ForeColor = Color.White;
            B_JoinRoom.Image = Properties.Resources._7517735301554892216_32;
            B_JoinRoom.ImageAlign = ContentAlignment.MiddleLeft;
            B_JoinRoom.Location = new Point(0, 145);
            B_JoinRoom.Name = "B_JoinRoom";
            B_JoinRoom.Size = new Size(236, 65);
            B_JoinRoom.TabIndex = 5;
            B_JoinRoom.Text = "JoinRoom";
            B_JoinRoom.UseVisualStyleBackColor = true;
            B_JoinRoom.Click += B_JoinRoom_Click;
            // 
            // B_AddRoom
            // 
            B_AddRoom.BackgroundImageLayout = ImageLayout.Center;
            B_AddRoom.FlatStyle = FlatStyle.Flat;
            B_AddRoom.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_AddRoom.ForeColor = Color.White;
            B_AddRoom.Image = (Image)resources.GetObject("B_AddRoom.Image");
            B_AddRoom.ImageAlign = ContentAlignment.MiddleLeft;
            B_AddRoom.Location = new Point(0, 74);
            B_AddRoom.Name = "B_AddRoom";
            B_AddRoom.Size = new Size(236, 65);
            B_AddRoom.TabIndex = 2;
            B_AddRoom.Text = "Add Room";
            B_AddRoom.UseVisualStyleBackColor = true;
            B_AddRoom.Click += B_AddRoom_Click;
            // 
            // sidebar_timer
            // 
            sidebar_timer.Interval = 10;
            sidebar_timer.Tick += sidebar_timer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(411, 205);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // F_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(246, 244, 235);
            ClientSize = new Size(1240, 703);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button B_AddRoom;
        private Button B_JoinRoom;
        private Button B_Exit;
        private System.Windows.Forms.Timer sidebar_timer;
        private Button Menu;
        private Label label1;
    }
}