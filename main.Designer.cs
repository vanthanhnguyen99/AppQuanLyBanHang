
namespace QLBH_API
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_KhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_NhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_HangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_DonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage_DangNhap = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_KhachHang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_AdminNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_NhanVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_Admin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_HangHoa = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_NhapHang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_NhapHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_DonDaHang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem_KhachHang,
            this.barButtonItem_NhanVien,
            this.barButtonItem_HangHoa,
            this.barButtonItem2,
            this.barButtonItem_DonDatHang});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_DangNhap,
            this.ribbonPage_KhachHang,
            this.ribbonPage_NhanVien,
            this.ribbonPage_HangHoa,
            this.ribbonPage_NhapHang,
            this.ribbonPage_DonDaHang});
            this.ribbonControl1.Size = new System.Drawing.Size(1153, 158);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đăng nhập";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_DanhNhap_ItemClick);
            // 
            // barButtonItem_KhachHang
            // 
            this.barButtonItem_KhachHang.Caption = "Quản lý khách hàng";
            this.barButtonItem_KhachHang.Id = 2;
            this.barButtonItem_KhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_KhachHang.ImageOptions.Image")));
            this.barButtonItem_KhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_KhachHang.ImageOptions.LargeImage")));
            this.barButtonItem_KhachHang.Name = "barButtonItem_KhachHang";
            this.barButtonItem_KhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_KhachHang_ItemClick);
            // 
            // barButtonItem_NhanVien
            // 
            this.barButtonItem_NhanVien.Caption = "Quản lý nhân viên";
            this.barButtonItem_NhanVien.Id = 3;
            this.barButtonItem_NhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NhanVien.ImageOptions.Image")));
            this.barButtonItem_NhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NhanVien.ImageOptions.LargeImage")));
            this.barButtonItem_NhanVien.Name = "barButtonItem_NhanVien";
            this.barButtonItem_NhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_NhanVien_ItemClick);
            // 
            // barButtonItem_HangHoa
            // 
            this.barButtonItem_HangHoa.Caption = "Hàng hóa";
            this.barButtonItem_HangHoa.Id = 4;
            this.barButtonItem_HangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_HangHoa.ImageOptions.Image")));
            this.barButtonItem_HangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_HangHoa.ImageOptions.LargeImage")));
            this.barButtonItem_HangHoa.Name = "barButtonItem_HangHoa";
            this.barButtonItem_HangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_HangHoa_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Quản lý nhập hàng";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem_DonDatHang
            // 
            this.barButtonItem_DonDatHang.Caption = "Đơn đặt hàng";
            this.barButtonItem_DonDatHang.Id = 6;
            this.barButtonItem_DonDatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_DonDatHang.ImageOptions.Image")));
            this.barButtonItem_DonDatHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_DonDatHang.ImageOptions.LargeImage")));
            this.barButtonItem_DonDatHang.Name = "barButtonItem_DonDatHang";
            this.barButtonItem_DonDatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_DonDatHang_ItemClick);
            // 
            // ribbonPage_DangNhap
            // 
            this.ribbonPage_DangNhap.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage_DangNhap.Name = "ribbonPage_DangNhap";
            this.ribbonPage_DangNhap.Text = "Đăng nhập";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Đăng nhập";
            // 
            // ribbonPage_KhachHang
            // 
            this.ribbonPage_KhachHang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_AdminNhanVien});
            this.ribbonPage_KhachHang.Name = "ribbonPage_KhachHang";
            this.ribbonPage_KhachHang.Text = "Khách hàng";
            // 
            // ribbonPageGroup_AdminNhanVien
            // 
            this.ribbonPageGroup_AdminNhanVien.ItemLinks.Add(this.barButtonItem_KhachHang);
            this.ribbonPageGroup_AdminNhanVien.Name = "ribbonPageGroup_AdminNhanVien";
            this.ribbonPageGroup_AdminNhanVien.Text = "Admin/Nhân viên";
            // 
            // ribbonPage_NhanVien
            // 
            this.ribbonPage_NhanVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_Admin});
            this.ribbonPage_NhanVien.Name = "ribbonPage_NhanVien";
            this.ribbonPage_NhanVien.Text = "Nhân viên";
            // 
            // ribbonPageGroup_Admin
            // 
            this.ribbonPageGroup_Admin.ItemLinks.Add(this.barButtonItem_NhanVien);
            this.ribbonPageGroup_Admin.Name = "ribbonPageGroup_Admin";
            this.ribbonPageGroup_Admin.Text = "Admin";
            // 
            // ribbonPage_HangHoa
            // 
            this.ribbonPage_HangHoa.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage_HangHoa.Name = "ribbonPage_HangHoa";
            this.ribbonPage_HangHoa.Text = "Hàng hóa";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem_HangHoa);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Admin/Nhân viên/Users";
            // 
            // ribbonPage_NhapHang
            // 
            this.ribbonPage_NhapHang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_NhapHang});
            this.ribbonPage_NhapHang.Name = "ribbonPage_NhapHang";
            this.ribbonPage_NhapHang.Text = "Nhập hàng";
            // 
            // ribbonPageGroup_NhapHang
            // 
            this.ribbonPageGroup_NhapHang.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup_NhapHang.Name = "ribbonPageGroup_NhapHang";
            this.ribbonPageGroup_NhapHang.Text = "Admin/Nhân viên";
            // 
            // ribbonPage_DonDaHang
            // 
            this.ribbonPage_DonDaHang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage_DonDaHang.Name = "ribbonPage_DonDaHang";
            this.ribbonPage_DonDaHang.Text = "Đon đặt hàng";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem_DonDatHang);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 656);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "main";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_KhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_AdminNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_NhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Admin;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_HangHoa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_NhapHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_NhapHang;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_DonDaHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_DangNhap;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_KhachHang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_NhanVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_HangHoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DonDatHang;
    }
}

