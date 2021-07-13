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
    public partial class Form_NhapHang : DevExpress.XtraEditors.XtraForm
    {
        BindingList<PhieuNhapHang> listPhieuNhapHang = null;
        BindingList<CtNhapHang> listChiTietNhapHang = null;
        BindingList<HangHoa> listHangHoa = null;
        public Form_NhapHang()
        {
            InitializeComponent();
        }

        private void Form_NhapHang_Load(object sender, EventArgs e)
        {
            loadToTablePhieuNhapHang();


            if (listHangHoa == null)
            {
                listHangHoa = new BindingList<HangHoa>();
                List<HangHoa> hangHoas = new Service_HangHoa().getListHangHoa();
                foreach (HangHoa hangHoa in hangHoas)
                {
                    listHangHoa.Add(hangHoa);
                }
            }

            comboBox_ChiTieNhapHang_IDHH.DataSource = listHangHoa;
            comboBox_ChiTieNhapHang_IDHH.ValueMember = "ten";
            comboBox_ChiTieNhapHang_IDHH.DisplayMember = "id";
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
            if (gridView1.GetRow(gridView1.FocusedRowHandle) == null) return;
            string id = gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]).ToString();
            loadToTableChiTietNhapHang(id);

            textBox_ID.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]).ToString();
            textBox_NgayLap.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["ngayLap"]).ToString();
            textBox_TongTien.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["tongTien"]).ToString();
            string idNV = gridView1.GetFocusedRowCellValue(gridView1.Columns["idNV"]).ToString();
            NhanVien nhanVien = new Service_NhanVien().getNhanVien(idNV);
            textBox_NhanVien.Text = idNV;
            textBox_HoTen.Text = nhanVien.hoTen;


        }

        private void loadToTableChiTietNhapHang(string id)
        {
            if (listChiTietNhapHang == null) listChiTietNhapHang = new BindingList<CtNhapHang>();
            listChiTietNhapHang.Clear();
            List<CtNhapHang> ctNhapHangs = new Service_ChiTietPhieuNhapHang().getListChiTietNhapHang(id);
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
            
            

        }
    }
}