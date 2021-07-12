
namespace QLBH_API.Forms
{
    partial class Form_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_KhachHang));
            this.gridControl_KhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_Them = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Ghi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.groupBox_input = new System.Windows.Forms.GroupBox();
            this.richTextBox_DiaChi = new System.Windows.Forms.RichTextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_SoDienThoai = new System.Windows.Forms.TextBox();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.label_SoDienThoai = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_HoTen = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_KhachHang
            // 
            this.gridControl_KhachHang.Location = new System.Drawing.Point(29, 46);
            this.gridControl_KhachHang.MainView = this.gridView1;
            this.gridControl_KhachHang.Name = "gridControl_KhachHang";
            this.gridControl_KhachHang.Size = new System.Drawing.Size(1168, 392);
            this.gridControl_KhachHang.TabIndex = 0;
            this.gridControl_KhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_KhachHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
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
            this.barButtonItem_Them,
            this.barButtonItem_Xoa,
            this.barButtonItem_Sua,
            this.barButtonItem_Ghi,
            this.barButtonItem_Thoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Them),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Ghi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Thoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_Them
            // 
            this.barButtonItem_Them.Caption = "Thêm";
            this.barButtonItem_Them.Id = 5;
            this.barButtonItem_Them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Them.ImageOptions.Image")));
            this.barButtonItem_Them.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Them.ImageOptions.LargeImage")));
            this.barButtonItem_Them.Name = "barButtonItem_Them";
            this.barButtonItem_Them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Them_ItemClick);
            // 
            // barButtonItem_Xoa
            // 
            this.barButtonItem_Xoa.Caption = "Xóa";
            this.barButtonItem_Xoa.Id = 6;
            this.barButtonItem_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Xoa.ImageOptions.Image")));
            this.barButtonItem_Xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Xoa.ImageOptions.LargeImage")));
            this.barButtonItem_Xoa.Name = "barButtonItem_Xoa";
            this.barButtonItem_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Xoa_ItemClick);
            // 
            // barButtonItem_Sua
            // 
            this.barButtonItem_Sua.Caption = "Sửa";
            this.barButtonItem_Sua.Id = 7;
            this.barButtonItem_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Sua.ImageOptions.Image")));
            this.barButtonItem_Sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Sua.ImageOptions.LargeImage")));
            this.barButtonItem_Sua.Name = "barButtonItem_Sua";
            this.barButtonItem_Sua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Sua_ItemClick);
            // 
            // barButtonItem_Ghi
            // 
            this.barButtonItem_Ghi.Caption = "Ghi";
            this.barButtonItem_Ghi.Id = 8;
            this.barButtonItem_Ghi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Ghi.ImageOptions.Image")));
            this.barButtonItem_Ghi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Ghi.ImageOptions.LargeImage")));
            this.barButtonItem_Ghi.Name = "barButtonItem_Ghi";
            this.barButtonItem_Ghi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Ghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Ghi_ItemClick);
            // 
            // barButtonItem_Thoat
            // 
            this.barButtonItem_Thoat.Caption = "Thoát";
            this.barButtonItem_Thoat.Id = 9;
            this.barButtonItem_Thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Thoat.ImageOptions.Image")));
            this.barButtonItem_Thoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Thoat.ImageOptions.LargeImage")));
            this.barButtonItem_Thoat.Name = "barButtonItem_Thoat";
            this.barButtonItem_Thoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Thoat_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1234, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 682);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1234, 20);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1234, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 658);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // groupBox_input
            // 
            this.groupBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_input.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_input.Controls.Add(this.richTextBox_DiaChi);
            this.groupBox_input.Controls.Add(this.textBox_Password);
            this.groupBox_input.Controls.Add(this.textBox_Email);
            this.groupBox_input.Controls.Add(this.textBox_SoDienThoai);
            this.groupBox_input.Controls.Add(this.textBox_HoTen);
            this.groupBox_input.Controls.Add(this.label_SoDienThoai);
            this.groupBox_input.Controls.Add(this.label_Password);
            this.groupBox_input.Controls.Add(this.label_HoTen);
            this.groupBox_input.Controls.Add(this.label_Email);
            this.groupBox_input.Controls.Add(this.label_DiaChi);
            this.groupBox_input.Controls.Add(this.textBox_ID);
            this.groupBox_input.Controls.Add(this.label_ID);
            this.groupBox_input.Location = new System.Drawing.Point(23, 473);
            this.groupBox_input.Name = "groupBox_input";
            this.groupBox_input.Size = new System.Drawing.Size(1174, 203);
            this.groupBox_input.TabIndex = 6;
            this.groupBox_input.TabStop = false;
            this.groupBox_input.Text = "Thông tin khách hàng";
            // 
            // richTextBox_DiaChi
            // 
            this.richTextBox_DiaChi.Location = new System.Drawing.Point(843, 50);
            this.richTextBox_DiaChi.Name = "richTextBox_DiaChi";
            this.richTextBox_DiaChi.Size = new System.Drawing.Size(325, 112);
            this.richTextBox_DiaChi.TabIndex = 13;
            this.richTextBox_DiaChi.Text = "";
            this.richTextBox_DiaChi.Leave += new System.EventHandler(this.richTextBox_DiaChi_Leave);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(624, 102);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(141, 21);
            this.textBox_Password.TabIndex = 12;
            this.textBox_Password.Leave += new System.EventHandler(this.textBox_Password_Leave);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(387, 138);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(142, 21);
            this.textBox_Email.TabIndex = 10;
            this.textBox_Email.Leave += new System.EventHandler(this.textBox_Email_Leave);
            // 
            // textBox_SoDienThoai
            // 
            this.textBox_SoDienThoai.Location = new System.Drawing.Point(387, 50);
            this.textBox_SoDienThoai.Name = "textBox_SoDienThoai";
            this.textBox_SoDienThoai.Size = new System.Drawing.Size(142, 21);
            this.textBox_SoDienThoai.TabIndex = 9;
            this.textBox_SoDienThoai.Leave += new System.EventHandler(this.textBox_SoDienThoai_Leave);
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Location = new System.Drawing.Point(105, 135);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(143, 21);
            this.textBox_HoTen.TabIndex = 8;
            this.textBox_HoTen.Leave += new System.EventHandler(this.textBox_HoTen_Leave);
            // 
            // label_SoDienThoai
            // 
            this.label_SoDienThoai.AutoSize = true;
            this.label_SoDienThoai.Location = new System.Drawing.Point(289, 53);
            this.label_SoDienThoai.Name = "label_SoDienThoai";
            this.label_SoDienThoai.Size = new System.Drawing.Size(69, 13);
            this.label_SoDienThoai.TabIndex = 7;
            this.label_SoDienThoai.Text = "Số điện thoại";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(550, 102);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(51, 13);
            this.label_Password.TabIndex = 5;
            this.label_Password.Text = "Mật khẩu";
            // 
            // label_HoTen
            // 
            this.label_HoTen.AutoSize = true;
            this.label_HoTen.Location = new System.Drawing.Point(48, 138);
            this.label_HoTen.Name = "label_HoTen";
            this.label_HoTen.Size = new System.Drawing.Size(42, 13);
            this.label_HoTen.TabIndex = 4;
            this.label_HoTen.Text = " Họ tên";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(289, 141);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(31, 13);
            this.label_Email.TabIndex = 3;
            this.label_Email.Text = "Email";
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.AutoSize = true;
            this.label_DiaChi.Location = new System.Drawing.Point(793, 105);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(44, 13);
            this.label_DiaChi.TabIndex = 2;
            this.label_DiaChi.Text = " ĐỊa chi";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(105, 50);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(143, 21);
            this.textBox_ID.TabIndex = 1;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(48, 53);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 13);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID ";
            // 
            // Form_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 702);
            this.Controls.Add(this.groupBox_input);
            this.Controls.Add(this.gridControl_KhachHang);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form_KhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.Form_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox_input.ResumeLayout(false);
            this.groupBox_input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_KhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox groupBox_input;
        private System.Windows.Forms.RichTextBox richTextBox_DiaChi;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_SoDienThoai;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.Label label_SoDienThoai;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_HoTen;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_DiaChi;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_ID;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Them;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Xoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Sua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Ghi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Thoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}