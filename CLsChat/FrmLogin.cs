using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLsChat
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DB.begin();
           

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="")
            {
                MessageBox.Show("Enter user name","Error",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUserName.Focus();
                return;

            }
            if (txtpassword.Text=="")
            {
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtpassword.Focus();
                return;

            }
            string sl = $"select UserID from Users where UserName = '{txtUserName.Text}'";
            string id = DB.Searchscaler(sl);
            if (id ==null)
            {
                MessageBox.Show("invalid user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string pass = $"select pass from Users where UserName = '{txtUserName.Text}'";
            string password = DB.Searchscaler(pass);
            if (txtpassword.Text != password )
            {
                MessageBox.Show("invalid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DB.UserID= int.Parse(id);
            //this.Hide();
            FrmMain frm = new FrmMain();
            frm.ShowDialog();
        }


    
        private void btncancel_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to close this app?";
            DialogResult res = MessageBox.Show(msg, "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
