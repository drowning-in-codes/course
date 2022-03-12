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
    public partial class studentinfo : UIForm
    {
        public MySqlConnection con;
        public studentinfo(MySqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void studentinfo_Load(object sender, EventArgs e)
        {
           
            // TODO: 这行代码将数据加载到表“book_systemDataSet.student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.book_systemDataSet.student);

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string password = this.uiTextBox2.Text;
            string sno = this.uiTextBox1.Text;
            string sql = "update student set s_password =\"{0}\" where sno=\"{1}\"";
            MySqlCommand cmd = new MySqlCommand(String.Format(sql, password, sno), con);
            int i=0;
            try
            {
                i = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                UIMessageBox.ShowError("更新错误"+ex.Message);
            }
            UIMessageTip.ShowOk(String.Format("一共有{0}条信息受影响",i));
            this.studentTableAdapter.Fill(this.book_systemDataSet.student);




        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            string sql = "insert into student values(\"{0}\",\"{1}\",\"{2}\",0,\"{3}\")";
            string sno = this.uiTextBox3.Text;
            string sname = this.uiTextBox4.Text;
            string smajor = this.uiTextBox5.Text;
            string password = this.uiTextBox6.Text;
            MySqlCommand cmd = new MySqlCommand(string.Format(sql,sno,sname,smajor,password),con);
            int i=0;
            try{
                i = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                UIMessageTip.ShowError(string.Format("增加错误,{0}",ex.Message));
            }
            UIMessageTip.ShowOk(string.Format("增加了{0}条数据",i));
            this.studentTableAdapter.Fill(this.book_systemDataSet.student);
            
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            string sno = this.uiTextBox7.Text;
            string sql = "delete from student where sno=\"{0}\"";
            MySqlCommand cmd = new MySqlCommand(string.Format(sql,sno),con);
            int i = 0;
            try
            {
                i= cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                UIMessageTip.ShowError(string.Format("删除错误,{0}",ex.Message));
            }
            UIMessageTip.ShowOk(string.Format("删除了{0}条数据", i));
            this.studentTableAdapter.Fill(this.book_systemDataSet.student);

        }
    }
}
