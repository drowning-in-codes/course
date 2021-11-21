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
    public partial class havebook : UIForm
    {
        MySqlConnection con;
        String username;
        public havebook(String name,MySqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            this.username = name;
        }

        private void havebook_Load(object sender, EventArgs e)
        {

            try
            {// TODO: 这行代码将数据加载到表“book_systemDataSet3.stu_sb”中。您可以根据需要移动或删除它。
                this.stu_sbTableAdapter.Fill(this.book_systemDataSet3.stu_sb);
            }
            catch(Exception ex)
            {
                UIMessageBox.ShowError("查询失败"+ex.Message);
                this.Close();
            }
            UIMessageTip.ShowOk("查询成功");
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.stu_sbTableAdapter.Fill(this.book_systemDataSet3.stu_sb);
            }
            catch (Exception ex)
            {
                UIMessageTip.ShowError("刷新失败" + ex.Message);
                this.Close();
            }
           
            UIMessageTip.Show("刷新成功");
           
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
