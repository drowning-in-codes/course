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
    public partial class Form1 : UIForm
    {
        
        private string username;
        private int state;
        private MySqlConnection con;
        public Form1(string username,int state,MySqlConnection con)
        {
            this.username = username;
            this.state = state;
            this.con = con;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
           this.greetings.Text = this.username+",你好呀";
            if(this.state==1)
                this.level.Text = "等级:管理员";
            else
                this.level.Text = "等级:学生";
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Label3.Text = DateTime.Now.DateTimeString();
        }

       

        private void uiButton1_Click(object sender, EventArgs e)
        {
            
            string sql = "select * from student";
            MySqlCommand cmd = new MySqlCommand(sql,con);
            string v  = (string)cmd.ExecuteScalar();
            UIMessageBox.Show(v);      
        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentinfo si = new studentinfo(con);
            si.Show();
        }

        private void 书籍信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookinfo bi = new bookinfo(con);
            bi.Show();
        }

        private void 借阅记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrow b = new borrow(con);
            b.Show();
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teinfo ti = new teinfo(con, this.username);
            ti.Show();
        }

        private void 管理员权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "管理员权限:1.增加书籍\n2.删除书籍\n3.增加,修改,删除学生信息\n4.审核借阅记录";
            UIMessageDialog.ShowInfoDialog(this, info);
        }

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UIMessageDialog.ShowAskDialog(this, "确定退出吗?", UIStyle.Colorful))

            {
                this.Dispose();//可以阻止Application.Exit()这句代码执行后再次Form2_FormClosing（）方法，需要点两次关闭
                Application.Exit();
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;   //不关闭窗口   //关闭窗口 e.Cancel = false;
            }
        }
    }
}
