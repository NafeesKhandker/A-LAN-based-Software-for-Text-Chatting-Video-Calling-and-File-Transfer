namespace SkypeClintGUI
{
    partial class LogInGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInGUI));
            this.label_appname = new System.Windows.Forms.Label();
            this.label_ConnectFriend = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_userName = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_forgotPassword = new System.Windows.Forms.Label();
            this.checkBox_keepLogIn = new System.Windows.Forms.CheckBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_signUp = new System.Windows.Forms.Label();
            this.pictureBox_userPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_userPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label_appname
            // 
            this.label_appname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_appname.AutoSize = true;
            this.label_appname.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_appname.ForeColor = System.Drawing.Color.Orange;
            this.label_appname.Location = new System.Drawing.Point(93, 25);
            this.label_appname.Name = "label_appname";
            this.label_appname.Size = new System.Drawing.Size(207, 93);
            this.label_appname.TabIndex = 0;
            this.label_appname.Text = "ChAt";
    
            // 
            // label_ConnectFriend
            // 
            this.label_ConnectFriend.AutoSize = true;
            this.label_ConnectFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_ConnectFriend.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConnectFriend.ForeColor = System.Drawing.Color.Silver;
            this.label_ConnectFriend.Location = new System.Drawing.Point(53, 247);
            this.label_ConnectFriend.Name = "label_ConnectFriend";
            this.label_ConnectFriend.Size = new System.Drawing.Size(155, 15);
            this.label_ConnectFriend.TabIndex = 3;
            this.label_ConnectFriend.Text = "Connect with your friends :";

            // 
            // textBox_userName
            // 
            this.textBox_userName.BackColor = System.Drawing.Color.DimGray;
            this.textBox_userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_userName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userName.ForeColor = System.Drawing.Color.White;
            this.textBox_userName.Location = new System.Drawing.Point(56, 305);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(276, 32);
            this.textBox_userName.TabIndex = 5;
            this.textBox_userName.TextChanged += new System.EventHandler(this.textBox_userName_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.DimGray;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.ForeColor = System.Drawing.Color.White;
            this.textBox_password.Location = new System.Drawing.Point(56, 380);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(276, 32);
            this.textBox_password.TabIndex = 6;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_userName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userName.ForeColor = System.Drawing.Color.Silver;
            this.label_userName.Location = new System.Drawing.Point(53, 281);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(74, 15);
            this.label_userName.TabIndex = 7;
            this.label_userName.Text = "User Name :";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_password.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.Silver;
            this.label_password.Location = new System.Drawing.Point(53, 355);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(66, 15);
            this.label_password.TabIndex = 8;
            this.label_password.Text = "Password :";
            // 
            // label_forgotPassword
            // 
            this.label_forgotPassword.AutoSize = true;
            this.label_forgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_forgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forgotPassword.ForeColor = System.Drawing.Color.Silver;
            this.label_forgotPassword.Location = new System.Drawing.Point(53, 430);
            this.label_forgotPassword.Name = "label_forgotPassword";
            this.label_forgotPassword.Size = new System.Drawing.Size(160, 15);
            this.label_forgotPassword.TabIndex = 9;
            this.label_forgotPassword.Text = "Forgot your password or ID?";
            this.label_forgotPassword.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            this.label_forgotPassword.Click += new System.EventHandler(this.label_forgotPassword_Click);
            this.label_forgotPassword.MouseEnter += new System.EventHandler(this.label_forgotPassword_MouseEnter);
            // 
            // checkBox_keepLogIn
            // 
            this.checkBox_keepLogIn.AutoSize = true;
            this.checkBox_keepLogIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_keepLogIn.ForeColor = System.Drawing.Color.Silver;
            this.checkBox_keepLogIn.Location = new System.Drawing.Point(56, 460);
            this.checkBox_keepLogIn.Name = "checkBox_keepLogIn";
            this.checkBox_keepLogIn.Size = new System.Drawing.Size(125, 19);
            this.checkBox_keepLogIn.TabIndex = 10;
            this.checkBox_keepLogIn.Text = "Keep me logged in";
            this.checkBox_keepLogIn.UseVisualStyleBackColor = true;
            this.checkBox_keepLogIn.CheckedChanged += new System.EventHandler(this.checkBox_keepLogIn_CheckedChanged);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Orange;
            this.button_login.Location = new System.Drawing.Point(56, 500);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(276, 37);
            this.button_login.TabIndex = 11;
            this.button_login.Text = "Log In";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_keepLogIn_Click);
            // 
            // label_signUp
            // 
            this.label_signUp.AutoSize = true;
            this.label_signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signUp.ForeColor = System.Drawing.Color.Silver;
            this.label_signUp.Location = new System.Drawing.Point(124, 573);
            this.label_signUp.Name = "label_signUp";
            this.label_signUp.Size = new System.Drawing.Size(121, 16);
            this.label_signUp.TabIndex = 12;
            this.label_signUp.Text = "Sign Up for ChAt";
            this.label_signUp.MouseLeave += new System.EventHandler(this.label_signUp_MouseLeave);
            this.label_signUp.Click += new System.EventHandler(this.label_signUp_Click);
            this.label_signUp.MouseEnter += new System.EventHandler(this.label_signUp_MouseEnter);
            // 
            // pictureBox_userPic
            // 
            this.pictureBox_userPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_userPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_userPic.BackgroundImage")));
            this.pictureBox_userPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_userPic.Location = new System.Drawing.Point(145, 125);
            this.pictureBox_userPic.Name = "pictureBox_userPic";
            this.pictureBox_userPic.Size = new System.Drawing.Size(100, 101);
            this.pictureBox_userPic.TabIndex = 1;
            this.pictureBox_userPic.TabStop = false;
            // 
            // LogInGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(391, 602);
            this.Controls.Add(this.label_signUp);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.checkBox_keepLogIn);
            this.Controls.Add(this.label_forgotPassword);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label_ConnectFriend);
            this.Controls.Add(this.pictureBox_userPic);
            this.Controls.Add(this.label_appname);
            this.Name = "LogInGUI";
            this.Text = "LogInGUI";
            this.Load += new System.EventHandler(this.LogInGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_userPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_appname;
        private System.Windows.Forms.PictureBox pictureBox_userPic;
        private System.Windows.Forms.Label label_ConnectFriend;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_forgotPassword;
        private System.Windows.Forms.CheckBox checkBox_keepLogIn;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_signUp;
    }
}