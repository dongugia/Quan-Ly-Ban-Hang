using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Ban_Hang
{
    
    public partial class FmLogin : Form
    {
        public string UserName = "dodeptrai";
        public string passWord = "12345678";
        public FmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (this.TbxLogin.Text == "d" && this.TbxPassWord.Text == "1")
            {
                MessageBox.Show("Bạn đã đăng nhập thành công!", "Thông báo");
                this.Close();                
            }
            else
            {
                MessageBox.Show("Không đúng tên đăng nhập hoặc/mật khẩu!!!", "Thông báo");
                this.TbxLogin.Focus();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) {
                Application.Exit();
            }
        }

        private void BtnTaoTK_Click(object sender, EventArgs e)
        {
            Form frm = new Tao_Tai_Khoan();
            frm.Name = "Tạo Tài Khoản";
            frm.ShowDialog();
        }

        private void FmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
