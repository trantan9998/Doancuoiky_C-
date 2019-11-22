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
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }
       
       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            SqlConnection conn =new SqlConnection(@"Data source =TRANTAN\SQLEXPRESS;Initial Catalog=QLBENHVIEN;Integrated Security=true");
            try
            {
                conn.Open();
                string taikhoan = txttaikhoan.Text;
                string matkhau = txtpassword.Text;
                string sql = "select * from DANGNHAP where taikhoan = '" + taikhoan + "' and matkhau= '" + matkhau + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta= cmd.ExecuteReader();
                if(dta.Read()==true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                  
                }
                else
                {
                    MessageBox.Show("đăng nhập thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("không kết được đến hệ thống!");
            }

            conn.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formdangky frm1 = new formdangky();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            doimatkhau f = new doimatkhau();
            f.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formdangky t = new formdangky();
            t.ShowDialog();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
