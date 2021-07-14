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
        public List<CtNhapHang> getListChiTietNhapHang()
        {
            List<CtNhapHang> ctNhapHangs = null;
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
        public bool deleteChiPhieuNhap(string id)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            try
            {
                client.UploadString(url + string.Format("/" + id), "DELETE", "");
                return true;
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
                return false;
            }
        }

        public bool insertChiTietPhieuNhapHang(CtNhapHang ctNhapHang)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            try
            {
                client.UploadString(url, "POST", JsonConvert.SerializeObject(ctNhapHang));
                return true;
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
                return false;
            }
        }

        public bool updateChiTietPhieuNhapHang(CtNhapHang ctNhapHang)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            try
            {
                client.UploadString(url, "PUT", JsonConvert.SerializeObject(ctNhapHang));
                return true;
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
                return false;
            }
        }

    }
}
