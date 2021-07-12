using Newtonsoft.Json;
using QLBH_API.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_API.Services
{
    class Service_ChiTietPhieuNhapHang
    {
        public static string errorCode;
        public static string errorMessage;
        string url = Program.baseURL + string.Format("chitietnhaphang");
        public List<CtNhapHang> getListChiTietNhapHang(string id)
        {
            List<CtNhapHang> ctNhapHangs = null;
            string url = Program.baseURL + string.Format("thongtinnhaphang/" + id);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            try
            {
                
                string data = client.DownloadString(url);
                ctNhapHangs = JsonConvert.DeserializeObject<List<CtNhapHang>>(data);
            }
            catch (WebException e)
            {
                using (StreamReader r = new StreamReader(
                   e.Response.GetResponseStream()))
                {
                    string responseContent = r.ReadToEnd();
                    errorMessage = Errors.listError[responseContent];
                    errorCode = responseContent;
                    Console.WriteLine(errorMessage);
                }
            }
            return ctNhapHangs;
        }
    }
}
