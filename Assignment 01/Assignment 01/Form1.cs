using System;
using System.Windows.Forms;

namespace Assignment_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chào");
        }

        private void btnGoodbye_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Tạm biệt");
        }
    }
}
