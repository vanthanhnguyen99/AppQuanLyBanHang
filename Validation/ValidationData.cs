using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_API.Validation
{
    class ValidationData
    {
        public static bool checkSDT(string sdt)
        {
            if (sdt.Length != 10) return false;
            try
            {
                int res = int.Parse(sdt);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
