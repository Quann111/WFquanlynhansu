using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThi.Net
{
    public partial class frmLuongNVthuviec : Form
    {
        public frmLuongNVthuviec()
        {
            InitializeComponent();
        }
        Clsdatabase cls = new Clsdatabase();
        public static SqlConnection Con;
        DataSet ds1 = new DataSet();
        

        private void frmLuongNVthuviec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet.TblHoSoThuViec' table. You can move, or remove it, as needed.
            this.tblHoSoThuViecTableAdapter.Fill(this.qLNSDataSet.TblHoSoThuViec);
            // TODO: This line of code loads data into the 'qLNSDataSet.TblBangCongThuViec' table. You can move, or remove it, as needed.
            this.tblBangCongThuViecTableAdapter.Fill(this.qLNSDataSet.TblBangCongThuViec);
            // TODO: This line of code loads data into the 'qLNSDataSet.TblTTNVCoBan' table. You can move, or remove it, as needed.
            this.tblTTNVCoBanTableAdapter.Fill(this.qLNSDataSet.TblTTNVCoBan);


        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txt2, "select * from TblPhongBan b,TblHoSoThuViec a where a.MaPhong=b.MaPhong and MaNVTV='" + cb1.Text + "'", 2);
            cls.loadtextboxchiso(txt1, "select * from TblBoPhan,TblPhongBan where TblPhongBan.MaBoPhan=TblBoPhan.MaBoPhan and TenPhong=N'" + txt2.Text + "'", 1);
            cls.loadtextboxchiso(txt3, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 3);
            cls.loadtextboxchiso(txt4, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 4);
            cls.loadtextboxchiso(txt5, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 5);
            cls.loadtextboxchiso(txt6, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 6);
            cls.loadtextboxchiso(txt7, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 7);
            cls.loadtextboxchiso(txt8, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 8);
            cls.loadtextboxchiso(textBox3, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 9);
            cls.loadtextboxchiso(txt9, "select * from TblBangCongThuViec where MaNVTV='" + cb1.Text + "'", 10);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cb1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txt7.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txt8.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            txt9.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string insert = "insert into TblBangCongThuViec values(N'" + txt1.Text + "',N'" + txt2.Text + "',N'" + cb1.Text + "',N'" + txt3.Text + "',N'" + txt4.Text + "',N'" + txt5.Text + "',N'" + txt6.Text + "',N'" + txt7.Text + "',N'" + txt8.Text + "',N'" + textBox3.Text + "',N'" + txt9.Text + "')";
            if (!cls.kttrungkhoa(cb1.Text, "select MaNVTV from TblBangCongThuViec"))
            {
                if (cb1.Text != "")
                {
                    cls.thucthiketnoi(insert);
                    dataGridView1.Refresh();
                    cls.loaddatagridview1(dataGridView1, ds1, "select * from TblBangCongThuViec");

                }
                else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
            }
            else
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblBangCongThuViec set TenBoPhan=N'" + txt1.Text + "',TenPhong=N'" + txt2.Text + "',LuongTViec=N'" + txt3.Text + "',Thang=N'" + txt4.Text + "',Nam='" + txt5.Text + "',SoNgayCong=N'" + txt6.Text + "',SoNgayNghi=N'" + txt7.Text + "',SoGioLamThem=N'" + txt8.Text + "',Luong=N'" + textBox3.Text + "',GhiChu='" + txt9.Text + "' where MaNVTV=N'" + cb1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView1, ds1, "select * from TblBangCongThuViec");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblBangCongThuViec where MaNVTV=N'" + cb1.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dataGridView1, ds1, "select * from TblBangCongThuViec");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int l = Convert.ToInt32(txt3.Text);
            int nc = Convert.ToInt32(txt6.Text);
            int lt = Convert.ToInt32(txt8.Text);
            float luong = ((l / 26) * nc + (lt * 40000));
            textBox3.Text = luong.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

