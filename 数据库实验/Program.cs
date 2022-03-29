using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
namespace 数据库实验
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginform lf = new loginform();
            Application.Run(lf);
            if (lf.state == 1&&lf.flag==0)
            {         
                Application.Run(new Form1(lf.name,lf.state,lf.con));
            }
            else if (lf.state == 0 && lf.flag == 0)
            {
                Application.Run(new Form2(lf.name,lf.state,lf.con));
            }



        }
    }
}
