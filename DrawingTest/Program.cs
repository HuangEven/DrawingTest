using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingTest
{
    static class Program
    {
        public static bool isValidUser = false;
        public static bool isDraw = false;
        public static bool isText = false;
        
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            if (isValidUser==true&&isDraw==true)
            {
                Application.Run(new Draw());
            }
            if(isValidUser==true&&isText==true)
            {
                Application.Run(new Text());
            }
        }
    }
}
