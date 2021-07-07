using DevExpress.XtraEditors;
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
        public Form_HangHoa()
        {
            InitializeComponent();
        }

        private void Form_HangHoa_Load(object sender, EventArgs e)
        {
            fillData();
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
            
            string name = gridView1.GetFocusedRowCellValue(gridView1.Columns["anh"]).ToString();
            Bitmap bitmap = Program.loadImage(Program.baseURL + string.Format("/img/" + name));

            pictureBox_anh.Image = Program.resizeImage(bitmap, pictureBox_anh.Width, pictureBox_anh.Height);
                
        }
    }
}