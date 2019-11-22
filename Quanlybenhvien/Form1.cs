using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybenhvien
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void hồSơBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Hồ_sơ_bệnh_nhân frm0 = new Hồ_sơ_bệnh_nhân();
            frm0.MdiParent = this;
            frm0.Show();

            DialogResult hoi;
            hoi=  MessageBox.Show("BẠN MUỐN TRUY CẬP! ", "thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(hoi==DialogResult.No)
            {
                frm0.Close();
            }
            


        }

        private void hồSơBệnhÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hồ_sơ_Bệnh_án frm1 = new Hồ_sơ_Bệnh_án();
            frm1.MdiParent = this;
            frm1.Show();

            DialogResult hoi;
            hoi = MessageBox.Show("BẠN MUỐN TRUY CẬP! ", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.No)
            {
                frm1.Close();
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đĂNGNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void đĂNGKÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formdangky frmdangky = new formdangky();
            frmdangky.MdiParent = this;
            frmdangky.Show();
        
        }

        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kHOANỘIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khoanoi frmkhoanoi = new khoanoi();
            frmkhoanoi.MdiParent = this;
            frmkhoanoi.Show();
            DialogResult hoi;
            hoi = MessageBox.Show("BẠN MUỐN TRUY CẬP! ", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.No)
            {
                frmkhoanoi.Close();
            }

        }

        private void kHOANGOẠIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khoangoai frmkhoangoai = new khoangoai();
            frmkhoangoai.MdiParent = this;
            frmkhoangoai.Show();
            DialogResult hoi;
            hoi = MessageBox.Show("BẠN MUỐN TRUY CẬP! ", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.No)
            {
                frmkhoangoai.Close();
            }
        }

        private void bácSỹToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bacsi frmbacsi = new bacsi();
            frmbacsi.MdiParent = this;
            frmbacsi.Show();
            DialogResult hoi;
            hoi = MessageBox.Show("BẠN MUỐN XEM THÔNG TIN BÁC SỸ! ", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.No)
            {
                frmbacsi.Close();
            }

        }

    
        private void pHÒNGKHÁMTAIMŨIHỌNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phongkhambenh frmphongkham = new phongkhambenh();
            frmphongkham.MdiParent = this;
            frmphongkham.Show();
            DialogResult hoi;
            hoi = MessageBox.Show("BẠN MUỐN TRUY CẬP! ", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.No)
            {
                frmphongkham.Close();
            }
        }

        private void pHÒNGKHÁMXÉTNGHIỆMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phongkhamxetnghiem frmphongxetnghiem = new phongkhamxetnghiem();
            frmphongxetnghiem.MdiParent = this;
            frmphongxetnghiem.Show();
            DialogResult hoi;
            hoi = MessageBox.Show("BẠN MUỐN TRUY CẬP! ", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.No)
            {
                frmphongxetnghiem.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmdannhap_Click(object sender, EventArgs e)
        {
            dangnhap frm1 = new dangnhap();
            frm1.MdiParent = this;
            frm1.Show();
           
        }

        private void đĂNGKÝToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đĂNGKÝToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formdangky frm1 = new formdangky();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhanvien frmnhanvien = new nhanvien();
            frmnhanvien.MdiParent = this;
            frmnhanvien.Show();
            DialogResult hoi;
            hoi = MessageBox.Show("BẠN MUỐN TRUY CẬP! ", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.No)
            {
                frmnhanvien.Close();
            }

        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
