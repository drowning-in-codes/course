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
    public partial class bookinfo : UIForm
    {
        MySqlConnection con;
        public string[] info = new string[5];
        public bookinfo(MySqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void bookinfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“book_systemDataSet_book.books”中。您可以根据需要移动或删除它。
            this.booksTableAdapter.Fill(this.book_systemDataSet_book.books);

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            string sql = "delete from books where isbn={0}";
            MySqlCommand cmd = new MySqlCommand(string.Format(sql,this.uiTextBox1.Text),con);
            int i = 0;
            try
            {
                i = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                UIMessageTip.ShowError("删除错误"+ex.Message);
            }
            UIMessageTip.ShowOk(string.Format("有{0}行受影响",i));
            this.booksTableAdapter.Fill(this.book_systemDataSet_book.books);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Boolean suc = true;
            string sno = this.uiTextBox2.Text;
            if (sno.Trim() == "" || sno == null)
            {
                UIMessageTip.ShowError("请输入一个isbn号");
            }
            else
            {   
               
                    string sql = "update books set b_name=\"{0}\",b_publish_time=\"{1}\",b_author=\"{2}\",b_num=\"{3}\",b_pop=\"{4}\" where isbn={5};";
                    MySqlCommand cmd = new MySqlCommand(string.Format(sql, info[0], info[1], info[2], info[3],info[4],sno), con);
                    int i = 0;
                    try
                    {
                        i = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        suc = false;
                        UIMessageTip.ShowError("更新错误"+ex.Message);
                    }
                    if(suc)
                        UIMessageTip.ShowOk(string.Format("更新成功{0}条记录", i));

                
            }
            this.booksTableAdapter.Fill(this.book_systemDataSet_book.books);
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Boolean suc = true;
            string sno = this.uiTextBox2.Text;
            if (sno.Trim() == "" || sno == null)
            {
                UIMessageTip.ShowError("请输入一个isbn号");
            }
            else
            {
                    string sql = "insert into books values(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\");";
                    MySqlCommand cmd = new MySqlCommand(string.Format(sql, sno,info[0], info[1], info[2], info[3],info[4]), con);
                    int i = 0;
                    try
                    {
                        i = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        suc = false;
                        UIMessageTip.ShowError("添加错误" + ex.Message);
                    }
                    if(suc)
                        UIMessageTip.ShowOk(string.Format("添加成功{0}条记录",i));

               
            }
            this.booksTableAdapter.Fill(this.book_systemDataSet_book.books);
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            
            string sno = this.uiTextBox2.Text;
            if (sno.Trim() == "" || sno == null)
            {
                UIMessageTip.ShowError("请输入一个isbn号");
            }
            else
            {
                alterbook ab = new alterbook(info);
                ab.Show();
                if (ab.DialogResult == DialogResult.Yes)
                {
                    UIMessageTip.ShowOk("可以进行更新或增加书籍");
                }


            }
        }
    }
}
