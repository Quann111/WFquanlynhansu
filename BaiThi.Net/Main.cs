using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiThi.Net
{
    public partial class frmMain : Form
    {
        Clsdatabase cls = new Clsdatabase();
        int i = 0;

        Login lg = new Login();
        public frmMain(string loaiTK)
        {
            //PHAN VUNG ADMIN VS USER
            InitializeComponent();
            this.IsMdiContainer = true;

            if (loaiTK == "1")
            {
                mnuDanhmuc.Enabled = true;
                mnuQLhoso.Enabled = true;
                mnuQLHthong.Enabled = true;
            }
            if (loaiTK == "0")
            {
                mnuDanhmuc.Enabled = false;
                mnuQLhoso.Enabled = true;
                mnuQLHthong.Enabled = false;
            }



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chứcCụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phòngNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhansu fc = new frmNhansu();
            fc.MdiParent = this;
            fc.Show();
            groupBox1.Hide();
        }

        private void mnuDanhmuc_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhongban fc = new frmPhongban();
            fc.MdiParent = this;
            fc.Show();
            groupBox1.Hide();

        }

        private void lươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khaiBáoHồSơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongtinNVthuVC fc = new frmThongtinNVthuVC();
            fc.MdiParent = this;
            fc.Show();
            groupBox1.Hide();

        }

        private void hồSơNhânViênThôiViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSthoivc fc = new frmDSthoivc();
            fc.MdiParent = this;
            fc.Show();
            groupBox1.Hide();

        }

        private void nhânViênThửViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLuongNVthuviec fc = new frmLuongNVthuviec();
            fc.MdiParent = this;
            fc.Show();
            groupBox1.Hide();

        }

        private void nhânViênChínhThứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLuongnvCT fc = new frmLuongnvCT();
            fc.MdiParent = this;
            fc.Show();
            groupBox1.Hide();

        }

        //PHÂN QUYỀN C2




        private void frmMain_Load(object sender, EventArgs e, string loaiTK)
        {
            /*   if (loaiTK == "Admin")
               {
                   mnuDanhmuc.Enabled = true;
                   mnuQLhoso.Enabled = true;
                   mnuQLHthong.Enabled = true;
               }
               else if (loaiTK == "user")
               {
                   mnuDanhmuc.Enabled = false;
                   mnuQLhoso.Enabled = true;
                   mnuQLHthong.Enabled = false;
               }*/
            this.IsMdiContainer = true;

            if (loaiTK == "1")
            {
                mnuDanhmuc.Enabled = true;
                mnuQLhoso.Enabled = true;
                mnuQLHthong.Enabled = true;
            }
            if (loaiTK == "0 ")
            {
                mnuDanhmuc.Enabled = false;
                mnuQLhoso.Enabled = true;
                mnuQLHthong.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            try
            {

                if ((textBox1.Text == "") || (textBox1.Text == ""))
                {
                    cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
                }
                else
                {

                    if (i == 1)
                    {
                        cls.loatextbox(textBox1, "select * from TblTTNVCoBan where MaNV like N'" + textBox1.Text + "%'", 2);
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where MaNV like N'" + textBox1.Text + "%'");
                    }
                    if (i == 2)
                    {
                        cls.loatextbox(textBox1, "select * from TblTTNVCoBan where MaNV like N'" + textBox1.Text + "%'", 3);
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where HoTen like N'" + textBox1.Text + "%'");
                    }
                    if (i == 3)
                    {
                        cls.loatextbox(textBox1, "select * from TblTTNVCoBan where MaNV like N'" + textBox1.Text + "%'", 8);
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where CMTND like N'" + textBox1.Text + "%'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("tìm kiếm sai");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox1.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where MaNV=N'" + textBox1.Text + "'");
                    }
                    if (i == 2)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where HoTen=N'" + textBox1.Text + "'");
                    }
                    if (i == 3)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where CMTND=N'" + textBox1.Text + "'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdoiMK fc = new frmdoiMK();
            fc.MdiParent = this;
            fc.Show();
            groupBox1.Hide();

        }

        private void thêmMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
#pragma warning disable CS0246 // The type or namespace name 'frm' could not be found (are you missing a using directive or an assembly reference?)
            frmthemTK fc = new frmthemTK();
#pragma warning restore CS0246 // The type or namespace name 'frm' could not be found (are you missing a using directive or an assembly reference?)
            fc.MdiParent = this;
            fc.Show();
            groupBox1.Hide();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login fc = new Login();
            fc.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
