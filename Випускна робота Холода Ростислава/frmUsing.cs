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
    public partial class frmUsing : Form
    {
        public frmUsing()
        {
            InitializeComponent();
        }

        private void frmUsing_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            webBrowser1.Navigate(path + "\\Text\\Застосування в техніці.htm");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
