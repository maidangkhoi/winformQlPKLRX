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
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "select * from nhanvien where taikhoan = '"+txttaikhoan.Text+"' and matkhau = '"+txtmatkhau.Text+"'";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            conn.Close();  // đóng kết nối
            //MessageBox.Show(dt.Rows[0].ItemArray[0].ToString());
            if(Int32.Parse( dt.Rows[0].ItemArray[3].ToString()) == 0)
            {
                Trangchu frmtrangchu = new Trangchu();
                frmtrangchu.ShowDialog();
            }else
            {
                danhsachphancong pc = new danhsachphancong(dt.Rows[0].ItemArray[3].ToString(), dt.Rows[0].ItemArray[0].ToString());
                pc.Show();
            }
            
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            doimatkhau dmk = new doimatkhau();
            dmk.Show();
            this.Hide();
        }
    }
}
