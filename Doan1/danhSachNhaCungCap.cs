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
    public partial class danhSachNhaCungCap : Form
    {
        public danhSachNhaCungCap()
        {
            InitializeComponent();
        }

        private void danhSachNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDataNCC();
        }
        public void LoadDataNCC()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select * from nhacungcap";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "insert into nhacungcap values(@maNCC, @tenNCC,@xuatXu)";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maNCC", SqlDbType.NVarChar).Value = txtMNCC.Text;
            cmd.Parameters.Add("@tenNCC", SqlDbType.NVarChar).Value = txtTNCC.Text;
            cmd.Parameters.Add("@xuatXu", SqlDbType.NVarChar).Value = txtXX.Text;
            if (txtMNCC.Text != "")
            {
                try
                {
                    int rowCount = cmd.ExecuteNonQuery();
                    txtMNCC.Text = "";
                    txtTNCC.Text = "";
                    txtXX.Text = "";
                    LoadDataNCC();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "update  nhacungcap set tennhacungcap = @tenNCC, xuatxu  = @xuatXu where maNCC = @maNCC";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maNCC", SqlDbType.NVarChar).Value = txtMNCC.Text;
            cmd.Parameters.Add("@tenNCC", SqlDbType.NVarChar).Value = txtTNCC.Text;
            cmd.Parameters.Add("@xuatXu", SqlDbType.NVarChar).Value = txtXX.Text;
            if (txtMNCC.Text != "")
            {
                try
                {
                    int rowCount = cmd.ExecuteNonQuery();
                    txtMNCC.Text = "";
                    txtTNCC.Text = "";
                    txtXX.Text = "";
                    LoadDataNCC();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật bại");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "delete nhacungcap where maNCC = @maNCC";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maNCC", SqlDbType.NVarChar).Value = txtMNCC.Text;
            if (txtMNCC.Text != "")
            {
                try
                {
                    int rowCount = cmd.ExecuteNonQuery();
                    txtMNCC.Text = "";
                    txtTNCC.Text = "";
                    txtXX.Text = "";
                    LoadDataNCC();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMNCC.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            txtTNCC.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            txtXX.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select * from nhacungcap where tennhacungcap = N'" + txttimkiem.Text + "'";

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
                LoadDataNCC();
                MessageBox.Show("không tìm thấy nhà cung cấp");
            }
        }
    }
}
