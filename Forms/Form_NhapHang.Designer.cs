
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
            this.groupBox_ChiTietNhapHang = new System.Windows.Forms.GroupBox();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_NhapHang_Them = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_NhapHang_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_NhapHang_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_NhapHang_Ghi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_NhapHang_Thoát = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PhieuDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ChiTietNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.gridControl_ChiTietNhapHang.Size = new System.Drawing.Size(923, 457);
            this.gridControl_ChiTietNhapHang.TabIndex = 1;
            this.gridControl_ChiTietNhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl_ChiTietNhapHang;
            this.gridView2.Name = "gridView2";
            // 
            // groupBox_PhieuNhapHang
            // 
            this.groupBox_PhieuNhapHang.Location = new System.Drawing.Point(32, 516);
            this.groupBox_PhieuNhapHang.Name = "groupBox_PhieuNhapHang";
            this.groupBox_PhieuNhapHang.Size = new System.Drawing.Size(842, 174);
            this.groupBox_PhieuNhapHang.TabIndex = 2;
            this.groupBox_PhieuNhapHang.TabStop = false;
            this.groupBox_PhieuNhapHang.Text = "Thông tin phiếu nhập hàng";
            // 
            // groupBox_ChiTietNhapHang
            // 
            this.groupBox_ChiTietNhapHang.Location = new System.Drawing.Point(942, 517);
            this.groupBox_ChiTietNhapHang.Name = "groupBox_ChiTietNhapHang";
            this.groupBox_ChiTietNhapHang.Size = new System.Drawing.Size(930, 173);
            this.groupBox_ChiTietNhapHang.TabIndex = 3;
            this.groupBox_ChiTietNhapHang.TabStop = false;
            this.groupBox_ChiTietNhapHang.Text = "Thông tin chi tiết phiếu nhập hàng";
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
            this.barButtonItem_NhapHang_Xoa,
            this.barButtonItem_NhapHang_Sua,
            this.barButtonItem_NhapHang_Ghi,
            this.barButtonItem_NhapHang_Thoát,
            this.barButtonItem1,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_NhapHang_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_NhapHang_Sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_NhapHang_Ghi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_NhapHang_Thoát),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
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
            // 
            // barButtonItem_NhapHang_Xoa
            // 
            this.barButtonItem_NhapHang_Xoa.Caption = "Xóa";
            this.barButtonItem_NhapHang_Xoa.Id = 1;
            this.barButtonItem_NhapHang_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NhapHang_Xoa.ImageOptions.Image")));
            this.barButtonItem_NhapHang_Xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NhapHang_Xoa.ImageOptions.LargeImage")));
            this.barButtonItem_NhapHang_Xoa.Name = "barButtonItem_NhapHang_Xoa";
            this.barButtonItem_NhapHang_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "                             ";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "                             ";
            this.barButtonItem2.Enabled = false;
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "                                            ";
            this.barButtonItem3.Enabled = false;
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "                           ";
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
            // 
            // barButtonItem_ChiTietNhapHang_Xoa
            // 
            this.barButtonItem_ChiTietNhapHang_Xoa.Caption = "Xóa";
            this.barButtonItem_ChiTietNhapHang_Xoa.Id = 11;
            this.barButtonItem_ChiTietNhapHang_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Xoa.ImageOptions.Image")));
            this.barButtonItem_ChiTietNhapHang_Xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Xoa.ImageOptions.LargeImage")));
            this.barButtonItem_ChiTietNhapHang_Xoa.Name = "barButtonItem_ChiTietNhapHang_Xoa";
            this.barButtonItem_ChiTietNhapHang_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem_ChiTietNhapHang_Sua
            // 
            this.barButtonItem_ChiTietNhapHang_Sua.Caption = "Sửa";
            this.barButtonItem_ChiTietNhapHang_Sua.Id = 12;
            this.barButtonItem_ChiTietNhapHang_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Sua.ImageOptions.Image")));
            this.barButtonItem_ChiTietNhapHang_Sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Sua.ImageOptions.LargeImage")));
            this.barButtonItem_ChiTietNhapHang_Sua.Name = "barButtonItem_ChiTietNhapHang_Sua";
            this.barButtonItem_ChiTietNhapHang_Sua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem_ChiTietNhapHang_Ghi
            // 
            this.barButtonItem_ChiTietNhapHang_Ghi.Caption = "Ghi";
            this.barButtonItem_ChiTietNhapHang_Ghi.Id = 13;
            this.barButtonItem_ChiTietNhapHang_Ghi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Ghi.ImageOptions.Image")));
            this.barButtonItem_ChiTietNhapHang_Ghi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Ghi.ImageOptions.LargeImage")));
            this.barButtonItem_ChiTietNhapHang_Ghi.Name = "barButtonItem_ChiTietNhapHang_Ghi";
            this.barButtonItem_ChiTietNhapHang_Ghi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem_ChiTietNhapHang_Thoat
            // 
            this.barButtonItem_ChiTietNhapHang_Thoat.Caption = "Thoát";
            this.barButtonItem_ChiTietNhapHang_Thoat.Id = 14;
            this.barButtonItem_ChiTietNhapHang_Thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Thoat.ImageOptions.Image")));
            this.barButtonItem_ChiTietNhapHang_Thoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChiTietNhapHang_Thoat.ImageOptions.LargeImage")));
            this.barButtonItem_ChiTietNhapHang_Thoat.Name = "barButtonItem_ChiTietNhapHang_Thoat";
            this.barButtonItem_ChiTietNhapHang_Thoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem_NhapHang_Xoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_NhapHang_Sua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_NhapHang_Ghi;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_NhapHang_Thoát;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ChiTietNhapHang_Them;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ChiTietNhapHang_Xoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ChiTietNhapHang_Sua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ChiTietNhapHang_Ghi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ChiTietNhapHang_Thoat;
    }
}