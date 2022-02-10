using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Doan1
{
    public partial class laprap : Form
    {
        public laprap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Trangchu frmtrangchu = new Trangchu();
            frmtrangchu.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void laprap_Load(object sender, EventArgs e)
        {
            LoadDataPhanCong();
            LoadComboBoxXe();
            LoadComboBoxTho();
            LoadComboBoxBanhxe();
            LoadComboBoxDauxe();
            LoadComboBoxthanxe();
            LoadComboBoxDonghoxe();
            LoadComboBoxDongco();
            LoadComboBoxmayxe();
            LoadComboBoxduoixe();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        public void LoadDataPhanCong()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT x.tenxe, pc.maPC,tlr.tentho,pc.tinhtrang from  xe x join phancong pc on pc.maXe=x.maXe join tholaprap tlr on tlr.maTho=pc.maTho";  // lay het du lieu trong bang sinh vien
            //string sql2 = "SELECT tenxe FROM xe ";
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            //DataSet dt2 = new DataSet();
            da.Fill(dt);
            //da2.Fill(dt2,"xe");// đổ dữ liệu vào kho
            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
            //cbxe.DisplayMember = "xe";
            //cbxe.ValueMember = "xe";
            //cbxe.DataSource = dt2.Tables["xe"];
        }
        public void LoadComboBoxXe()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var cmd = new SqlCommand("SELECT tenxe FROM xe ",conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbxe.DisplayMember="tenxe";
            cbxe.DataSource = dt;
        }

        private void cbntlr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void LoadComboBoxTho()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var cmd = new SqlCommand("SELECT tentho FROM tholaprap where tinhtrang = 'rảnh'", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbtlr.DisplayMember = "tentho";
            cbtlr.DataSource = dt;
        }

        void LoadComboBoxDauxe()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var cmd = new SqlCommand("SELECT pk.tenPK  FROM phukien pk join loaiphukien lpk on lpk.maLPK = pk.maLPK where lpk.maLPK = 'D'", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbdauxe.DisplayMember = "tenPK";
            cbdauxe.DataSource = dt;
        }
        void LoadComboBoxBanhxe()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var cmd = new SqlCommand("SELECT pk.tenPK  FROM phukien pk join loaiphukien lpk on lpk.maLPK = pk.maLPK where lpk.maLPK = 'B'", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbanhxe.DisplayMember = "tenPK";
            cbbanhxe.DataSource = dt;
        }
        void LoadComboBoxDongco()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var cmd = new SqlCommand("SELECT pk.tenPK  FROM phukien pk join loaiphukien lpk on lpk.maLPK = pk.maLPK where lpk.maLPK = 'DC'", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbdongco.DisplayMember = "tenPK";
            cbdongco.DataSource = dt;
        }
        void LoadComboBoxDonghoxe()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var cmd = new SqlCommand("SELECT pk.tenPK  FROM phukien pk join loaiphukien lpk on lpk.maLPK = pk.maLPK where lpk.maLPK = 'DH'", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbdonghoxe.DisplayMember = "tenPK";
            cbdonghoxe.DataSource = dt;
        }
        void LoadComboBoxduoixe()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var cmd = new SqlCommand("SELECT pk.tenPK  FROM phukien pk join loaiphukien lpk on lpk.maLPK = pk.maLPK where lpk.maLPK = 'DD'", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbduoixe.DisplayMember = "tenPK";
            cbduoixe.DataSource = dt;
        }
        void LoadComboBoxmayxe()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var cmd = new SqlCommand("SELECT pk.tenPK  FROM phukien pk join loaiphukien lpk on lpk.maLPK = pk.maLPK where lpk.maLPK = 'M'", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbmayxe.DisplayMember = "tenPK";
            cbmayxe.DataSource = dt;
        }
        void LoadComboBoxthanxe()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var cmd = new SqlCommand("SELECT pk.tenPK  FROM phukien pk join loaiphukien lpk on lpk.maLPK = pk.maLPK where lpk.maLPK = 'T'", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbthanxe.DisplayMember = "tenPK";
            cbthanxe.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        { 
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string var;
            var = cbxe.Text;
            var iteam = this.cbxe.GetItemText(this.cbxe.SelectedItem);
            string sql = "SELECT pk.tenPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe='" + var+"'";
            var cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //cbdauxe.SelectedIndex = cbdauxe.FindString("Đầu xe 2");
            //string test = 'Đầu xe AB 2';
            //cbdauxe.SelectedValue = test;
            //cbxe.SelectedIndex = cbxe.Items.IndexOf(gridView1.GetFocusedRowCellValue("vVendor"));
            //cbdauxe.SelectedIndex = cbdauxe.FindString(dt.Rows[1].ItemArray[0].ToString());
            //cbbanhxe.SelectedIndex = cbbanhxe.FindString(dt.Rows[2].ItemArray[0].ToString());
            //cbdongco.SelectedIndex = cbdongco.FindString(dt.Rows[6].ItemArray[0].ToString());
            //cbmayxe.SelectedIndex = cbmayxe.FindString(dt.Rows[3].ItemArray[0].ToString());
            //cbduoixe.SelectedIndex = cbduoixe.FindString(dt.Rows[2].ItemArray[0].ToString());
            //cbdonghoxe.SelectedIndex = cbdonghoxe.FindString(dt.Rows[5].ItemArray[0].ToString());
            //cbthanxe.SelectedIndex = cbthanxe.FindString(dt.Rows[4].ItemArray[0].ToString());
            conn.Close();  // đóng kết nối

            LoadComboBoxBanhxe();
            LoadComboBoxDauxe();
            LoadComboBoxthanxe();
            LoadComboBoxDonghoxe();
            LoadComboBoxDongco();
            LoadComboBoxmayxe();
            LoadComboBoxduoixe();
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (cbdauxe.FindString(dt.Rows[i].ItemArray[j].ToString().Trim()) >0)
                    {
                        cbdauxe.SelectedIndex = cbdauxe.FindString(dt.Rows[i].ItemArray[j].ToString().Trim());
                    }
                    if (cbbanhxe.FindString(dt.Rows[i].ItemArray[j].ToString()) > 0)
                    {
                        cbbanhxe.SelectedIndex = cbbanhxe.FindString(dt.Rows[i].ItemArray[j].ToString());
                    }
                    if (cbdongco.FindString(dt.Rows[i].ItemArray[j].ToString()) >0)
                    {
                        cbdongco.SelectedIndex = cbdongco.FindString(dt.Rows[i].ItemArray[j].ToString());
                    }
                    if (cbmayxe.FindString(dt.Rows[i].ItemArray[j].ToString()) >0)
                    {
                        cbmayxe.SelectedIndex = cbmayxe.FindString(dt.Rows[i].ItemArray[j].ToString());
                    }
                    if (cbduoixe.FindString(dt.Rows[i].ItemArray[j].ToString()) >0)
                    {
                        cbduoixe.SelectedIndex = cbduoixe.FindString(dt.Rows[i].ItemArray[j].ToString());
                    }
                    if (cbdonghoxe.FindString(dt.Rows[i].ItemArray[j].ToString())>0)
                    {
                        cbdonghoxe.SelectedIndex = cbdonghoxe.FindString(dt.Rows[i].ItemArray[j].ToString());
                    }
                    if (cbthanxe.FindString(dt.Rows[i].ItemArray[j].ToString()) >0)
                    {
                        cbthanxe.SelectedIndex = cbthanxe.FindString(dt.Rows[i].ItemArray[j].ToString());
                    }
                    
                }
            }
            
            
            
            
            
        }

        private void cbdauxe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnphancong_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "insert into phancong values((select maXe from xe where tenxe = @maXe),(select maTho from tholaprap where tentho = @maTho),N'Chưa hoàn thành'); update tholaprap set tinhtrang = N'bận' where tentho = @maTho; IF (NOT EXISTS(SELECT * FROM chitietxe WHERE maXe = (select maXe from xe where tenxe = @tenXe)) ) BEGIN INSERT INTO chitietxe VALUES((select maXe from xe where tenxe = @tenXe),(select maPK from phukien where tenPK = @dauXe)), ((select maXe from xe where tenxe = @tenXe),(select maPK from phukien where tenPK = @duoiXe)), ((select maXe from xe where tenxe = @tenXe),(select maPK from phukien where tenPK = @dongHoXe)), ((select maXe from xe where tenxe = @tenXe),(select maPK from phukien where tenPK = @dongCoXe)), ((select maXe from xe where tenxe = @tenXe),(select maPK from phukien where tenPK = @banhXe)), ((select maXe from xe where tenxe = @tenXe),(select maPK from phukien where tenPK = @mayXe)), ((select maXe from xe where tenxe = @tenXe),(select maPK from phukien where tenPK = @thanXe)) END ELSE BEGIN UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = @dauXe) WHERE maXe = (select maXe from xe where tenxe = @tenXe) AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= @tenXe and pk.maLPK = 'D'); UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = @duoiXe) WHERE maXe = (select maXe from xe where tenxe = @tenXe) AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= @tenXe and pk.maLPK = 'DD') UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = @dongHoXe) WHERE maXe = (select maXe from xe where tenxe = @tenXe) AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= @tenXe and pk.maLPK = 'DH') UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = @dongCoXe) WHERE maXe = (select maXe from xe where tenxe = @tenXe) AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= @tenXe and pk.maLPK = 'DC') UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = @banhXe) WHERE maXe = (select maXe from xe where tenxe = @tenXe) AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= @tenXe and pk.maLPK = 'B') UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = @mayXe) WHERE maXe = (select maXe from xe where tenxe = @tenXe) AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= @tenXe and pk.maLPK = 'M') UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = @thanXe) WHERE maXe = (select maXe from xe where tenxe = @tenXe) AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= @tenXe and pk.maLPK = 'T') END ; update phukien set soluong = (select soluong from phukien where tenPK = @dauXe ) - 1 where tenPK = @dauXe; update phukien set soluong = (select soluong from phukien where tenPK = @thanXe ) - 1 where tenPK = @thanXe; update phukien set soluong = (select soluong from phukien where tenPK = @duoiXe ) - 1 where tenPK = @duoiXe; update phukien set soluong = (select soluong from phukien where tenPK = @dongHoXe ) - 1 where tenPK = @dongHoXe; update phukien set soluong = (select soluong from phukien where tenPK = @dongCoXe ) - 1 where tenPK = @dongCoXe; update phukien set soluong = (select soluong from phukien where tenPK = @banhXe ) - 1 where tenPK = @banhXe; update phukien set soluong = (select soluong from phukien where tenPK = @mayXe ) - 1 where tenPK = @mayXe;";
            SqlCommand cmd =conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@maXe", SqlDbType.NVarChar).Value =  cbxe.Text;
            cmd.Parameters.Add("@maTho", SqlDbType.NVarChar).Value = cbtlr.Text;
            cmd.Parameters.Add("@tenXe", SqlDbType.NVarChar).Value = cbxe.Text;
            cmd.Parameters.Add("@dauXe", SqlDbType.NVarChar).Value = cbdauxe.Text;
            cmd.Parameters.Add("@banhXe", SqlDbType.NVarChar).Value = cbbanhxe.Text;
            cmd.Parameters.Add("@duoiXe", SqlDbType.NVarChar).Value = cbduoixe.Text;
            cmd.Parameters.Add("@dongHoXe", SqlDbType.NVarChar).Value = cbdonghoxe.Text;
            cmd.Parameters.Add("@dongCoXe", SqlDbType.NVarChar).Value = cbdongco.Text;
            cmd.Parameters.Add("@mayXe", SqlDbType.NVarChar).Value = cbmayxe.Text;
            cmd.Parameters.Add("@thanXe", SqlDbType.NVarChar).Value = cbthanxe.Text;
            
            if(cbtlr.Text != "") { int rowCount = cmd.ExecuteNonQuery(); } else
            {
                MessageBox.Show("tất cả thợ đều bận");
            }
            LoadComboBoxTho();
            cbtlr.Text = "";
            LoadDataPhanCong();
        }
    }
}
