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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_API.Forms
{
    public partial class Form_HangHoa : DevExpress.XtraEditors.XtraForm
    {
        BindingList<Entity.HangHoa> listHangHoa;
        HangHoa hangHoaEdit;
        string path;
        bool isEdit = true;
        public Form_HangHoa()
        {
            InitializeComponent();
        }

        private void Form_HangHoa_Load(object sender, EventArgs e)
        {
            fillData();
            groupBox_input.Enabled = false;
            gridControl_HangHoa.Enabled = true;
            
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
        private void fillData()
        {
            List<Entity.HangHoa> hangHoas = new Service_HangHoa().getListHangHoa();
            if (listHangHoa == null) listHangHoa = new BindingList<Entity.HangHoa>();
            foreach (Entity.HangHoa hangHoa in hangHoas)
            {
                listHangHoa.Add(hangHoa);
            }


           

            gridControl_HangHoa.DataSource = listHangHoa;
            gridView1.PopulateColumns();
            
            gridView1.Columns["id"].Caption = "ID";
            gridView1.Columns["ten"].Caption = "Tên";
            gridView1.Columns["moTa"].Caption = "Mô tả";
            gridView1.Columns["khoiLuong"].Caption = "Khối lượng";
            gridView1.Columns["soLuongTon"].Caption = "Số lượng tồn";

            gridView1.Columns["id"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["ten"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["moTa"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["khoiLuong"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["soLuongTon"].OptionsColumn.AllowEdit = false;

            gridView1.Columns["anh"].Visible = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!isEdit) return;

            if (gridView1.GetFocusedRowCellValue(gridView1.Columns["anh"]) != null)
            {
                string name = gridView1.GetFocusedRowCellValue(gridView1.Columns["anh"]).ToString();
                Bitmap bitmap = Program.loadImage(Program.baseURL + string.Format("/img/" + name));

                pictureBox_anh.Image = Program.resizeImage(bitmap, pictureBox_anh.Width, pictureBox_anh.Height);
            }
            else
            {
                pictureBox_anh.Image = null;
            }

            textBox_ID.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]).ToString();
            textBox_Ten.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["ten"]).ToString();
            textBox_KhoiLuong.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["khoiLuong"]).ToString();
            textBox_SoLuongTon.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["soLuongTon"]).ToString();
            richTextBox_MoTa.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["moTa"]).ToString();

            GiaHangHoa giaHangHoa = new Service_HangHoa().getGiaHangHoa(textBox_ID.Text);
            if (giaHangHoa == null)
            {
                switch (Service_HangHoa.errorCode)
                {
                    case "2":
                        {
                            MessageBox.Show("Lỗi kết nối với server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case "4":
                        {
                            textBox_Gia.Text = "0";
                            break;
                        }
                }
            }
            else
            {
                textBox_Gia.Text = giaHangHoa.gia.ToString();
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

            gridControl_HangHoa.Enabled = false;
            groupBox_input.Enabled = true;

            gridView1.AddNewRow();
            
            hangHoaEdit = new HangHoa();
            int soluong = new Service_HangHoa().getListHangHoa().Count;
            if (soluong < 10)
            {
                textBox_ID.Text = "HH00" + soluong;
            }
            else
            {
                if (soluong < 100)
                {
                    textBox_ID.Text = "HH0" + soluong;
                }
                else
                {
                    textBox_ID.Text = "HH" + soluong;
                }
            }
            hangHoaEdit.id = textBox_ID.Text;
            hangHoaEdit.soLuongTon = 0;

            textBox_SoLuongTon.Text = "0";
            textBox_KhoiLuong.Text = "";
            textBox_Ten.Text = "";
            richTextBox_MoTa.Text = "";
            textBox_Gia.Text = "0";
            pictureBox_anh.Image = null;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["id"], textBox_ID.Text);

        }

        private void textBox_Ten_Leave(object sender, EventArgs e)
        {
            if (hangHoaEdit == null) return;
            if (isEdit) return;
            hangHoaEdit.ten = textBox_Ten.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["ten"], textBox_Ten.Text);
        }

        private void textBox_KhoiLuong_Leave(object sender, EventArgs e)
        {
            if (hangHoaEdit == null) return;
            if (isEdit) return;
            hangHoaEdit.khoiLuong = textBox_KhoiLuong.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["khoiLuong"], textBox_KhoiLuong.Text);
        }

        private void richTextBox_MoTa_Leave(object sender, EventArgs e)
        {
            if (hangHoaEdit == null) return;
            if (isEdit) return;
            hangHoaEdit.moTa = richTextBox_MoTa.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["moTa"], richTextBox_MoTa.Text);
        }

        private void barButtonItem_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textBox_Ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng không để trống tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox_KhoiLuong.Text.Trim().Length == 0 || !ValidationData.checkSoDuong(textBox_KhoiLuong.Text.Trim()))
            {
                MessageBox.Show("Vui lòng không để trống khối lượng hoặc cần nhập đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox_Gia.Text.Trim().Length == 0 || !ValidationData.checkSoDuong(textBox_Gia.Text.Trim()))
            {
                MessageBox.Show("Vui lòng không để trống giá hoặc cần nhập đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (richTextBox_MoTa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng không để trống mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(pictureBox_anh.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int64 gia = Int64.Parse(textBox_Gia.Text.Trim());
            if (!isEdit) // Thêm
            {
                // save data
                if (textBox_Ten.Focused)
                {
                    hangHoaEdit.ten = textBox_Ten.Text.Trim();
                }
                if (textBox_KhoiLuong.Focused)
                {
                    hangHoaEdit.khoiLuong = textBox_KhoiLuong.Text.Trim();
                }
                if (richTextBox_MoTa.Focused)
                {
                    hangHoaEdit.moTa = richTextBox_MoTa.Text.Trim();
                }
                hangHoaEdit.anh = new Service_HangHoa().uploadImage(path);
                if (hangHoaEdit.anh == null)
                {
                    MessageBox.Show("Lỗi kết nối server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                gridView1.SetFocusedRowCellValue(gridView1.Columns["anh"], hangHoaEdit.anh);

                hangHoaEdit.khoiLuong = hangHoaEdit.khoiLuong + "G";
                if (!new Service_HangHoa().insertHangHoa(hangHoaEdit))
                {
                    switch (Service_HangHoa.errorCode)
                    {
                        case "1":
                            {
                                MessageBox.Show("Lỗi khóa chính. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                int soluong = new Service_HangHoa().getListHangHoa().Count;
                                if (soluong < 10)
                                {
                                    textBox_ID.Text = "HH00" + soluong;
                                }
                                else
                                {
                                    if (soluong < 100)
                                    {
                                        textBox_ID.Text = "HH0" + soluong;
                                    }
                                    else
                                    {
                                        textBox_ID.Text = "HH" + soluong;
                                    }
                                }
                                hangHoaEdit.id = textBox_ID.Text;

                                return;
                            }
                        case "2":
                            {
                                MessageBox.Show("Lỗi kêt nối máy chủ. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                    }
                    MessageBox.Show("Đã có lỗi xãy ra");
                    return;
                }

                // insert gian niem yet
                CtGiaNiemYet ctGiaNiemYet = new CtGiaNiemYet();
                ctGiaNiemYet.gia = (int)gia;
                ctGiaNiemYet.idHH = hangHoaEdit.id;
                ctGiaNiemYet.ngayApDung = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                if (!new Service_ChiTietGiaNiemYet().insertChitietNiemYet(ctGiaNiemYet))
                {
                    // delete hang hoa
                    MessageBox.Show("Đã có lỗi trong quá trình truyền dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (!new Service_HangHoa().deleteHangHoa(ctGiaNiemYet.idHH))
                    {
                        MessageBox.Show("Lỗi kết nối server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    return;
                }
            }
            else  //Sửa
            {
                hangHoaEdit = new HangHoa();
                hangHoaEdit.id = textBox_ID.Text.Trim();
                hangHoaEdit.ten = textBox_Ten.Text.Trim();
                hangHoaEdit.soLuongTon = int.Parse(textBox_SoLuongTon.Text.Trim());
                hangHoaEdit.moTa = richTextBox_MoTa.Text.Trim();
                hangHoaEdit.khoiLuong = textBox_KhoiLuong.Text.Trim() + "G";
                if (path != null) // upload ảnh
                {
                    hangHoaEdit.anh = new Service_HangHoa().uploadImage(path);
                    if (hangHoaEdit.anh == null)
                    {
                        MessageBox.Show(Service_HangHoa.errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    hangHoaEdit.anh = gridView1.GetFocusedRowCellValue(gridView1.Columns["anh"]).ToString();
                }
                if (!new Service_HangHoa().updateHangHoa(hangHoaEdit)) // update hàng hóa
                {
                    MessageBox.Show(Service_HangHoa.errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GiaHangHoa giaHangHoa = new Service_HangHoa().getGiaHangHoa(textBox_ID.Text.Trim());
                if (gia != giaHangHoa.gia)
                {
                    CtGiaNiemYet ctGiaNiemYet = new CtGiaNiemYet();
                    ctGiaNiemYet.gia = (int)gia;
                    ctGiaNiemYet.idHH = textBox_ID.Text.Trim();
                    ctGiaNiemYet.ngayApDung = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                    // insert
                    if (!new Service_ChiTietGiaNiemYet().insertChitietNiemYet(ctGiaNiemYet))
                    {
                        if (Service_ChiTietGiaNiemYet.errorCode == "1")
                        {
                            // update
                            if (!new Service_ChiTietGiaNiemYet().updateChiTietGiaNiemYet(ctGiaNiemYet))
                            {
                                MessageBox.Show(Service_ChiTietGiaNiemYet.errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show(Service_HangHoa.errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                gridView1.SetFocusedRowCellValue(gridView1.Columns["khoiLuong"], hangHoaEdit.khoiLuong);
                gridView1.SetFocusedRowCellValue(gridView1.Columns["ten"], hangHoaEdit.ten);
                gridView1.SetFocusedRowCellValue(gridView1.Columns["moTa"], hangHoaEdit.moTa);
                gridView1.SetFocusedRowCellValue(gridView1.Columns["anh"], hangHoaEdit.anh);
            }
            

            barButtonItem_Them.Enabled = true;
            barButtonItem_Xoa.Enabled = true;
            barButtonItem_Sua.Enabled = true;
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;

            isEdit = true;

            gridControl_HangHoa.Enabled = true;
            groupBox_input.Enabled = false;

            path = null;
        }

        private void pictureBox_anh_Click(object sender, EventArgs e)
        {
            // check is edit??
            // load ảnh
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;*.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox_anh.Image = Program.resizeImage(new Bitmap(open.FileName), pictureBox_anh.Width, pictureBox_anh.Height);
            }
            path = open.FileName;
            
        }

        private void barButtonItem_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (!isEdit)
            {
                gridView1.DeleteSelectedRows();
                hangHoaEdit = null;

                if (gridView1.RowCount > 0)
                {
                    gridView1.FocusedRowHandle = 0;
                }
                else
                {
                    textBox_ID.Text = "";
                    textBox_Ten.Text = "";
                    textBox_KhoiLuong.Text = "";
                    textBox_SoLuongTon.Text = "";
                    richTextBox_MoTa.Text = "";
                }
            }
            else
            {
                if (gridView1.GetFocusedRowCellValue(gridView1.Columns["anh"]) != null)
                {
                    string name = gridView1.GetFocusedRowCellValue(gridView1.Columns["anh"]).ToString();
                    Bitmap bitmap = Program.loadImage(Program.baseURL + string.Format("/img/" + name));

                    pictureBox_anh.Image = Program.resizeImage(bitmap, pictureBox_anh.Width, pictureBox_anh.Height);
                }
                else
                {
                    pictureBox_anh.Image = null;
                }

                textBox_ID.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["id"]).ToString();
                textBox_Ten.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["ten"]).ToString();
                textBox_KhoiLuong.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["khoiLuong"]).ToString();
                textBox_SoLuongTon.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["soLuongTon"]).ToString();
                richTextBox_MoTa.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns["moTa"]).ToString();

                GiaHangHoa giaHangHoa = new Service_HangHoa().getGiaHangHoa(textBox_ID.Text);
                if (giaHangHoa == null)
                {
                    switch (Service_HangHoa.errorCode)
                    {
                        case "2":
                            {
                                MessageBox.Show("Lỗi kết nối với server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        case "4":
                            {
                                textBox_Gia.Text = "0";
                                break;
                            }
                    }
                }
                else
                {
                    textBox_Gia.Text = giaHangHoa.gia.ToString();
                }
            }

            barButtonItem_Them.Enabled = true;
            barButtonItem_Xoa.Enabled = true;
            barButtonItem_Sua.Enabled = true;
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;

            gridControl_HangHoa.Enabled = true;
            groupBox_input.Enabled = false;

            isEdit = true;
        }

        private void barButtonItem_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng hóa " + textBox_ID.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (new Service_HangHoa().deleteHangHoa(textBox_ID.Text))
                {
                    gridView1.DeleteSelectedRows();

                    if (gridView1.RowCount == 0)
                    {
                        textBox_ID.Text = "";
                        textBox_Ten.Text = "";
                        textBox_KhoiLuong.Text = "";
                        textBox_SoLuongTon.Text = "";
                        textBox_Gia.Text = "";
                        richTextBox_MoTa.Text = "";
                        pictureBox_anh.Image = null;
                    }
                    gridView1.RefreshData();
                }
                else
                {
                    if (Service_HangHoa.errorCode == "5")
                    {
                        MessageBox.Show("Không thể xóa mẫu tin này","Thông báo",MessageBoxButtons.OK);
                        return;
                    }
                    MessageBox.Show("Lỗi kết nối server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void barButtonItem_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listHangHoa = null;
            fillData();
        }

        private void barButtonItem_Sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isEdit = true;

            barButtonItem_Them.Enabled = false;
            barButtonItem_Xoa.Enabled = false;
            barButtonItem_Sua.Enabled = false;
            barButtonItem_Ghi.Enabled = true;
            barButtonItem_Thoat.Enabled = true;

            gridControl_HangHoa.Enabled = false;
            groupBox_input.Enabled = true;

            textBox_KhoiLuong.Text = textBox_KhoiLuong.Text.ToUpper();
            textBox_KhoiLuong.Text = textBox_KhoiLuong.Text.Replace('G',' ');
            textBox_KhoiLuong.Text = textBox_KhoiLuong.Text.Trim();
        }
    }
}