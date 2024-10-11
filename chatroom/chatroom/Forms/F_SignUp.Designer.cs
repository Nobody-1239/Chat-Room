namespace chatroom.Forms
{
    partial class F_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_SignUp));
            label1 = new Label();
            T_User_Name = new TextBox();
            T_Password = new TextBox();
            T_Email = new TextBox();
            B_SignUp = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(212, 42);
            label1.Name = "label1";
            label1.Size = new Size(119, 36);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // T_User_Name
            // 
            T_User_Name.Location = new Point(60, 171);
            T_User_Name.Name = "T_User_Name";
            T_User_Name.Size = new Size(412, 27);
            T_User_Name.TabIndex = 2;
            T_User_Name.Text = "Username";
            // 
            // T_Password
            // 
            T_Password.Location = new Point(60, 251);
            T_Password.Name = "T_Password";
            T_Password.Size = new Size(412, 27);
            T_Password.TabIndex = 4;
            T_Password.Text = "Password";
            // 
            // T_Email
            // 
            T_Email.Location = new Point(60, 337);
            T_Email.Name = "T_Email";
            T_Email.Size = new Size(412, 27);
            T_Email.TabIndex = 6;
            T_Email.Text = "Email";
            // 
            // B_SignUp
            // 
            B_SignUp.BackColor = Color.DarkSlateGray;
            B_SignUp.Cursor = Cursors.Hand;
            B_SignUp.ForeColor = Color.White;
            B_SignUp.Location = new Point(185, 408);
            B_SignUp.Name = "B_SignUp";
            B_SignUp.Size = new Size(167, 29);
            B_SignUp.TabIndex = 7;
            B_SignUp.Text = "submite";
            B_SignUp.UseVisualStyleBackColor = false;
            B_SignUp.Click += B_SignUp_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(519, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 500);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // F_SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 492);
            Controls.Add(panel1);
            Controls.Add(B_SignUp);
            Controls.Add(T_Email);
            Controls.Add(T_Password);
            Controls.Add(T_User_Name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "F_SignUp";
            Load += F_SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox T_User_Name;
        private TextBox T_Password;
        private TextBox T_Email;
        private Button B_SignUp;
        private Panel panel1;
    }
}