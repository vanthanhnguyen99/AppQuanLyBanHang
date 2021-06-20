using DevExpress.XtraEditors;
using QLBH_API.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH_API.Services;

namespace QLBH_API.Form
{
    public partial class Form_Login : DevExpress.XtraEditors.XtraForm
    {
        public static string username;
        public static string password;
        public static int role = -1;
        public Form_Login()
        {
            InitializeComponent();
            textBox_password.PasswordChar = '*';
        }

        public void button_DangNhap_Click(object sender, EventArgs e)
        {
            username = textBox_ID.Text;
            password = textBox_password.Text;

            Login login = new Login();
            login.username = username;
            login.password = password;

            int role = new Service_Login().login(login);

            new Service_NhanVien().getNhanVien("1231231");
            switch (role)
            {
                case -1:
                    {
                        MessageBox.Show( "Sai thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK);
                        Form_Login.role = -1;

                        break;
                    }
                case 0: // nhân viên
                    {
                        MessageBox.Show( "Bạn là nhân viên", "Thông báo", MessageBoxButtons.OK);

                        Form_Login.role = 0;
                        Program.form_main.refeshComponent();

                        break;
                    }
                case 1: // admin
                    {
                        MessageBox.Show( "Bạn là admin", "Thông báo", MessageBoxButtons.OK);

                        Form_Login.role = 1;
                        Program.form_main.refeshComponent();

                        break;
                    }
                case 2: // khách hàng
                    {
                        MessageBox.Show( "Bạn là khách hàng", "Thông báo", MessageBoxButtons.OK);

                        Form_Login.role = 2;
                        Program.form_main.refeshComponent();

                        break;
                    }
            }
        }
    }
}