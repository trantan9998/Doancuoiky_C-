using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Quanlybenhvien
{
    public partial class Hồ_sơ_bệnh_nhân : Form
    {
        public Hồ_sơ_bệnh_nhân()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlConnection connect = new SqlConnection(@" Data source =TRANTAN\SQLEXPRESS;Initial Catalog=QLBENHVIEN;Integrated Security=true");
        string chuoiketnoi = @"Data source =TRANTAN\SQLEXPRESS;Initial Catalog=QLBENHVIEN;Integrated Security=true";
        private void hienthi()
        {
            
            string sqlselect = "select *from THONGTINBENHNHAN";
            SqlCommand cmd = new SqlCommand(sqlselect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            datahosobenhnhan.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                if (txtmasoBN.Text != "" && txthovaten.Text != "" && cmbgioitinh.Text != "" && txtdiachi.Text != "" && datetimeNS.Text != "" && txtnoisinh.Text != "" && txtcmnd.Text != "" && txtsodt.Text != "" && txtnghenghiep.Text != "" && txtemail.Text != "" )
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
            catch(Exception ex)
            {
                MessageBox.Show("lỗi kết nối:" + ex.Message);
            }
          
        }
        private void lsthosobenhnhan_SelectedIndexChanged(object sender, EventArgs e)
        {
           }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
                string sql = "update hang set tenhang='" + txtmasoBN.Text + "','" + txthovaten.Text + "','" + cmbgioitinh + "','" + txtdiachi.Text + "','" + datetimeNS.Text + "','" + txtnoisinh.Text + "','" + txtcmnd.Text + "','" + txtsodt.Text + "','" + txtnghenghiep.Text + "','" + txtemail.Text + "')";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối:" + ex.Message);
            }

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datahosobenhnhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Hồ_sơ_bệnh_nhân_Load(object sender, EventArgs e)
        {
            
            
         }

        private void button5_Click(object sender, EventArgs e)
        {
            connect.Open();
           
            string sql = "select THONGTINBENHNHAN.maso,hovaten,gioitinh,diachi,ngaysinh,noisinh,cmnd,sodt,nghenghiep,email from THONGTINBENHNHAN";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datahosobenhnhan.DataSource = dt;
            connect.Close();
        }
    }
}
