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

    public partial class QL_DM_Thanh_Pho : Form
    {
        //chuoi ket noi
        string strConnectionString = @"Data Source=DK0626-PC\SQLEXPRESS;Initial Catalog=BanHang;Integrated Security=True";
        //doi tuong ket noi
        SqlConnection conn = null;
        //doi tuong dua vao ket noi
        SqlDataAdapter daTblThanhPho = null;
        //doi tuong hin thi du lieu len datagridview trong Form
        DataTable dtTblThanhPho = null;
        bool Them; //Khai Báo biến việc thêm hay sửa dữ liệu

        public QL_DM_Thanh_Pho()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                //Khởi động connection
                conn = new SqlConnection(strConnectionString);
                //vận chuyển dữ liệu lên datatable dttblThanhPho
                daTblThanhPho = new SqlDataAdapter("select * from ThanhPho", conn);
                dtTblThanhPho = new DataTable();
                dtTblThanhPho.Clear();
                daTblThanhPho.Fill(dtTblThanhPho);
                //đưa dữ liệu lên datagridview
                DgvThanhPho.DataSource = dtTblThanhPho;
                DgvThanhPho.AutoResizeColumns();
                this.TxtTenThanhPho.ResetText();
                this.TxtThanhPho.ResetText();
                BtnHuyBo.Enabled = false;
                BtnLuu.Enabled = false;
                //this.panel2.Enabled = false;
                BtnThem.Enabled = true;
                BtnSua.Enabled = true;
                BtnXoa.Enabled = true;
                BtnTroVe.Enabled = true;

            }
            catch(SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong Table Thành Phố");
            }
        }

        private void QL_DM_Thanh_Pho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banHangDataSet2.ThanhPho' table. You can move, or remove it, as needed.
            this.thanhPhoTableAdapter.Fill(this.banHangDataSet2.ThanhPho);
            LoadData();
        }

        private void QL_DM_Thanh_Pho_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtTblThanhPho.Dispose();
            dtTblThanhPho = null;
            //Hủy kết nối
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
            TxtTenThanhPho.ResetText();
            TxtThanhPho.ResetText();
            BtnHuyBo.Enabled = true;
            BtnLuu.Enabled = true;
            panel1.Enabled = true;
            //
            BtnThem.Enabled = false;
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            BtnTroVe.Enabled = false;

            this.TxtThanhPho.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            panel1.Enabled = true;
            int r = DgvThanhPho.CurrentCell.RowIndex;
            TxtThanhPho.Text = DgvThanhPho.Rows[r].Cells[0].Value.ToString();
            TxtTenThanhPho.Text = DgvThanhPho.Rows[r].Cells[1].Value.ToString();
            BtnLuu.Enabled = true;
            BtnHuyBo.Enabled = true;
            panel1.Enabled = true;

            BtnThem.Enabled = false;
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            BtnTroVe.Enabled = false;

            TxtThanhPho.Focus();

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
                int r = DgvThanhPho.CurrentCell.RowIndex;
                string strThanhPho = DgvThanhPho.Rows[r].Cells[0].Value.ToString();

                cmd.CommandText = String.Concat("Delete from ThanhPho Where ThanhPho='" + strThanhPho + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                LoadData();
                MessageBox.Show("Đã xóa xong!");

            }
            catch(SqlException)
            {
                MessageBox.Show("Không xóa được!");
            }
            conn.Close();
        }

        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            TxtTenThanhPho.ResetText();
            TxtThanhPho.ResetText();
            BtnThem.Enabled = true;

            BtnSua.Enabled = true;
            BtnXoa.Enabled = true;
            BtnTroVe.Enabled = true;

            BtnLuu.Enabled = false;
            BtnHuyBo.Enabled = false;
            panel1.Enabled = false;
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
                    cmd.CommandText = System.String.Concat("Insert Into ThanhPho Values(" + "N'" + TxtThanhPho.Text.ToString() + "',N'"
                        + TxtTenThanhPho.Text.ToString() + "')");
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

            if(!Them)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r = DgvThanhPho.CurrentCell.RowIndex;
                //Ma KH hien hanh
                string strThanhPho = DgvThanhPho.Rows[r].Cells[0].Value.ToString();

                cmd.CommandText = String.Concat("Update ThanhPho Set TenThanhPho =N'" + TxtTenThanhPho.Text.ToString() + 
                    "'Where ThanhPho=N'" + strThanhPho+"'");

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
            conn.Close();
        }
    }
}
