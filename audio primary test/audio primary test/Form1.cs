using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.Sockets;

using LumiSoft.Net.UDP;
using LumiSoft.Net.Codec;
//using LumiSoft.Media.Wave;


namespace audio_primary_test
{
    public partial class Form1 : Form
    {
        UdpServer udpServer = new UdpServer();
        IPEndPoint localEndpoint = null;
        IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 13000);

        //WaveIn waveIn = new WaveIn(WaveIn.Devices[0], 8000, 16, 1, 400);
        //WaveOut waveOut = new WaveOut(WaveOut.Devices[0], 8000, 16, 1);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            udpServer.Bindings = new IPEndPoint[] { new IPEndPoint(IPAddress.Parse("127.0.0.1"), 13000) };
            udpServer.PacketReceived += new PacketReceivedHandler(udpServer_packet_received_method);
            udpServer.Start();

            //waveIn.BufferFull += new BufferFullHandler(waveIn_Buffer_Full);
            //waveIn.Start();  
        }

        public void udpServer_packet_received_method(UdpPacket_eArgs e)
        {
           // byte[] decodedData = null;
            byte[] receiveData = null;
            //decodedData = G711.Decode_aLaw(e.Data, 0, e.Data.Length);
            receiveData = G711.Decode_aLaw(e.Data, 0, e.Data.Length);


            ASCIIEncoding aEncoding = new ASCIIEncoding();

            string receivedMessage = aEncoding.GetString(receiveData);

            listMessage.Items.Add("Friend: " + receivedMessage);
            //waveOut.Play(decodedData, 0, decodedData.Length);
        }

        public void waveIn_Buffer_Full(byte[] buffer)
        {
            byte[] encodedData = null;
            encodedData = G711.Encode_aLaw(buffer, 0, buffer.Length);

            udpServer.SendPacket(encodedData, 0, encodedData.Length, remoteEndPoint);
        }

        private void stop(object sender, EventArgs e)
        {
            udpServer.Stop();
            udpServer.Dispose();

            //waveIn.Stop();
            //waveIn.Dispose();

            //waveOut.Dispose();
        }

        private void richTextBox_ShowMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = null;
            sendingMessage = aEncoding.GetBytes(textBox_WriteMessage.Text);
            udpServer.SendPacket(sendingMessage, 0, sendingMessage.Length, remoteEndPoint);
            listMessage.Items.Add("Me: " + textBox_WriteMessage.Text);
            textBox_WriteMessage.Text = "";
        

        }

        private void textBox_WriteMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
