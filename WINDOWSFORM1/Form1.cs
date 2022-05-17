using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINDOWSFORM1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Visible = false;
            Text = DateTime.Now.ToLongTimeString();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);

            Thread.Sleep(400);
            if (pictureBox2.Visible == false)
            {
                pictureBox2.Visible = true;
                var timeUtc = DateTime.UtcNow;
                var easternZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
                var today = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, easternZone);

                label1.Text = today.ToLongTimeString();
                Text = today.ToLongTimeString();
            }
            else
            {
                pictureBox2.Visible = false;
                Text = DateTime.Now.ToLongTimeString();
                label1.Text = DateTime.Now.ToLongTimeString();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
