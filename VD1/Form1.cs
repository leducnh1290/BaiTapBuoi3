using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD1
{
    public partial class frm_DangKy : Form
    {
        public frm_DangKy()
        {
            InitializeComponent();
        }

        private void frm_DangKy_Load(object sender, EventArgs e)
        {
           // this.BackColor = Color.Blue;
        }

        private void frm_DangKy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là nội dung của popup!", "Tiêu đề Popup", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frm_DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Muốn thoát à ?"
                ,"Daddy says",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel=true;  
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_ho.Text.Length > 0)
            {
                lb_hoten.Text = tb_ho.Text;
                return;
            }
        }

        private void btn_ten_Click(object sender, EventArgs e)
        {
            if (tb_ten.Text.Length > 0)
            {
                lb_hoten.Text = tb_ten.Text;
                return;
            }
        }

        private void btn_hoten_Click(object sender, EventArgs e)
        {
            if (tb_ho.Text.Length > 0&& tb_ten.Text.Length > 0)
            {
                lb_hoten.Text = tb_ho.Text+" "+tb_ten.Text;
                return;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_hoten_DoubleClick(object sender, EventArgs e)
        {
            lb_hoten.Text = "";
        }
    }
}
