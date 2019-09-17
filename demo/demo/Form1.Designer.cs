namespace demo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_moi = new System.Windows.Forms.Button();
            this.maskedTextBox_ngaySinh = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_MaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.tb_khoa = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_lop = new System.Windows.Forms.TextBox();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_luu = new System.Windows.Forms.Button();
            this.button_huy = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // button_moi
            // 
            this.button_moi.Location = new System.Drawing.Point(72, 559);
            this.button_moi.Name = "button_moi";
            this.button_moi.Size = new System.Drawing.Size(75, 34);
            this.button_moi.TabIndex = 1;
            this.button_moi.Text = "Mới";
            this.button_moi.UseVisualStyleBackColor = true;
            this.button_moi.Click += new System.EventHandler(this.Button_moi_Click);
            // 
            // maskedTextBox_ngaySinh
            // 
            this.maskedTextBox_ngaySinh.Location = new System.Drawing.Point(164, 169);
            this.maskedTextBox_ngaySinh.Name = "maskedTextBox_ngaySinh";
            this.maskedTextBox_ngaySinh.Size = new System.Drawing.Size(184, 22);
            this.maskedTextBox_ngaySinh.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(869, 233);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyUp);
            // 
            // tb_MaSV
            // 
            this.tb_MaSV.Location = new System.Drawing.Point(164, 51);
            this.tb_MaSV.Name = "tb_MaSV";
            this.tb_MaSV.Size = new System.Drawing.Size(184, 22);
            this.tb_MaSV.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ Và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lớp ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa Chỉ";
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Location = new System.Drawing.Point(164, 112);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(184, 22);
            this.tb_HoTen.TabIndex = 10;
            // 
            // tb_khoa
            // 
            this.tb_khoa.Location = new System.Drawing.Point(575, 51);
            this.tb_khoa.Name = "tb_khoa";
            this.tb_khoa.Size = new System.Drawing.Size(143, 22);
            this.tb_khoa.TabIndex = 11;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(575, 169);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(143, 22);
            this.tb_diachi.TabIndex = 12;
            // 
            // tb_lop
            // 
            this.tb_lop.Location = new System.Drawing.Point(575, 110);
            this.tb_lop.Name = "tb_lop";
            this.tb_lop.Size = new System.Drawing.Size(143, 22);
            this.tb_lop.TabIndex = 13;
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(195, 559);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(75, 34);
            this.button_sua.TabIndex = 14;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.Button_sua_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(339, 559);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(75, 34);
            this.button_xoa.TabIndex = 15;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.Button_xoa_Click);
            // 
            // button_luu
            // 
            this.button_luu.Location = new System.Drawing.Point(484, 559);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(86, 34);
            this.button_luu.TabIndex = 16;
            this.button_luu.Text = "Lưu";
            this.button_luu.UseVisualStyleBackColor = true;
            this.button_luu.Click += new System.EventHandler(this.Button_luu_Click);
            // 
            // button_huy
            // 
            this.button_huy.Location = new System.Drawing.Point(619, 559);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(82, 34);
            this.button_huy.TabIndex = 17;
            this.button_huy.Text = "Hủy";
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.Button_huy_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(752, 559);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(76, 34);
            this.button_thoat.TabIndex = 18;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.Button_thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 623);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.tb_lop);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.tb_khoa);
            this.Controls.Add(this.tb_HoTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_MaSV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maskedTextBox_ngaySinh);
            this.Controls.Add(this.button_moi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_moi;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ngaySinh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_MaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.TextBox tb_khoa;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_lop;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.Button button_thoat;
    }
}

