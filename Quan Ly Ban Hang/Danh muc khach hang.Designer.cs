namespace Quan_Ly_Ban_Hang
{
    partial class Danh_muc_khach_hang
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
            this.DgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.LblDanhMuc = new System.Windows.Forms.Label();
            this.BtnTroVe = new System.Windows.Forms.Button();
            this.banHangDataSet = new Quan_Ly_Ban_Hang.BanHangDataSet();
            this.banHangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvDanhMuc
            // 
            this.DgvDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDanhMuc.Location = new System.Drawing.Point(16, 81);
            this.DgvDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvDanhMuc.Name = "DgvDanhMuc";
            this.DgvDanhMuc.ReadOnly = true;
            this.DgvDanhMuc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvDanhMuc.RowTemplate.Height = 21;
            this.DgvDanhMuc.Size = new System.Drawing.Size(674, 449);
            this.DgvDanhMuc.TabIndex = 0;
            // 
            // LblDanhMuc
            // 
            this.LblDanhMuc.AutoSize = true;
            this.LblDanhMuc.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblDanhMuc.Location = new System.Drawing.Point(187, 33);
            this.LblDanhMuc.Name = "LblDanhMuc";
            this.LblDanhMuc.Size = new System.Drawing.Size(215, 20);
            this.LblDanhMuc.TabIndex = 1;
            this.LblDanhMuc.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // BtnTroVe
            // 
            this.BtnTroVe.BackColor = System.Drawing.Color.MistyRose;
            this.BtnTroVe.Location = new System.Drawing.Point(8, 24);
            this.BtnTroVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTroVe.Name = "BtnTroVe";
            this.BtnTroVe.Size = new System.Drawing.Size(99, 35);
            this.BtnTroVe.TabIndex = 2;
            this.BtnTroVe.Text = "Back";
            this.BtnTroVe.UseVisualStyleBackColor = false;
            this.BtnTroVe.Click += new System.EventHandler(this.BtnTroVe_Click);
            // 
            // banHangDataSet
            // 
            this.banHangDataSet.DataSetName = "BanHangDataSet";
            this.banHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banHangDataSetBindingSource
            // 
            this.banHangDataSetBindingSource.DataSource = this.banHangDataSet;
            this.banHangDataSetBindingSource.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnTroVe);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(571, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(119, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Danh_muc_khach_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblDanhMuc);
            this.Controls.Add(this.DgvDanhMuc);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Danh_muc_khach_hang";
            this.Text = "Danh mục khách hàng";
            this.Load += new System.EventHandler(this.Danh_muc_khach_hang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDanhMuc;
        private System.Windows.Forms.Label LblDanhMuc;
        private System.Windows.Forms.Button BtnTroVe;
        private System.Windows.Forms.BindingSource banHangDataSetBindingSource;
        private BanHangDataSet banHangDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}