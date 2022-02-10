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
    public partial class khophukien : Form
    {
        public khophukien()
        {
            InitializeComponent();
        }

        private void khophukien_Load(object sender, EventArgs e)
        {
            LoadDataPK();
            LoadComboBoxLPK();
            LoadComboBoxNCC();
        }

        public void LoadDataPK()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select * from phukien";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        void LoadComboBoxLPK()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var cmd = new SqlCommand("select tenloai from loaiphukien", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbLPK.DisplayMember = "tenloai";
            cbbLPK.DataSource = dt;
        }
        void LoadComboBoxNCC()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var cmd = new SqlCommand("select tennhacungcap from nhacungcap", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbNCC.DisplayMember = "tennhacungcap";
            cbbNCC.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select tennhacungcap from nhacungcap where maNCC ='" + dataGridView1.Rows[numrow].Cells[2].Value.ToString() + "';";
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);
            var NCC = dt.Rows[0].ItemArray[0].ToString();
            string sql2 = "select tenloai from loaiphukien where maLPK =  '" + dataGridView1.Rows[numrow].Cells[1].Value.ToString() + "'";
            SqlCommand com2 = new SqlCommand(sql2, conn); //bat dau truy van
            com2.CommandType = CommandType.Text;
            SqlDataAdapter da2 = new SqlDataAdapter(com2);
            DataTable dt2 = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da2.Fill(dt2);
            var LPK = dt2.Rows[0].ItemArray[0].ToString();

            txtMPK.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            txtTPK.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
            txtSL.Text = dataGridView1.Rows[numrow].Cells[5].Value.ToString();
            txtDVT.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
            cbbNCC.SelectedIndex = cbbNCC.FindString(NCC);
            cbbLPK.SelectedIndex = cbbLPK.FindString(LPK);
        }

        private void btnnhaphang_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "insert into phukien values(@maPK, (select maLPK from loaiphukien where  tenloai = @maLPK)   ,(select maNCC  from nhacungcap where tennhacungcap = @maNCC) ,@tenPK,@dvt,@sl)";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maPK", SqlDbType.NVarChar).Value = txtMPK.Text;
            cmd.Parameters.Add("@maLPK", SqlDbType.NVarChar).Value = cbbLPK.Text;
            cmd.Parameters.Add("@maNCC", SqlDbType.NVarChar).Value = cbbNCC.Text;
            cmd.Parameters.Add("@tenPK", SqlDbType.NVarChar).Value = txtTPK.Text;
            cmd.Parameters.Add("@dvt", SqlDbType.NVarChar).Value = txtDVT.Text;
            cmd.Parameters.Add("@sl", SqlDbType.Int).Value =txtSL.Text;

            
            
            if (txtMPK.Text != "")
            {

                try
                {
                    int rowCount = cmd.ExecuteNonQuery();
                    txtMPK.Text = "";
                    txtTPK.Text = "";
                    txtSL.Text = "";
                    txtDVT.Text = "";
                    cbbNCC.SelectedIndex = 0;
                    cbbLPK.SelectedIndex = 0;
                    LoadDataPK();
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
            string sql = "update phukien set maLPK = (select maLPK from loaiphukien where  tenloai = @maLPK),maNCC = (select maNCC  from nhacungcap where tennhacungcap = @maNCC),tenPK = @tenPK,dvt = @dvt,soluong = @sl where maPK = @maPK";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maPK", SqlDbType.NVarChar).Value = txtMPK.Text;
            cmd.Parameters.Add("@maLPK", SqlDbType.NVarChar).Value = cbbLPK.Text;
            cmd.Parameters.Add("@maNCC", SqlDbType.NVarChar).Value = cbbNCC.Text;
            cmd.Parameters.Add("@tenPK", SqlDbType.NVarChar).Value = txtTPK.Text;
            cmd.Parameters.Add("@dvt", SqlDbType.NVarChar).Value = txtDVT.Text;
            cmd.Parameters.Add("@sl", SqlDbType.Int).Value = txtSL.Text;
            if(txtMPK.Text != "" && Int32.Parse(txtSL.Text)  >= 0) {

                try
                {
                    int rowCount = cmd.ExecuteNonQuery();
                    txtMPK.Text = "";
                    txtTPK.Text = "";
                    txtSL.Text = "";
                    txtDVT.Text = "";
                    cbbNCC.SelectedIndex = 0;
                    cbbLPK.SelectedIndex = 0;
                    LoadDataPK();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại");
                }

                
            }else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "delete phukien where maPK = @maPK";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maPK", SqlDbType.NVarChar).Value = txtMPK.Text;
            if (txtMPK.Text != "")
            {

                try
                {
                    int rowCount = cmd.ExecuteNonQuery();
                    txtMPK.Text = "";
                    txtTPK.Text = "";
                    txtSL.Text = "";
                    txtDVT.Text = "";
                    cbbNCC.SelectedIndex = 0;
                    cbbLPK.SelectedIndex = 0;
                    LoadDataPK();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại");
                }
                
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select * from phukien where tenPK = N'" + txttimkiem.Text + "'";

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
                LoadDataPK();
                MessageBox.Show("không tìm thấy phụ kiện");
            }
        }
    }
}
