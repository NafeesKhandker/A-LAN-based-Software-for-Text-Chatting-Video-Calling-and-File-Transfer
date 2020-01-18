using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BOLayer;
using System.Net;
using System.Net.Sockets;


namespace SkypeClintGUI
{

    public partial class ChatGUI : Form
    {

        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        BOClass bo = new BOClass();

        public ChatGUI()
        {




            InitializeComponent();


            //richTextBox_textField.ReadOnly = true;
            textBox_textWrite.Select();
            textBox_textWrite.Text = "Send a message";

            SqlDataReader DR1 = bo.chatHistoryDisplay();

            while (DR1.Read())
            {
                richTextBox_textField.AppendText(DR1["chat"].ToString());
                richTextBox_textField.AppendText("\n");

            }

            DR1.Close();
            bo.closeConnection();

            richTextBox_textField.SelectionStart = richTextBox_textField.Text.Length;
            richTextBox_textField.ScrollToCaret();

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button_textSend.ForeColor = System.Drawing.Color.Orange;
        }

        private void button_textSend_Click(object sender, EventArgs e)
        {

            ASCIIEncoding aEncoding = new ASCIIEncoding();

            byte[] sendingMessage = new byte[1500];

            sendingMessage = aEncoding.GetBytes(textBox_textWrite.Text);

            sck.Send(sendingMessage);

            listView_showMsg.Items.Add("Me: " + textBox_textWrite.Text);
            listView_showMsg.Text = "";



            richTextBox_textField.AppendText(textBox_textWrite.Text);

            richTextBox_textField.AppendText("\n");

            bo.chatHistorySave(textBox_textWrite.Text);

            textBox_textWrite.Clear();
            textBox_textWrite.Select();
            richTextBox_textField.SelectionStart = richTextBox_textField.Text.Length;
            richTextBox_textField.ScrollToCaret();
           
        }

        private string GetLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }

            }
            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receiveData = new byte[1500];

                receiveData = (byte[])aResult.AsyncState;

                ASCIIEncoding aEncoding = new ASCIIEncoding();

                string receivedMessage = aEncoding.GetString(receiveData);

                listMessage.Items.Add("Friend: " + receivedMessage);

                buffer = new byte[1500];

                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void button_textSend_MouseLeave(object sender, EventArgs e)
        {
            button_textSend.ForeColor = System.Drawing.Color.Silver;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox_textField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ChatGUI_Load(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));

            sck.Bind(epLocal);

            epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIp.Text), Convert.ToInt32(textRemotePort.Text));

            sck.Connect(epRemote);

            buffer = new byte[1500];

            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);



        }

        private void textBox_textWrite_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {

                richTextBox_textField.AppendText(textBox_textWrite.Text);


                richTextBox_textField.AppendText("\n");

                bo.chatHistorySave(textBox_textWrite.Text);

                textBox_textWrite.Clear();
                textBox_textWrite.Select();
                richTextBox_textField.SelectionStart = richTextBox_textField.Text.Length;
                richTextBox_textField.ScrollToCaret();
                
                e.Handled = true;
                
                
            }
        }

        private void textBox_textWrite_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_textWrite_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_textWrite.Clear();
            textBox_textWrite.Select();
        }

        private void panel_textChat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_DeleteHistory_Click(object sender, EventArgs e)
        {

             DialogResult dr = MessageBox.Show("Do you want to delete all history?", "Delete History", MessageBoxButtons.YesNoCancel);
            
            if (dr == DialogResult.Yes)
            {
                bo.deleteChatHistory();
                richTextBox_textField.Clear();
            }

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button_DeleteHistory_MouseEnter(object sender, EventArgs e)
        {
            button_DeleteHistory.ForeColor = System.Drawing.Color.Orange;
        }

        private void button_DeleteHistory_MouseLeave(object sender, EventArgs e)
        {
            button_DeleteHistory.ForeColor = System.Drawing.Color.Silver;
        }

        private void panel_name_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView_showMsg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
