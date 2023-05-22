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
    public partial class frmDSthoivc : Form
    {
        public frmDSthoivc()
        {
            InitializeComponent();
        }
        Clsdatabase cls = new Clsdatabase();
        public static SqlConnection Con;
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {

            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void frmDSthoivc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet.TblNVThoiViec' table. You can move, or remove it, as needed.
            this.tblNVThoiViecTableAdapter.Fill(this.qLNSDataSet.TblNVThoiViec);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            textBox4.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox9.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dateTimePicker3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox19.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
           // txtMa.Text = dgv.Rows[i].Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblNVThoiViec where HoTen=N'" + textBox4.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dataGridView1, "select * from TblNVThoiViec");
            }
            MessageBox.Show("Đã xóa dữ liệu ");
        }
    }
}
