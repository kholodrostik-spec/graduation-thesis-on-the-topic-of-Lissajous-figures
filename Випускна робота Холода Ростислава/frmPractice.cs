using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Випускна_робота_Холода_Ростислава
{
    public partial class frmPractice : Form
    {
        public frmPractice()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath + "\\Picture\\";
        string path1 = Application.StartupPath + "\\Video\\";
        int n = 0;
        void LoadPict()
        {
            path = Application.StartupPath + "\\Picture\\";
            pictureBox1.Load(path + "1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(n < 3)
            {
                n++;
                pictureBox1.Load(path + n.ToString() + ".jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                axWindowsMediaPlayer1.URL = path1 + n.ToString() + ".mp4";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (n > 1)
            {
                n--;
                pictureBox1.Load(path + n.ToString() + ".jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                axWindowsMediaPlayer1.URL = path1 + n.ToString() + ".mp4";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
