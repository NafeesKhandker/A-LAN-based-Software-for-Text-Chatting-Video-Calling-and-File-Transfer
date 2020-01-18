namespace SkypeClintGUI
{
    partial class ChatGUI
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
            this.panel_textChat = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_textWrite = new System.Windows.Forms.TextBox();
            this.button_textSend = new System.Windows.Forms.Button();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox_userPic = new System.Windows.Forms.PictureBox();
            this.panel_extra = new System.Windows.Forms.Panel();
            this.panel_name = new System.Windows.Forms.Panel();
            this.label_chatFriend = new System.Windows.Forms.Label();
            this.panel_extra1 = new System.Windows.Forms.Panel();
            this.button_DeleteHistory = new System.Windows.Forms.Button();
            this.listView_showMsg = new System.Windows.Forms.ListView();
            this.panel_textChat.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_userPic)).BeginInit();
            this.panel_name.SuspendLayout();
            this.panel_extra1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_textChat
            // 
            this.panel_textChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_textChat.Controls.Add(this.listView_showMsg);
            this.panel_textChat.Controls.Add(this.panel4);
            this.panel_textChat.Location = new System.Drawing.Point(0, 0);
            this.panel_textChat.Name = "panel_textChat";
            this.panel_textChat.Size = new System.Drawing.Size(346, 430);
            this.panel_textChat.TabIndex = 0;
            this.panel_textChat.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_textChat_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.textBox_textWrite);
            this.panel4.Controls.Add(this.button_textSend);
            this.panel4.Location = new System.Drawing.Point(8, 344);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(329, 78);
            this.panel4.TabIndex = 1;
            // 
            // textBox_textWrite
            // 
            this.textBox_textWrite.BackColor = System.Drawing.Color.Black;
            this.textBox_textWrite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_textWrite.ForeColor = System.Drawing.Color.White;
            this.textBox_textWrite.Location = new System.Drawing.Point(0, 3);
            this.textBox_textWrite.Multiline = true;
            this.textBox_textWrite.Name = "textBox_textWrite";
            this.textBox_textWrite.Size = new System.Drawing.Size(205, 72);
            this.textBox_textWrite.TabIndex = 1;
            this.textBox_textWrite.TextChanged += new System.EventHandler(this.textBox_textWrite_TextChanged);
            this.textBox_textWrite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_textWrite_MouseClick);
            this.textBox_textWrite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_textWrite_KeyPress);
            // 
            // button_textSend
            // 
            this.button_textSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_textSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_textSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_textSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_textSend.ForeColor = System.Drawing.Color.Silver;
            this.button_textSend.Location = new System.Drawing.Point(213, 8);
            this.button_textSend.Name = "button_textSend";
            this.button_textSend.Size = new System.Drawing.Size(109, 62);
            this.button_textSend.TabIndex = 0;
            this.button_textSend.Text = "Send";
            this.button_textSend.UseVisualStyleBackColor = false;
            this.button_textSend.MouseLeave += new System.EventHandler(this.button_textSend_MouseLeave);
            this.button_textSend.Click += new System.EventHandler(this.button_textSend_Click);
            this.button_textSend.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // panel_Control
            // 
            this.panel_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Control.Location = new System.Drawing.Point(0, 435);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(674, 79);
            this.panel_Control.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox_userPic);
            this.panel5.Controls.Add(this.panel_extra);
            this.panel5.Controls.Add(this.panel_name);
            this.panel5.Location = new System.Drawing.Point(351, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(316, 159);
            this.panel5.TabIndex = 2;
            // 
            // pictureBox_userPic
            // 
            this.pictureBox_userPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_userPic.BackgroundImage = global::SkypeClintGUI.Properties.Resources.user_info;
            this.pictureBox_userPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_userPic.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_userPic.Name = "pictureBox_userPic";
            this.pictureBox_userPic.Size = new System.Drawing.Size(103, 106);
            this.pictureBox_userPic.TabIndex = 0;
            this.pictureBox_userPic.TabStop = false;
            // 
            // panel_extra
            // 
            this.panel_extra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_extra.Location = new System.Drawing.Point(0, 107);
            this.panel_extra.Name = "panel_extra";
            this.panel_extra.Size = new System.Drawing.Size(316, 52);
            this.panel_extra.TabIndex = 1;
            // 
            // panel_name
            // 
            this.panel_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_name.Controls.Add(this.label_chatFriend);
            this.panel_name.Location = new System.Drawing.Point(104, 2);
            this.panel_name.Name = "panel_name";
            this.panel_name.Size = new System.Drawing.Size(212, 104);
            this.panel_name.TabIndex = 0;
            this.panel_name.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_name_Paint);
            // 
            // label_chatFriend
            // 
            this.label_chatFriend.AutoSize = true;
            this.label_chatFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chatFriend.ForeColor = System.Drawing.Color.Orange;
            this.label_chatFriend.Location = new System.Drawing.Point(3, 14);
            this.label_chatFriend.Name = "label_chatFriend";
            this.label_chatFriend.Size = new System.Drawing.Size(120, 16);
            this.label_chatFriend.TabIndex = 1;
            this.label_chatFriend.Text = "Md Aminul Islam";
            // 
            // panel_extra1
            // 
            this.panel_extra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_extra1.Controls.Add(this.button_DeleteHistory);
            this.panel_extra1.Location = new System.Drawing.Point(351, 174);
            this.panel_extra1.Name = "panel_extra1";
            this.panel_extra1.Size = new System.Drawing.Size(316, 255);
            this.panel_extra1.TabIndex = 3;
            this.panel_extra1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // button_DeleteHistory
            // 
            this.button_DeleteHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_DeleteHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteHistory.ForeColor = System.Drawing.Color.Silver;
            this.button_DeleteHistory.Location = new System.Drawing.Point(198, 23);
            this.button_DeleteHistory.Name = "button_DeleteHistory";
            this.button_DeleteHistory.Size = new System.Drawing.Size(103, 65);
            this.button_DeleteHistory.TabIndex = 1;
            this.button_DeleteHistory.Text = "Delete History";
            this.button_DeleteHistory.UseVisualStyleBackColor = true;
            this.button_DeleteHistory.MouseLeave += new System.EventHandler(this.button_DeleteHistory_MouseLeave);
            this.button_DeleteHistory.Click += new System.EventHandler(this.button_DeleteHistory_Click);
            this.button_DeleteHistory.MouseEnter += new System.EventHandler(this.button_DeleteHistory_MouseEnter);
            // 
            // listView_showMsg
            // 
            this.listView_showMsg.BackColor = System.Drawing.SystemColors.InfoText;
            this.listView_showMsg.ForeColor = System.Drawing.Color.Black;
            this.listView_showMsg.Location = new System.Drawing.Point(8, 9);
            this.listView_showMsg.Name = "listView_showMsg";
            this.listView_showMsg.Size = new System.Drawing.Size(329, 329);
            this.listView_showMsg.TabIndex = 2;
            this.listView_showMsg.UseCompatibleStateImageBehavior = false;
            this.listView_showMsg.SelectedIndexChanged += new System.EventHandler(this.listView_showMsg_SelectedIndexChanged);
            // 
            // ChatGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(674, 514);
            this.Controls.Add(this.panel_extra1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel_Control);
            this.Controls.Add(this.panel_textChat);
            this.Name = "ChatGUI";
            this.Text = "ChatGUI";
            this.Load += new System.EventHandler(this.ChatGUI_Load);
            this.panel_textChat.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_userPic)).EndInit();
            this.panel_name.ResumeLayout(false);
            this.panel_name.PerformLayout();
            this.panel_extra1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_textChat;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_textSend;
        private System.Windows.Forms.TextBox textBox_textWrite;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel_name;
        private System.Windows.Forms.Panel panel_extra;
        private System.Windows.Forms.Panel panel_extra1;
        private System.Windows.Forms.PictureBox pictureBox_userPic;
        private System.Windows.Forms.Label label_chatFriend;
        private System.Windows.Forms.Button button_DeleteHistory;
        private System.Windows.Forms.ListView listView_showMsg;
    }
}