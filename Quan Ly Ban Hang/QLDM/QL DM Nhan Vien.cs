using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Ban_Hang
{
    public partial class QL_DM_Nhan_Vien : Form
    {
        //chuoi ket noi
        string strConnectionString = @"Data Source=DK0626-PC\SQLEXPRESS;Initial Catalog=BanHang;Integrated Security=True";

        SqlConnection conn = null;             //doi tuong ket noi    
        SqlDataAdapter daTblNhanVien = null;  //doi tuong dua vao ket noi
        //SqlDataAdapter daTblThanhPho = null;
        DataTable dtTblNhanVien = null;      //doi tuong hin thi du lieu len datagridview trong Form
        //DataTable dtTblThanhPho = null;
        bool Them;                            //Khai Báo biến việc thêm hay sửa dữ liệu
        public QL_DM_Nhan_Vien()
        {
            InitializeComponent();
        }

        private void QL_DM_Nhan_Vien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);     //Khởi động connection            

                daTblNhanVien = new SqlDataAdapter("select * from NhanVien", conn);  //vận chuyển dữ liệu lên datatable dttblNhanVien
                dtTblNhanVien = new DataTable();
                dtTblNhanVien.Clear();
                daTblNhanVien.Fill(dtTblNhanVien);

                //đưa dữ liệu lên datagridview
                DgvNhanVien.DataSource = dtTblNhanVien;
                //DgvKhachHang.AutoResizeColumns();

                TbxMaNV.ResetText();
                TbxTen.ResetText();
                TbxHoDem.ResetText();
                TbxNgaySinh.ResetText();
                TbxDienThoai.ResetText();
                TbxDiaChi.ResetText();

                BtnHuyBo.Enabled = false;
                BtnLuu.Enabled = false;
                panel1.Enabled = false;

                BtnThem.Enabled = true;
                BtnSua.Enabled = true;
                BtnXoa.Enabled = true;
                BtnTroVe.Enabled = true;

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Table Nhân Viên!", "Thông báo");
            }
        }

        private void QL_DM_Nhan_Vien_FormClosing(object sender, FormClosingEventArgs e)
        {
            daTblNhanVien.Dispose();
            daTblNhanVien = null;
            conn = null;
        }

        private void BtnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            TbxMaNV.ResetText();
            TbxHoDem.ResetText();
            TbxTen.ResetText();
            TbxNgaySinh.ResetText();
            TbxDienThoai.ResetText();
            TbxDiaChi.ResetText();

            BtnHuyBo.Enabled = true;
            BtnLuu.Enabled = true;
            panel1.Enabled = true;
            //
            BtnThem.Enabled = false;
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            BtnTroVe.Enabled = false;

            this.TbxMaNV.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            panel1.Enabled = true;

            int r = DgvNhanVien.CurrentCell.RowIndex;
            TbxMaNV.Text = DgvNhanVien.Rows[r].Cells[0].Value.ToString();
            TbxHoDem.Text = DgvNhanVien.Rows[r].Cells[1].Value.ToString();
            TbxTen.Text = DgvNhanVien.Rows[r].Cells[2].Value.ToString();
            TbxNgaySinh.Text = DgvNhanVien.Rows[r].Cells[3].Value.ToString();
            TbxDiaChi.Text = DgvNhanVien.Rows[r].Cells[4].Value.ToString();
            TbxDienThoai.Text = DgvNhanVien.Rows[r].Cells[5].Value.ToString();

            BtnLuu.Enabled = true;
            BtnHuyBo.Enabled = true;
            panel1.Enabled = true;

            BtnThem.Enabled = false;
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            BtnTroVe.Enabled = false;

            this.TbxMaNV.Focus();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (Them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("Insert Into NhanVien Values(" + "N'" + TbxMaNV.Text.ToString() + "',N'"
                        + TbxHoDem.Text.ToString() + "',N'" + TbxTen.Text.ToString() + "',N'" + TbxNgaySinh.Text.ToString() +
                        "',N'" + TbxDiaChi.Text.ToString() + "',N'" + TbxDienThoai.Text.ToString() + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Không thêm được!");
                }
            }

            if (!Them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    int r = DgvNhanVien.CurrentCell.RowIndex;
                    //Ma KH hien hanh
                    string strMaNV = DgvNhanVien.Rows[r].Cells[0].Value.ToString();

                    cmd.CommandText = String.Concat("Update NhanVien Set " +
                        "HoLot =N'" + TbxHoDem.Text.ToString() + "', Ten =N'" + TbxTen.Text.ToString() +
                        "', NgaySinh =N'" + TbxNgaySinh.Text.ToString() + "', DiaChi =N'" + TbxDiaChi.Text.ToString() +
                        "', DienThoai =N'" + TbxDienThoai.Text.ToString() + "'Where MaNV =N'" + strMaNV + "'");

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. \r\n Lỗi kết nối!");
                }
            }
            conn.Close();
        }

        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            TbxMaNV.ResetText();
            TbxHoDem.ResetText();
            TbxTen.ResetText();
            TbxNgaySinh.ResetText();
            TbxDienThoai.ResetText();
            TbxDiaChi.ResetText();

            BtnThem.Enabled = true;
            BtnSua.Enabled = true;
            BtnXoa.Enabled = true;
            BtnTroVe.Enabled = true;

            BtnLuu.Enabled = false;
            BtnHuyBo.Enabled = false;
            panel1.Enabled = false;

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                //Thực hiện lệnh
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                //Lấy thứ tự Record hiện hành
                int r = DgvNhanVien.CurrentCell.RowIndex;
                string strNhanVien = DgvNhanVien.Rows[r].Cells[0].Value.ToString();

                cmd.CommandText = String.Concat("Delete from NhanVien Where MaNV='" + strNhanVien + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                LoadData();
                MessageBox.Show("Đã xóa xong!");

            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. \r\nKiểm tra lại kết nối!");
            }
            conn.Close();
        }
    }
}
