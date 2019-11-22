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

namespace Quanlybenhvien
{
    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlConnection connect = new SqlConnection(@" Data source =TRANTAN\SQLEXPRESS;Initial Catalog=QLBENHVIEN;Integrated Security=true");
        string chuoiketnoi = @"Data source =TRANTAN\SQLEXPRESS;Initial Catalog=QLBENHVIEN;Integrated Security=true";

        private void hienthi()
        {

            string sqlselect = "select *from NHANVIEN";
            SqlCommand cmd = new SqlCommand(sqlselect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            datanhanvien.DataSource = dt;
        }
        private void datahosobenhnhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nhanvien_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            connect.Open();

            string sql = "select NHANVIEN.maso,hovaten,gioitinh,diachi,ngaysinh,noisinh,cmnd,sodt,nghenghiep,email from NHANVIEN";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datanhanvien.DataSource = dt;
            connect.Close();
        }

        private void bttLƯU_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                if (txtmasoBN.Text != "" && txthovaten.Text != "" && cmbgioitinh.Text != "" && txtdiachi.Text != "" && datetimeNS.Text != "" && txtnoisinh.Text != "" && txtcmnd.Text != "" && txtsodt.Text != "" && txtnghenghiep.Text != "" && txtemail.Text != "")
                {

                    conn.Open();
                    string sql = "insert into hang value ('" + txtmasoBN.Text + "','" + txthovaten.Text + "','" + cmbgioitinh + "','" + txtdiachi.Text + "','" + datetimeNS.Text + "','" + txtnoisinh.Text + "','" + txtcmnd.Text + "','" + txtsodt.Text + "','" + txtnghenghiep.Text + "','" + txtemail.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {

                        MessageBox.Show("thêm thành công!");

                    }

                    else

                        MessageBox.Show("thêm thất bại!");
                    conn.Close();
                }
                else
                    MessageBox.Show("chưa nhập đủ thông tin");

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối:" + ex.Message);
            }

        }

        private void bttthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
