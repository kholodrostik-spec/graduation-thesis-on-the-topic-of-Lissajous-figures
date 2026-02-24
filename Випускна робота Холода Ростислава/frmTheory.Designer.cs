
namespace Випускна_робота_Холода_Ростислава
{
    partial class frmTheory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Вступ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("1.1 Гармонічні механічні коливання та їх характеристики.");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("1.2.1 Додавання коливань одного напрямку");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("1.2.2 Додавання взаємно перпендикулярних коливань");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("1.2.3 Фігури Ліссажу");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("1.2 Додавання гармонічних коливань ", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("1.3 Маятники");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("1.4 Графіки гармонічних коливань(ξ=x)");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("1.5 Енергія гармонічних коливань");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("1.6 Маятник Ейрі");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("1.Розділ 1. Теоретична частина.", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Вступ";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "1.1 Гармонічні механічні коливання та їх характеристики.";
            treeNode3.Name = "Узел4";
            treeNode3.Text = "1.2.1 Додавання коливань одного напрямку";
            treeNode4.Name = "Узел5";
            treeNode4.Text = "1.2.2 Додавання взаємно перпендикулярних коливань";
            treeNode5.Name = "Узел6";
            treeNode5.Text = "1.2.3 Фігури Ліссажу";
            treeNode6.Name = "Узел3";
            treeNode6.Text = "1.2 Додавання гармонічних коливань ";
            treeNode7.Name = "Узел7";
            treeNode7.Text = "1.3 Маятники";
            treeNode8.Name = "Узел8";
            treeNode8.Text = "1.4 Графіки гармонічних коливань(ξ=x)";
            treeNode9.Name = "Узел9";
            treeNode9.Text = "1.5 Енергія гармонічних коливань";
            treeNode10.Name = "Узел10";
            treeNode10.Text = "1.6 Маятник Ейрі";
            treeNode11.Name = "Узел1";
            treeNode11.Text = "1.Розділ 1. Теоретична частина.";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(1459, 100);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 119);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1459, 647);
            this.webBrowser1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1368, 763);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 39);
            this.button4.TabIndex = 14;
            this.button4.Text = "Закрити";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1260, 763);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTheory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTheory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTheory";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}