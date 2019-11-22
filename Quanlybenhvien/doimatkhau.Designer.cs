namespace Quanlybenhvien
{
    partial class doimatkhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnhaplaimatkhau = new System.Windows.Forms.TextBox();
            this.txtnhaplai = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP MẬT KHẨU:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NHẬP LẠI MẬT KHẨU:";
            // 
            // txtnhaplaimatkhau
            // 
            this.txtnhaplaimatkhau.Location = new System.Drawing.Point(143, 24);
            this.txtnhaplaimatkhau.Name = "txtnhaplaimatkhau";
            this.txtnhaplaimatkhau.Size = new System.Drawing.Size(228, 20);
            this.txtnhaplaimatkhau.TabIndex = 1;
            this.txtnhaplaimatkhau.TextChanged += new System.EventHandler(this.txtnhaplaimatkhau_TextChanged);
            // 
            // txtnhaplai
            // 
            this.txtnhaplai.Location = new System.Drawing.Point(143, 64);
            this.txtnhaplai.Name = "txtnhaplai";
            this.txtnhaplai.Size = new System.Drawing.Size(228, 20);
            this.txtnhaplai.TabIndex = 1;
            this.txtnhaplai.TextChanged += new System.EventHandler(this.txtnhaplai_TextChanged);
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.RosyBrown;
            this.btndangnhap.Location = new System.Drawing.Point(143, 107);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(104, 46);
            this.btndangnhap.TabIndex = 5;
            this.btndangnhap.Text = "ĐĂNG NHẬP";
            this.btndangnhap.UseVisualStyleBackColor = false;
            // 
            // doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 171);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txtnhaplai);
            this.Controls.Add(this.txtnhaplaimatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "doimatkhau";
            this.Text = "doimatkhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnhaplaimatkhau;
        private System.Windows.Forms.TextBox txtnhaplai;
        private System.Windows.Forms.Button btndangnhap;
    }
}