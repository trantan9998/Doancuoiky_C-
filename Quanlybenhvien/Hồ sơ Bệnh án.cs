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
using System.Configuration;

namespace Quanlybenhvien
{
   
    public partial class Hồ_sơ_Bệnh_án : Form
    {
      
        public Hồ_sơ_Bệnh_án()
        {
            InitializeComponent();
        }
        SqlConnection conn ;
        SqlConnection connect = new SqlConnection(@" Data source =TRANTAN\SQLEXPRESS;Initial Catalog=QLBENHVIEN;Integrated Security=true");
        string chuoiketnoi = @"Data source =TRANTAN\SQLEXPRESS;Initial Catalog=QLBENHVIEN;Integrated Security=true";
        public void hienthi()
        {

            string sqlselect = "select *from HOSOBENHAN0";
            SqlCommand cmd = new SqlCommand(sqlselect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            databenhan.DataSource = dt;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();

            string sql = "select HOSOBENHAN0.hovaten,gioitinh,diachi,ngaysinh,noisinh,cmnd,sodt,ngayvaovien,ngayravien,chandoanlucvaovien,chandoanlucravien from HOSOBENHAN0";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            databenhan.DataSource = dt;
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hồ_sơ_Bệnh_án_Load(object sender, EventArgs e)
        {
            
        }

        private void databenhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                if (txthovaten.Text != "" && cmbgioitinh.Text != "" && datetimengaysinh.Text != "" && txtnoisinh.Text != "" && txtcmnd.Text != "" && txtsodt.Text != "" && dateTimengayvaovien.Text != "" && dateTimengayravien.Text != "" && txtlucvaovien.Text != "" && txtlucravien.Text != "")
                {

                    conn.Open();
                    string sql = "insert into HOSOBENHAN0 value ('"+ txthovaten.Text + "','" + cmbgioitinh.Text + "','" + datetimengaysinh + "','" + txtnoisinh.Text + "','" + txtcmnd.Text + "','" + txtsodt.Text + "','" + dateTimengayvaovien.Text + "','" + dateTimengayravien.Text + "','" + txtlucvaovien.Text + "','" + txtlucravien.Text + "')";
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
                MessageBox.Show("lỗi kết nối:"  ,ex.Message );
            }

        }

        private void Hồ_sơ_Bệnh_án_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

       
    }
}
