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
    class Service_ChiTietGiaNiemYet
    {
        string url = Program.baseURL + string.Format("chitietgianiemyet");
        public static string errorCode;
        public static string errorMessage;
        public bool insertChitietNiemYet(CtGiaNiemYet ctGiaNiemYet)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            try
            {
                Console.WriteLine(JsonConvert.SerializeObject(ctGiaNiemYet));
                client.UploadString(url, "POST", JsonConvert.SerializeObject(ctGiaNiemYet));
                return true;
            }
            catch (WebException e)
            {
                using (StreamReader r = new StreamReader(
                   e.Response.GetResponseStream()))
                {
                    string responseContent = r.ReadToEnd();
                    Console.WriteLine(responseContent);
                    errorMessage = Errors.listError[responseContent];
                    errorCode = responseContent;

                }
                return false;
            }
        }
        public bool updateChiTietGiaNiemYet(CtGiaNiemYet ctGiaNiemYet)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            try
            {
                client.UploadString(url, "PUT", JsonConvert.SerializeObject(ctGiaNiemYet));
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
        public bool deleteChiTietGiaNiemYet(CtGiaNiemYet ctGiaNiemYet)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            ctGiaNiemYet.ngayApDung = ctGiaNiemYet.ngayApDung.Replace('-', '/');
            string request = ctGiaNiemYet.idHH.Trim() + "&" + ctGiaNiemYet.ngayApDung;
            try
            {
                client.UploadString(url + string.Format("/" + request),"DELETE","");
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
