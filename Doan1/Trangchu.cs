using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan1
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Trangchu_Load(object sender, EventArgs e)
        {

        }

        private void btnlaprap_Click(object sender, EventArgs e)
        {
            laprap frmlaprap = new laprap();
            frmlaprap.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnlaprap_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            laprap lr = new laprap();
            lr.Show();
        }

        private void btntho_Click(object sender, EventArgs e)
        {
            Danhsachtho tho = new Danhsachtho();
            tho.Show();
        }

        private void btnphukien_Click(object sender, EventArgs e)
        {
            khophukien pk = new khophukien();
            pk.Show();
        }

        private void btnphancong_Click(object sender, EventArgs e)
        {
            danhsachphancong pc = new danhsachphancong("0"," ");
            pc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            danhSachXe xe = new danhSachXe();
            xe.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            danhSachLoaiPhuKien lpk = new danhSachLoaiPhuKien();
            lpk.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            danhSachNhaCungCap ncc = new danhSachNhaCungCap();
            ncc.Show();
        }
        private void logout(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dn.Show();
            this.Hide();
        }
    }
}
