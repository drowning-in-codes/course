using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据库实验
{
    public partial class loginform : UILoginForm
    {
        public string name;
        public int userinfo;
        public loginform()
        {
            InitializeComponent();
        }

       

        private void loginform_ButtonLoginClick(object sender, EventArgs e)
        {

            //如果是管理员登录
            if (this.UserName == "admin")
            {
                if (this.Password == "admin")
                {
                    UIMessageTip.ShowOk("登陆成功");
                    this.name = this.UserName;
                    this.userinfo = 1; //表示是管理员
                    this.Close();
                }
                else
                {
                    UIMessageTip.ShowError("输入账户或密码错误");

                }
            }
            else
            {
                if (this.UserName == "" && this.Password == "")
                {
                    UIMessageTip.ShowOk("登陆成功");
                    this.name = this.UserName;
                    this.userinfo = 1; //表示使学生
                    this.Close();
                }
                else
                {
                    UIMessageTip.ShowError("输入账户或密码错误");

                }
            }
            //如果是学生登陆
        }
    }
}
