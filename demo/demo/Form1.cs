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

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Connect();

        }
        SqlConnection con;
        DataTable tblSinhVien;
        public void Connect()
        {
            con = new SqlConnection();
            //con.ConnectionString = @"Data Source=.\SQLEXPRESS; AttachDbFilename=" +
            //    Application.StartupPath + @"\QLSV.mdf; Integrated Security=True;Connect Timeout=30; User Instance=True";
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BaiTapLon\demo\demo\QLSV.mdf;Integrated Security=True; Initial Catalog=IPDatabase";
            con.Open();
        }


        public void DisConnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }
        }

        public void LoadDataGribView()
        {
            string sql;
            sql = "SELECT * FROM tblSinhVien";
            SqlDataAdapter MyData = new SqlDataAdapter(sql, con);
            tblSinhVien = new DataTable();
            this.Connect();
            MyData.Fill(tblSinhVien);
            dataGridView1.DataSource = tblSinhVien;

        }
        public void RunSQL(String sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Button_sua_Click(object sender, EventArgs e)
        {

            String sql;
            sql = "UPDATE tblSinhVien SET HoTen=N'" + tb_HoTen.Text + "',NgaySinh='" + maskedTextBox_ngaySinh.Text +
                "',Khoa=N'" + tb_khoa.Text + "',Lop=N'" + tb_lop.Text + "',DiaChi=N'" + tb_diachi.Text + "' WHERE MaSV='" + tb_MaSV.Text + "'";
            RunSQL(sql);
            LoadDataGribView();
        }

        private void Button_luu_Click(object sender, EventArgs e)
        {

            //String dk = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (tb_MaSV.Text == "" || tb_HoTen.Text == "" || tb_khoa.Text == "" || maskedTextBox_ngaySinh.Text == "" || tb_lop.Text == "" || tb_diachi.Text == "")
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
            }
            //else if(tb_MaSV.Text == dk)
            //{
            //    MessageBox.Show("trùng mã sinh viên, vui lòng nhập lại ");
            //    tb_MaSV.Focus();
            //}
            else
            {
                string sql;
                sql = "SELECT MaSV FROM tblSinhVien WHERE MaSV=N'" + tb_MaSV.Text + "'";
                SqlDataAdapter MyData = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                MyData.Fill(table);


                sql = "INSERT INTO tblSinhVien VALUES (N'" + tb_MaSV.Text + "',N'" + tb_HoTen.Text + "',N'" + maskedTextBox_ngaySinh.Text + "','"
                        + tb_khoa.Text + "',N'" + tb_lop.Text + "',N'" + tb_diachi.Text + "')";
                //sql = "INSERT INTO tblSinhVien(HoTen) VALUES ('Nam')";

                RunSQL(sql);
                LoadDataGribView();
            }
        }

        private void Button_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE FROM tblSinhVien WHERE MaSV=N'" + tb_MaSV.Text + "'";
                RunSQL(sql);
                LoadDataGribView();
                // ResetValue();
            }

        }

        private void Button_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                this.Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGribView();
        }

        

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            String dk = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_MaSV.Text = dk;
            String dk1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_HoTen.Text = dk1;
            String dk2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_ngaySinh.Text = dk2;
            String dk3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_khoa.Text = dk3;
            String dk4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_lop.Text = dk4;
            String dk5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tb_diachi.Text = dk5;
        }

        private void Button_moi_Click(object sender, EventArgs e)
        {
            this.Connect();
            LoadDataGribView();
            tb_MaSV.Focus();
            tb_MaSV.Text = "";
            tb_HoTen.Text = "";
            tb_khoa.Text = "";
            maskedTextBox_ngaySinh.Text = "";
            tb_lop.Text = "";
            tb_diachi.Text = "";
        }

        private void Button_huy_Click(object sender, EventArgs e)
        {
            this.DisConnect();
            dataGridView1.DataSource = null;
        }

        private void DataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
