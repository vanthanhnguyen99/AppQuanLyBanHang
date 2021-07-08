using DevExpress.XtraEditors;
using QLBH_API.Entity;
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
    public partial class Form_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        bool isEdit = false;
        BindingList<NhanVien> listNhanVien;
        NhanVien NhanVienEdit = null;
        public Form_NhanVien()
        {
            
            InitializeComponent();
            
        }

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {
            // load list

            loadToTable();

            groupBox_input.Enabled = false;

            barButtonItem_Them.Enabled = true;
            barButtonItem_Xoa.Enabled = true;
            barButtonItem_Sua.Enabled = true;
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;

        }
        public void loadToTable()
        {
            List<NhanVien> nhanViens = new Service_NhanVien().getListNhanVien();
            if (listNhanVien == null) listNhanVien = new BindingList<NhanVien>();
            foreach (NhanVien nhanVien in nhanViens)
            {
               listNhanVien.Add(nhanVien);
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
            gridView1.Columns["quyen"].Caption = "Quyền";

            gridView1.Columns["id"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["diaChi"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["email"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["sdt"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["hoTen"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["matKhau"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["quyen"].OptionsColumn.AllowEdit = false;

            gridView1.Columns["matKhau"].Visible = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (NhanVienEdit != null) return;
            NhanVien nhanVien = (NhanVien) gridView1.GetFocusedRow();

            if (nhanVien == null) return;
            textBox_ID.Text = nhanVien.id;
            richTextBox_DiaChi.Text = nhanVien.diaChi;
            textBox_Email.Text = nhanVien.email;
            textBox_HoTen.Text = nhanVien.hoTen;
            if (nhanVien.quyen) comboBox_Quyen.SelectedIndex = 1;
            else comboBox_Quyen.SelectedIndex = 0;
            textBox_SoDienThoai.Text = nhanVien.sdt;
            textBox_Password.Text = "";
            if (nhanVien.matKhau != null)
            for (int i = 0; i < nhanVien.matKhau.Length; i++)
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

            List<NhanVien> nhanViens = new Service_NhanVien().getListNhanVien();
            int soLuong = nhanViens.Count;

            gridView1.AddNewRow();
            if (soLuong < 10)
            {
                textBox_ID.Text = "NV00" + soLuong;
            }
            else
            {
                if (soLuong < 100)
                {
                    textBox_ID.Text = "NV0" + soLuong;
                }
                else
                {
                    textBox_ID.Text = "NV" + soLuong;
                }
            }
            richTextBox_DiaChi.Text = "";
            textBox_Email.Text = "";
            textBox_HoTen.Text = "";
            textBox_Password.Text = "";
            comboBox_Quyen.SelectedIndex = 0;
            textBox_SoDienThoai.Text = "";
            gridControl_NhanVien.Enabled = false;
            groupBox_input.Enabled = true;
            textBox_Password.Enabled = true;

            NhanVienEdit = new NhanVien();
            NhanVienEdit.id = textBox_ID.Text;
            NhanVienEdit.quyen = false;

            gridView1.SetFocusedRowCellValue(gridView1.Columns["id"], textBox_ID.Text);
            textBox_HoTen.Focus();
        }
       
        private void textBox_SoDienThoai_Leave(object sender, EventArgs e)
        {
            if (isEdit) return;
            if (NhanVienEdit == null) return;
            NhanVienEdit.sdt = textBox_SoDienThoai.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["sdt"], textBox_SoDienThoai.Text);
        }

        private void textBox_HoTen_Leave(object sender, EventArgs e)
        {
            if(isEdit) return;
            if (NhanVienEdit == null) return;
            NhanVienEdit.hoTen = textBox_HoTen.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["hoTen"], textBox_HoTen.Text);
        }

        private void textBox_Email_Leave(object sender, EventArgs e)
        {
            if(isEdit) return;
            if (NhanVienEdit == null) return;
            NhanVienEdit.email = textBox_Email.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["email"], textBox_Email.Text);
        }

        private void textBox_Password_Leave(object sender, EventArgs e)
        {
            if (isEdit) return;
            if (NhanVienEdit == null) return;
            NhanVienEdit.matKhau = textBox_Password.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["matKhau"], textBox_Password.Text);
        }

        private void richTextBox_DiaChi_Leave(object sender, EventArgs e)
        {
            if (isEdit) return;
            if (NhanVienEdit == null) return;
            NhanVienEdit.diaChi = richTextBox_DiaChi.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["diaChi"], richTextBox_DiaChi.Text);
        }

        private void comboBox_Quyen_Leave(object sender, EventArgs e)
        {
            if (isEdit) return;
            if (NhanVienEdit == null) return;
            NhanVienEdit.quyen = (comboBox_Quyen.SelectedIndex == 1);
            gridView1.SetFocusedRowCellValue(gridView1.Columns["quyen"], comboBox_Quyen.SelectedIndex == 1);
        }

        private void barButtonItem_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isEdit)
            {
                textBox_HoTen.Text = NhanVienEdit.hoTen;
                textBox_Email.Text = NhanVienEdit.email;
                textBox_SoDienThoai.Text = NhanVienEdit.sdt;
                richTextBox_DiaChi.Text = NhanVienEdit.diaChi;
                if (NhanVienEdit.quyen) comboBox_Quyen.SelectedIndex = 1;
                else comboBox_Quyen.SelectedIndex = 0;

                NhanVienEdit = null;
            }    
            else
            {
                gridView1.DeleteSelectedRows();
                NhanVienEdit = null;
                if (gridView1.RowCount > 0) gridView1.FocusedRowHandle = 0;
                else
                {
                    textBox_ID.Text = "";
                    textBox_HoTen.Text = "";
                    textBox_Password.Text = "";
                    textBox_Email.Text = "";
                    richTextBox_DiaChi.Text = "";
                    comboBox_Quyen.SelectedIndex = 0;
                }

            }    
           

            groupBox_input.Enabled = false;
            gridControl_NhanVien.Enabled = true;
            barButtonItem_Them.Enabled = true;
            barButtonItem_Xoa.Enabled = true;
            barButtonItem_Sua.Enabled = true;
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;
        }

        private void barButtonItem_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidationData.checkEmail(textBox_Email.Text.Trim()))
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
            if (!ValidationData.checkSDT(textBox_SoDienThoai.Text.Trim()))
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
                    NhanVienEdit.email = textBox_Email.Text.Trim();
                    gridView1.SetFocusedRowCellValue(gridView1.Columns["email"], textBox_Email.Text.Trim());

                }
                if (textBox_HoTen.Focused)
                {
                    NhanVienEdit.hoTen = textBox_HoTen.Text.Trim();
                    gridView1.SetFocusedRowCellValue(gridView1.Columns["hoTen"], textBox_HoTen.Text.Trim());
                }
                if (textBox_Password.Focused)
                {
                    NhanVienEdit.matKhau = textBox_Password.Text;
                    gridView1.SetFocusedRowCellValue(gridView1.Columns["matKhau"], textBox_Password.Text);
                }
                if (textBox_SoDienThoai.Focused)
                {
                    NhanVienEdit.sdt = textBox_SoDienThoai.Text.Trim();
                    gridView1.SetFocusedRowCellValue(gridView1.Columns["sdt"], textBox_SoDienThoai.Text.Trim());
                }
                if (richTextBox_DiaChi.Focused)
                {
                    NhanVienEdit.diaChi = richTextBox_DiaChi.Text.Trim();
                    gridView1.SetFocusedRowCellValue(gridView1.Columns["diaChi"], richTextBox_DiaChi.Text.Trim());
                }


                if (!new Service_NhanVien().insertNhanVien(NhanVienEdit))
                {
                    MessageBox.Show("Đã có lỗi xãy ra! Vui lòng thử lại sau");
                    return;
                }
    

                NhanVienEdit = null;
                gridView1.FocusedRowHandle = 0;
            }
            else
            {
                NhanVienEdit.hoTen = textBox_HoTen.Text;
                NhanVienEdit.quyen = (comboBox_Quyen.SelectedIndex == 1);
                NhanVienEdit.diaChi = richTextBox_DiaChi.Text;
                NhanVienEdit.email = textBox_Email.Text;
                NhanVienEdit.sdt = textBox_SoDienThoai.Text;


                if (!new Service_NhanVien().updateNhanVien(NhanVienEdit))
                {
                    MessageBox.Show("Đã có lỗi xãy ra! Vui lòng thử lại sau");
                    return;
                }    

                gridView1.SetFocusedRowCellValue(gridView1.Columns["hoTen"], NhanVienEdit.hoTen);
                gridView1.SetFocusedRowCellValue(gridView1.Columns["quyen"], NhanVienEdit.quyen);
                gridView1.SetFocusedRowCellValue(gridView1.Columns["diaChi"], NhanVienEdit.diaChi);
                gridView1.SetFocusedRowCellValue(gridView1.Columns["email"], NhanVienEdit.email);
                gridView1.SetFocusedRowCellValue(gridView1.Columns["sdt"], NhanVienEdit.sdt);

                NhanVienEdit = null;
            }    

            groupBox_input.Enabled = false;
            gridControl_NhanVien.Enabled = true;
            barButtonItem_Them.Enabled = true;
            barButtonItem_Xoa.Enabled = true;
            barButtonItem_Sua.Enabled = true;
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;
        }

        private void barButtonItem_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắc muốn nhân viên " + textBox_ID.Text + "?" , "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if(new Service_NhanVien().deleteNhanVien(textBox_ID.Text.Trim()))
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
                        comboBox_Quyen.SelectedIndex = 0;
                    }

                    groupBox_input.Enabled = false;
                    gridControl_NhanVien.Enabled = true;
                    barButtonItem_Them.Enabled = true;
                    barButtonItem_Xoa.Enabled = true;
                    barButtonItem_Sua.Enabled = true;
                    barButtonItem_Ghi.Enabled = false;
                    barButtonItem_Thoat.Enabled = false;

                    return;
                }    
                if (Service_NhanVien.errorCode.Equals("5"))
                {
                    MessageBox.Show("Không thể xóa mẫu tin này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Lỗi máy chủ, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            NhanVienEdit = new NhanVien();
            NhanVienEdit.id = textBox_ID.Text;
            NhanVienEdit.hoTen = textBox_HoTen.Text;
            NhanVienEdit.quyen = (comboBox_Quyen.SelectedIndex == 1);
            NhanVienEdit.diaChi = richTextBox_DiaChi.Text;
            NhanVienEdit.email = textBox_Email.Text;
            NhanVienEdit.sdt = textBox_SoDienThoai.Text;
            NhanVienEdit.matKhau = (string)gridView1.GetFocusedRowCellValue(gridView1.Columns["matKhau"]);

            gridControl_NhanVien.Enabled = false;
            groupBox_input.Enabled = true;
            textBox_Password.Enabled = false;
        }
    }
}