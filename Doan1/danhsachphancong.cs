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
    public partial class danhsachphancong : Form
    {
        public danhsachphancong(string role,string id)
        {
            InitializeComponent();
            if(role != "") {
                txtrole.Text = role;
            }
            if(id != "")
            {
                txtid.Text = id;
            }
            
        }

        private void danhsachphancong_Load(object sender, EventArgs e)
        {
            txtrole.Visible = false;
            txtid.Visible = false;
            if (Int32.Parse(txtrole.Text) != 0)
            {
                LoadDataPCT();
                btnxoa.Visible = false;
                txtMPC.Enabled = false;
                txtMT.Enabled = false;
                txtMX.Enabled = false;
            }
            else
            {
                btnxoa.Visible = true;
                txtMPC.Enabled = true;
                txtMT.Enabled = true;
                txtMX.Enabled = true;
                LoadDataPCQL();
            }
            //txttimkiem.Visible = false;
            
        }
        public void LoadDataPCT()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select pc.maPC,pc.maXe,x.tenxe,pc.maTho,tlr.tentho,pc.tinhtrang from phancong pc join tholaprap tlr on pc.maTho = tlr.maTho join xe x on pc.maXe = x.maXe where tlr.maTho = '" + txtid.Text+"'";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        public void LoadDataPCQL()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select pc.maPC,pc.maXe,x.tenxe,pc.maTho,tlr.tentho,pc.tinhtrang from phancong pc join tholaprap tlr on pc.maTho = tlr.maTho join xe x on pc.maXe = x.maXe";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select pc.maPC,pc.maXe,x.tenxe,pc.maTho,tlr.tentho,pc.tinhtrang from phancong pc join tholaprap tlr on pc.maTho = tlr.maTho join xe x on pc.maXe = x.maXe where tlr.tentho = N'" + txttimkiem.Text + "'";

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
                LoadDataPCQL();
                MessageBox.Show("không tìm thấy phân công theo thợ");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "delete  phancong  where maPC = @maPC";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maPC", SqlDbType.NVarChar).Value = txtMPC.Text;
            cmd.Parameters.Add("@maXe", SqlDbType.NVarChar).Value = txtMX.Text;
            cmd.Parameters.Add("@maTho", SqlDbType.NVarChar).Value = txtMT.Text;
            cmd.Parameters.Add("@tinhTrang", SqlDbType.NVarChar).Value = cbbTT.Text;
            if (txtMPC.Text != "")
            {
                try
                {
                    int rowCount = cmd.ExecuteNonQuery();
                    txtMPC.Text = "";
                    txtMX.Text = "";
                    txtMT.Text = "";
                    cbbTT.SelectedIndex = 0;
                    LoadDataPCQL();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "update  phancong set maXe = @maXe, maTho = @maTho, tinhtrang = @tinhtrang where maPC = @maPC";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maPC", SqlDbType.NVarChar).Value = txtMPC.Text;
            cmd.Parameters.Add("@maXe", SqlDbType.NVarChar).Value = txtMX.Text;
            cmd.Parameters.Add("@maTho", SqlDbType.NVarChar).Value = txtMT.Text;
            cmd.Parameters.Add("@tinhTrang", SqlDbType.NVarChar).Value = cbbTT.Text;
            if (txtMPC.Text != "")
            {
                try
                {
                    int rowCount = cmd.ExecuteNonQuery();
                    txtMPC.Text = "";
                    txtMX.Text = "";
                    txtMT.Text = "";
                    cbbTT.SelectedIndex = 0;
                    LoadDataPCQL();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật bại");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;


            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select x.tenxe,pk.tenPK from xe x join chitietxe ctx on x.maXe = ctx.maXe join phukien pk on ctx.maPK = pk.maPK where x.maXe ='" + dataGridView1.Rows[numrow].Cells[1].Value.ToString() + "';";
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);
            var ten = dt.Rows[0].ItemArray[0].ToString();
            var dau = dt.Rows[0].ItemArray[1].ToString();
            var duoi = dt.Rows[1].ItemArray[1].ToString();
            var than = dt.Rows[2].ItemArray[1].ToString();
            var dongho = dt.Rows[3].ItemArray[1].ToString();
            var dongco = dt.Rows[4].ItemArray[1].ToString();
            var may = dt.Rows[5].ItemArray[1].ToString();
            var banh = dt.Rows[6].ItemArray[1].ToString();
            txtMPC.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString(); ;
            txtMX.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString(); ;
            txtMT.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString(); ;
            cbbTT.SelectedIndex = cbbTT.FindString(dataGridView1.Rows[numrow].Cells[5].Value.ToString());
            txtdau.Text = dau;
            txtduoi.Text = duoi;
            txttenxe.Text = ten;
            txtthan.Text = than;
            txtdongho.Text = dongho;
            txtdongco.Text = dongco;
            txtmay.Text = may;
            txtbanh.Text = banh;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
