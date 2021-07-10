
namespace QLBH_API.Forms
{
    partial class Form_HangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HangHoa));
            this.groupBox_input = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Gia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Ten = new System.Windows.Forms.TextBox();
            this.textBox_SoLuongTon = new System.Windows.Forms.TextBox();
            this.richTextBox_MoTa = new System.Windows.Forms.RichTextBox();
            this.textBox_KhoiLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.pictureBox_anh = new System.Windows.Forms.PictureBox();
            this.gridControl_HangHoa = new DevExpress.XtraGrid.GridControl();
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
            this.barButtonItem_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.groupBox_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_HangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_input
            // 
            this.groupBox_input.Controls.Add(this.label5);
            this.groupBox_input.Controls.Add(this.textBox_Gia);
            this.groupBox_input.Controls.Add(this.label4);
            this.groupBox_input.Controls.Add(this.label3);
            this.groupBox_input.Controls.Add(this.label2);
            this.groupBox_input.Controls.Add(this.textBox_Ten);
            this.groupBox_input.Controls.Add(this.textBox_SoLuongTon);
            this.groupBox_input.Controls.Add(this.richTextBox_MoTa);
            this.groupBox_input.Controls.Add(this.textBox_KhoiLuong);
            this.groupBox_input.Controls.Add(this.label1);
            this.groupBox_input.Controls.Add(this.label);
            this.groupBox_input.Controls.Add(this.textBox_ID);
            this.groupBox_input.Controls.Add(this.pictureBox_anh);
            this.groupBox_input.Location = new System.Drawing.Point(26, 401);
            this.groupBox_input.Name = "groupBox_input";
            this.groupBox_input.Size = new System.Drawing.Size(1180, 285);
            this.groupBox_input.TabIndex = 1;
            this.groupBox_input.TabStop = false;
            this.groupBox_input.Text = "Hàng hóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giá";
            // 
            // textBox_Gia
            // 
            this.textBox_Gia.Location = new System.Drawing.Point(469, 136);
            this.textBox_Gia.Name = "textBox_Gia";
            this.textBox_Gia.Size = new System.Drawing.Size(215, 21);
            this.textBox_Gia.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(773, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số lượng tồn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên";
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.Location = new System.Drawing.Point(847, 35);
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.Size = new System.Drawing.Size(195, 21);
            this.textBox_Ten.TabIndex = 7;
            this.textBox_Ten.Leave += new System.EventHandler(this.textBox_Ten_Leave);
            // 
            // textBox_SoLuongTon
            // 
            this.textBox_SoLuongTon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_SoLuongTon.Enabled = false;
            this.textBox_SoLuongTon.Location = new System.Drawing.Point(847, 83);
            this.textBox_SoLuongTon.Name = "textBox_SoLuongTon";
            this.textBox_SoLuongTon.Size = new System.Drawing.Size(195, 21);
            this.textBox_SoLuongTon.TabIndex = 6;
            // 
            // richTextBox_MoTa
            // 
            this.richTextBox_MoTa.Location = new System.Drawing.Point(469, 177);
            this.richTextBox_MoTa.Name = "richTextBox_MoTa";
            this.richTextBox_MoTa.Size = new System.Drawing.Size(573, 89);
            this.richTextBox_MoTa.TabIndex = 5;
            this.richTextBox_MoTa.Text = "";
            this.richTextBox_MoTa.Leave += new System.EventHandler(this.richTextBox_MoTa_Leave);
            // 
            // textBox_KhoiLuong
            // 
            this.textBox_KhoiLuong.Location = new System.Drawing.Point(469, 86);
            this.textBox_KhoiLuong.Name = "textBox_KhoiLuong";
            this.textBox_KhoiLuong.Size = new System.Drawing.Size(215, 21);
            this.textBox_KhoiLuong.TabIndex = 4;
            this.textBox_KhoiLuong.Text = " ";
            this.textBox_KhoiLuong.Leave += new System.EventHandler(this.textBox_KhoiLuong_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khối lượng";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(421, 38);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(18, 13);
            this.label.TabIndex = 2;
            this.label.Text = "ID";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(469, 38);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(215, 21);
            this.textBox_ID.TabIndex = 1;
            // 
            // pictureBox_anh
            // 
            this.pictureBox_anh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_anh.Location = new System.Drawing.Point(28, 20);
            this.pictureBox_anh.Name = "pictureBox_anh";
            this.pictureBox_anh.Size = new System.Drawing.Size(304, 236);
            this.pictureBox_anh.TabIndex = 0;
            this.pictureBox_anh.TabStop = false;
            this.pictureBox_anh.Click += new System.EventHandler(this.pictureBox_anh_Click);
            // 
            // gridControl_HangHoa
            // 
            this.gridControl_HangHoa.Location = new System.Drawing.Point(26, 37);
            this.gridControl_HangHoa.MainView = this.gridView1;
            this.gridControl_HangHoa.Name = "gridControl_HangHoa";
            this.gridControl_HangHoa.Size = new System.Drawing.Size(1180, 358);
            this.gridControl_HangHoa.TabIndex = 2;
            this.gridControl_HangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_HangHoa;
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
            this.barButtonItem_Them,
            this.barButtonItem_Xoa,
            this.barButtonItem_Sua,
            this.barButtonItem_Ghi,
            this.barButtonItem_Thoat,
            this.barButtonItem_Refresh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(305, 124);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Them),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Ghi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Thoat),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Refresh)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_Them
            // 
            this.barButtonItem_Them.Caption = "Thêm";
            this.barButtonItem_Them.Id = 0;
            this.barButtonItem_Them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Them.ImageOptions.Image")));
            this.barButtonItem_Them.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Them.ImageOptions.LargeImage")));
            this.barButtonItem_Them.Name = "barButtonItem_Them";
            this.barButtonItem_Them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Them_ItemClick);
            // 
            // barButtonItem_Xoa
            // 
            this.barButtonItem_Xoa.Caption = "Xóa";
            this.barButtonItem_Xoa.Id = 1;
            this.barButtonItem_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Xoa.ImageOptions.Image")));
            this.barButtonItem_Xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Xoa.ImageOptions.LargeImage")));
            this.barButtonItem_Xoa.Name = "barButtonItem_Xoa";
            this.barButtonItem_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Xoa_ItemClick);
            // 
            // barButtonItem_Sua
            // 
            this.barButtonItem_Sua.Caption = "Sửa";
            this.barButtonItem_Sua.Id = 2;
            this.barButtonItem_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Sua.ImageOptions.Image")));
            this.barButtonItem_Sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Sua.ImageOptions.LargeImage")));
            this.barButtonItem_Sua.Name = "barButtonItem_Sua";
            this.barButtonItem_Sua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem_Ghi
            // 
            this.barButtonItem_Ghi.Caption = "Ghi";
            this.barButtonItem_Ghi.Id = 3;
            this.barButtonItem_Ghi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Ghi.ImageOptions.Image")));
            this.barButtonItem_Ghi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Ghi.ImageOptions.LargeImage")));
            this.barButtonItem_Ghi.Name = "barButtonItem_Ghi";
            this.barButtonItem_Ghi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Ghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Ghi_ItemClick);
            // 
            // barButtonItem_Thoat
            // 
            this.barButtonItem_Thoat.Caption = "Thoát";
            this.barButtonItem_Thoat.Id = 4;
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
            // barButtonItem_Refresh
            // 
            this.barButtonItem_Refresh.Caption = "Refresh";
            this.barButtonItem_Refresh.Id = 5;
            this.barButtonItem_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Refresh.ImageOptions.Image")));
            this.barButtonItem_Refresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Refresh.ImageOptions.LargeImage")));
            this.barButtonItem_Refresh.Name = "barButtonItem_Refresh";
            this.barButtonItem_Refresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Refresh_ItemClick);
            // 
            // Form_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 702);
            this.Controls.Add(this.gridControl_HangHoa);
            this.Controls.Add(this.groupBox_input);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form_HangHoa";
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.Form_HangHoa_Load);
            this.groupBox_input.ResumeLayout(false);
            this.groupBox_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_HangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_input;
        private DevExpress.XtraGrid.GridControl gridControl_HangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.PictureBox pictureBox_anh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Ten;
        private System.Windows.Forms.TextBox textBox_SoLuongTon;
        private System.Windows.Forms.RichTextBox richTextBox_MoTa;
        private System.Windows.Forms.TextBox textBox_KhoiLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox_ID;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Them;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Xoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Sua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Ghi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Thoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Gia;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Refresh;
    }
}