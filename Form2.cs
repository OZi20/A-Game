using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 炫舞游戏
{
    public partial class Form2 : Form
    {
        public Form2()
        { 
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
        }

        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pB2.Image = imageList1.Images[a++];
            if (a == 10)
            {
                a = 0;
                pB2.Hide();
            }
        }
       
        int b = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            pB3.Image = imageList2.Images[b++];
            if (b == 11)
            {
                b = 0;
                pB3.Hide();
            }
        }

        int c = 0;

        private void timer3_Tick(object sender, EventArgs e)
        {
            pB4.Image = imageList3.Images[c++];
            if (c == 12)
            {
                c = 0;
                pB4.Hide();
            }
        }

        int d = 0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            pB5.Image = imageList4.Images[d++];
            if (d == 13)
            {
                d = 0;
                pB5.Hide();
            }
        }

        int f = 0;
        private void timer5_Tick(object sender, EventArgs e)
        {
            pB6.Image = imageList5.Images[f++];
            if (f == 14)
            {
                f = 0;
                pB6.Hide();
            }
        }

        int g = 0;
        private void timer6_Tick(object sender, EventArgs e)
        {
            pB7.Image = imageList6.Images[g++];
            if (g == 15)
            {
                g = 0;
                pB7.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            this.Close();
        }

        
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && (g == 5 || g == 6 || g == 9 || g == 15))
            {                
                    pB8.Image = imageList7.Images[0];
                    pB8.Refresh();                                              
            }
            else
            {
                pB8.Image = imageList7.Images[1];
                pB8.Refresh();
            }
            return;
            if (e.KeyCode == Keys.S && (g == 7 || g == 13 || g == 14))
            {               
                    pB8.Image = imageList7.Images[0];
                    pB8.Refresh();                              
            }
            else
            {
                pB8.Image = imageList7.Images[1];
                pB8.Refresh();
            }
            return;
            if (e.KeyCode == Keys.A && (g == 11 || g == 12))
            {                
                    pB8.Image = imageList7.Images[0];
                    pB8.Refresh();                               
            }
            else
            {
                pB8.Image = imageList7.Images[1];
                pB8.Refresh();
            }
            return;
            if (e.KeyCode == Keys.D && (g == 8 || g == 10))
            {                
                    pB8.Image = imageList7.Images[0];
                    pB8.Refresh();                               
            }
            else
            {
                pB8.Image = imageList7.Images[1];

            }
            return;
        }
    }
    
}
