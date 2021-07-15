
namespace QLBH_API.Forms
{
    partial class Form_DatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DatHang));
            this.gridControl_PhieuDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_ChiTietDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox_PhieDatHang = new System.Windows.Forms.GroupBox();
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
            this.groupBox_ChiTietDatHang = new System.Windows.Forms.GroupBox();
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
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Ghi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.textBox_TenHangHoa = new System.Windows.Forms.TextBox();
            this.comboBox_TrangThai = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_IDKH = new System.Windows.Forms.TextBox();
            this.textBox_TenKH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PhieuDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ChiTietDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox_PhieDatHang.SuspendLayout();
            this.groupBox_ChiTietDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_PhieuDatHang
            // 
            this.gridControl_PhieuDatHang.Location = new System.Drawing.Point(37, 26);
            this.gridControl_PhieuDatHang.MainView = this.gridView1;
            this.gridControl_PhieuDatHang.Name = "gridControl_PhieuDatHang";
            this.gridControl_PhieuDatHang.Size = new System.Drawing.Size(849, 432);
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
            // gridControl_ChiTietDatHang
            // 
            this.gridControl_ChiTietDatHang.Location = new System.Drawing.Point(942, 26);
            this.gridControl_ChiTietDatHang.MainView = this.gridView2;
            this.gridControl_ChiTietDatHang.Name = "gridControl_ChiTietDatHang";
            this.gridControl_ChiTietDatHang.Size = new System.Drawing.Size(937, 432);
            this.gridControl_ChiTietDatHang.TabIndex = 1;
            this.gridControl_ChiTietDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl_ChiTietDatHang;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // groupBox_PhieDatHang
            // 
            this.groupBox_PhieDatHang.Controls.Add(this.label14);
            this.groupBox_PhieDatHang.Controls.Add(this.label13);
            this.groupBox_PhieDatHang.Controls.Add(this.textBox_TenKH);
            this.groupBox_PhieDatHang.Controls.Add(this.textBox_IDKH);
            this.groupBox_PhieDatHang.Controls.Add(this.label12);
            this.groupBox_PhieDatHang.Controls.Add(this.comboBox_TrangThai);
            this.groupBox_PhieDatHang.Controls.Add(this.textBox_TongTien);
            this.groupBox_PhieDatHang.Controls.Add(this.textBox_NhanVien);
            this.groupBox_PhieDatHang.Controls.Add(this.textBox_HoTen);
            this.groupBox_PhieDatHang.Controls.Add(this.textBox_NgayLap);
            this.groupBox_PhieDatHang.Controls.Add(this.textBox_ID);
            this.groupBox_PhieDatHang.Controls.Add(this.label5);
            this.groupBox_PhieDatHang.Controls.Add(this.label4);
            this.groupBox_PhieDatHang.Controls.Add(this.label3);
            this.groupBox_PhieDatHang.Controls.Add(this.label2);
            this.groupBox_PhieDatHang.Controls.Add(this.label1);
            this.groupBox_PhieDatHang.Location = new System.Drawing.Point(37, 499);
            this.groupBox_PhieDatHang.Name = "groupBox_PhieDatHang";
            this.groupBox_PhieDatHang.Size = new System.Drawing.Size(849, 174);
            this.groupBox_PhieDatHang.TabIndex = 4;
            this.groupBox_PhieDatHang.TabStop = false;
            this.groupBox_PhieDatHang.Text = "Thông tin phiếu nhập hàng";
            // 
            // textBox_TongTien
            // 
            this.textBox_TongTien.Location = new System.Drawing.Point(480, 36);
            this.textBox_TongTien.Name = "textBox_TongTien";
            this.textBox_TongTien.ReadOnly = true;
            this.textBox_TongTien.Size = new System.Drawing.Size(131, 21);
            this.textBox_TongTien.TabIndex = 9;
            // 
            // textBox_NhanVien
            // 
            this.textBox_NhanVien.Location = new System.Drawing.Point(71, 90);
            this.textBox_NhanVien.Name = "textBox_NhanVien";
            this.textBox_NhanVien.ReadOnly = true;
            this.textBox_NhanVien.Size = new System.Drawing.Size(128, 21);
            this.textBox_NhanVien.TabIndex = 8;
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Location = new System.Drawing.Point(267, 95);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.ReadOnly = true;
            this.textBox_HoTen.Size = new System.Drawing.Size(131, 21);
            this.textBox_HoTen.TabIndex = 7;
            // 
            // textBox_NgayLap
            // 
            this.textBox_NgayLap.Location = new System.Drawing.Point(267, 36);
            this.textBox_NgayLap.Name = "textBox_NgayLap";
            this.textBox_NgayLap.ReadOnly = true;
            this.textBox_NgayLap.Size = new System.Drawing.Size(131, 21);
            this.textBox_NgayLap.TabIndex = 6;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(71, 41);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(128, 21);
            this.textBox_ID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox_ChiTietDatHang
            // 
            this.groupBox_ChiTietDatHang.Controls.Add(this.textBox_TenHangHoa);
            this.groupBox_ChiTietDatHang.Controls.Add(this.numericUpDown1);
            this.groupBox_ChiTietDatHang.Controls.Add(this.textBox_ChiTietNhapHang_IDHH);
            this.groupBox_ChiTietDatHang.Controls.Add(this.textBox_ChiTieNhapHang_ThanhTien);
            this.groupBox_ChiTietDatHang.Controls.Add(this.textBox_ChiTieNhapHang_IDPhieuNhap);
            this.groupBox_ChiTietDatHang.Controls.Add(this.textBox_ChiTietNhapHang_ID);
            this.groupBox_ChiTietDatHang.Controls.Add(this.label11);
            this.groupBox_ChiTietDatHang.Controls.Add(this.label10);
            this.groupBox_ChiTietDatHang.Controls.Add(this.label9);
            this.groupBox_ChiTietDatHang.Controls.Add(this.label8);
            this.groupBox_ChiTietDatHang.Controls.Add(this.label7);
            this.groupBox_ChiTietDatHang.Controls.Add(this.label6);
            this.groupBox_ChiTietDatHang.Enabled = false;
            this.groupBox_ChiTietDatHang.Location = new System.Drawing.Point(942, 499);
            this.groupBox_ChiTietDatHang.Name = "groupBox_ChiTietDatHang";
            this.groupBox_ChiTietDatHang.Size = new System.Drawing.Size(937, 174);
            this.groupBox_ChiTietDatHang.TabIndex = 5;
            this.groupBox_ChiTietDatHang.TabStop = false;
            this.groupBox_ChiTietDatHang.Text = "Thông tin chi tiết phiếu nhập hàng";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(427, 56);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(182, 21);
            this.numericUpDown1.TabIndex = 12;
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
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem_Sua,
            this.barButtonItem_Ghi,
            this.barButtonItem_Thoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
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
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Ghi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Thoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "                                                          ";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "                                                             ";
            this.barButtonItem2.Enabled = false;
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "                                                                 ";
            this.barButtonItem3.Enabled = false;
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "                                                                ";
            this.barButtonItem4.Enabled = false;
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "                                ";
            this.barButtonItem5.Enabled = false;
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem_Sua
            // 
            this.barButtonItem_Sua.Caption = "Sửa";
            this.barButtonItem_Sua.Id = 5;
            this.barButtonItem_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Sua.ImageOptions.Image")));
            this.barButtonItem_Sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Sua.ImageOptions.LargeImage")));
            this.barButtonItem_Sua.Name = "barButtonItem_Sua";
            this.barButtonItem_Sua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Sua_ItemClick);
            // 
            // barButtonItem_Ghi
            // 
            this.barButtonItem_Ghi.Caption = "Ghi";
            this.barButtonItem_Ghi.Id = 6;
            this.barButtonItem_Ghi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Ghi.ImageOptions.Image")));
            this.barButtonItem_Ghi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Ghi.ImageOptions.LargeImage")));
            this.barButtonItem_Ghi.Name = "barButtonItem_Ghi";
            this.barButtonItem_Ghi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Ghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Ghi_ItemClick);
            // 
            // barButtonItem_Thoat
            // 
            this.barButtonItem_Thoat.Caption = "Thoát";
            this.barButtonItem_Thoat.Id = 7;
            this.barButtonItem_Thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Thoat.ImageOptions.Image")));
            this.barButtonItem_Thoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Thoat.ImageOptions.LargeImage")));
            this.barButtonItem_Thoat.Name = "barButtonItem_Thoat";
            this.barButtonItem_Thoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Thoat_ItemClick);
            // 
            // textBox_TenHangHoa
            // 
            this.textBox_TenHangHoa.Location = new System.Drawing.Point(427, 126);
            this.textBox_TenHangHoa.Name = "textBox_TenHangHoa";
            this.textBox_TenHangHoa.Size = new System.Drawing.Size(182, 21);
            this.textBox_TenHangHoa.TabIndex = 13;
            // 
            // comboBox_TrangThai
            // 
            this.comboBox_TrangThai.FormattingEnabled = true;
            this.comboBox_TrangThai.Items.AddRange(new object[] {
            "Hủy đơn",
            "Chờ xác nhận",
            "Xác nhận và giao hàng",
            "Hoàn thành"});
            this.comboBox_TrangThai.Location = new System.Drawing.Point(703, 36);
            this.comboBox_TrangThai.Name = "comboBox_TrangThai";
            this.comboBox_TrangThai.Size = new System.Drawing.Size(124, 21);
            this.comboBox_TrangThai.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(641, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Trạng thái";
            // 
            // textBox_IDKH
            // 
            this.textBox_IDKH.Location = new System.Drawing.Point(480, 100);
            this.textBox_IDKH.Name = "textBox_IDKH";
            this.textBox_IDKH.ReadOnly = true;
            this.textBox_IDKH.Size = new System.Drawing.Size(131, 21);
            this.textBox_IDKH.TabIndex = 12;
            // 
            // textBox_TenKH
            // 
            this.textBox_TenKH.Location = new System.Drawing.Point(703, 95);
            this.textBox_TenKH.Name = "textBox_TenKH";
            this.textBox_TenKH.ReadOnly = true;
            this.textBox_TenKH.Size = new System.Drawing.Size(124, 21);
            this.textBox_TenKH.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(411, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Khách hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(641, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Họ tên";
            // 
            // Form_DatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 702);
            this.Controls.Add(this.groupBox_ChiTietDatHang);
            this.Controls.Add(this.groupBox_PhieDatHang);
            this.Controls.Add(this.gridControl_ChiTietDatHang);
            this.Controls.Add(this.gridControl_PhieuDatHang);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form_DatHang";
            this.Text = "Đặt hàng";
            this.Load += new System.EventHandler(this.Form_DatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PhieuDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ChiTietDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox_PhieDatHang.ResumeLayout(false);
            this.groupBox_PhieDatHang.PerformLayout();
            this.groupBox_ChiTietDatHang.ResumeLayout(false);
            this.groupBox_ChiTietDatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_PhieuDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl_ChiTietDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox groupBox_PhieDatHang;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_TrangThai;
        private System.Windows.Forms.GroupBox groupBox_ChiTietDatHang;
        private System.Windows.Forms.TextBox textBox_TenHangHoa;
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
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Sua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Ghi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Thoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_TenKH;
        private System.Windows.Forms.TextBox textBox_IDKH;
    }
}