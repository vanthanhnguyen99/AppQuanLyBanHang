using DevExpress.XtraEditors;
using QLBH_API.Entity;
using QLBH_API.Form;
using QLBH_API.Services;
using QLBH_API.Validation;
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
    public partial class Form_KhachHang : DevExpress.XtraEditors.XtraForm
    {
        BindingList<KhachHang> listKhachHang;
        bool isEdit;
        KhachHang khachHangEdit;
        public Form_KhachHang()
        {
            InitializeComponent();
        }

        private void Form_KhachHang_Load(object sender, EventArgs e)
        {
            loadToTable();

            groupBox_input.Enabled = false;

            switch (Form_Login.role)
            {
                case 0: // nhân viên
                    {
                        barButtonItem_Them.Enabled = true;
                        barButtonItem_Xoa.Enabled = true;
                        barButtonItem_Sua.Enabled = true;
                        barButtonItem_Ghi.Enabled = false;
                        barButtonItem_Thoat.Enabled = false;
                        break;
                    }
                case 1: // admin
                    {
                        barButtonItem_Them.Enabled = false;
                        barButtonItem_Xoa.Enabled = false;
                        barButtonItem_Sua.Enabled = false;
                        barButtonItem_Ghi.Enabled = false;
                        barButtonItem_Thoat.Enabled = false;
                        break;
                    }
            }
        }
        public void loadToTable()
        {
            List<KhachHang> khachHangs = new Service_KhachHang().getListKhachHang();
            if (listKhachHang == null) listKhachHang = new BindingList<KhachHang>();
            foreach (KhachHang khachHang in khachHangs)
            {
                listKhachHang.Add(khachHang);
            }

            //MessageBox.Show(gridControl_NhanVien.DataSource.ToString());
            gridControl_KhachHang.DataSource = listKhachHang;
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
            

            gridView1.Columns["matKhau"].Visible = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            KhachHang khachHang = (KhachHang)gridView1.GetFocusedRow();

            if (khachHang == null) return;
            textBox_ID.Text = khachHang.id;
            richTextBox_DiaChi.Text = khachHang.diaChi;
            textBox_Email.Text = khachHang.email;
            textBox_HoTen.Text = khachHang.hoTen;
            textBox_SoDienThoai.Text = khachHang.sdt;
            textBox_Password.Text = "";
            if (khachHang.matKhau != null)
                for (int i = 0; i < khachHang.matKhau.Length; i++)
                {
                    textBox_Password.Text += '*';
                }
        }

        private void barButtonItem_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isEdit = false;
            barButtonItem_Them.Enabled = false;
            barButtonItem_Xoa.Enabled = false;
            barButtonItem_Sua.Enabled = false;
            barButtonItem_Ghi.Enabled = true;
            barButtonItem_Thoat.Enabled = true;
            gridControl_KhachHang.Enabled = false;
            groupBox_input.Enabled = true;

            gridView1.AddNewRow();

            List<KhachHang> khachHangs = new Service_KhachHang().getListKhachHang();
            if (khachHangs.Count > 0) textBox_ID.Text = Program.generateID(khachHangs[khachHangs.Count - 1].id);
            else textBox_ID.Text = "KH001";

            
            
            richTextBox_DiaChi.Text = "";
            textBox_Email.Text = "";
            textBox_HoTen.Text = "";
            textBox_Password.Text = "";
            textBox_SoDienThoai.Text = "";
            groupBox_input.Enabled = true;
            textBox_Password.Enabled = true;

            khachHangEdit = new KhachHang();
            khachHangEdit.id = textBox_ID.Text;
            

            gridView1.SetFocusedRowCellValue(gridView1.Columns["id"], textBox_ID.Text);
            textBox_HoTen.Focus();
            
        }
        private void textBox_SoDienThoai_Leave(object sender, EventArgs e)
        {
            if (isEdit) return;
            if (khachHangEdit == null) return;
            khachHangEdit.sdt = textBox_SoDienThoai.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["sdt"], textBox_SoDienThoai.Text);
        }

        private void textBox_HoTen_Leave(object sender, EventArgs e)
        {
            if (isEdit) return;
            if (khachHangEdit == null) return;
            khachHangEdit.hoTen = textBox_HoTen.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["hoTen"], textBox_HoTen.Text);
        }

        private void textBox_Email_Leave(object sender, EventArgs e)
        {
            if (isEdit) return;
            if (khachHangEdit == null) return;
            khachHangEdit.email = textBox_Email.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["email"], textBox_Email.Text);
        }

        private void textBox_Password_Leave(object sender, EventArgs e)
        {
            if (isEdit) return;
            if (khachHangEdit == null) return;
            khachHangEdit.matKhau = textBox_Password.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["matKhau"], textBox_Password.Text);
        }

        private void richTextBox_DiaChi_Leave(object sender, EventArgs e)
        {
            if (isEdit) return;
            if (khachHangEdit == null) return;
            khachHangEdit.diaChi = richTextBox_DiaChi.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["diaChi"], richTextBox_DiaChi.Text);
        }

        private void barButtonItem_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isEdit)
            {
                textBox_HoTen.Text = khachHangEdit.hoTen;
                textBox_Email.Text = khachHangEdit.email;
                textBox_SoDienThoai.Text = khachHangEdit.sdt;
                richTextBox_DiaChi.Text = khachHangEdit.diaChi;
                

                khachHangEdit = null;
            }
            else
            {
                gridView1.DeleteSelectedRows();
                khachHangEdit = null;
                if (gridView1.RowCount > 0) gridView1.FocusedRowHandle = 0;
                else
                {
                    textBox_ID.Text = "";
                    textBox_HoTen.Text = "";
                    textBox_Password.Text = "";
                    textBox_Email.Text = "";
                    richTextBox_DiaChi.Text = "";
                }

            }


            groupBox_input.Enabled = false;
            gridControl_KhachHang.Enabled = true;
            barButtonItem_Them.Enabled = true;
            barButtonItem_Xoa.Enabled = true;
            barButtonItem_Sua.Enabled = true;
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;
        }

        private void barButtonItem_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textBox_Email.Text.Trim().Length == 0 || !ValidationData.checkEmail(textBox_Email.Text.Trim()))
            {
                MessageBox.Show("Địa chỉ email trống hoặc không đúng định dạng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (textBox_HoTen.Text.Length == 0)
            {
                MessageBox.Show("Không để trống để trống họ tên", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (textBox_Password.Text.Length == 0)
            {
                MessageBox.Show("Không để trống để trống mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (textBox_SoDienThoai.Text.Trim().Length == 0 || !ValidationData.checkSDT(textBox_SoDienThoai.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại trống hoặc không hợp lệ", "Thông báo", MessageBoxButtons.OK);

                return;
            }
            if (richTextBox_DiaChi.Text.Length == 0)
            {
                MessageBox.Show("Không để trống để trống địa chỉ", "Thông bá", MessageBoxButtons.OK);
                return;
            }


            if (!isEdit)
            {
                if (textBox_Email.Focused)
                {
                    khachHangEdit.email = textBox_Email.Text.Trim();
                    gridView1.SetFocusedRowCellValue(gridView1.Columns["email"], textBox_Email.Text.Trim());

                }
                if (textBox_HoTen.Focused)
                {
                    khachHangEdit.hoTen = textBox_HoTen.Text.Trim();
                    gridView1.SetFocusedRowCellValue(gridView1.Columns["hoTen"], textBox_HoTen.Text.Trim());
                }
                if (textBox_Password.Focused)
                {
                    khachHangEdit.matKhau = textBox_Password.Text;
                    gridView1.SetFocusedRowCellValue(gridView1.Columns["matKhau"], textBox_Password.Text);
                }
                if (textBox_SoDienThoai.Focused)
                {
                    khachHangEdit.sdt = textBox_SoDienThoai.Text.Trim();
                    gridView1.SetFocusedRowCellValue(gridView1.Columns["sdt"], textBox_SoDienThoai.Text.Trim());
                }
                if (richTextBox_DiaChi.Focused)
                {
                    khachHangEdit.diaChi = richTextBox_DiaChi.Text.Trim();
                    gridView1.SetFocusedRowCellValue(gridView1.Columns["diaChi"], richTextBox_DiaChi.Text.Trim());
                }


                if (!new Service_KhachHang().insertKhachHang(khachHangEdit))
                {
                    MessageBox.Show("Đã có lỗi xãy ra! Vui lòng thử lại sau");

                    List<KhachHang> khachHangs = new Service_KhachHang().getListKhachHang();
                    if (khachHangs.Count > 0) textBox_ID.Text = Program.generateID(khachHangs[khachHangs.Count - 1].id);
                    else textBox_ID.Text = "KH001";

                    return;
                }


                khachHangEdit = null;
                gridView1.FocusedRowHandle = 0;
            }
            else
            {
                khachHangEdit.hoTen = textBox_HoTen.Text;
                khachHangEdit.diaChi = richTextBox_DiaChi.Text;
                khachHangEdit.email = textBox_Email.Text;
                khachHangEdit.sdt = textBox_SoDienThoai.Text;


                if (!new Service_KhachHang().updateKhachHang(khachHangEdit))
                {
                    MessageBox.Show("Đã có lỗi xãy ra! Vui lòng thử lại sau");
                    return;
                }

                gridView1.SetFocusedRowCellValue(gridView1.Columns["hoTen"], khachHangEdit.hoTen);
                gridView1.SetFocusedRowCellValue(gridView1.Columns["diaChi"], khachHangEdit.diaChi);
                gridView1.SetFocusedRowCellValue(gridView1.Columns["email"], khachHangEdit.email);
                gridView1.SetFocusedRowCellValue(gridView1.Columns["sdt"], khachHangEdit.sdt);

                khachHangEdit = null;
            }

            groupBox_input.Enabled = false;
            barButtonItem_Them.Enabled = true;
            barButtonItem_Xoa.Enabled = true;
            barButtonItem_Sua.Enabled = true;
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;
            
            gridControl_KhachHang.Enabled = true;
            groupBox_input.Enabled = false;
        }

        private void barButtonItem_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa khách hàng " + textBox_ID.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (new Service_KhachHang().deleteKhachHang(textBox_ID.Text.Trim()))
                {
                    gridView1.DeleteSelectedRows();
                    if (gridView1.RowCount > 0) gridView1.FocusedRowHandle = 0;
                    else
                    {
                        textBox_ID.Text = "";
                        textBox_HoTen.Text = "";
                        textBox_Password.Text = "";
                        textBox_Email.Text = "";
                        richTextBox_DiaChi.Text = "";
                    }

                    groupBox_input.Enabled = false;
                    gridControl_KhachHang.Enabled = true;
                    barButtonItem_Them.Enabled = true;
                    barButtonItem_Xoa.Enabled = true;
                    barButtonItem_Sua.Enabled = true;
                    barButtonItem_Ghi.Enabled = false;
                    barButtonItem_Thoat.Enabled = false;

                    return;
                }
                else
                if (Service_KhachHang.errorCode.Equals("5"))
                {
                    MessageBox.Show("Không thể xóa mẫu tin này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show(Service_KhachHang.errorCode, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void barButtonItem_Sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isEdit = true;
            barButtonItem_Them.Enabled = false;
            barButtonItem_Xoa.Enabled = false;
            barButtonItem_Sua.Enabled = false;
            barButtonItem_Ghi.Enabled = true;
            barButtonItem_Thoat.Enabled = true;

            khachHangEdit = new KhachHang();
            khachHangEdit.id = textBox_ID.Text;
            khachHangEdit.hoTen = textBox_HoTen.Text;
            khachHangEdit.diaChi = richTextBox_DiaChi.Text;
            khachHangEdit.email = textBox_Email.Text;
            khachHangEdit.sdt = textBox_SoDienThoai.Text;
            khachHangEdit.matKhau = (string)gridView1.GetFocusedRowCellValue(gridView1.Columns["matKhau"]);

            gridControl_KhachHang.Enabled = false;
            groupBox_input.Enabled = true;
            textBox_Password.Enabled = false;
        }
    }
}