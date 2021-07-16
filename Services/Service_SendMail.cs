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
    class Service_SendMail
    {
        public static string errorCode;
        public static string errorMessage;
        string url = Program.baseURL + "send";
        public bool guiTrangThai(string id)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            try
            {
                client.DownloadString(url + string.Format("/" + id));
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
