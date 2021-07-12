using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using QLBH_API.Form;
using QLBH_API.Forms;
using System;
using System.Windows.Forms;
namespace QLBH_API
{
    public partial class main : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public main()
        {
            InitializeComponent();

            ribbonPage_DangNhap.Visible = true;
            ribbonPage_HangHoa.Visible = false;
            ribbonPage_KhachHang.Visible = false;
            ribbonPage_NhanVien.Visible = false;
            ribbonPage_NhapHang.Visible = false;
            ribbonPage_DonDaHang.Visible = false;
        }
    
        public void refeshComponent()
        {
            switch(Form_Login.role)
            {
                case 0: // nhân viên
                    {
                        ribbonPage_DangNhap.Visible = true;
                        ribbonPage_HangHoa.Visible = true;
                        ribbonPage_KhachHang.Visible = true;
                        ribbonPage_NhanVien.Visible = false;
                        ribbonPage_NhapHang.Visible = true;
                        ribbonPage_DonDaHang.Visible = true;

                        break;
                    }
                case 1: // admin
                    {
                        ribbonPage_DangNhap.Visible = true;
                        ribbonPage_HangHoa.Visible = true;
                        ribbonPage_KhachHang.Visible = true;
                        ribbonPage_NhanVien.Visible = true;
                        ribbonPage_NhapHang.Visible = true;
                        ribbonPage_DonDaHang.Visible = true;

                        break;
                    } 
                case 2: // khách hàng
                    {
                        ribbonPage_DangNhap.Visible = true;
                        ribbonPage_HangHoa.Visible = true;
                        ribbonPage_KhachHang.Visible = false;
                        ribbonPage_NhanVien.Visible = false;
                        ribbonPage_NhapHang.Visible = false;
                        ribbonPage_DonDaHang.Visible = true;

                        break;
                    }
            }    
        }
        public void closeAllForm()
        {
            foreach (System.Windows.Forms.Form f in this.MdiChildren)
            {
                if (f.GetType() != typeof(Form_Login)) f.Close();
            }
        }
        private System.Windows.Forms.Form checkExist(Type ftype)
        {
            foreach (System.Windows.Forms.Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype) return f;
            }
            return null;
        }

        private void barButtonItem_DanhNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Windows.Forms.Form frm = this.checkExist(typeof(Form_Login));
            if (frm != null)
            {
                frm.Activate();
                frm.Show();
            }
            else
            {
                Form_Login f = new Form_Login();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem_NhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Windows.Forms.Form frm = this.checkExist(typeof(Form_NhanVien));
            if (frm != null)
            {
                frm.Activate();
                frm.Show();
            }
            else
            {
                Form_NhanVien f = new Form_NhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem_HangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Windows.Forms.Form frm = this.checkExist(typeof(Form_HangHoa));
            if (frm != null)
            {
                frm.Activate();
                frm.Show();
            }
            else
            {
                Form_HangHoa f = new Form_HangHoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem_KhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {

            System.Windows.Forms.Form frm = this.checkExist(typeof(Form_KhachHang));
            if (frm != null)
            {
                frm.Activate();
                frm.Show();
            }
            else
            {
                Form_KhachHang f = new Form_KhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Windows.Forms.Form frm = this.checkExist(typeof(Form_NhapHang));
            if (frm != null)
            {
                frm.Activate();
                frm.Show();
            }
            else
            {
                Form_NhapHang f = new Form_NhapHang();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
