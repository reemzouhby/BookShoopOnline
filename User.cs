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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {

        }

        private void Auteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
