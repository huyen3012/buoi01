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
            DialogResult r = MessageBox.Show("Bạn muốn đóng form không?", "Đóng form", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if(r==DialogResult.Cancel)
            {
                e.Cancel = true;
            }    
        }

        private void frm2_Leave(object sender, EventArgs e)
        {
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);
            tinhtoan x = new tinhtoan(a, b);
           
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            
        }
    }
}
