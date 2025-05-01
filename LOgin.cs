using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookshoop
{
    public partial class LOgin : Form
    {
        public LOgin()
        {
            InitializeComponent();
        }

        private void LOgin_Load(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
                    }

        private void showpaswrd_CheckedChanged(object sender, EventArgs e)
        {
            if (showpaswrd.Checked)
            {
                PasswordtextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordtextBox.PasswordChar = '●';
            }
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            ForgotPass changepaswrd_Form = new ForgotPass();
           
            changepaswrd_Form.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
