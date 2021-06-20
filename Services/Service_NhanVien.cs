using QLBH_API.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace QLBH_API.Services
{
    class Service_NhanVien
    {

        string url = Program.baseURL + "nhanvien";
        public static string errorMessage = "";
        
        public List<NhanVien> getListNhanVien()
        {
            List<NhanVien> nhanViens;

            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
 
            string data = wc.DownloadString(url);

            Console.WriteLine(data);

            nhanViens = JsonConvert.DeserializeObject<List<NhanVien>>(data);

            return nhanViens;
        }

        public NhanVien getNhanVien(string id)
        {
            WebClient client = new WebClient();
            NhanVien nhanVien = null;

            try
            {
                String data = client.DownloadString(url + string.Format("/" + id)); // try catch dòng này
                nhanVien = JsonConvert.DeserializeObject<NhanVien>(data);
            }
            catch (WebException e)
            {
                using (StreamReader r = new StreamReader(
                    e.Response.GetResponseStream()))
                {
                    string responseContent = r.ReadToEnd();
                    errorMessage = Errors.listError[responseContent];
                    Console.WriteLine(errorMessage);
                }
            }

            return nhanVien;

        }
    }
}
