﻿using Newtonsoft.Json;
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
    class Service_ChiTietGiaNhap
    {
        public static string errorCode;
        public static string errorMessage;
        string url = Program.baseURL + string.Format("chitietgianhap");

        public GiaHangHoa getGiaNhapHang(string id)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            client.Headers[HttpRequestHeader.ContentType] = "application/json";

            GiaHangHoa giaHangHoa = null;

            try
            {
                string data = client.DownloadString(Program.baseURL + string.Format("hanghoa/gianhaphang/" + id));
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

        public bool insertChiTietGiaNhap(CtGiaNhap ctGiaNhap)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            client.Headers[HttpRequestHeader.ContentType] = "application/json";

            try
            {
                client.UploadString(url, "POST", JsonConvert.SerializeObject(ctGiaNhap));
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

        public bool updateChiTietGiaNhap(CtGiaNhap ctGiaNhap)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            client.Headers[HttpRequestHeader.ContentType] = "application/json";

            try
            {
                client.UploadString(url, "PUT", JsonConvert.SerializeObject(ctGiaNhap));
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
