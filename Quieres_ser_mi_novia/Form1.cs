using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quieres_ser_mi_novia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox2;
            label3.Parent = pictureBox2;
            panel2.Hide();
            btnsi.TabStop = false;
            btnno.TabStop = false;
        }

        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - btnno.Width);
            int y = r.Next(0, this.Height - btnno.Height);
            btnno.Location = new Point(x, y);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=mCdA4bJAGGk";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void btnno_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (btnno.Location == btnsi.Location || btnno.Location == label1.Location || btnno.Location == button1.Location)
            {
                MoverBoton();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void btnsi_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

     

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
