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
    public partial class doimatkhau : Form
    {
        public doimatkhau()
        {
            InitializeComponent();
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "update  nhanvien set matkhau = @matKhauMoi  where taikhoan = @tenDN and matkhau = @matKhau";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@tenDN", SqlDbType.NVarChar).Value = txttdn.Text;
            cmd.Parameters.Add("@matKhau", SqlDbType.NVarChar).Value = txtmatkhaucu.Text;
            cmd.Parameters.Add("@matKhauMoi", SqlDbType.NVarChar).Value = txtmatkhaumoi.Text;
            if (txtmatkhaumoi.Text == txtnhaplaimatkhau.Text)
            {
                try
                {
                    int rowCount = cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Đổi mật khẩu thành công");
                    dangnhap dn = new dangnhap();
                    dn.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đổi mật khẩu thất bại");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp");
            }
        }
    }
}
