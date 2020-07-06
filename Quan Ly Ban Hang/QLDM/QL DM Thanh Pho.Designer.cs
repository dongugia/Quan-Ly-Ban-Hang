namespace Quan_Ly_Ban_Hang
{
    partial class QL_DM_Thanh_Pho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtTenThanhPho = new System.Windows.Forms.TextBox();
            this.TxtThanhPho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvThanhPho = new System.Windows.Forms.DataGridView();
            this.BtnReLoad = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.BtnHuyBo = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnTroVe = new System.Windows.Forms.Button();
            this.banHangDataSet2 = new Quan_Ly_Ban_Hang.BanHangDataSet2();
            this.thanhPhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thanhPhoTableAdapter = new Quan_Ly_Ban_Hang.BanHangDataSet2TableAdapters.ThanhPhoTableAdapter();
            this.thanhPhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThanhPhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvThanhPho)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhPhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtTenThanhPho);
            this.panel1.Controls.Add(this.TxtThanhPho);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 152);
            this.panel1.TabIndex = 0;
            // 
            // TxtTenThanhPho
            // 
            this.TxtTenThanhPho.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtTenThanhPho.Location = new System.Drawing.Point(265, 85);
            this.TxtTenThanhPho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTenThanhPho.Multiline = true;
            this.TxtTenThanhPho.Name = "TxtTenThanhPho";
            this.TxtTenThanhPho.Size = new System.Drawing.Size(275, 32);
            this.TxtTenThanhPho.TabIndex = 1;
            // 
            // TxtThanhPho
            // 
            this.TxtThanhPho.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtThanhPho.Location = new System.Drawing.Point(265, 37);
            this.TxtThanhPho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtThanhPho.Multiline = true;
            this.TxtThanhPho.Name = "TxtThanhPho";
            this.TxtThanhPho.Size = new System.Drawing.Size(275, 32);
            this.TxtThanhPho.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(55, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Thành Phố";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thành Phố";
            // 
            // DgvThanhPho
            // 
            this.DgvThanhPho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvThanhPho.AutoGenerateColumns = false;
            this.DgvThanhPho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvThanhPho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvThanhPho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvThanhPho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thanhPhoDataGridViewTextBoxColumn,
            this.tenThanhPhoDataGridViewTextBoxColumn});
            this.DgvThanhPho.DataSource = this.thanhPhoBindingSource;
            this.DgvThanhPho.Location = new System.Drawing.Point(14, 201);
            this.DgvThanhPho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvThanhPho.Name = "DgvThanhPho";
            this.DgvThanhPho.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DgvThanhPho.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvThanhPho.RowTemplate.Height = 21;
            this.DgvThanhPho.Size = new System.Drawing.Size(614, 395);
            this.DgvThanhPho.TabIndex = 1;
            // 
            // BtnReLoad
            // 
            this.BtnReLoad.Location = new System.Drawing.Point(12, 12);
            this.BtnReLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnReLoad.Name = "BtnReLoad";
            this.BtnReLoad.Size = new System.Drawing.Size(104, 47);
            this.BtnReLoad.TabIndex = 2;
            this.BtnReLoad.Text = "Reload";
            this.BtnReLoad.UseVisualStyleBackColor = true;
            this.BtnReLoad.Click += new System.EventHandler(this.BtnReLoad_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(160, 12);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(104, 47);
            this.BtnThem.TabIndex = 3;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(308, 12);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(104, 47);
            this.BtnSua.TabIndex = 4;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnLuu
            // 
            this.BtnLuu.Location = new System.Drawing.Point(12, 67);
            this.BtnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(104, 47);
            this.BtnLuu.TabIndex = 5;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.UseVisualStyleBackColor = true;
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // BtnHuyBo
            // 
            this.BtnHuyBo.Location = new System.Drawing.Point(160, 67);
            this.BtnHuyBo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnHuyBo.Name = "BtnHuyBo";
            this.BtnHuyBo.Size = new System.Drawing.Size(104, 47);
            this.BtnHuyBo.TabIndex = 6;
            this.BtnHuyBo.Text = "Hủy Bỏ";
            this.BtnHuyBo.UseVisualStyleBackColor = true;
            this.BtnHuyBo.Click += new System.EventHandler(this.BtnHuyBo_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(308, 67);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(104, 47);
            this.BtnXoa.TabIndex = 7;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.BtnReLoad);
            this.panel2.Controls.Add(this.BtnTroVe);
            this.panel2.Controls.Add(this.BtnXoa);
            this.panel2.Controls.Add(this.BtnThem);
            this.panel2.Controls.Add(this.BtnHuyBo);
            this.panel2.Controls.Add(this.BtnLuu);
            this.panel2.Controls.Add(this.BtnSua);
            this.panel2.Location = new System.Drawing.Point(14, 616);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 124);
            this.panel2.TabIndex = 3;
            // 
            // BtnTroVe
            // 
            this.BtnTroVe.Location = new System.Drawing.Point(493, 67);
            this.BtnTroVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTroVe.Name = "BtnTroVe";
            this.BtnTroVe.Size = new System.Drawing.Size(104, 47);
            this.BtnTroVe.TabIndex = 8;
            this.BtnTroVe.Text = "Trở Về";
            this.BtnTroVe.UseVisualStyleBackColor = true;
            this.BtnTroVe.Click += new System.EventHandler(this.BtnTroVe_Click);
            // 
            // banHangDataSet2
            // 
            this.banHangDataSet2.DataSetName = "BanHangDataSet2";
            this.banHangDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thanhPhoBindingSource
            // 
            this.thanhPhoBindingSource.DataMember = "ThanhPho";
            this.thanhPhoBindingSource.DataSource = this.banHangDataSet2;
            // 
            // thanhPhoTableAdapter
            // 
            this.thanhPhoTableAdapter.ClearBeforeFill = true;
            // 
            // thanhPhoDataGridViewTextBoxColumn
            // 
            this.thanhPhoDataGridViewTextBoxColumn.DataPropertyName = "ThanhPho";
            this.thanhPhoDataGridViewTextBoxColumn.HeaderText = "ThanhPho";
            this.thanhPhoDataGridViewTextBoxColumn.Name = "thanhPhoDataGridViewTextBoxColumn";
            this.thanhPhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenThanhPhoDataGridViewTextBoxColumn
            // 
            this.tenThanhPhoDataGridViewTextBoxColumn.DataPropertyName = "TenThanhPho";
            this.tenThanhPhoDataGridViewTextBoxColumn.HeaderText = "TenThanhPho";
            this.tenThanhPhoDataGridViewTextBoxColumn.Name = "tenThanhPhoDataGridViewTextBoxColumn";
            this.tenThanhPhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // QL_DM_Thanh_Pho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 756);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DgvThanhPho);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QL_DM_Thanh_Pho";
            this.Text = "QL_DM_Thanh_Pho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QL_DM_Thanh_Pho_FormClosing);
            this.Load += new System.EventHandler(this.QL_DM_Thanh_Pho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvThanhPho)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhPhoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtTenThanhPho;
        private System.Windows.Forms.TextBox TxtThanhPho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvThanhPho;
        private System.Windows.Forms.Button BtnReLoad;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnLuu;
        private System.Windows.Forms.Button BtnHuyBo;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnTroVe;
        private BanHangDataSet2 banHangDataSet2;
        private System.Windows.Forms.BindingSource thanhPhoBindingSource;
        private BanHangDataSet2TableAdapters.ThanhPhoTableAdapter thanhPhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThanhPhoDataGridViewTextBoxColumn;
    }
}