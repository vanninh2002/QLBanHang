using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn Có Thực Sự Muốn Thoát Chương Trình?","Thông Báo", MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TableManager T = new TableManager();
            this.Hide();
            T.ShowDialog();
            this.Show();
        }
    }
}
