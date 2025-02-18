using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dongfrm
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void frm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("dong form", "dong",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtYearofBirthday.Clear();
            txtYourName.Clear();
            txtYourName.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string tb = "My name is :" + txtYourName.Text + "\nAge:" + txtYearofBirthday.Text ;
            DialogResult r = MessageBox.Show(tb, "");
        }

       

        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
            if (string.IsNullOrEmpty(txtYourName.Text))
            {
                this.errorProvider1.SetError(ct, "ban phai nhap noi dung");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

       

        private void txtYearofBirthday_TextChanged(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
            if (string.IsNullOrEmpty(txtYearofBirthday.Text))
            {
                this.errorProvider1.SetError(ct, "ban phai nhap noi dung");
            }
            else if (txtYearofBirthday.Text.All(char.IsDigit) == false)
            {
                this.errorProvider1.SetError(ct, "ban phai nhap so");
              
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
