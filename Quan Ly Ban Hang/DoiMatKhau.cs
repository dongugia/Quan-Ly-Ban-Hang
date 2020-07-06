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

    public partial class FrmDoiMatKhau : Form
    {
        private FmLogin FrmLogin;
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
        private void ChangePassWord() {
            if (TbxLoginName.Text == FrmLogin.UserName) {
                if (TbxPassOld.Text == FrmLogin.passWord) {
                    if (TbxNewPass1.Text == TbxNewpass.Text) {
                        MessageBox.Show("PassWord đã được thay đổi");
                        FrmLogin.passWord = TbxNewpass.Text;
                    }
                    else {
                        TbxNewpass.Focus();
                        MessageBox.Show("PassWord không giống nhau!");
                    }
                }
                else
                {
                    TbxPassOld.Focus();
                    MessageBox.Show("Sai PassWord");
                }
            }
            else
            {
                TbxLoginName.Focus();
                MessageBox.Show("Không tồn tại user này");
            }
        }

        private void BtnAcept_Click(object sender, EventArgs e)
        {
            if (TbxLoginName.Text == "") {
                MessageBox.Show("Tến đăng nhập còn trống");
                TbxLoginName.Focus();
            }
            else if (TbxPassOld.Text == "") {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ");
                TbxPassOld.Focus();
            }
            else if (TbxNewpass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                TbxNewpass.Focus();
            }
            else if (TbxNewPass1.Text == "") {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu mới");
                TbxNewPass1.Focus();
            }
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.None);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
