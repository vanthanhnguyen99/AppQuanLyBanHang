using Newtonsoft.Json;
using QLBH_API.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

namespace QLBH_API.Services
{
    class Service_HangHoa
    {
        string url = Program.baseURL + "hanghoa";
        public static string errorMessage = "";
        public static string errorCode;

        public List<HangHoa> getListHangHoa()
        {

            List<HangHoa> hangHoas = null;
            WebClient client = new System.Net.WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            try
            {
                string data = client.DownloadString(url);

                Console.WriteLine(data);

                hangHoas = JsonConvert.DeserializeObject<List<HangHoa>>(data);
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
            return hangHoas;
        }

        public HangHoa getHangHoa(string id)
        {
            HangHoa hangHoa = null;
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            try
            {
                string data = client.DownloadString(url + string.Format("/" + id));
                hangHoa = JsonConvert.DeserializeObject<HangHoa>(data);
               
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
            return hangHoa;
        }
        public GiaHangHoa getGiaHangHoa(string id)
        {
            GiaHangHoa giaHangHoa = null;
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            try
            {
                string data = client.DownloadString(url + string.Format("/gia/" + id));
                giaHangHoa = JsonConvert.DeserializeObject<GiaHangHoa>(data);
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
            return giaHangHoa;
        }
        public string uploadImage(string path)
        {
            // Read file to data
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fileStream.Length];
            fileStream.Read(data, 0 ,data.Length);
            fileStream.Close();

            // Generate post object
            Dictionary<string, object> keyValues = new Dictionary<string, object>();
            string[] splitString = path.Split('\\');
            keyValues.Add("hinhanh", new FileUpload.FileParameter(data, splitString[splitString.Length - 1],"application/file"));

            // Create request
            string uri = Program.baseURL + string.Format("uploadImage");
            string userAgent = "vanth";
            HttpWebResponse webResponse = FileUpload.MultipartFormDataPost(uri, userAgent, keyValues);

            // Process response
            StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
            string response = responseReader.ReadToEnd();
            webResponse.Close();
            return response;
            
        }
        public bool insertHangHoa(HangHoa hangHoa)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            try
            {
                string res = client.UploadString(url, "POST", JsonConvert.SerializeObject(hangHoa));
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
        public bool deleteHangHoa(string id)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            try
            {
                client.UploadString(url + string.Format("/" + id), "DELETE","");
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
        public bool updateHangHoa(HangHoa hangHoa)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            
            try
            {
                Console.WriteLine(JsonConvert.SerializeObject(hangHoa));
                client.UploadString(url, "PUT", JsonConvert.SerializeObject(hangHoa));
                return true;
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
                return false;
            }

        }
       
    }
}
