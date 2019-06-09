using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn thật sự muốn thoát?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) Application.Exit();
        }

        BUS_Login login = new BUS_Login();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from Login where UserName = '" + txtUserName.Text + "' and Password = '" + txtPasswd.Text + "'";
            if (login.Load_BUS(sql).Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                FrmMain f = new FrmMain();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }
    }
}
