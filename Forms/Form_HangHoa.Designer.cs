
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
            this.groupBox_input = new System.Windows.Forms.GroupBox();
            this.gridControl_HangHoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureBox_anh = new System.Windows.Forms.PictureBox();
            this.groupBox_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_HangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_input
            // 
            this.groupBox_input.Controls.Add(this.pictureBox_anh);
            this.groupBox_input.Location = new System.Drawing.Point(26, 419);
            this.groupBox_input.Name = "groupBox_input";
            this.groupBox_input.Size = new System.Drawing.Size(1180, 267);
            this.groupBox_input.TabIndex = 1;
            this.groupBox_input.TabStop = false;
            this.groupBox_input.Text = "Hàng hóa";
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
            // pictureBox_anh
            // 
            this.pictureBox_anh.Location = new System.Drawing.Point(15, 25);
            this.pictureBox_anh.Name = "pictureBox_anh";
            this.pictureBox_anh.Size = new System.Drawing.Size(317, 236);
            this.pictureBox_anh.TabIndex = 0;
            this.pictureBox_anh.TabStop = false;
            // 
            // Form_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 702);
            this.Controls.Add(this.gridControl_HangHoa);
            this.Controls.Add(this.groupBox_input);
            this.Name = "Form_HangHoa";
            this.Text = "Form_HangHoa";
            this.Load += new System.EventHandler(this.Form_HangHoa_Load);
            this.groupBox_input.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_HangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_input;
        private DevExpress.XtraGrid.GridControl gridControl_HangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.PictureBox pictureBox_anh;
    }
}