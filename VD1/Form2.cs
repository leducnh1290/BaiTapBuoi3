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
    public partial class frm_form2 : Form
    {
        public frm_form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ten = textBox1.Text;
            String ngaysinh = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            String gt = radioButton1.Checked ? "Nam" : "Nữ";
            String st = (checkBox1.Checked ?
                checkBox1.Text:"")+ (checkBox2.Checked ?
                ", "+checkBox2.Text : "")
                + (checkBox3.Checked ?
                ", " + checkBox3.Text : "");
            MessageBox.Show(("Họ tên : " +
                ten
                + ", Giới tính : " + gt
                + ", Ngày sinh : " + ngaysinh
                + ", Sở thích : " + st),"Thông tin",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
