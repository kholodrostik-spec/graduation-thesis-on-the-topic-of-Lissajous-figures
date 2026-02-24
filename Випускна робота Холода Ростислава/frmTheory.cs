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
    public partial class frmTheory : Form
    {
        public frmTheory()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = Application.StartupPath;
            string st = treeView1.SelectedNode.Text;
            int n = treeView1.SelectedNode.Index;
            if (st == "Вступ")
                webBrowser1.Navigate(path + "\\Text\\Вступ.htm");
            if (st == "1.Розділ 1. Теоретична частина.")
                webBrowser1.Navigate(path + "\\Text\\1.1 Гармонічні механічні коливання та їх характеристики.htm");
            if (st == "1.1 Гармонічні механічні коливання та їх характеристики.")
                webBrowser1.Navigate(path + "\\Text\\1.1 Гармонічні механічні коливання та їх характеристики.htm");
            if(st == "1.2 Додавання гармонічних коливань ")
                webBrowser1.Navigate(path + "\\Text\\1.2 Додавання гармонічних коливань.htm");
            if (st == "1.2.1 Додавання коливань одного напрямку")
                webBrowser1.Navigate(path + "\\Text\\1.2.1 Додавання коливань одного напрямку.htm");
            if (st == "1.2.2 Додавання взаємно перпендикулярних коливань")
                webBrowser1.Navigate(path + "\\Text\\1.2.2 Додавання взаємно перпендикулярних коливань.htm");
            if (st == "1.2.3 Фігури Ліссажу")
                webBrowser1.Navigate(path + "\\Text\\1.2.3 Фігури Ліссажу.htm");
            if (st == "1.3 Маятники")
                webBrowser1.Navigate(path + "\\Text\\1.3 Маятники.htm");
            if (st == "1.4 Графіки гармонічних коливань(ξ=x)")
                webBrowser1.Navigate(path + "\\Text\\1.4 Графіки гармонічних коливань(ξ=x).htm");
            if (st == "1.5 Енергія гармонічних коливань")
                webBrowser1.Navigate(path + "\\Text\\1.5 Енергія гармонічних коливань.htm");
            if (st == "1.6 Маятник Ейрі")
                webBrowser1.Navigate(path + "\\Text\\1.6 Маятник Ейрі.htm");
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
