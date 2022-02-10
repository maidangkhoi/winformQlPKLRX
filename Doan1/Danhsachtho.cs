using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Doan1
{
    public partial class Danhsachtho : Form
    {
        public Danhsachtho()
        {
            InitializeComponent();
        }

        private void Danhsachtho_Load(object sender, EventArgs e)
        {
            LoadDataTho();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "insert into tholaprap values(@maTho,@maTho,@tenTho,@tinhTrang); insert into nhanvien values(@maTho,@maTho2,'1234',1)";
             SqlCommand cmd =conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maTho", SqlDbType.NVarChar).Value = txtmatho.Text;
            cmd.Parameters.Add("@maTho2", SqlDbType.NVarChar).Value = "tho"+txtmatho.Text;
            cmd.Parameters.Add("@tenTho", SqlDbType.NVarChar).Value = txttentho.Text;
            cmd.Parameters.Add("@tinhTrang", SqlDbType.NVarChar).Value = cbbTinhTrang.Text;
            if (txtmatho.Text != "")
            {
                try
                {

                    int rowCount = cmd.ExecuteNonQuery(); MessageBox.Show("Thêm thành công"); LoadDataTho();

                    txtmatho.Text = "";
                    txttentho.Text = "";
                    cbbTinhTrang.SelectedIndex = 0;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm thất bại");
                }
                
            }
            
        }

        public void LoadDataTho()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select * from tholaprap ";  
            //string sql2 = "SELECT tenxe FROM xe ";
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            //DataSet dt2 = new DataSet();
            da.Fill(dt);
            //da2.Fill(dt2,"xe");// đổ dữ liệu vào kho
            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "update tholaprap set tentho = @tenTho,tinhtrang = @tinhTrang where maTho = @maTho";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maTho", SqlDbType.NVarChar).Value = txtmatho.Text;
            cmd.Parameters.Add("@tenTho", SqlDbType.NVarChar).Value = txttentho.Text;
            cmd.Parameters.Add("@tinhTrang", SqlDbType.NVarChar).Value = cbbTinhTrang.Text;
            if (txtmatho.Text != "")
            {
                try
                {

                    int rowCount = cmd.ExecuteNonQuery(); MessageBox.Show("Cập nhật thành công"); LoadDataTho();

                    txtmatho.Text = "";
                    txttentho.Text = "";
                    cbbTinhTrang.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại");
                }

            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtmatho.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            txttentho.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
            cbbTinhTrang.SelectedIndex = cbbTinhTrang.FindString(dataGridView1.Rows[numrow].Cells[3].Value.ToString());
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "delete tholaprap where maTho = @maTho";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maTho", SqlDbType.NVarChar).Value = txtmatho.Text;
            if (txtmatho.Text != "")
            {
                try
                {

                    int rowCount = cmd.ExecuteNonQuery(); MessageBox.Show("Xóa thành công"); LoadDataTho();

                    txtmatho.Text = "";
                    txttentho.Text = "";
                    cbbTinhTrang.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại");
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select * from tholaprap where tentho = N'" + txttimkiem.Text+"'";

            //string sql2 = "SELECT tenxe FROM xe ";
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);
            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt;


            if (dataGridView1.Rows.Count ==1)
            {
                LoadDataTho();
                MessageBox.Show("không tìm thấy thợ");
            }
            //else
            //{
            //    MessageBox.Show(dt.Rows.Count.ToString());
            //    //DataSet dt2 = new DataSet();
            //    da.Fill(dt);
            //    //da2.Fill(dt2,"xe");// đổ dữ liệu vào kho
            //    conn.Close();  // đóng kết nối
            //    dataGridView1.DataSource = dt;
            //}



        }

        private void btnquayve_Click(object sender, EventArgs e)
        {

        }
    }
}
