using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkypeClintGUI
{
    public partial class LogInGUI : Form
    {
        public LogInGUI()
        {
            InitializeComponent();
        }
  
        private void LogInGUI_Load(object sender, EventArgs e)
        {

        }
        
        private void button_keepLogIn_Click(object sender, EventArgs e)
        {
            SkypeGUI myGui = new SkypeGUI();
            myGui.Show();
            this.Hide();
        }

        private void label_forgotPassword_Click(object sender, EventArgs e)
        {
            label_forgotPassword.Text = "Please wait man!!!!!!!!!!!!!!";
        }

        private void label_signUp_Click(object sender, EventArgs e)
        {

            SignUpGUI signup = new SignUpGUI();
            signup.Show();

        }

        private void label_signUp_MouseEnter(object sender, EventArgs e)
        {
            label_signUp.ForeColor = System.Drawing.Color.Orange;
        
        }

        private void label_signUp_MouseLeave(object sender, EventArgs e)
        {
            label_signUp.ForeColor = System.Drawing.Color.Silver;
        }

        private void label_forgotPassword_MouseEnter(object sender, EventArgs e)
        {
            label_forgotPassword.ForeColor = System.Drawing.Color.Orange;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label_forgotPassword.ForeColor = System.Drawing.Color.Silver;
        }

        private void textBox_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_keepLogIn_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
