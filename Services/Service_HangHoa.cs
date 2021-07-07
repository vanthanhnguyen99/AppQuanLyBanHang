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
    }
}
