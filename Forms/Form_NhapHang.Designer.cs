
namespace QLBH_API.Forms
{
    partial class Form_NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NhapHang));
            this.gridControl_PhieuDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_ChiTietNhapHang = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox_PhieuNhapHang = new System.Windows.Forms.GroupBox();
            this.textBox_TongTien = new System.Windows.Forms.TextBox();
            this.textBox_NhanVien = new System.Windows.Forms.TextBox();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.textBox_NgayLap = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_ChiTietNhapHang = new System.Windows.Forms.GroupBox();
            this.comboBox_ChiTieNhapHang_TenHangHoa = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox_ChiTietNhapHang_IDHH = new System.Windows.Forms.TextBox();
            this.textBox_ChiTieNhapHang_ThanhTien = new System.Windows.Forms.TextBox();
            this.textBox_ChiTieNhapHang_IDPhieuNhap = new System.Windows.Forms.TextBox();
            this.textBox_ChiTietNhapHang_ID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_NhapHang_Them = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_NhapHang_Ghi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_NhapHang_Thoát = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_PhieuNhapHang_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ChiTietNhapHang_Them = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ChiTietNhapHang_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ChiTietNhapHang_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ChiTietNhapHang_Ghi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ChiTietNhapHang_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem_NhapHang_Sua = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PhieuDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ChiTietNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox_PhieuNhapHang.SuspendLayout();
            this.groupBox_ChiTietNhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_PhieuDatHang
            // 
            this.gridControl_PhieuDatHang.Location = new System.Drawing.Point(31, 30);
            this.gridControl_PhieuDatHang.MainView = this.gridView1;
            this.gridControl_PhieuDatHang.Name = "gridControl_PhieuDatHang";
            this.gridControl_PhieuDatHang.Size = new System.Drawing.Size(843, 457);
            this.gridControl_PhieuDatHang.TabIndex = 0;
            this.gridControl_PhieuDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_PhieuDatHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl_ChiTietNhapHang
            // 
            this.gridControl_ChiTietNhapHang.Location = new System.Drawing.Point(942, 30);
            this.gridControl_ChiTietNhapHang.MainView = this.gridView2;
            this.gridControl_ChiTietNhapHang.Name = "gridControl_ChiTietNhapHang";
            this.gridControl_ChiTietNhapHang.Size = new System.Drawing.Size(930, 457);
            this.gridControl_ChiTietNhapHang.TabIndex = 1;
            this.gridControl_ChiTietNhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl_ChiTietNhapHang;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // groupBox_PhieuNhapHang
            // 
            this.groupBox_PhieuNhapHang.Controls.Add(this.textBox_TongTien);
            this.groupBox_PhieuNhapHang.Controls.Add(this.textBox_NhanVien);
            this.groupBox_PhieuNhapHang.Controls.Add(this.textBox_HoTen);
            this.groupBox_PhieuNhapHang.Controls.Add(this.textBox_NgayLap);
            this.groupBox_PhieuNhapHang.Controls.Add(this.textBox_ID);
            this.groupBox_PhieuNhapHang.Controls.Add(this.label5);
            this.groupBox_PhieuNhapHang.Controls.Add(this.label4);
            this.groupBox_PhieuNhapHang.Controls.Add(this.label3);
            this.groupBox_PhieuNhapHang.Controls.Add(this.label2);
            this.groupBox_PhieuNhapHang.Controls.Add(this.label1);
            this.groupBox_PhieuNhapHang.Enabled = false;
            this.groupBox_PhieuNhapHang.Location = new System.Drawing.Point(32, 516);
            this.groupBox_PhieuNhapHang.Name = "groupBox_PhieuNhapHang";
            this.groupBox_PhieuNhapHang.Size = new System.Drawing.Size(842, 174);
            this.groupBox_PhieuNhapHang.TabIndex = 2;
            this.groupBox_PhieuNhapHang.TabStop = false;
            this.groupBox_PhieuNhapHang.Text = "Thông tin phiếu nhập hàng";
            // 
            // textBox_TongTien
            // 
            this.textBox_TongTien.Location = new System.Drawing.Point(632, 74);
            this.textBox_TongTien.Name = "textBox_TongTien";
            this.textBox_TongTien.Size = new System.Drawing.Size(171, 21);
            this.textBox_TongTien.TabIndex = 9;
            // 
            // textBox_NhanVien
            // 
            this.textBox_NhanVien.Location = new System.Drawing.Point(107, 95);
            this.textBox_NhanVien.Name = "textBox_NhanVien";
            this.textBox_NhanVien.Size = new System.Drawing.Size(171, 21);
            this.textBox_NhanVien.TabIndex = 8;
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Location = new System.Drawing.Point(353, 100);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(171, 21);
            this.textBox_HoTen.TabIndex = 7;
            // 
            // textBox_NgayLap
            // 
            this.textBox_NgayLap.Location = new System.Drawing.Point(353, 41);
            this.textBox_NgayLap.Name = "textBox_NgayLap";
            this.textBox_NgayLap.Size = new System.Drawing.Size(171, 21);
            this.textBox_NgayLap.TabIndex = 6;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(107, 46);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(171, 21);
            this.textBox_ID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox_ChiTietNhapHang
            // 
            this.groupBox_ChiTietNhapHang.Controls.Add(this.comboBox_ChiTieNhapHang_TenHangHoa);
            this.groupBox_ChiTietNhapHang.Controls.Add(this.numericUpDown1);
            this.groupBox_ChiTietNhapHang.Controls.Add(this.textBox_ChiTietNhapHang_IDHH);
            this.groupBox_ChiTietNhapHang.Controls.Add(this.textBox_ChiTieNhapHang_ThanhTien);
            this.groupBox_ChiTietNhapHang.Controls.Add(this.textBox_ChiTieNhapHang_IDPhieuNhap);
            this.groupBox_ChiTietNhapHang.Controls.Add(this.textBox_ChiTietNhapHang_ID);
            this.groupBox_ChiTietNhapHang.Controls.Add(this.label11);
            this.groupBox_ChiTietNhapHang.Controls.Add(this.label10);
            this.groupBox_ChiTietNhapHang.Controls.Add(this.label9);
            this.groupBox_ChiTietNhapHang.Controls.Add(this.label8);
            this.groupBox_ChiTietNhapHang.Controls.Add(this.label7);
            this.groupBox_ChiTietNhapHang.Controls.Add(this.label6);
            this.groupBox_ChiTietNhapHang.Location = new System.Drawing.Point(942, 517);
            this.groupBox_ChiTietNhapHang.Name = "groupBox_ChiTietNhapHang";
            this.groupBox_ChiTietNhapHang.Size = new System.Drawing.Size(930, 173);
            this.groupBox_ChiTietNhapHang.TabIndex = 3;
            this.groupBox_ChiTietNhapHang.TabStop = false;
            this.groupBox_ChiTietNhapHang.Text = "Thông tin chi tiết phiếu nhập hàng";
            // 
            // comboBox_ChiTieNhapHang_TenHangHoa
            // 
            this.comboBox_ChiTieNhapHang_TenHangHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ChiTieNhapHang_TenHangHoa.FormattingEnabled = true;
            this.comboBox_ChiTieNhapHang_TenHangHoa.Location = new System.Drawing.Point(427, 126);
            this.comboBox_ChiTieNhapHang_TenHangHoa.Name = "comboBox_ChiTieNhapHang_TenHangHoa";
            this.comboBox_ChiTieNhapHang_TenHangHoa.Size = new System.Drawing.Size(182, 21);
            this.comboBox_ChiTieNhapHang_TenHangHoa.TabIndex = 13;
            this.comboBox_ChiTieNhapHang_TenHangHoa.SelectedIndexChanged += new System.EventHandler(this.comboBox_ChiTieNhapHang_TenHangHoa_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(427, 56);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(182, 21);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox_ChiTietNhapHang_IDHH
            // 
            this.textBox_ChiTietNhapHang_IDHH.Enabled = false;
            this.textBox_ChiTietNhapHang_IDHH.Location = new System.Drawing.Point(726, 126);
            this.textBox_ChiTietNhapHang_IDHH.Name = "textBox_ChiTietNhapHang_IDHH";
            this.textBox_ChiTietNhapHang_IDHH.Size = new System.Drawing.Size(182, 21);
            this.textBox_ChiTietNhapHang_IDHH.TabIndex = 11;
            // 
            // textBox_ChiTieNhapHang_ThanhTien
            // 
            this.textBox_ChiTieNhapHang_ThanhTien.Enabled = false;
            this.textBox_ChiTieNhapHang_ThanhTien.Location = new System.Drawing.Point(726, 56);
            this.textBox_ChiTieNhapHang_ThanhTien.Name = "textBox_ChiTieNhapHang_ThanhTien";
            this.textBox_ChiTieNhapHang_ThanhTien.Size = new System.Drawing.Size(182, 21);
            this.textBox_ChiTieNhapHang_ThanhTien.TabIndex = 10;
            // 
            // textBox_ChiTieNhapHang_IDPhieuNhap
            // 
            this.textBox_ChiTieNhapHang_IDPhieuNhap.Enabled = false;
            this.textBox_ChiTieNhapHang_IDPhieuNhap.Location = new System.Drawing.Point(130, 121);
            this.textBox_ChiTieNhapHang_IDPhieuNhap.Name = "textBox_ChiTieNhapHang_IDPhieuNhap";
            this.textBox_ChiTieNhapHang_IDPhieuNhap.Size = new System.Drawing.Size(182, 21);
            this.textBox_ChiTieNhapHang_IDPhieuNhap.TabIndex = 7;
            // 
            // textBox_ChiTietNhapHang_ID
            // 
            this.textBox_ChiTietNhapHang_ID.Enabled = false;
            this.textBox_ChiTietNhapHang_ID.Location = new System.Drawing.Point(130, 58);
            this.textBox_ChiTietNhapHang_ID.Name = "textBox_ChiTietNhapHang_ID";
            this.textBox_ChiTietNhapHang_ID.Size = new System.Drawing.Size(182, 21);
            this.textBox_ChiTietNhapHang_ID.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tên hàng hóa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "ID Phiếu nhập hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(641, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "ID Hàng hóa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(650, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Thành tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_NhapHang_Them,
            this.barButtonItem_NhapHang_Sua,
            this.barButtonItem_NhapHang_Ghi,
            this.barButtonItem_NhapHang_Thoát,
            this.barButtonItem_PhieuNhapHang_Xoa,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem_ChiTietNhapHang_Them,
            this.barButtonItem_ChiTietNhapHang_Xoa,
            this.barButtonItem_ChiTietNhapHang_Sua,
            this.barButtonItem_ChiTietNhapHang_Ghi,
            this.barButtonItem_ChiTietNhapHang_Thoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 15;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_NhapHang_Them),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_PhieuNhapHang_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_ChiTietNhapHang_Them),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_ChiTietNhapHang_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_ChiTietNhapHang_Sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_ChiTietNhapHang_Ghi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_ChiTietNhapHang_Thoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_NhapHang_Them
            // 
            this.barButtonItem_NhapHang_Them.Caption = "Thêm";
            this.barButtonItem_NhapHang_Them.Id = 0;
            this.barButtonItem_NhapHang_Them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NhapHang_Them.ImageOptions.Image")));
            this.barButtonItem_NhapHang_Them.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NhapHang_Them.ImageOptions.LargeImage")));
            this.barButtonItem_NhapHang_Them.Name = "barButtonItem_NhapHang_Them";
            this.barButtonItem_NhapHang_Them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_NhapHang_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_NhapHang_Them_ItemClick);
            // 
            // barButtonItem_NhapHang_Ghi
            // 
            this.barButtonItem_NhapHang_Ghi.Caption = "Ghi";
            this.barButtonItem_NhapHang_Ghi.Id = 3;
            this.barButtonItem_NhapHang_Ghi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NhapHang_Ghi.ImageOptions.Image")));
            this.barButtonItem_NhapHang_Ghi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NhapHang_Ghi.ImageOptions.LargeImage")));
            this.barButtonItem_NhapHang_Ghi.Name = "barButtonItem_NhapHang_Ghi";
            this.barButtonItem_NhapHang_Ghi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem_NhapHang_Thoát
            // 
            this.barButtonItem_NhapHang_Thoát.Caption = "Thoát";
            this.barButtonItem_NhapHang_Thoát.Id = 4;
            this.barButtonItem_NhapHang_Thoát.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NhapHang_Thoát.ImageOptions.Image")));
            this.barButtonItem_NhapHang_Thoát.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NhapHang_Thoát.ImageOptions.LargeImage")));
            this.barButtonItem_NhapHang_Thoát.Name = "barButtonItem_NhapHang_Thoát";
            this.barButtonItem_NhapHang_Thoát.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem_PhieuNhapHang_Xoa
            // 
            this.barButtonItem_PhieuNhapHang_Xoa.Caption = "Xóa";
            this.barButtonItem_PhieuNhapHang_Xoa.Id = 5;
            this.barButtonItem_PhieuNhapHang_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_PhieuNhapHang_Xoa.ImageOptions.Image")));
            this.barButtonItem_PhieuNhapHang_Xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_PhieuNhapHang_Xoa.ImageOptions.LargeImage")));
            this.barButtonItem_PhieuNhapHang_Xoa.Name = "barButtonItem_PhieuNhapHang_Xoa";
            this.barButtonItem_PhieuNhapHang_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_PhieuNhapHang_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_PhieuNhapHang_Xoa_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "                                            ";
            this.barButtonItem2.Enabled = false;
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "                                                                     ";
            this.barButtonItem3.Enabled = false;
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "                                                                                ";
            this.barButtonItem4.Enabled = false;
            this.barButtonItem4.Id = 8;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "                                                     ";
            this.barButtonItem5.Enabled = false;
            this.barButtonItem5.Id = 9;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem_ChiTietNhapHang_Them
            // 
            this.barButtonItem_ChiTietNhapHang_Them.Caption = "Thêm";
            this.barButtonItem_ChiTietNhapHang_Them.Id = 10;
            this.barButtonItem_ChiTietNhapHang_Them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Them.ImageOptions.Image")));
            this.barButtonItem_ChiTietNhapHang_Them.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Them.ImageOptions.LargeImage")));
            this.barButtonItem_ChiTietNhapHang_Them.Name = "barButtonItem_ChiTietNhapHang_Them";
            this.barButtonItem_ChiTietNhapHang_Them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_ChiTietNhapHang_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ChiTietNhapHang_Them_ItemClick);
            // 
            // barButtonItem_ChiTietNhapHang_Xoa
            // 
            this.barButtonItem_ChiTietNhapHang_Xoa.Caption = "Xóa";
            this.barButtonItem_ChiTietNhapHang_Xoa.Id = 11;
            this.barButtonItem_ChiTietNhapHang_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Xoa.ImageOptions.Image")));
            this.barButtonItem_ChiTietNhapHang_Xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Xoa.ImageOptions.LargeImage")));
            this.barButtonItem_ChiTietNhapHang_Xoa.Name = "barButtonItem_ChiTietNhapHang_Xoa";
            this.barButtonItem_ChiTietNhapHang_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_ChiTietNhapHang_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ChiTietNhapHang_Xoa_ItemClick);
            // 
            // barButtonItem_ChiTietNhapHang_Sua
            // 
            this.barButtonItem_ChiTietNhapHang_Sua.Caption = "Sửa";
            this.barButtonItem_ChiTietNhapHang_Sua.Id = 12;
            this.barButtonItem_ChiTietNhapHang_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Sua.ImageOptions.Image")));
            this.barButtonItem_ChiTietNhapHang_Sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Sua.ImageOptions.LargeImage")));
            this.barButtonItem_ChiTietNhapHang_Sua.Name = "barButtonItem_ChiTietNhapHang_Sua";
            this.barButtonItem_ChiTietNhapHang_Sua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_ChiTietNhapHang_Sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ChiTietNhapHang_Sua_ItemClick);
            // 
            // barButtonItem_ChiTietNhapHang_Ghi
            // 
            this.barButtonItem_ChiTietNhapHang_Ghi.Caption = "Ghi";
            this.barButtonItem_ChiTietNhapHang_Ghi.Id = 13;
            this.barButtonItem_ChiTietNhapHang_Ghi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Ghi.ImageOptions.Image")));
            this.barButtonItem_ChiTietNhapHang_Ghi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Ghi.ImageOptions.LargeImage")));
            this.barButtonItem_ChiTietNhapHang_Ghi.Name = "barButtonItem_ChiTietNhapHang_Ghi";
            this.barButtonItem_ChiTietNhapHang_Ghi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_ChiTietNhapHang_Ghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ChiTietNhapHang_Ghi_ItemClick);
            // 
            // barButtonItem_ChiTietNhapHang_Thoat
            // 
            this.barButtonItem_ChiTietNhapHang_Thoat.Caption = "Thoát";
            this.barButtonItem_ChiTietNhapHang_Thoat.Id = 14;
            this.barButtonItem_ChiTietNhapHang_Thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Thoat.ImageOptions.Image")));
            this.barButtonItem_ChiTietNhapHang_Thoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Thoat.ImageOptions.LargeImage")));
            this.barButtonItem_ChiTietNhapHang_Thoat.Name = "barButtonItem_ChiTietNhapHang_Thoat";
            this.barButtonItem_ChiTietNhapHang_Thoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_ChiTietNhapHang_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ChiTietNhapHang_Thoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1918, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 682);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1918, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 658);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1918, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 658);
            // 
            // barButtonItem_NhapHang_Sua
            // 
            this.barButtonItem_NhapHang_Sua.Caption = "Sửa";
            this.barButtonItem_NhapHang_Sua.Id = 2;
            this.barButtonItem_NhapHang_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NhapHang_Sua.ImageOptions.Image")));
            this.barButtonItem_NhapHang_Sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NhapHang_Sua.ImageOptions.LargeImage")));
            this.barButtonItem_NhapHang_Sua.Name = "barButtonItem_NhapHang_Sua";
            this.barButtonItem_NhapHang_Sua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // Form_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 702);
            this.Controls.Add(this.groupBox_ChiTietNhapHang);
            this.Controls.Add(this.groupBox_PhieuNhapHang);
            this.Controls.Add(this.gridControl_ChiTietNhapHang);
            this.Controls.Add(this.gridControl_PhieuDatHang);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form_NhapHang";
            this.Text = "Form_NhapHang";
            this.Load += new System.EventHandler(this.Form_NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PhieuDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ChiTietNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox_PhieuNhapHang.ResumeLayout(false);
            this.groupBox_PhieuNhapHang.PerformLayout();
            this.groupBox_ChiTietNhapHang.ResumeLayout(false);
            this.groupBox_ChiTietNhapHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_PhieuDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl_ChiTietNhapHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox groupBox_PhieuNhapHang;
        private System.Windows.Forms.GroupBox groupBox_ChiTietNhapHang;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_NhapHang_Them;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_NhapHang_Sua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_NhapHang_Ghi;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_NhapHang_Thoát;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_PhieuNhapHang_Xoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ChiTietNhapHang_Them;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ChiTietNhapHang_Xoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ChiTietNhapHang_Sua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ChiTietNhapHang_Ghi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ChiTietNhapHang_Thoat;
        private System.Windows.Forms.TextBox textBox_TongTien;
        private System.Windows.Forms.TextBox textBox_NhanVien;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.TextBox textBox_NgayLap;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ChiTieNhapHang_TenHangHoa;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox_ChiTietNhapHang_IDHH;
        private System.Windows.Forms.TextBox textBox_ChiTieNhapHang_ThanhTien;
        private System.Windows.Forms.TextBox textBox_ChiTieNhapHang_IDPhieuNhap;
        private System.Windows.Forms.TextBox textBox_ChiTietNhapHang_ID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}