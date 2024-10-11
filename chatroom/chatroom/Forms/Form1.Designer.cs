namespace chatroom
{
    partial class F_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            B_Sign_Up = new Button();
            B_Login = new Button();
            T_Password = new TextBox();
            label4 = new Label();
            T_UserName = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 631);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(466, 92);
            label1.Name = "label1";
            label1.Size = new Size(103, 41);
            label1.TabIndex = 1;
            label1.Text = "Hello,";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(466, 133);
            label2.Name = "label2";
            label2.Size = new Size(185, 46);
            label2.TabIndex = 2;
            label2.Text = "Welcome!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(B_Sign_Up);
            groupBox1.Controls.Add(B_Login);
            groupBox1.Controls.Add(T_Password);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(T_UserName);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(466, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 310);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "UserLogin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 372);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 6;
            // 
            // B_Sign_Up
            // 
            B_Sign_Up.BackColor = Color.Gray;
            B_Sign_Up.Cursor = Cursors.Hand;
            B_Sign_Up.Location = new Point(339, 244);
            B_Sign_Up.Name = "B_Sign_Up";
            B_Sign_Up.Size = new Size(175, 39);
            B_Sign_Up.TabIndex = 5;
            B_Sign_Up.Text = "Sign Up ";
            B_Sign_Up.UseVisualStyleBackColor = false;
            B_Sign_Up.Click += B_Sign_Up_Click;
            // 
            // B_Login
            // 
            B_Login.BackColor = Color.Gray;
            B_Login.Cursor = Cursors.Hand;
            B_Login.ForeColor = SystemColors.ControlText;
            B_Login.Location = new Point(142, 244);
            B_Login.Name = "B_Login";
            B_Login.Size = new Size(175, 39);
            B_Login.TabIndex = 4;
            B_Login.Text = "Login";
            B_Login.UseVisualStyleBackColor = false;
            B_Login.Click += B_Login_Click;
            // 
            // T_Password
            // 
            T_Password.Location = new Point(142, 129);
            T_Password.Name = "T_Password";
            T_Password.Size = new Size(372, 27);
            T_Password.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Peru;
            label4.Location = new Point(15, 129);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 2;
            label4.Text = "Password : ";
            // 
            // T_UserName
            // 
            T_UserName.Location = new Point(142, 67);
            T_UserName.Name = "T_UserName";
            T_UserName.Size = new Size(372, 27);
            T_UserName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Peru;
            label3.Location = new Point(15, 67);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 0;
            label3.Text = "Username : ";
            // 
            // F_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_Login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Button B_Sign_Up;
        private Button B_Login;
        private TextBox T_Password;
        private Label label4;
        private TextBox T_UserName;
        private Label label5;
    }
}
