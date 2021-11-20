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
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UIMessageDialog.ShowAskDialog(this, "确定退出吗?", UIStyle.Colorful))

            {
                this.Dispose();//可以阻止Application.Exit()这句代码执行后再次Form2_FormClosing（）方法，需要点两次关闭
                Application.Exit();
            }
            else
            {
                e.Cancel = true;   //不关闭窗口   //关闭窗口 e.Cancel = false;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Label3.Text = DateTime.Now.DateTimeString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            UIMessageDialog.ShowMessageDialog(this,"请给个好评","退出",true,UIStyle.Colorful);
            this.con.Close();

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            /*  String sqlId = "select * from student";
              con.Open(); 
              MySqlCommand cmd = new MySqlCommand(sqlId, con);
              MySqlDataAdapter da = new MySqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds, "student");            //dataGridView1.DataSource=ds.Tables["Student"];此处直接用DataTalbe绑定，与下面两行代码的效果是一样的
              uiDataGridView1.DataSource = ds;//使用Dataset，单必须指定DataMember，因为DataSet是DataTable的集合，而datagridview只能绑定一个datatable
              */
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
            bookinfo si = new bookinfo(con);
            si.Show();
        }

        private void 借阅记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrow b = new borrow(con);
            b.Show();
        }
    }
}
