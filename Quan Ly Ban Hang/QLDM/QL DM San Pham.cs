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
    public partial class QL_DM_San_Pham : Form
    {
        //chuoi ket noi
        string strConnectionString = @"Data Source=DK0626-PC\SQLEXPRESS;Initial Catalog=BanHang;Integrated Security=True";

        SqlConnection conn = null;             //doi tuong ket noi    
        SqlDataAdapter daTblSanPham = null;  //doi tuong dua vao ket noi
        DataTable dtTblSanPham = null;      //doi tuong hin thi du lieu len datagridview trong Form
        bool Them;                            //Khai Báo biến việc thêm hay sửa dữ liệu
        public QL_DM_San_Pham()
        {
            InitializeComponent();
        }

        private void QL_DM_San_Pham_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);     //Khởi động connection            

                daTblSanPham = new SqlDataAdapter("select * from SanPham", conn);  //vận chuyển dữ liệu lên datatable dttblSanPham
                dtTblSanPham = new DataTable();
                dtTblSanPham.Clear();
                daTblSanPham.Fill(dtTblSanPham);

                //đưa dữ liệu lên datagridview
                DgvSanPham.DataSource = dtTblSanPham;

                TbxMaSP.ResetText();
                TbxTenSP.ResetText();
                TbxDVTinh.ResetText();
                TbxDonGia.ResetText();

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
                MessageBox.Show("Không lấy được nội dung trong Table Sản Phẩm!", "Thông báo");
            }
        }

        private void BtnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void QL_DM_San_Pham_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtTblSanPham.Dispose();
            dtTblSanPham = null;
            conn = null;
        }

        private void BtnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            TbxMaSP.ResetText();
            TbxTenSP.ResetText();
            TbxDVTinh.ResetText();
            TbxDonGia.ResetText();

            BtnHuyBo.Enabled = true;
            BtnLuu.Enabled = true;
            panel1.Enabled = true;
            //
            BtnThem.Enabled = false;
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            BtnTroVe.Enabled = false;

            this.TbxMaSP.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            panel1.Enabled = true;

            int r = DgvSanPham.CurrentCell.RowIndex;
            TbxMaSP.Text = DgvSanPham.Rows[r].Cells[0].Value.ToString();
            TbxTenSP.Text = DgvSanPham.Rows[r].Cells[1].Value.ToString();
            TbxDVTinh.Text = DgvSanPham.Rows[r].Cells[2].Value.ToString();
            TbxDonGia.Text = DgvSanPham.Rows[r].Cells[3].Value.ToString();

            BtnLuu.Enabled = true;
            BtnHuyBo.Enabled = true;
            panel1.Enabled = true;

            BtnThem.Enabled = false;
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            BtnTroVe.Enabled = false;

            this.TbxMaSP.Focus();
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
                    cmd.CommandText = System.String.Concat("Insert Into SanPham Values(" + "N'" + TbxMaSP.Text.ToString() + "',N'"
                        + TbxTenSP.Text.ToString() + "',N'" + TbxDVTinh.Text.ToString() + "',N'" + TbxDonGia.Text.ToString() + "',N'" + "')");
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
                    int r = DgvSanPham.CurrentCell.RowIndex;
                    //Ma SP hien hanh
                    string strMaSP = DgvSanPham.Rows[r].Cells[0].Value.ToString();
                    cmd.CommandText = String.Concat("Update SanPham Set " +
                        "TenSP =N'" + TbxTenSP.Text.ToString() + "', DonViTinh =N'" + TbxDVTinh.Text.ToString() +
                        "', DonGia =N'" + TbxDonGia.Text.ToString() + "'Where MaSP =N'" + strMaSP + "'");
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
            TbxMaSP.ResetText();
            TbxTenSP.ResetText();
            TbxDVTinh.ResetText();
            TbxDonGia.ResetText();

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
                int r = DgvSanPham.CurrentCell.RowIndex;
                string strSanPham = DgvSanPham.Rows[r].Cells[0].Value.ToString();

                cmd.CommandText = String.Concat("Delete from SanPham Where MaSP='" + strSanPham + "'");
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
