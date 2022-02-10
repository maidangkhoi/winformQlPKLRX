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
    public partial class danhSachXe : Form
    {
        public danhSachXe()
        {
            InitializeComponent();
        }

        private void danhSachXe_Load(object sender, EventArgs e)
        {
            LoadDataXe();
        }
        public void LoadDataXe()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select * from xe";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "update xe set tenxe = @tenXe where maXe = @maXe";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maXe", SqlDbType.NVarChar).Value = txtMX.Text;
            cmd.Parameters.Add("@tenXe", SqlDbType.NVarChar).Value = txtTX.Text;
            if (txtMX.Text != "")
            {
                try
                {
                    int rowCount = cmd.ExecuteNonQuery();
                    txtMX.Text = "";
                    txtTX.Text = "";
                    LoadDataXe();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "delete xe where maXe = @maXe";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maXe", SqlDbType.NVarChar).Value = txtMX.Text;
            cmd.Parameters.Add("@tenXe", SqlDbType.NVarChar).Value = txtTX.Text;
            if (txtMX.Text != "")
            {
                try
                {
                    int rowCount = cmd.ExecuteNonQuery();
                    txtMX.Text = "";
                    txtTX.Text = "";
                    LoadDataXe();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "insert into xe values(@maXe, @tenXe)";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maXe", SqlDbType.NVarChar).Value = txtMX.Text;
            cmd.Parameters.Add("@tenXe", SqlDbType.NVarChar).Value = txtTX.Text;
            if (txtMX.Text != "")
            {
                try {
                    int rowCount = cmd.ExecuteNonQuery();
                    txtMX.Text = "";
                    txtTX.Text = "";
                    LoadDataXe();
                    MessageBox.Show("Thêm thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            //else
            //{
            //    MessageBox.Show("Thêm thất bại");
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMX.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            txtTX.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select * from xe where tenxe = N'" + txttimkiem.Text + "'";

            //string sql2 = "SELECT tenxe FROM xe ";
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);
            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt;


            if (dataGridView1.Rows.Count == 1)
            {
                LoadDataXe();
                MessageBox.Show("không tìm thấy xe");
            }
        }
    }
}
