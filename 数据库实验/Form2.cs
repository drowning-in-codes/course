using Sunny.UI;
using MySql.Data.MySqlClient;
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
    public partial class Form2 : UIForm
    {
        private string username;
        private int state;
        private MySqlConnection con;
        public Form2(string username, int state, MySqlConnection con)
        {
            InitializeComponent();
            this.username = username;
            this.state = state;
            this.con = con;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = DateTime.Now.DateTimeString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“book_systemDataSet4.avai_book”中。您可以根据需要移动或删除它。
            this.avai_bookTableAdapter.Fill(this.book_systemDataSet4.avai_book);
            // TODO: 这行代码将数据加载到表“book_systemDataSet_book.books”中。您可以根据需要移动或删除它。
            this.booksTableAdapter1.Fill(this.book_systemDataSet_book.books);
            // TODO: 这行代码将数据加载到表“book_systemDataSet2.books”中。您可以根据需要移动或删除它。
            this.toolStripStatusLabel1.Text = this.username + ",你好呀";
            if (this.state == 1)
                this.toolStripStatusLabel2.Text = "等级:管理员";
            else
                this.toolStripStatusLabel2.Text = "等级:学生";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UIMessageDialog.ShowAskDialog(this,"确定退出吗?",UIStyle.Colorful))

            {
                this.Dispose();//可以阻止Application.Exit()这句代码执行后再次Form2_FormClosing（）方法，需要点两次关闭
                Application.Exit();
            }
            else
            {
                e.Cancel = true;   //不关闭窗口   //关闭窗口 e.Cancel = false;
            }

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            int suc = 1;
            string borrow_time = this.uiComboBox2.Text;
            string book_sno = this.comboBox1.Text;
            string book_num = this.uiComboBox1.Text;
            string sql = "insert into sb_info (sno,isbn,borrow_time,borrow_num,back_time) values (\"{0}\",\"{1}\",\"{2}\",{3},\"{4}\");";
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format(sql, this.username, book_sno, DateTime.Now.DateTimeString(), book_num, DateTime.Now.AddDays(Double.Parse(borrow_time)).DateTimeString()), con);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                suc = 0;
                UIMessageTip.ShowError("借书失败"+ex.Message);
            }
            if (suc == 1)
                UIMessageTip.ShowOk("借书请求成功,等待管理员审核");
            // TODO: 这行代码将数据加载到表“book_systemDataSet_book.books”中。您可以根据需要移动或删除它。
            this.booksTableAdapter1.Fill(this.book_systemDataSet_book.books);
            // TODO: 这行代码将数据加载到表“book_systemDataSet2.books”中。您可以根据需要移动或删除它。
            this.avai_bookTableAdapter.Fill(this.book_systemDataSet4.avai_book);
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            int suc = 1;
            string book_sno = this.comboBox1.Text;
            string sql = "update sb_info set is_back=1 where isbn=\"{0}\" and sno=\"{1}\";";
            MySqlCommand cmd = new MySqlCommand(string.Format(sql, this.username, book_sno), con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                suc = 0;
                UIMessageTip.ShowError("还书失败" + ex.Message);
            }
            if (suc == 1)
                UIMessageTip.ShowOk("还书请求成功,等待管理员审核");
            // TODO: 这行代码将数据加载到表“book_systemDataSet_book.books”中。您可以根据需要移动或删除它。
            this.booksTableAdapter1.Fill(this.book_systemDataSet_book.books);
            // TODO: 这行代码将数据加载到表“book_systemDataSet2.books”中。您可以根据需要移动或删除它。
            this.avai_bookTableAdapter.Fill(this.book_systemDataSet4.avai_book);

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            int suc = 1;
            string book_sno = this.comboBox1.Text;
            string sql = "update sb_info set is_con=1) where isbn=\"{0}\" and sno=\"{1}\";";
           
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format(sql,this.username, book_sno), con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                suc = 0;
                UIMessageTip.ShowError("续借书失败" + ex.Message);
            }
            if (suc == 1)
                UIMessageTip.ShowOk("续借书请求成功,等待管理员审核");
            // TODO: 这行代码将数据加载到表“book_systemDataSet_book.books”中。您可以根据需要移动或删除它。
            this.booksTableAdapter1.Fill(this.book_systemDataSet_book.books);
            // TODO: 这行代码将数据加载到表“book_systemDataSet2.books”中。您可以根据需要移动或删除它。
            this.avai_bookTableAdapter.Fill(this.book_systemDataSet4.avai_book);

        }

        private void 所借书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            havebook hb = new havebook(this.username,con);
            hb.Show();
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stuinfo si = new stuinfo(con,this.username);
            si.Show();
        }

        private void 用户权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "学生权限:1.借阅书籍\n2.归还书籍\n3.续借书籍\n4.修改密码" ;
            UIMessageDialog.ShowInfoDialog(this,info);
        }

       

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            UIMessageTip.Show("借阅书籍ISBN" + this.comboBox1.Text);
        }

        private void uiComboBox2_TextChanged(object sender, EventArgs e)
        {
            int num = 1;
            try
            {
                num = int.Parse(this.uiComboBox2.Text);
            }
            catch(Exception ex)
            {
                UIMessageTip.ShowError("输入错误" + ex.Message);
                this.uiComboBox2.Text = "1";
            }
            if (num>40)
            {
                UIMessageTip.ShowWarning("您借书的时间未免太长了");
                this.uiComboBox2.Text = "1";
            }
            
        }

       

        private void timer2_Tick(object sender, EventArgs e)
        {
            string sql = "select back_time from student,books,sb_info where student.sno=sb_info.sno and books.isbn=sb_info.isbn and is_back=0 and borrow_num>0;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = null;
            try
            {
              dr =  cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                UIMessageBox.ShowError("连接出错,请检查连接"+ex.Message);
                this.Close();
            }
            while(dr.Read())
            {
                if (dr[0] != DBNull.Value)
                {
                    DateTime dt = Convert.ToDateTime(dr[0]);
                    if (DateTime.Compare(DateTime.Now, dt) > 0)
                    {
                        UIMessageBox.ShowInfo("您书籍归还日期已到,请及时归还!!");
                        break;
                    }
                  
                }
            }
            dr.Close();
        }
    }
}
