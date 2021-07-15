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
    class Service_PhieuDatHang
    {
        public static string errorCode;
        public static string errorMessage;
        string url = Program.baseURL + string.Format("phieudathang");
        public List<PhieuDatHang> getListPhieuDatHang()
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            List<PhieuDatHang> phieuDatHangs = null;

            try
            {
                string data = client.DownloadString(url);
                phieuDatHangs = JsonConvert.DeserializeObject<List<PhieuDatHang>>(data);
            }
            catch(WebException e)
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

            return phieuDatHangs;
            
        }
        public bool updatePhieuDatHang(PhieuDatHang phieuDatHang)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            client.Headers[HttpRequestHeader.ContentType] = "application/json";

            try
            {
                client.UploadString(url, "PUT", JsonConvert.SerializeObject(phieuDatHang));
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
        public List<CtDatHang> ChiTietDatHang(string id)
        {
            List<CtDatHang> ctDatHangs = null;
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            client.Headers[HttpRequestHeader.ContentType] = "application/json";

            try
            {
                string data = client.DownloadString(Program.baseURL + string.Format("thongtinphieudathang/" + id));
                ctDatHangs = JsonConvert.DeserializeObject<List<CtDatHang>>(data);
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
            return ctDatHangs;
        }
    }
}
