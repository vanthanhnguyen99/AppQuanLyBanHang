using DevExpress.XtraEditors;
using QLBH_API.Entity;
using QLBH_API.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_API.Forms
{
    public partial class Form_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        BindingList<NhanVien> listNhanVien;
        public Form_NhanVien()
        {
            
            InitializeComponent();
            
        }

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {
            // load list

            loadToTable();
           

        }
        public void loadToTable()
        {
            List<NhanVien> nhanViens = new Service_NhanVien().getListNhanVien();
            if (listNhanVien == null) listNhanVien = new BindingList<NhanVien>();
            foreach (NhanVien nhanVien in nhanViens)
            {
                //nhanVien.chuanHoaDuLieu();
               listNhanVien.Add(nhanVien);
                //MessageBox.Show(nhanVien.hoTen);
            }

            //MessageBox.Show(gridControl_NhanVien.DataSource.ToString());
            gridControl_NhanVien.DataSource = listNhanVien;
            gridView1.PopulateColumns();

            gridView1.Columns["id"].Caption = "ID";
            gridView1.Columns["diaChi"].Caption = "Địa chỉ";
            gridView1.Columns["email"].Caption = "Email";
            gridView1.Columns["sdt"].Caption = "Số điện thoại";
            gridView1.Columns["hoTen"].Caption = "Họ tên";
            gridView1.Columns["matKhau"].Caption = "Mật khẩu";

            gridView1.Columns["id"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["diaChi"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["email"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["sdt"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["hoTen"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["matKhau"].OptionsColumn.AllowEdit = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            NhanVien nhanVien = (NhanVien) gridView1.GetFocusedValue();

            if (nhanVien == null) return;

            textBox_ID.Text = nhanVien.id;
        }
    }
}