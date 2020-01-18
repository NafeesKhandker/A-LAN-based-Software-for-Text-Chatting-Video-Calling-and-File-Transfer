namespace audio_primary_test
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_WriteMessage = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.stop);
            // 
            // textBox_WriteMessage
            // 
            this.textBox_WriteMessage.Location = new System.Drawing.Point(12, 299);
            this.textBox_WriteMessage.Multiline = true;
            this.textBox_WriteMessage.Name = "textBox_WriteMessage";
            this.textBox_WriteMessage.Size = new System.Drawing.Size(297, 59);
            this.textBox_WriteMessage.TabIndex = 3;
            this.textBox_WriteMessage.TextChanged += new System.EventHandler(this.textBox_WriteMessage_TextChanged);
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(335, 314);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(96, 23);
            this.button_Send.TabIndex = 4;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(12, 75);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(442, 199);
            this.listMessage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 385);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_WriteMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_WriteMessage;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.ListBox listMessage;
    }
}

