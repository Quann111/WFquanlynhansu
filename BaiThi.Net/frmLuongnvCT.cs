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
    public partial class frmLuongnvCT : Form
    {
        public frmLuongnvCT()
        {
            InitializeComponent();
        }
        Clsdatabase cls = new Clsdatabase();
        public static SqlConnection Con;
        DataSet ds2 = new DataSet();

        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {

            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị


        }

        private void frmLuongnvCT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet.TblPhongBan' table. You can move, or remove it, as needed.
            this.tblPhongBanTableAdapter.Fill(this.qLNSDataSet.TblPhongBan);
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-N5JKS23\sqlexpress;Initial Catalog=QLNS;Integrated Security=True";

            cls.loadcombobox(cb2, "select MaNV from TblCongKhoiDieuHanh", 0);

           // FillCombo("SELECT TenPhong FROM TblPhongBan", comboBox10, "TenPhong", "TenPhong");
           // comboBox10.SelectedIndex = -1;

            cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh ");
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txt50, "select * from TblTTNVCoBan where MaNV='" + cb2.Text + "'", 4);
            cls.loadtextboxchiso(txt10, "select * from TblBangLuongCTy l where l.MaLuong='" + txt50.Text + "'", 1);
            cls.loadtextboxchiso(txt11, "select * from TblBangLuongCTy l where l.MaLuong='" + txt50.Text + "'", 2);
            //cls.loadtextboxchiso(txt10, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 4);
            cls.loadtextboxchiso(txt53, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 2);
            //cls.loadtextboxchiso(txt51, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 3);
            // cls.loadtextboxchiso(txt11, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 5);
            cls.loadtextboxchiso(txt12, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 6);
            cls.loadtextboxchiso(textBox1, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 7);
            cls.loadtextboxchiso(textBox2, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 8);
            cls.loadtextboxchiso(txt13, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 9);
            cls.loadtextboxchiso(txt14, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 10);
            cls.loadtextboxchiso(txt15, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 11);
            cls.loadtextboxchiso(txt16, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 12);
            cls.loadtextboxchiso(txt17, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 13);
            cls.loadtextboxchiso(txt52, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 14);
            cls.loadtextboxchiso(txt18, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 15);
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            //frmLuongnvCT.FillCombo("select MaNV from TblCongKhoiDieuHanh where TenPhong=(select top(1) TenPhong from TblPhongBan a, TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.TenPhong=N'" + comboBox10.SelectedValue + "' group by TenPhong)", cb2, "MaNV", "MaNV");
            //cb2.DisplayMember = "MaNV";
            //cb2.ValueMember = "MaNV";
            // cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh b where b.TenPhong=N'" + comboBox10.SelectedValue + "'");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cb2.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txt10.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            txt53.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txt50.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            comboBox10.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txt11.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            txt12.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            textBox1.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            textBox2.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            txt13.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
            txt14.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();
            txt15.Text = dataGridView2.Rows[i].Cells[11].Value.ToString();
            txt16.Text = dataGridView2.Rows[i].Cells[12].Value.ToString();
            txt17.Text = dataGridView2.Rows[i].Cells[13].Value.ToString();
            txt52.Text = dataGridView2.Rows[i].Cells[14].Value.ToString();
            txt18.Text = dataGridView2.Rows[i].Cells[15].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblCongKhoiDieuHanh set MaNV='" + cb2.Text + "', MaLuong=N'" + txt50.Text + "',TenPhong=N'" + comboBox10.Text + "', HoTen=N'" + txt53.Text + "',LCB=N'" + txt10.Text + "',PCChucVu=N'" + txt11.Text + "',PCapKhac=N'" + txt12.Text + "',Thuong=N'" + textBox1.Text + "',KyLuat='" + textBox2.Text + "',Thang=N'" + txt13.Text + "',Nam='" + txt14.Text + "',SoNgayCongThang=N'" + txt15.Text + "',SoNgayNghi=N'" + txt16.Text + "',SoGioLamThem=N'" + txt17.Text + "',Luong=N'" + txt52.Text + "',GhiChu='" + txt18.Text + "' where MaNV=N'" + cb2.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh where TenPhong=N'" + comboBox10.SelectedValue + "'");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblCongKhoiDieuHanh where MaNV=N'" + cb2.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int lcb = Convert.ToInt32(txt10.Text);
            int pc = Convert.ToInt32(txt11.Text);
            int pck = Convert.ToInt32(txt12.Text);
            int nc = Convert.ToInt32(txt15.Text);
            int lt = Convert.ToInt32(txt17.Text);
            int th = Convert.ToInt32(textBox1.Text);
            int kl = Convert.ToInt32(textBox2.Text);

            float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck + th - kl);
            txt52.Text = luong.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox4.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }
    }
}
