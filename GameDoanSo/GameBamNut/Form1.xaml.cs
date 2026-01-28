using System;
using System.Windows.Forms;

namespace GameBamNut
{
    // Phải có chữ "partial class" và ": Form"
    public partial class Form1 : Form
    {
        int diemSo = 0;

        public Form1()
        {
            InitializeComponent(); // Dòng này nếu bị đỏ là do bạn đang ở sai file
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Code xử lý nút bấm ở đây
            diemSo++;
            label1.Text = "Điểm: " + diemSo; // label1 phải tồn tại bên giao diện trước
        }
    }
}