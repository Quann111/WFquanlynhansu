using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiThi.Net
{
    public partial class Login : Form
    {
        SqlConnection conn;
        string str = @"Data Source=DESKTOP-7V1GAAL;Initial Catalog=QLNS;Integrated Security=True";
        SqlDataAdapter adt = new SqlDataAdapter();//ham load du lieu der hien thi
        DataTable table = new DataTable();
        DataSet ds = new DataSet();
        public static string loaiTK = "-1";

        public Login()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtTK.Text == "")
            {
                MessageBox.Show(txtTK, "Nhập lại Tài khoản !!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTK.Focus();
            }
            if (txtMK.Text == "")
            {
                MessageBox.Show(txtMK, "Nhập lại mật khẩu", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMK.Focus();
            }
            else
            {
                //
                conn = new SqlConnection(str);

                string laydulieu = "select * from tbuser where Username = '" + txtTK.Text.Trim() + "' and Pass = '" + txtMK.Text.Trim() + "'";
                adt = new SqlDataAdapter(laydulieu, conn);
                adt.Fill(table);

                if (table.Rows.Count > 0)
                {
                    
                    loaiTK = table.Rows[0][2].ToString();
                    frmMain objMain = new frmMain(loaiTK);
                    objMain.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dang Nhap That Bai.\nVui Long Dang Nhap Lai.", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTK.Text = "";
                    txtMK.Text = "";
                    txtMK.Focus();
                }
            }



        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

