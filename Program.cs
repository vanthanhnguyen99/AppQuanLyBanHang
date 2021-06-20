using DevExpress.Skins;
using DevExpress.UserSkins;
using QLBH_API.Entity;
using QLBH_API.Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH_API
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static string baseURL = "https://quan-ly-ban-hang-api.herokuapp.com/";
        //public static string baseURL = "http://127.0.0.1:8080/";
        public static main form_main;
        public static string convertToUTF8(string data)
        {
            // đưa về dịnh dạng UTF-8
            var utf8 = Encoding.UTF8;
            byte[] utfBytes = utf8.GetBytes(data);
            data = utf8.GetString(utfBytes, 0, utfBytes.Length);
            return data;
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Errors.generateListError();
            form_main = new main();
            Application.Run(form_main);
        }
    }
}
