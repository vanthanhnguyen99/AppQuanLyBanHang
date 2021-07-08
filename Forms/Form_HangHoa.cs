using DevExpress.XtraEditors;
using QLBH_API.Entity;
using QLBH_API.Form;
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
    public partial class Form_HangHoa : DevExpress.XtraEditors.XtraForm
    {
        BindingList<Entity.HangHoa> listHangHoa;
        HangHoa hangHoaEdit;
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
                        MessageBox.Show("Nhân viên");
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

        }

        private void textBox_Ten_Leave(object sender, EventArgs e)
        {
            if (hangHoaEdit == null) return;
            hangHoaEdit.ten = textBox_Ten.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["ten"], textBox_Ten.Text);
        }

        private void textBox_KhoiLuong_Leave(object sender, EventArgs e)
        {
            if (hangHoaEdit == null) return;
            hangHoaEdit.khoiLuong = textBox_KhoiLuong.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["khoiLuong"], textBox_KhoiLuong.Text);
        }

        private void richTextBox_MoTa_Leave(object sender, EventArgs e)
        {
            if (hangHoaEdit == null) return;
            hangHoaEdit.moTa = richTextBox_MoTa.Text;
            gridView1.SetFocusedRowCellValue(gridView1.Columns["moTa"], richTextBox_MoTa.Text);
        }

        private void barButtonItem_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
        }

        private void barButtonItem_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isEdit = true;
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

            barButtonItem_Them.Enabled = true;
            barButtonItem_Xoa.Enabled = true;
            barButtonItem_Sua.Enabled = true;
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;

            gridControl_HangHoa.Enabled = true;
            groupBox_input.Enabled = false;
        }
    }
}