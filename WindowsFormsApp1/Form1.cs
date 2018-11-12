using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.DialogResult = DialogResult.OK;
            btn.Text = "확인";
            btn.Size = new Size(100, 50);
            btn.Location = new Point(30, 30);
            Controls.Add(btn);
            btn.Click += btn_click;
        }

        private void btn_click(object o, EventArgs a)
        {
            MessageBox.Show("확인","확인창");
        }
    }
}
