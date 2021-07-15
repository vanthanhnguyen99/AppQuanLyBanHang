using DevExpress.XtraEditors;
using QLBH_API.Entity;
using QLBH_API.Form;
using QLBH_API.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_API.Forms
{
    public partial class Form_NhapHang : DevExpress.XtraEditors.XtraForm
    {
        BindingList<PhieuNhapHang> listPhieuNhapHang = null;
        BindingList<CtNhapHang> listChiTietNhapHang = null;
        BindingList<HangHoa> listHangHoa = null;
        volatile bool isEdit = true;
        public Form_NhapHang()
        {
            InitializeComponent();
        }

        private void Form_NhapHang_Load(object sender, EventArgs e)
        {

            barButtonItem_NhapHang_Them.Enabled = true;
            barButtonItem_PhieuNhapHang_Xoa.Enabled = (gridView1.RowCount > 0);
            barButtonItem_ChiTietNhapHang_Them.Enabled = true;
            barButtonItem_ChiTietNhapHang_Xoa.Enabled = (gridView2.RowCount > 0);
            barButtonItem_ChiTietNhapHang_Sua.Enabled = (gridView2.RowCount > 0);
            barButtonItem_ChiTietNhapHang_Ghi.Enabled = false;
            barButtonItem_ChiTietNhapHang_Thoat.Enabled = false;

            gridControl_ChiTietNhapHang.Enabled = true;
            groupBox_ChiTietNhapHang.Enabled = false;

            loadToTablePhieuNhapHang();


            if (listHangHoa == null)
            {
                listHangHoa = new BindingList<HangHoa>();
                listHangHoa.Add(new HangHoa());
                List<HangHoa> hangHoas = new Service_HangHoa().getListHangHoa();
                foreach (HangHoa hangHoa in hangHoas)
                {
                    listHangHoa.Add(hangHoa);
                }
            }

            comboBox_ChiTieNhapHang_TenHangHoa.DataSource = listHangHoa;
            comboBox_ChiTieNhapHang_TenHangHoa.ValueMember = "id";
            comboBox_ChiTieNhapHang_TenHangHoa.DisplayMember = "ten";

        }

        private void loadToTablePhieuNhapHang()
        {
            if (listPhieuNhapHang == null) listPhieuNhapHang = new BindingList<PhieuNhapHang>();
            List<PhieuNhapHang> phieuNhapHangs = new Service_PhieuNhapHang().getListPhieuNhapHang();
            foreach (PhieuNhapHang phieuNhapHang in phieuNhapHangs)
            {
                listPhieuNhapHang.Add(phieuNhapHang);
            }

            gridControl_PhieuDatHang.DataSource = listPhieuNhapHang;
            gridView1.PopulateColumns();

            gridView1.Columns["id"].Caption = "ID";
            gridView1.Columns["ngayLap"].Caption = "Ngày lập";
            gridView1.Columns["tongTien"].Caption = "Tổng tiền";
            gridView1.Columns["idNV"].Caption = "Nhâp viên lập phiếu";

            gridView1.Columns["id"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["ngayLap"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["tongTien"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["idNV"].OptionsColumn.AllowEdit = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]) == null)
            {
                
                barButtonItem_NhapHang_Them.Enabled = true;
                barButtonItem_PhieuNhapHang_Xoa.Enabled = (gridView1.RowCount > 0);
                barButtonItem_ChiTietNhapHang_Them.Enabled = false;
                barButtonItem_ChiTietNhapHang_Xoa.Enabled = (gridView2.RowCount > 0);
                barButtonItem_ChiTietNhapHang_Sua.Enabled = false;
                barButtonItem_ChiTietNhapHang_Ghi.Enabled = false;
                barButtonItem_ChiTietNhapHang_Thoat.Enabled = false;

                gridControl_ChiTietNhapHang.Enabled = true;
                groupBox_ChiTietNhapHang.Enabled = false;
                return;
            } 
            string id = gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]).ToString();
            loadToTableChiTietNhapHang(id);

            textBox_ID.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]).ToString();
            textBox_NgayLap.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["ngayLap"]).ToString();
            textBox_TongTien.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["tongTien"]).ToString();
            string idNV = gridView1.GetFocusedRowCellValue(gridView1.Columns["idNV"]).ToString();
            NhanVien nhanVien = new Service_NhanVien().getNhanVien(idNV);
            textBox_NhanVien.Text = idNV;
            textBox_HoTen.Text = nhanVien.hoTen;

            barButtonItem_NhapHang_Them.Enabled = true;
            barButtonItem_PhieuNhapHang_Xoa.Enabled = (gridView1.RowCount > 0);
            barButtonItem_ChiTietNhapHang_Them.Enabled = true;
            barButtonItem_ChiTietNhapHang_Xoa.Enabled = (gridView2.RowCount > 0);
            barButtonItem_ChiTietNhapHang_Sua.Enabled = (gridView2.RowCount > 0);
            barButtonItem_ChiTietNhapHang_Ghi.Enabled = false;
            barButtonItem_ChiTietNhapHang_Thoat.Enabled = false;

            gridControl_ChiTietNhapHang.Enabled = true;
            groupBox_ChiTietNhapHang.Enabled = false;

        }

        private void loadToTableChiTietNhapHang(string id)
        {
            if (listChiTietNhapHang == null) listChiTietNhapHang = new BindingList<CtNhapHang>();
            listChiTietNhapHang.Clear();
            List<CtNhapHang> ctNhapHangs = new Service_ChiTietPhieuNhapHang().getListChiTietNhapHang(id);
            if (ctNhapHangs == null) return;
            foreach(CtNhapHang ctNhapHang in  ctNhapHangs)
            {
                listChiTietNhapHang.Add(ctNhapHang);
            }

            gridControl_ChiTietNhapHang.DataSource = listChiTietNhapHang;
            gridView2.PopulateColumns();

            gridView2.Columns["id"].Caption = "ID";
            gridView2.Columns["soLuong"].Caption = "Số lượng";
            gridView2.Columns["thanhTien"].Caption = "Thành tiền";
            gridView2.Columns["idhh"].Caption = "ID Hàng hóa";
            gridView2.Columns["idPhieuNhapHang"].Caption = "ID Phiếu nhập hàng";

            gridView2.Columns["id"].OptionsColumn.AllowEdit = false;
            gridView2.Columns["soLuong"].OptionsColumn.AllowEdit = false;
            gridView2.Columns["thanhTien"].OptionsColumn.AllowEdit = false;
            gridView2.Columns["idhh"].OptionsColumn.AllowEdit = false;
            gridView2.Columns["idPhieuNhapHang"].OptionsColumn.AllowEdit = false;

            gridView2.RefreshData();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue(gridView2.Columns["id"]) == null)
            {
                if (isEdit)
                {
                    textBox_ChiTieNhapHang_IDPhieuNhap.Text = "";
                }
                textBox_ChiTieNhapHang_ThanhTien.Text = "";
                if (isEdit) textBox_ChiTietNhapHang_ID.Text = "";
                textBox_ChiTietNhapHang_IDHH.Text = "";
                comboBox_ChiTieNhapHang_TenHangHoa.SelectedIndex = 0;
                numericUpDown1.Value = 0;
                return;
            }
           
            comboBox_ChiTieNhapHang_TenHangHoa.SelectedValue = gridView2.GetFocusedRowCellValue(gridView2.Columns["idhh"]).ToString();
            if (isEdit) textBox_ChiTietNhapHang_ID.Text = gridView2.GetFocusedRowCellValue(gridView2.Columns["id"]).ToString();
            numericUpDown1.Value = Decimal.Parse(gridView2.GetFocusedRowCellValue(gridView2.Columns["soLuong"]).ToString());
            textBox_ChiTieNhapHang_ThanhTien.Text = gridView2.GetFocusedRowCellValue(gridView2.Columns["thanhTien"]).ToString();
            textBox_ChiTieNhapHang_IDPhieuNhap.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]).ToString();
        }

        private void comboBox_ChiTieNhapHang_TenHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ChiTieNhapHang_TenHangHoa.SelectedValue == null || comboBox_ChiTieNhapHang_TenHangHoa.SelectedIndex == 0) return;
            textBox_ChiTietNhapHang_IDHH.Text = comboBox_ChiTieNhapHang_TenHangHoa.SelectedValue.ToString();


            if (groupBox_ChiTietNhapHang.Enabled)
            {
                if (comboBox_ChiTieNhapHang_TenHangHoa.SelectedIndex != 0 && numericUpDown1.Value != 0)
                {
                    GiaHangHoa giaHangHoa = new Service_ChiTietGiaNhap().getGiaNhapHang(textBox_ChiTietNhapHang_IDHH.Text);
                    textBox_ChiTieNhapHang_ThanhTien.Text = (giaHangHoa.gia * numericUpDown1.Value).ToString();
                }
                else
                {
                    textBox_ChiTieNhapHang_ThanhTien.Text = "0";
                }
            }
        }

        private void barButtonItem_NhapHang_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (gridView1.RowCount > 0)
                textBox_ID.Text = Program.generateID(gridView1.GetRowCellDisplayText(gridView1.RowCount - 1, gridView1.Columns["id"]));
            else textBox_ID.Text = "PNH001";

            gridView1.AddNewRow();
            NhanVien nhanVien = new Service_NhanVien().getNhanVien(Form_Login.username);
            textBox_NhanVien.Text = nhanVien.id.ToUpper();
            textBox_HoTen.Text = nhanVien.hoTen;
            textBox_TongTien.Text = "0";
            textBox_NgayLap.Text = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            gridView1.SetFocusedRowCellValue(gridView1.Columns["id"], textBox_ID.Text);
            gridView1.SetFocusedRowCellValue(gridView1.Columns["ngayLap"], textBox_NgayLap.Text);
            gridView1.SetFocusedRowCellValue(gridView1.Columns["tongTien"], "0");
            gridView1.SetFocusedRowCellValue(gridView1.Columns["idNV"], textBox_NhanVien.Text);

            PhieuNhapHang phieuNhapHang = new PhieuNhapHang();
            phieuNhapHang.id = textBox_ID.Text;
            phieuNhapHang.ngayLap = textBox_NgayLap.Text;
            phieuNhapHang.tongTien = numericUpDown1.Value;
            phieuNhapHang.idNV = textBox_NhanVien.Text;

            if (!new Service_PhieuNhapHang().insertPhieuNhapHang(phieuNhapHang))
            {
                MessageBox.Show(Service_PhieuNhapHang.errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridView1.DeleteSelectedRows();
                return;
            }

            if (gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]) == null)
            {

                barButtonItem_NhapHang_Them.Enabled = true;
                barButtonItem_PhieuNhapHang_Xoa.Enabled = (gridView1.RowCount > 0);
                barButtonItem_ChiTietNhapHang_Them.Enabled = false;
                barButtonItem_ChiTietNhapHang_Xoa.Enabled = (gridView2.RowCount > 0);
                barButtonItem_ChiTietNhapHang_Sua.Enabled = false;
                barButtonItem_ChiTietNhapHang_Ghi.Enabled = false;
                barButtonItem_ChiTietNhapHang_Thoat.Enabled = false;

                gridControl_ChiTietNhapHang.Enabled = true;
                groupBox_ChiTietNhapHang.Enabled = false;
                return;
            }
            string id = gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]).ToString();
            loadToTableChiTietNhapHang(id);

            barButtonItem_NhapHang_Them.Enabled = true;
            barButtonItem_PhieuNhapHang_Xoa.Enabled = (gridView1.RowCount > 0);
            barButtonItem_ChiTietNhapHang_Them.Enabled = true;
            barButtonItem_ChiTietNhapHang_Xoa.Enabled = (gridView2.RowCount > 0);
            barButtonItem_ChiTietNhapHang_Sua.Enabled = (gridView2.RowCount > 0);
            barButtonItem_ChiTietNhapHang_Ghi.Enabled = false;
            barButtonItem_ChiTietNhapHang_Thoat.Enabled = false;

            gridControl_ChiTietNhapHang.Enabled = true;
            groupBox_ChiTietNhapHang.Enabled = false;


        }

        private void barButtonItem_ChiTietNhapHang_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isEdit = false;


            // xử lý combobox

            for (int i = 0; i < gridView2.RowCount; i++)
            {
                string id = (gridView2.GetRowCellDisplayText(i, gridView2.Columns["idhh"]));

                listHangHoa.Remove(listHangHoa.SingleOrDefault(p => p.id == id));
                
                //for (int j = 0; j < listHangHoa.Count; j++)
                //{
                //    if (id.Trim() == listHangHoa.g)
                //}

            }
            if (listHangHoa.Count == 0)
            {
                MessageBox.Show("Không thể thêm hàng hóa vào đơn nhập này","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    string id = (gridView2.GetRowCellDisplayText(i, gridView2.Columns["idhh"]));

                    listHangHoa.Add(new Service_HangHoa().getHangHoa(id));
                }
                isEdit = true;
                return;
            }


            comboBox_ChiTieNhapHang_TenHangHoa.DataSource = listHangHoa;
            comboBox_ChiTieNhapHang_TenHangHoa.ValueMember = "id";
            comboBox_ChiTieNhapHang_TenHangHoa.DisplayMember = "ten";

            gridView2.AddNewRow();
            List<CtNhapHang> ctNhapHangs = new Service_ChiTietPhieuNhapHang().getListChiTietNhapHang();
  
            if (gridView2.RowCount > 1)
                textBox_ChiTietNhapHang_ID.Text = Program.generateID(ctNhapHangs[ctNhapHangs.Count-1].id);
            else textBox_ChiTietNhapHang_ID.Text = "CTNH001";
            //MessageBox.Show(Program.generateID(ctNhapHangs[ctNhapHangs.Count - 1].id));
            

            barButtonItem_NhapHang_Them.Enabled = false;
            barButtonItem_PhieuNhapHang_Xoa.Enabled = false;
            barButtonItem_ChiTietNhapHang_Them.Enabled = false;
            barButtonItem_ChiTietNhapHang_Xoa.Enabled = false;
            barButtonItem_ChiTietNhapHang_Sua.Enabled = false;
            barButtonItem_ChiTietNhapHang_Ghi.Enabled = true;
            barButtonItem_ChiTietNhapHang_Thoat.Enabled = true;
            comboBox_ChiTieNhapHang_TenHangHoa.Enabled = true;

            gridControl_ChiTietNhapHang.Enabled = false;
            groupBox_ChiTietNhapHang.Enabled = true;

            //textBox_ChiTieNhapHang_IDPhieuNhap.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]).ToString();


           

            
        }

        private void barButtonItem_ChiTietNhapHang_Sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isEdit = true;

            textBox_ChiTieNhapHang_IDPhieuNhap.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]).ToString();

            barButtonItem_NhapHang_Them.Enabled = false;
            barButtonItem_PhieuNhapHang_Xoa.Enabled = false;
            barButtonItem_ChiTietNhapHang_Them.Enabled = false;
            barButtonItem_ChiTietNhapHang_Xoa.Enabled = false;
            barButtonItem_ChiTietNhapHang_Sua.Enabled = false;
            barButtonItem_ChiTietNhapHang_Ghi.Enabled = true;
            barButtonItem_ChiTietNhapHang_Thoat.Enabled = true;
            comboBox_ChiTieNhapHang_TenHangHoa.Enabled = false;

            gridControl_ChiTietNhapHang.Enabled = false;
            groupBox_ChiTietNhapHang.Enabled = true;
        }

        private void barButtonItem_PhieuNhapHang_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập hàng " + textBox_ID.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (!new Service_PhieuNhapHang().deletePhieuNhapHang(textBox_ID.Text))
                {
                    if (Service_PhieuNhapHang.errorCode == "5")
                    {
                        MessageBox.Show("Không thể xóa mẫu tin này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show(Service_PhieuNhapHang.errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                gridView1.DeleteSelectedRows();
            }
        }

        private void barButtonItem_ChiTietNhapHang_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa hàng hóa " + textBox_ChiTietNhapHang_IDHH.Text + "ra khỏi phiếu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                HangHoa hangHoa = new Service_HangHoa().getHangHoa(textBox_ChiTietNhapHang_IDHH.Text);

                if (hangHoa.soLuongTon < int.Parse(gridView2.GetFocusedRowCellValue(gridView2.Columns["soLuong"]).ToString()))
                {
                    MessageBox.Show("Không thể xóa. Không đủ hàng trong kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (!new Service_ChiTietPhieuNhapHang().deleteChiPhieuNhap(textBox_ChiTietNhapHang_ID.Text))
                {
                    MessageBox.Show(Service_ChiTietPhieuNhapHang.errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                gridView2.DeleteSelectedRows();
            }
        }

        private void barButtonItem_ChiTietNhapHang_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!isEdit)
            {
               

                // add lại
                for (int i = 0; i < gridView2.RowCount-1; i++)
                {
                    string id = (gridView2.GetRowCellDisplayText(i, gridView2.Columns["idhh"]));

                    listHangHoa.Add(new Service_HangHoa().getHangHoa(id));
                }

                gridView2.DeleteSelectedRows();
            }
            else
            {
                comboBox_ChiTieNhapHang_TenHangHoa.SelectedValue = gridView2.GetFocusedRowCellValue(gridView2.Columns["idhh"]).ToString();
                textBox_ChiTietNhapHang_ID.Text = gridView2.GetFocusedRowCellValue(gridView2.Columns["id"]).ToString();
                numericUpDown1.Value = Decimal.Parse(gridView2.GetFocusedRowCellValue(gridView2.Columns["soLuong"]).ToString());
                textBox_ChiTieNhapHang_ThanhTien.Text = gridView2.GetFocusedRowCellValue(gridView2.Columns["thanhTien"]).ToString();
                textBox_ChiTieNhapHang_IDPhieuNhap.Text = gridView2.GetFocusedRowCellValue(gridView2.Columns["idPhieuNhapHang"]).ToString();
            }

            barButtonItem_NhapHang_Them.Enabled = true;
            barButtonItem_PhieuNhapHang_Xoa.Enabled = true;
            barButtonItem_ChiTietNhapHang_Them.Enabled = true;
            barButtonItem_ChiTietNhapHang_Xoa.Enabled = (gridView2.RowCount > 0);
            barButtonItem_ChiTietNhapHang_Sua.Enabled = true;
            barButtonItem_ChiTietNhapHang_Ghi.Enabled = false;
            barButtonItem_ChiTietNhapHang_Thoat.Enabled = false;

            gridControl_ChiTietNhapHang.Enabled = true;
            groupBox_ChiTietNhapHang.Enabled = false;
            isEdit = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!groupBox_ChiTietNhapHang.Enabled) return;
            
            if (numericUpDown1.Value < 0) numericUpDown1.Value = 0;
            if (comboBox_ChiTieNhapHang_TenHangHoa.SelectedIndex != 0 && numericUpDown1.Value != 0)
            {
                GiaHangHoa giaHangHoa = new Service_ChiTietGiaNhap().getGiaNhapHang(textBox_ChiTietNhapHang_IDHH.Text);
                if (giaHangHoa == null) return;
                textBox_ChiTieNhapHang_ThanhTien.Text = (giaHangHoa.gia * numericUpDown1.Value).ToString();
            }
            else
            {
                textBox_ChiTieNhapHang_ThanhTien.Text = "0";
            }
        }

        private void barButtonItem_ChiTietNhapHang_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textBox_ChiTietNhapHang_IDHH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CtNhapHang ctNhapHang = new CtNhapHang();
            ctNhapHang.id = textBox_ChiTietNhapHang_ID.Text;
            ctNhapHang.soLuong = (int)numericUpDown1.Value;
            ctNhapHang.thanhTien = int.Parse(textBox_ChiTieNhapHang_ThanhTien.Text);
            ctNhapHang.idhh = textBox_ChiTietNhapHang_IDHH.Text;
            ctNhapHang.idPhieuNhapHang = textBox_ChiTieNhapHang_IDPhieuNhap.Text;

            if (!isEdit)
            {
                if (!new Service_ChiTietPhieuNhapHang().insertChiTietPhieuNhapHang(ctNhapHang))
                {
                    MessageBox.Show(Service_ChiTietPhieuNhapHang.errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // add lại
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    string id = (gridView2.GetRowCellDisplayText(i, gridView2.Columns["idhh"]));

                    listHangHoa.Add(new Service_HangHoa().getHangHoa(id));
                }
            }
            else
            {
                // so sánh với kho
                HangHoa hangHoa = new Service_HangHoa().getHangHoa(textBox_ChiTietNhapHang_IDHH.Text);
                
                if (hangHoa.soLuongTon < int.Parse(gridView2.GetFocusedRowCellValue(gridView2.Columns["soLuong"]).ToString()) - (int)numericUpDown1.Value)
                {
                    MessageBox.Show("Không thể thay đổi giá trị. Không đủ hàng trong kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (!new Service_ChiTietPhieuNhapHang().updateChiTietPhieuNhapHang(ctNhapHang))
                {
                    MessageBox.Show(Service_ChiTietPhieuNhapHang.errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Cập nhật lại giá
            int tong = 0;
            for (int i = 0; i < gridView2.RowCount-1; i++)
            {
                tong = tong + int.Parse(gridView2.GetRowCellDisplayText(i, gridView2.Columns["thanhTien"]));
            }
            tong = tong + int.Parse(textBox_ChiTieNhapHang_ThanhTien.Text);

            PhieuNhapHang phieuNhapHang = new PhieuNhapHang();
            phieuNhapHang.id = textBox_ID.Text;
            phieuNhapHang.ngayLap = textBox_NgayLap.Text;
            phieuNhapHang.tongTien = tong;
            phieuNhapHang.idNV = Form_Login.username.ToUpper();

            if (!new Service_PhieuNhapHang().updatePhieuNhapHang(phieuNhapHang))
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox_TongTien.Text = tong.ToString();
            NhanVien nhanVien = new Service_NhanVien().getNhanVien(Form_Login.username);
            textBox_NhanVien.Text = nhanVien.id.ToUpper();
            textBox_HoTen.Text = nhanVien.hoTen;
            // Hiển thị data mới
            gridView2.SetFocusedRowCellValue(gridView2.Columns["id"], textBox_ChiTietNhapHang_ID.Text);
            gridView2.SetFocusedRowCellValue(gridView2.Columns["soLuong"], numericUpDown1.Value.ToString());
            gridView2.SetFocusedRowCellValue(gridView2.Columns["thanhTien"], textBox_ChiTieNhapHang_ThanhTien.Text);
            gridView2.SetFocusedRowCellValue(gridView2.Columns["idhh"], textBox_ChiTietNhapHang_IDHH.Text);
            gridView2.SetFocusedRowCellValue(gridView2.Columns["idPhieuNhapHang"], textBox_ChiTieNhapHang_IDPhieuNhap.Text);


            gridView1.SetFocusedRowCellValue(gridView1.Columns["tongTien"], textBox_TongTien.Text);
            gridView1.SetFocusedRowCellValue(gridView1.Columns["idNV"], textBox_NhanVien.Text.ToUpper());

            // Hiển thị lại button
            barButtonItem_NhapHang_Them.Enabled = true;
            barButtonItem_PhieuNhapHang_Xoa.Enabled = true;
            barButtonItem_ChiTietNhapHang_Them.Enabled = true;
            barButtonItem_ChiTietNhapHang_Xoa.Enabled = true;
            barButtonItem_ChiTietNhapHang_Sua.Enabled = true;
            barButtonItem_ChiTietNhapHang_Ghi.Enabled = false;
            barButtonItem_ChiTietNhapHang_Thoat.Enabled = false;
            comboBox_ChiTieNhapHang_TenHangHoa.Enabled = true;

            gridControl_ChiTietNhapHang.Enabled = true;
            groupBox_ChiTietNhapHang.Enabled = false;

            isEdit = true;
        }
    }
}