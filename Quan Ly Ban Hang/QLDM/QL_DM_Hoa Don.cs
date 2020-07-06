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

namespace Quan_Ly_Ban_Hang.QLDM
{
    public partial class QL_DM_Hoa_Don : Form
    {
        //chuoi ket noi
        string strConnectionString = @"Data Source=DK0626-PC\SQLEXPRESS;Initial Catalog=BanHang;Integrated Security=True";

        SqlConnection conn = null;             //doi tuong ket noi    
        SqlDataAdapter daTblHoaDon = null;  //doi tuong dua vao ket noi
        DataTable dtTblHoaDon = null;      //doi tuong hien thi du lieu len datagridview trong Form

        SqlDataAdapter daTblKhachHang = null;  //doi tuong dua vao ket noi
        DataTable dtTblKhachHang = null;

        SqlDataAdapter daTblNhanVien = null;  //doi tuong dua vao ket noi
        DataTable dtTblNhanVien = null;

        bool Them;


        public QL_DM_Hoa_Don()
        {
            InitializeComponent();
        }

        private void QL_DM_Hoa_Don_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);     //Khởi động connection            

                daTblHoaDon = new SqlDataAdapter("select * from HoaDon", conn);  //vận chuyển dữ liệu lên datatable dttblHoaDon
                dtTblHoaDon = new DataTable();
                dtTblHoaDon.Clear();
                daTblHoaDon.Fill(dtTblHoaDon);

                daTblKhachHang = new SqlDataAdapter("select * from KhachHang", conn);  //vận chuyển dữ liệu lên datatable dttblKhachHang
                dtTblKhachHang = new DataTable();
                dtTblKhachHang.Clear();
                daTblKhachHang.Fill(dtTblKhachHang);

                daTblNhanVien = new SqlDataAdapter("select * from NhanVien", conn);  //vận chuyển dữ liệu lên datatable dttblNhanVien
                dtTblNhanVien = new DataTable();
                dtTblNhanVien.Clear();
                daTblNhanVien.Fill(dtTblNhanVien);

                //đưa dữ liệu lên datagridview
                DgvHoaDon.DataSource = dtTblHoaDon;

                TbxMaHD.ResetText();
                Dtp_NgayNH.ResetText();
                Dtp_NgayLHD.ResetText();
                CbxMaKH.ResetText();
                CbxMaNV.ResetText();

                BtnHuyBo.Enabled = false;
                BtnLuu.Enabled = false;
                panel1.Enabled = false;

                BtnThem.Enabled = true;
                BtnSua.Enabled = true;
                BtnXoa.Enabled = true;
                BtnTroVe.Enabled = true;

                //Đưa dữ liệu lên combobox
                this.CbxMaKH.DataSource = dtTblKhachHang;
                this.CbxMaKH.DisplayMember = "MaKH";
                this.CbxMaKH.ValueMember = "MaKH";

                //Đưa dữ liệu lên combobox
                this.CbxMaNV.DataSource = dtTblNhanVien;
                this.CbxMaNV.DisplayMember = "MaNV";
                this.CbxMaNV.ValueMember = "MaNV";

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Table Hóa Đơn!", "Thông báo");
            }
        }

        private void BtnReLoad_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void QL_DM_Hoa_Don_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtTblHoaDon.Dispose();
            dtTblHoaDon = null;
            conn = null;
        }

        private void BtnTroVe_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnThem_Click_1(object sender, EventArgs e)
        {
            Them = true;
            TbxMaHD.ResetText();
            Dtp_NgayNH.ResetText();
            Dtp_NgayLHD.ResetText();
            CbxMaKH.ResetText();
            CbxMaNV.ResetText();

            BtnHuyBo.Enabled = true;
            BtnLuu.Enabled = true;
            panel1.Enabled = true;
            //
            BtnThem.Enabled = false;
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            BtnTroVe.Enabled = false;

            this.TbxMaHD.Focus();

        }

        private void BtnSua_Click_1(object sender, EventArgs e)
        {
            Them = false;
            panel1.Enabled = true;

            int r = DgvHoaDon.CurrentCell.RowIndex;
            TbxMaHD.Text = DgvHoaDon.Rows[r].Cells[0].Value.ToString();
            CbxMaKH.SelectedValue = DgvHoaDon.Rows[r].Cells[1].Value.ToString();
            CbxMaNV.SelectedValue = DgvHoaDon.Rows[r].Cells[2].Value.ToString();
            Dtp_NgayLHD.Text = DgvHoaDon.Rows[r].Cells[3].Value.ToString();
            Dtp_NgayNH.Text = DgvHoaDon.Rows[r].Cells[4].Value.ToString();

            BtnLuu.Enabled = true;
            BtnHuyBo.Enabled = true;
            panel1.Enabled = true;

            BtnThem.Enabled = false;
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            BtnTroVe.Enabled = false;

            this.TbxMaHD.Focus();
        }

        private void BtnLuu_Click_1(object sender, EventArgs e)
        {
            conn.Open();

            if (Them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("Insert Into HoaDon Values(" + "N'" + TbxMaHD.Text.ToString() + "',N'"
                        + CbxMaKH.SelectedValue.ToString() + "',N'" + CbxMaNV.SelectedValue.ToString() + "',N'" + Dtp_NgayLHD.Value.Date +
                        "',N'" + Dtp_NgayNH.Value.Date + "')");
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
                    int r = DgvHoaDon.CurrentCell.RowIndex;
                    //Ma SP hien hanh
                    string strMaHD = DgvHoaDon.Rows[r].Cells[0].Value.ToString();
                    cmd.CommandText = String.Concat("Update HoaDon Set " +
                        "NgayLapHD =N'" + Dtp_NgayLHD.Value.Date + "', NgayNhanHang =N'" + Dtp_NgayNH.Value.Date + "', MaKH =N'" + CbxMaKH.SelectedValue.ToString() +
                        "', MaNV =N'" + CbxMaNV.SelectedValue.ToString() + "'Where MaHD =N'" + strMaHD + "'");
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

        private void BtnHuyBo_Click_1(object sender, EventArgs e)
        {
            TbxMaHD.ResetText();
            Dtp_NgayNH.ResetText();
            Dtp_NgayLHD.ResetText();
            CbxMaKH.ResetText();
            CbxMaNV.ResetText();

            BtnThem.Enabled = true;
            BtnSua.Enabled = true;
            BtnXoa.Enabled = true;
            BtnTroVe.Enabled = true;

            BtnLuu.Enabled = false;
            BtnHuyBo.Enabled = false;
            panel1.Enabled = false;
        }

        private void BtnXoa_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                //Thực hiện lệnh
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                //Lấy thứ tự Record hiện hành
                int r = DgvHoaDon.CurrentCell.RowIndex;
                string strHoaDon = DgvHoaDon.Rows[r].Cells[0].Value.ToString();

                cmd.CommandText = String.Concat("Delete from HoaDon Where MaHD='" + strHoaDon + "'");
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
