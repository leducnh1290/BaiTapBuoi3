using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VD1
{
    public partial class frm_ListView : Form
    {
        public frm_ListView()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
          
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(tb_FirstName.Text);
            item.SubItems.Add(tb_LastName.Text);
            item.SubItems.Add(tb_Phone.Text);
            lv_nhanvien.Items.Add(item);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lv_nhanvien.SelectedItems[0];

            selectedItem.Text = tb_FirstName.Text; 
            selectedItem.SubItems[1].Text = tb_LastName.Text; 
            selectedItem.SubItems[2].Text = tb_Phone.Text; 
        }

        private void lv_nhanvien_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
           
        }

        private void lv_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_nhanvien.SelectedItems.Count > 0)
            {
                
                ListViewItem selectedItem = lv_nhanvien.SelectedItems[0];

               
                tb_FirstName.Text = selectedItem.Text;
                tb_LastName.Text = selectedItem.SubItems[1].Text; 
                tb_Phone.Text = selectedItem.SubItems[2].Text; 
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lv_nhanvien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
               
                foreach (ListViewItem item in lv_nhanvien.SelectedItems)
                {
                    lv_nhanvien.Items.Remove(item);
                }
            }
        }
    }
}
