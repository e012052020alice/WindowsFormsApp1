using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class GlobalVar
    {
        //public static string image_dir = @"D:\全端工程師就業養成班\1.C#\C#\期中個人專題\WindowsFormsApp1\WindowsFormsApp1\images";
        //public static string image_dir = @"C:\Users\iSpan\Desktop\上課\期中個人專題\書籍圖片";
        public static string image_dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"images");
        public static string strDBConnectionString = "";
        public static int loadId2 = 0;
        public static int 使用者id = 2;
        public static bool is登入成功 = false;
        public static string 使用者名稱 = "";
        public static int 使用者權限 = 1;
        public static string 使用者使用狀態 = "";
    }
}
