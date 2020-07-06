namespace Quan_Ly_Ban_Hang
{
    partial class QL_DM_Khach_Hang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnReLoad = new System.Windows.Forms.Button();
            this.BtnTroVe = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnHuyBo = new System.Windows.Forms.Button();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.DgvKhachHang = new System.Windows.Forms.DataGridView();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banHangDataSet3 = new Quan_Ly_Ban_Hang.BanHangDataSet3();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbThanhPho = new System.Windows.Forms.ComboBox();
            this.TbxDiaChi = new System.Windows.Forms.TextBox();
            this.TbxDienThoai = new System.Windows.Forms.TextBox();
            this.TbxTenCty = new System.Windows.Forms.TextBox();
            this.TbxMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.khachHangTableAdapter = new Quan_Ly_Ban_Hang.BanHangDataSet3TableAdapters.KhachHangTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.BtnReLoad);
            this.panel2.Controls.Add(this.BtnTroVe);
            this.panel2.Controls.Add(this.BtnXoa);
            this.panel2.Controls.Add(this.BtnThem);
            this.panel2.Controls.Add(this.BtnHuyBo);
            this.panel2.Controls.Add(this.BtnLuu);
            this.panel2.Controls.Add(this.BtnSua);
            this.panel2.Location = new System.Drawing.Point(13, 459);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 66);
            this.panel2.TabIndex = 6;
            // 
            // BtnReLoad
            // 
            this.BtnReLoad.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnReLoad.Location = new System.Drawing.Point(12, 12);
            this.BtnReLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnReLoad.Name = "BtnReLoad";
            this.BtnReLoad.Size = new System.Drawing.Size(70, 40);
            this.BtnReLoad.TabIndex = 5;
            this.BtnReLoad.Text = "Reload";
            this.BtnReLoad.UseVisualStyleBackColor = true;
            this.BtnReLoad.Click += new System.EventHandler(this.BtnReLoad_Click);
            // 
            // BtnTroVe
            // 
            this.BtnTroVe.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnTroVe.Location = new System.Drawing.Point(578, 12);
            this.BtnTroVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTroVe.Name = "BtnTroVe";
            this.BtnTroVe.Size = new System.Drawing.Size(70, 40);
            this.BtnTroVe.TabIndex = 11;
            this.BtnTroVe.Text = "Trở Về";
            this.BtnTroVe.UseVisualStyleBackColor = true;
            this.BtnTroVe.Click += new System.EventHandler(this.BtnTroVe_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnXoa.Location = new System.Drawing.Point(482, 12);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(70, 40);
            this.BtnXoa.TabIndex = 10;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnThem.Location = new System.Drawing.Point(106, 12);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(70, 40);
            this.BtnThem.TabIndex = 6;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnHuyBo
            // 
            this.BtnHuyBo.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnHuyBo.Location = new System.Drawing.Point(388, 12);
            this.BtnHuyBo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnHuyBo.Name = "BtnHuyBo";
            this.BtnHuyBo.Size = new System.Drawing.Size(70, 40);
            this.BtnHuyBo.TabIndex = 9;
            this.BtnHuyBo.Text = "Hủy Bỏ";
            this.BtnHuyBo.UseVisualStyleBackColor = true;
            this.BtnHuyBo.Click += new System.EventHandler(this.BtnHuyBo_Click);
            // 
            // BtnLuu
            // 
            this.BtnLuu.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnLuu.Location = new System.Drawing.Point(294, 12);
            this.BtnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(70, 40);
            this.BtnLuu.TabIndex = 8;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.UseVisualStyleBackColor = true;
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSua.Location = new System.Drawing.Point(200, 12);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(70, 40);
            this.BtnSua.TabIndex = 7;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // DgvKhachHang
            // 
            this.DgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvKhachHang.AutoGenerateColumns = false;
            this.DgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKHDataGridViewTextBoxColumn,
            this.tenCtyDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.thanhPhoDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn});
            this.DgvKhachHang.DataSource = this.khachHangBindingSource;
            this.DgvKhachHang.Location = new System.Drawing.Point(13, 170);
            this.DgvKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvKhachHang.Name = "DgvKhachHang";
            this.DgvKhachHang.ReadOnly = true;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DgvKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.DgvKhachHang.RowTemplate.Height = 21;
            this.DgvKhachHang.Size = new System.Drawing.Size(672, 272);
            this.DgvKhachHang.TabIndex = 5;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            this.maKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenCtyDataGridViewTextBoxColumn
            // 
            this.tenCtyDataGridViewTextBoxColumn.DataPropertyName = "TenCty";
            this.tenCtyDataGridViewTextBoxColumn.HeaderText = "TenCty";
            this.tenCtyDataGridViewTextBoxColumn.Name = "tenCtyDataGridViewTextBoxColumn";
            this.tenCtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thanhPhoDataGridViewTextBoxColumn
            // 
            this.thanhPhoDataGridViewTextBoxColumn.DataPropertyName = "ThanhPho";
            this.thanhPhoDataGridViewTextBoxColumn.HeaderText = "ThanhPho";
            this.thanhPhoDataGridViewTextBoxColumn.Name = "thanhPhoDataGridViewTextBoxColumn";
            this.thanhPhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.banHangDataSet3;
            // 
            // banHangDataSet3
            // 
            this.banHangDataSet3.DataSetName = "BanHangDataSet3";
            this.banHangDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.CbThanhPho);
            this.panel1.Controls.Add(this.TbxDiaChi);
            this.panel1.Controls.Add(this.TbxDienThoai);
            this.panel1.Controls.Add(this.TbxTenCty);
            this.panel1.Controls.Add(this.TbxMaKH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 136);
            this.panel1.TabIndex = 4;
            // 
            // CbThanhPho
            // 
            this.CbThanhPho.FormattingEnabled = true;
            this.CbThanhPho.Location = new System.Drawing.Point(506, 17);
            this.CbThanhPho.Name = "CbThanhPho";
            this.CbThanhPho.Size = new System.Drawing.Size(142, 28);
            this.CbThanhPho.TabIndex = 3;
            // 
            // TbxDiaChi
            // 
            this.TbxDiaChi.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TbxDiaChi.Location = new System.Drawing.Point(162, 93);
            this.TbxDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxDiaChi.Multiline = true;
            this.TbxDiaChi.Name = "TbxDiaChi";
            this.TbxDiaChi.Size = new System.Drawing.Size(185, 32);
            this.TbxDiaChi.TabIndex = 2;
            // 
            // TbxDienThoai
            // 
            this.TbxDienThoai.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TbxDienThoai.Location = new System.Drawing.Point(506, 56);
            this.TbxDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxDienThoai.Multiline = true;
            this.TbxDienThoai.Name = "TbxDienThoai";
            this.TbxDienThoai.Size = new System.Drawing.Size(142, 32);
            this.TbxDienThoai.TabIndex = 4;
            // 
            // TbxTenCty
            // 
            this.TbxTenCty.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TbxTenCty.Location = new System.Drawing.Point(162, 56);
            this.TbxTenCty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxTenCty.Multiline = true;
            this.TbxTenCty.Name = "TbxTenCty";
            this.TbxTenCty.Size = new System.Drawing.Size(185, 32);
            this.TbxTenCty.TabIndex = 1;
            // 
            // TbxMaKH
            // 
            this.TbxMaKH.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TbxMaKH.Location = new System.Drawing.Point(162, 19);
            this.TbxMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxMaKH.Multiline = true;
            this.TbxMaKH.Name = "TbxMaKH";
            this.TbxMaKH.Size = new System.Drawing.Size(185, 32);
            this.TbxMaKH.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(384, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Công Ty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(384, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thành Phố";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // QL_DM_Khach_Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DgvKhachHang);
            this.Controls.Add(this.panel1);
            this.Name = "QL_DM_Khach_Hang";
            this.Text = "QL_DM_Khach_Hang";
            this.Load += new System.EventHandler(this.QL_DM_Khach_Hang_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnReLoad;
        private System.Windows.Forms.Button BtnTroVe;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnHuyBo;
        private System.Windows.Forms.Button BtnLuu;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.DataGridView DgvKhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbxTenCty;
        private System.Windows.Forms.TextBox TbxMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbThanhPho;
        private System.Windows.Forms.TextBox TbxDiaChi;
        private System.Windows.Forms.TextBox TbxDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private BanHangDataSet3 banHangDataSet3;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private BanHangDataSet3TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
    }
}