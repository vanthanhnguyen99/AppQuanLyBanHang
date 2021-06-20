using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_API.Entity
{
    class PhieuDatHang
    {
        string id { get; set; }
        DateTime ngayLap { get; set; }
        int tongTien { get; set; }
        string idNV { get; set; }
        string idKH { get; set; }
        bool xacnhan { get; set; }

    }
}
