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
    
    public partial class Danh_muc_khach_hang : Form
    {
        //chuoi ket noi
        string strConnectionString = @"Data Source=DK0626-PC\SQLEXPRESS;Initial Catalog=BanHang;Integrated Security=True";
        //doi tuong ket noi
        SqlConnection conn = null;
        //doi tuong dua vao ket noi
        SqlDataAdapter daTable = null;
        //doi tuong hin thi du lieu len datagridview trong Form
        DataTable dtTable = null;
        
        public Danh_muc_khach_hang()
        {
            InitializeComponent();
        }

        private void Danh_muc_khach_hang_Load(object sender, EventArgs e)
        {
            try
            {
                //khoi dong connection
                conn = new SqlConnection(strConnectionString);
                //Xu li danh muc
                int intDM = Convert.ToInt32(this.Text);
                switch(intDM)
                {
                    case 1:
                        LblDanhMuc.Text = "Danh mục Thành Phố";
                        daTable = new SqlDataAdapter("select * from ThanhPho", conn); //ThanhPho,TenThanhPho
                        break;
                    case 2:
                        LblDanhMuc.Text = "Danh mục Khách Hàng";
                        daTable = new SqlDataAdapter("SELECT * FROM KhachHang", conn); //MaKH,TenCty
                        break;
                    case 3:
                        LblDanhMuc.Text = "Danh mục Nhân Viên"; 
                        daTable = new SqlDataAdapter("SELECT * FROM NhanVien", conn); //MaNV,Ho,Ten
                        break;
                    case 4:
                        LblDanhMuc.Text = "Danh mục Sản Phẩm";
                        daTable = new SqlDataAdapter("SELECT * FROM SanPham", conn); //MaSP,TenSP,DonViTinh,DonGia
                        break;
                    case 5:
                        LblDanhMuc.Text = "Danh mục Hóa Đơn";
                        daTable = new SqlDataAdapter("SELECT * FROM HoaDon", conn); //MaHD,MaKH,MaNV
                        break;
                    case 6:
                        LblDanhMuc.Text = "Danh mục Chi tiết Hóa Đơn";
                        daTable = new SqlDataAdapter("SELECT * FROM ChiTietHoaDon", conn);
                        break;
                    default:
                        break;                       
                }
                // Vận chuyển dữ liệu lên dataTable dtTable
                dtTable = new DataTable();
                dtTable.Clear();
                daTable.Fill(dtTable);
                //Đưa dữ liệu lên datagridView 
                DgvDanhMuc.DataSource = dtTable;
                //Thay đổi độ rộng của cột
                //DgvDanhMuc.AutoResizeColumns();
                //Load TextName
                this.Text = (LblDanhMuc.Text).Remove(0,9);
                this.Text.ToUpper();
            }
            catch(SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng!");
            }
        }

        private void BtnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
