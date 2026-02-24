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
    public partial class frmMain : Form
    {
        public frmTheory theory = new frmTheory();
        public frmPractice practice = new frmPractice();
        public frmModeling modeling = new frmModeling();
        public frmUsing us = new frmUsing();
        public frmMain()
        {
            InitializeComponent();
            AddOwnedForm(theory);
            AddOwnedForm(practice);
            AddOwnedForm(modeling);
            AddOwnedForm(us);
        }

        string path = Application.StartupPath + "\\Picture\\";

        private void button1_Click(object sender, EventArgs e)
        {
            theory.StartPosition = FormStartPosition.CenterScreen;
            theory.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            practice.StartPosition = FormStartPosition.CenterScreen;
            practice.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modeling.StartPosition = FormStartPosition.CenterScreen;
            modeling.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            us.StartPosition = FormStartPosition.CenterScreen;
            us.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pictureBox1.Load(path + "Осцилограф.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
