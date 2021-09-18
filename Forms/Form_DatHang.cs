using DevExpress.DataAccess.Json;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class Form_DatHang : DevExpress.XtraEditors.XtraForm
    {
        BindingList<PhieuDatHang> listPhieuDatHang;
        BindingList<CtDatHang> listCtPhieuDatHang;
        List<string> list = new List<string>();
        public Form_DatHang()
        {
            list.Add("Hủy đơn");
            list.Add("Chờ xác nhận");
            list.Add("Xác nhận và giao hàng");
            list.Add ("Hoàn thành");
            list.Add("Giao hàng thất bại");
            InitializeComponent();
        }

        private void Form_DatHang_Load(object sender, EventArgs e)
        {
            loadToTablePhieuDatHang();
            barButtonItem_Sua.Enabled = (gridView1.RowCount > 0);
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;
            barButtonItem_Xem.Enabled = (gridView1.RowCount > 0);

            gridControl_PhieuDatHang.Enabled = true;
            groupBox_PhieDatHang.Enabled = false;

            
        }
        void loadToTablePhieuDatHang()
        {
            if (listPhieuDatHang == null) listPhieuDatHang = new BindingList<PhieuDatHang>();
            List<PhieuDatHang> phieuDatHangs = new Service_PhieuDatHang().getListPhieuDatHang();
            foreach(PhieuDatHang phieuDatHang in phieuDatHangs)
            {
                listPhieuDatHang.Add(phieuDatHang);
            }

            gridControl_PhieuDatHang.DataSource = listPhieuDatHang;
            gridView1.PopulateColumns();

            gridView1.Columns["id"].Caption = "ID";
            gridView1.Columns["ngayLap"].Caption = "Ngày lập";
            gridView1.Columns["tongTien"].Caption = "Tổng tiền";
            gridView1.Columns["idNV"].Caption = "Nhâp viên lập phiếu";
            gridView1.Columns["idKH"].Caption = "ID Khách hàng";
            gridView1.Columns["trangThai"].Caption = "Trạng thái";

            gridView1.Columns["id"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["ngayLap"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["tongTien"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["idNV"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["trangThai"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["idKH"].OptionsColumn.AllowEdit = false;

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                switch (gridView1.GetRowCellDisplayText(i,gridView1.Columns["trangThai"]))
                {
                    case "-1":
                        {
                            gridView1.SetRowCellValue(i,"trangThai", "Hủy đơn");
                            break;
                        }
                    case "0":
                        {
                            gridView1.SetRowCellValue(i, "trangThai", "Chờ xác nhận");
                            break;
                        }
                    case "1":
                        {
                            gridView1.SetRowCellValue(i, "trangThai", "Xác nhận và giao hàng");
                            break;
                        }
                    case "2":
                        {
                            gridView1.SetRowCellValue(i, "trangThai", "Hoàn thành");
                            break;
                        }
                    case "3":
                        {
                            gridView1.SetRowCellValue(i, "trangThai", "Giao hàng thất bại");
                            break;
                        }

                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textBox_ID.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]).ToString();
            textBox_NgayLap.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["ngayLap"]).ToString();
            textBox_TongTien.Text = Program.formatCurrency(gridView1.GetFocusedRowCellValue(gridView1.Columns["tongTien"]).ToString());
            textBox_NhanVien.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["idNV"]).ToString();
            NhanVien nhanVien = new Service_NhanVien().getNhanVien(textBox_NhanVien.Text);
            textBox_HoTen.Text = nhanVien.hoTen;
            textBox_IDKH.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["idKH"]).ToString();
            KhachHang khachHang = new Service_KhachHang().getKhachHang(textBox_IDKH.Text);
            textBox_TenKH.Text = khachHang.hoTen;
            comboBox_TrangThai.SelectedItem = gridView1.GetFocusedRowCellValue(gridView1.Columns["trangThai"]).ToString();

            loadToTableChiTiet(textBox_ID.Text);
        }

        void loadToTableChiTiet(string id)
        {
            if (listCtPhieuDatHang == null) listCtPhieuDatHang = new BindingList<CtDatHang>();
            List<CtDatHang> ctDatHangs = new Service_PhieuDatHang().ChiTietDatHang(id);
            listCtPhieuDatHang.Clear();
            foreach(CtDatHang ctDatHang in ctDatHangs)
            {
                listCtPhieuDatHang.Add(ctDatHang);
            }

            gridControl_ChiTietDatHang.DataSource = listCtPhieuDatHang;
            gridView2.PopulateColumns();

            gridView2.Columns["id"].Caption = "ID";
            gridView2.Columns["soLuong"].Caption = "Số lượng";
            gridView2.Columns["thanhTien"].Caption = "Thành tiền";
            gridView2.Columns["idHH"].Caption = "ID Hàng hóa";
            gridView2.Columns["idPhieuDatHang"].Caption = "ID Phiếu đặt hàng";

            gridView2.Columns["id"].OptionsColumn.AllowEdit = false;
            gridView2.Columns["soLuong"].OptionsColumn.AllowEdit = false;
            gridView2.Columns["thanhTien"].OptionsColumn.AllowEdit = false;
            gridView2.Columns["idHH"].OptionsColumn.AllowEdit = false;
            gridView2.Columns["idPhieuDatHang"].OptionsColumn.AllowEdit = false;
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue(gridView2.Columns["id"]) == null)
            {
                
               
                textBox_ChiTieNhapHang_IDPhieuNhap.Text = "";
                textBox_ChiTieNhapHang_ThanhTien.Text = "";
                textBox_ChiTietNhapHang_ID.Text = "";
                textBox_ChiTietNhapHang_IDHH.Text = "";
                textBox_TenHangHoa.Text = "";
                numericUpDown1.Value = 0;
                return;
            }

            HangHoa hangHoa = new Service_HangHoa().getHangHoa(gridView2.GetFocusedRowCellValue(gridView2.Columns["idHH"]).ToString());
            textBox_TenHangHoa.Text = hangHoa.ten;
            textBox_ChiTietNhapHang_ID.Text = gridView2.GetFocusedRowCellValue(gridView2.Columns["id"]).ToString();
            numericUpDown1.Value = Decimal.Parse(gridView2.GetFocusedRowCellValue(gridView2.Columns["soLuong"]).ToString());
            
           
            textBox_ChiTieNhapHang_ThanhTien.Text = Program.formatCurrency(gridView2.GetFocusedRowCellValue(gridView2.Columns["thanhTien"]).ToString());

            textBox_ChiTieNhapHang_IDPhieuNhap.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]).ToString();
            textBox_ChiTietNhapHang_IDHH.Text = hangHoa.id;
        }

        private void barButtonItem_Sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl_PhieuDatHang.Enabled = false;
            groupBox_PhieDatHang.Enabled = true;
            barButtonItem_Sua.Enabled = false;
            barButtonItem_Ghi.Enabled = true;
            barButtonItem_Thoat.Enabled = true;
            barButtonItem_Xem.Enabled = false;

            switch (gridView1.GetFocusedRowCellValue(gridView1.Columns["trangThai"]).ToString())
            {
                case "Hủy đơn":
                    {
                        comboBox_TrangThai.Items.Clear();
                        comboBox_TrangThai.Items.Add(list[0]);
                        comboBox_TrangThai.SelectedIndex = 0;
                        break;
                    }
                case "Chờ xác nhận":
                    {
                        comboBox_TrangThai.Items.Clear();
                        comboBox_TrangThai.Items.Add(list[0]);
                        comboBox_TrangThai.Items.Add(list[1]);
                        comboBox_TrangThai.Items.Add(list[2]);
                        break;
                    }
                case "Xác nhận và giao hàng":
                    {
                        comboBox_TrangThai.Items.Clear();
                        comboBox_TrangThai.Items.Add(list[2]);
                        comboBox_TrangThai.Items.Add(list[3]);
                        comboBox_TrangThai.Items.Add(list[4]);
                        comboBox_TrangThai.SelectedIndex = 0;
                        break;
                    }
                case "Hoàn thành":
                    {
                        comboBox_TrangThai.Items.Clear();
                        comboBox_TrangThai.Items.Add(list[3]);
                        comboBox_TrangThai.SelectedIndex = 0;
                        break;
                    }
                case "Giao hàng thất bại":
                    {
                        comboBox_TrangThai.Items.Clear();
                        comboBox_TrangThai.Items.Add(list[4]);
                        comboBox_TrangThai.SelectedIndex = 0;
                        break;
                    }
            }
            
        }

        private void barButtonItem_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(gridView1.Columns["trangThai"]).ToString() != comboBox_TrangThai.SelectedItem.ToString())
            {
                // save data
                PhieuDatHang phieuDatHang = new PhieuDatHang();
                phieuDatHang.id = textBox_ID.Text;
                phieuDatHang.ngayLap = textBox_NgayLap.Text;
                phieuDatHang.tongTien = decimal.Parse (textBox_TongTien.Text);
                phieuDatHang.idNV = textBox_NhanVien.Text;
                phieuDatHang.idKH = textBox_IDKH.Text;

                switch(comboBox_TrangThai.SelectedItem.ToString())
                {
                    case "Hủy đơn":
                        {
                            phieuDatHang.trangThai = "-1";
                            break;
                        }
                    case "Chờ xác nhận":
                        {
                            phieuDatHang.trangThai = "0";
                            break;
                        }
                    case "Xác nhận và giao hàng":
                        {
                            phieuDatHang.trangThai = "1";
                            break;
                        }
                    case "Hoàn thành":
                        {
                            phieuDatHang.trangThai = "2";
                            break;
                        }
                    case "Giao hàng thất bại":
                        {
                            phieuDatHang.trangThai = "3";
                            break;
                        }
                }

                if (!new Service_PhieuDatHang().updatePhieuDatHang(phieuDatHang))
                {
                    MessageBox.Show(Service_PhieuDatHang.errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                new Service_SendMail().guiTrangThai(textBox_ID.Text);
                gridView1.SetFocusedRowCellValue(gridView1.Columns["trangThai"], comboBox_TrangThai.SelectedItem.ToString());
            }

            gridControl_PhieuDatHang.Enabled = true;
            groupBox_PhieDatHang.Enabled = false;
            barButtonItem_Sua.Enabled = true;
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;
            barButtonItem_Xem.Enabled = (gridView1.RowCount > 0);

            comboBox_TrangThai.Items.Clear();
            comboBox_TrangThai.Items.Add(list[0]);
            comboBox_TrangThai.Items.Add(list[1]);
            comboBox_TrangThai.Items.Add(list[2]);
            comboBox_TrangThai.Items.Add(list[3]);
            comboBox_TrangThai.Items.Add(list[4]);

            comboBox_TrangThai.SelectedItem = gridView1.GetFocusedRowCellValue(gridView1.Columns["trangThai"]);
        }

        private void barButtonItem_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl_PhieuDatHang.Enabled = true;
            groupBox_PhieDatHang.Enabled = false;
            barButtonItem_Sua.Enabled = true;
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;
            barButtonItem_Xem.Enabled = (gridView1.RowCount > 0);

            comboBox_TrangThai.Items.Clear();
            comboBox_TrangThai.Items.Add(list[0]);
            comboBox_TrangThai.Items.Add(list[1]);
            comboBox_TrangThai.Items.Add(list[2]);
            comboBox_TrangThai.Items.Add(list[3]);
            comboBox_TrangThai.Items.Add(list[4]);
            comboBox_TrangThai.SelectedItem = gridView1.GetFocusedRowCellValue(gridView1.Columns["trangThai"]);
        }

        private void gridView2_FocusedRowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {

        }

        private void textBox_ChiTieNhapHang_ThanhTien_TextChanged(object sender, EventArgs e)
        {
            if (textBox_ChiTieNhapHang_ThanhTien.Text == null || textBox_ChiTieNhapHang_ThanhTien.Text == "") return;
            textBox_ChiTieNhapHang_ThanhTien.Text = Program.formatCurrency(textBox_ChiTieNhapHang_ThanhTien.Text);
        }

        private void barButtonItem_Xem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var datasource = new JsonDataSource();
            datasource.JsonSource = new UriJsonSource(new Uri(Program.baseURL + string.Format("thongkedathang/" + textBox_ID.Text)));
            datasource.Fill();
            HoaDon hoaDon = new HoaDon("PDH003");
            hoaDon.label_name.Text = "HÓA ĐƠN MUA HÀNG " + textBox_ID.Text;
            hoaDon.DataSource = datasource;
            ReportPrintTool print = new ReportPrintTool(hoaDon);
            print.ShowPreviewDialog();
        }
    }
}