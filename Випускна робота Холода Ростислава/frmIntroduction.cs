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
    public partial class frmIntroduction : Form
    {
        public frmMain Next_form = new frmMain();
        public frmIntroduction()
        {
            InitializeComponent();
            AddOwnedForm(Next_form);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
