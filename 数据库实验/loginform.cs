using System.Configuration;
using Sunny.UI;
using System;
using MySql.Data.MySqlClient;
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
        string sql = "select sno,s_password from student";
        MySqlCommand cmd;
        MySqlDataReader dr;
        public string name; 
        public MySqlConnection con;
        public int state;
        public int flag = 1;
        public loginform()
        {
            InitializeComponent();
        }



        private void loginform_ButtonLoginClick(object sender, EventArgs e)
        {
            flag = 1;
            cmd = new MySqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                string user = dr[0].ToString();
                string password = dr[1].ToString();
                
                if (this.UserName == user)
                {
                    if (this.Password == password)
                    {
                        flag = 0;
                        
                        UIMessageTip.ShowOk("登陆成功");
                        this.name = this.UserName;
                        
                        dr.Close();
                        this.Close();
                        break;
                    }
                }
            }
            if(flag==1)
                UIMessageTip.ShowError("输入账户或密码错误");
            dr.Close();
            
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            if (this.uiCheckBox1.Checked)
            {
                this.sql = "select a_name,a_password from administer";
            }
            
            string constr = ConfigurationManager.ConnectionStrings["数据库实验.Properties.Settings.book_systemConnectionString"].ToString();
     
            try
            {
                con = new MySqlConnection(constr);
                con.Open();
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError("连接数据库失败" + ex.Message);
            }
            

        }

        private void uiCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.uiCheckBox1.Checked)
            {
                state = 1;//管理员
                sql = "select a_name,a_password from administer";
            }
            else
            {
                state = 0;//学生
                sql = "select sno,s_password from student";
            }
        }

        private void loginform_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.flag==1)
            {
                con.Close();
            }
        }
    }
}
