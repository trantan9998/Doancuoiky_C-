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
    public partial class phongkhambenh : Form
    {
        public phongkhambenh()
        {
            InitializeComponent();
        }
        
        SqlConnection conn;
        SqlConnection connect = new SqlConnection(@" Data source =TRANTAN\SQLEXPRESS;Initial Catalog=QLBENHVIEN;Integrated Security=true");
        string chuoiketnoi = @"Data source =TRANTAN\SQLEXPRESS;Initial Catalog=QLBENHVIEN;Integrated Security=true";
        public void hienthi()
        {

            string sqlselect = "select *from PHONGKHAMBENH";
            SqlCommand cmd = new SqlCommand(sqlselect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataphongkhambenh.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void phongkhambenh_Load(object sender, EventArgs e)
        {

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                if (txtmaso.Text != "" && txthovaten.Text != "" && cmbgioitinh.Text != "" && txttuoi.Text != "" && txtdohuyetap.Text != "" && txtdonhiptim.Text != "" && txtdonhietdo.Text != "" && txtkhamlamsang.Text != "" && txtchuandoan.Text != "") 
                {

                    conn.Open();
                    string sql = "insert into hang value ('" + txtmaso.Text + "','" + txthovaten.Text + "','" + cmbgioitinh + "','" + txttuoi.Text + "','" + txtdohuyetap.Text + "','" + txtdonhiptim.Text + "','" + txtdonhietdo.Text+"','"+txtkhamlamsang.Text+"','" +txtchuandoan+ "')";
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
            */
        }

        private void bttcapnhapthongtin_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sql = "select PHONGKHAMBENH.maso,hovaten,gioitinh,tuoi,dohuyetap,donhiptim,donhietdo,khamlamsang,chuandoan from PHONGKHAMBENH";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataphongkhambenh.DataSource = dt;
            connect.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
