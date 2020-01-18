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
    public partial class SkypeGUI : Form
    {
        //Button btest = new Button();
        public SkypeGUI()
        {
            InitializeComponent();

            
           
        }

        private void SkypeGUI_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button_test_Click(object sender, EventArgs e)
        {
            ChatGUI cg = new ChatGUI();
            cg.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.EnsureVisible(listView1.Items.Count - 1);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button[] btn = new Button[100];
             
            

            int n = 20;
            for (int i = 1; i < 20; i++)
            {
                btn[i] = new Button();
                btn[i].Text = "Button" + i;
                btn[i].FlatStyle = FlatStyle.Popup;
                btn[i].Location = new Point(300, n);
                btn[i].BackColor = System.Drawing.Color.Gray;
                n = n + 20;
                listView1.Controls.Add(btn[i]);
            }
            
            listView1.Refresh();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
         
        }

    }
}
