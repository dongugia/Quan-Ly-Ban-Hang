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
    public partial class QL_DM_Khach_Hang : Form
    {
        //chuoi ket noi
        string strConnectionString = @"Data Source=DK0626-PC\SQLEXPRESS;Initial Catalog=BanHang;Integrated Security=True";
        
        SqlConnection conn = null;             //doi tuong ket noi    
        SqlDataAdapter daTblKhachHang = null;  //doi tuong dua vao ket noi
        SqlDataAdapter daTblThanhPho = null; 
        DataTable dtTblKhachHang = null;      //doi tuong hin thi du lieu len datagridview trong Form
        DataTable dtTblThanhPho = null;
        bool Them;                            //Khai Báo biến việc thêm hay sửa dữ liệu
        public QL_DM_Khach_Hang()
        {
            InitializeComponent();
        }

        private void QL_DM_Khach_Hang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banHangDataSet3.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.banHangDataSet3.KhachHang);
            LoadData();
        }

        void LoadData()
        {
            try
            {             
                conn = new SqlConnection(strConnectionString);     //Khởi động connection            
                daTblThanhPho = new SqlDataAdapter("select * from ThanhPho", conn);  //vận chuyển dữ liệu lên datatable dttblThanhPho
                dtTblThanhPho = new DataTable();
                dtTblThanhPho.Clear();
                daTblThanhPho.Fill(dtTblThanhPho);
        
                daTblKhachHang = new SqlDataAdapter("select * from KhachHang", conn);  //vận chuyển dữ liệu lên datatable dttblThanhPho
                dtTblKhachHang = new DataTable();
                dtTblKhachHang.Clear();
                daTblKhachHang.Fill(dtTblKhachHang);

                //đưa dữ liệu lên datagridview
                DgvKhachHang.DataSource = dtTblKhachHang;
                //DgvKhachHang.AutoResizeColumns();

                TbxTenCty.ResetText();
                TbxMaKH.ResetText();
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
                MessageBox.Show("Không lấy được nội dung trong Table Khách Hàng!","Thông báo");
            }
        }

        private void BtnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            TbxTenCty.ResetText();
            TbxMaKH.ResetText();
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

            //Đưa dữ liệu lên combobox
            this.CbThanhPho.DataSource = dtTblThanhPho;
            this.CbThanhPho.DisplayMember = "TenThanhPho";
            this.CbThanhPho.ValueMember = "ThanhPho";

            this.TbxMaKH.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            panel1.Enabled = true;
            this.CbThanhPho.DataSource = dtTblThanhPho;
            this.CbThanhPho.DisplayMember = "TenThanhPho";
            this.CbThanhPho.ValueMember = "ThanhPho";

            int r = DgvKhachHang.CurrentCell.RowIndex;
            TbxMaKH.Text = DgvKhachHang.Rows[r].Cells[0].Value.ToString();
            TbxTenCty.Text = DgvKhachHang.Rows[r].Cells[1].Value.ToString();
            TbxDiaChi.Text = DgvKhachHang.Rows[r].Cells[2].Value.ToString();
            CbThanhPho.SelectedValue = DgvKhachHang.Rows[r].Cells[3].Value.ToString();
            TbxDienThoai.Text = DgvKhachHang.Rows[r].Cells[4].Value.ToString();

            BtnLuu.Enabled = true;
            BtnHuyBo.Enabled = true;
            panel1.Enabled = true;

            BtnThem.Enabled = false;
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            BtnTroVe.Enabled = false;

            this.TbxMaKH.Focus();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (Them)
            {
                try
                {
                    if (MessageBox.Show("Do u want to save ?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = System.String.Concat("Insert Into KhachHang Values(" + "N'" + TbxMaKH.Text.ToString() + "',N'"
                            + TbxTenCty.Text.ToString() + "',N'" + TbxDiaChi.Text.ToString() + "',N'" + CbThanhPho.SelectedValue.ToString() +
                            "',N'" + TbxDienThoai.Text.ToString() + "')");
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        LoadData();
                        MessageBox.Show("Đã thêm xong!");
                    }

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
                    int r = DgvKhachHang.CurrentCell.RowIndex;
                    //Ma KH hien hanh
                    string strMaKH = DgvKhachHang.Rows[r].Cells[0].Value.ToString();

                    cmd.CommandText = String.Concat("Update KhachHang Set "+
                        "TenCty =N'" + TbxTenCty.Text.ToString() + "', DiaChi =N'" + TbxDiaChi.Text.ToString() +
                        "', ThanhPho =N'" + CbThanhPho.SelectedValue.ToString() + "', DienThoai =N'" + TbxDienThoai.Text.ToString() +
                        "'Where KhachHang =N'" + strMaKH + "'");

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Không sửa được. \r\n Lỗi kết nối!");
                }
            }
            conn.Close();
        }

        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            TbxMaKH.ResetText();
            TbxTenCty.ResetText();
            TbxDiaChi.ResetText();
            TbxDienThoai.ResetText();

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
                int r = DgvKhachHang.CurrentCell.RowIndex;
                string strKhachHang = DgvKhachHang.Rows[r].Cells[0].Value.ToString();

                cmd.CommandText = String.Concat("Delete from KhachHang Where MaKH='" + strKhachHang + "'");
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

        private void BtnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
