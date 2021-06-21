
namespace QLBH_API.Forms
{
    partial class Form_NhanVien
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
            this.gridControl_NhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox_input = new System.Windows.Forms.GroupBox();
            this.richTextBox_DiaChi = new System.Windows.Forms.RichTextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Quyen = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_SoDienThoai = new System.Windows.Forms.TextBox();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.label_SoDienThoai = new System.Windows.Forms.Label();
            this.label_Quyen = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_HoTen = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_NhanVien
            // 
            this.gridControl_NhanVien.Location = new System.Drawing.Point(29, 12);
            this.gridControl_NhanVien.MainView = this.gridView1;
            this.gridControl_NhanVien.Name = "gridControl_NhanVien";
            this.gridControl_NhanVien.Size = new System.Drawing.Size(1174, 434);
            this.gridControl_NhanVien.TabIndex = 0;
            this.gridControl_NhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl_NhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // groupBox_input
            // 
            this.groupBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_input.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_input.Controls.Add(this.richTextBox_DiaChi);
            this.groupBox_input.Controls.Add(this.textBox_Password);
            this.groupBox_input.Controls.Add(this.textBox_Quyen);
            this.groupBox_input.Controls.Add(this.textBox_Email);
            this.groupBox_input.Controls.Add(this.textBox_SoDienThoai);
            this.groupBox_input.Controls.Add(this.textBox_HoTen);
            this.groupBox_input.Controls.Add(this.label_SoDienThoai);
            this.groupBox_input.Controls.Add(this.label_Quyen);
            this.groupBox_input.Controls.Add(this.label_Password);
            this.groupBox_input.Controls.Add(this.label_HoTen);
            this.groupBox_input.Controls.Add(this.label_Email);
            this.groupBox_input.Controls.Add(this.label_DiaChi);
            this.groupBox_input.Controls.Add(this.textBox_ID);
            this.groupBox_input.Controls.Add(this.label_ID);
            this.groupBox_input.Location = new System.Drawing.Point(29, 473);
            this.groupBox_input.Name = "groupBox_input";
            this.groupBox_input.Size = new System.Drawing.Size(1174, 217);
            this.groupBox_input.TabIndex = 1;
            this.groupBox_input.TabStop = false;
            this.groupBox_input.Text = "Thông tin nhân viên";
            // 
            // richTextBox_DiaChi
            // 
            this.richTextBox_DiaChi.Location = new System.Drawing.Point(843, 50);
            this.richTextBox_DiaChi.Name = "richTextBox_DiaChi";
            this.richTextBox_DiaChi.Size = new System.Drawing.Size(315, 112);
            this.richTextBox_DiaChi.TabIndex = 13;
            this.richTextBox_DiaChi.Text = "";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(633, 141);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(141, 21);
            this.textBox_Password.TabIndex = 12;
            // 
            // textBox_Quyen
            // 
            this.textBox_Quyen.Location = new System.Drawing.Point(633, 50);
            this.textBox_Quyen.Name = "textBox_Quyen";
            this.textBox_Quyen.Size = new System.Drawing.Size(141, 21);
            this.textBox_Quyen.TabIndex = 11;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(387, 138);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(142, 21);
            this.textBox_Email.TabIndex = 10;
            // 
            // textBox_SoDienThoai
            // 
            this.textBox_SoDienThoai.Location = new System.Drawing.Point(387, 50);
            this.textBox_SoDienThoai.Name = "textBox_SoDienThoai";
            this.textBox_SoDienThoai.Size = new System.Drawing.Size(142, 21);
            this.textBox_SoDienThoai.TabIndex = 9;
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Location = new System.Drawing.Point(105, 135);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(143, 21);
            this.textBox_HoTen.TabIndex = 8;
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
            // label_Quyen
            // 
            this.label_Quyen.AutoSize = true;
            this.label_Quyen.Location = new System.Drawing.Point(559, 53);
            this.label_Quyen.Name = "label_Quyen";
            this.label_Quyen.Size = new System.Drawing.Size(28, 13);
            this.label_Quyen.TabIndex = 6;
            this.label_Quyen.Text = "Vị trí";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(559, 141);
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
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 702);
            this.Controls.Add(this.groupBox_input);
            this.Controls.Add(this.gridControl_NhanVien);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form_NhanVien";
            this.Text = "Form_NhanVien";
            this.Load += new System.EventHandler(this.Form_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox_input.ResumeLayout(false);
            this.groupBox_input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_NhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox_input;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_SoDienThoai;
        private System.Windows.Forms.Label label_Quyen;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_HoTen;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_DiaChi;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.RichTextBox richTextBox_DiaChi;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Quyen;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_SoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}