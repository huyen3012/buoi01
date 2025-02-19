using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vidu01;


namespace dongfrm
{
    public partial class frm2 : Form
    {
       
        public frm2()
        {
            InitializeComponent();
        }

        private void frm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn đóng form không?", "Đóng form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(r==DialogResult.Cancel)
            {
                e.Cancel = true;
            }    
        }

        private void frm2_Leave(object sender, EventArgs e)
        {
                if (int.TryParse(txta.Text, out int a) && int.TryParse(txtb.Text, out int b))
                {
                    tinhtoan x = new tinhtoan(a, b);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ vào ô a và b.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
        }

        private void btncong_Click(object sender, EventArgs e)
        {
                if (int.TryParse(txta.Text, out int a) && int.TryParse(txtb.Text, out int b))
                {
                    int result = a + b;
                    MessageBox.Show($"Tổng: {result}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ vào ô a và b.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
