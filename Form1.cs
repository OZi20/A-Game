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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btneasy_Click(object sender, EventArgs e)
        {
            var frm2 = new Form2();
            frm2.Show();
            
        }

        private void btndifficult_Click(object sender, EventArgs e)
        {
            var frm = new Form3();
            frm.Show();
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
