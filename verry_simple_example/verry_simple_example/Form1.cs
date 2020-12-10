using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verry_simple_example
{
    public partial class Form1 : Form
    {
        int countTime = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aalo");
        }

        private void textBox2_message_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = textBox2_message.Text;
            MessageBox.Show($"와타시가 {message} 다.");
        }

        private void lavel_nowTime_Click(object sender, EventArgs e)
        {

        }

        private void 현재시간_Click(object sender, EventArgs e)
        {
            label_nowTime.Text = $"{DateTime.Now.Year}년" +
                $"{DateTime.Now.Month}월"+
                $"{DateTime.Now.Day}일"+
                $"{DateTime.Now.Hour}시"+
                $"{DateTime.Now.Minute}분"+
                $"{DateTime.Now.Second}초";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //내가 지정한 인터벌(interval)에 한번씩 동작
            //여기에선 1000ms에 한 번 동작
            label_second.Text = countTime.ToString();
            countTime++;

        }

        private void label_second_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com");

        }
        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com");
        }
    }
}
