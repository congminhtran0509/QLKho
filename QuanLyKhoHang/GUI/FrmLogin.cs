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
                Application.Exit();
        }

        BUS_Login login = new BUS_Login();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from Login where UserName = '" + txtUserName.Text + "' and Password = '" + txtPasswd.Text + "'";
            if (login.Load_BUS(sql).Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                FrmMain.username = txtUserName.Text;
                FrmMain f = new FrmMain();
                FrmLogin_Load(sender, e);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPasswd.Clear();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
                e.Cancel=true;
        }
    }
}
