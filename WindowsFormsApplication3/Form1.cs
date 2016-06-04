using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 10;//残り時間の変数

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();//タイマー１を開始
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x--;
            label1.Text = x.ToString();//xをラベルに表示
            if (x % 3== 0)//xが0ならば...
            {
                label1.Text = "あほ";//ラベルに表示
            }
        }
    }
}