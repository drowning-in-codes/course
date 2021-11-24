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
    public partial class alterinfo : UIForm
    {
        Boolean[] info;
        MySqlConnection con;
        string sno;
        string isbn;
        string borrow_time;
        public alterinfo(Boolean []info,MySqlConnection con,string sno,string isbn,string borrow_time)
        {
            InitializeComponent();
            this.info = info;
            this.sno = sno;
            this.con = con;
            this.isbn = isbn;
            this.borrow_time = borrow_time.Replace("/","-");
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            info[0] = this.uiCheckBox1.Checked;
            info[1] = this.uiCheckBox2.Checked ;
            info[2] = this.uiCheckBox3.Checked;

            UIMessageTip.ShowOk("更改成功");
            this.Close();
        }

        private void alterinfo_Load(object sender, EventArgs e)
        {
            string sql = "select is_back_allowed, is_allowed, is_con_allowed from sb_info where sno=\"{0}\" and isbn=\"{1}\" and borrow_time=\"{2}\";";
            MySqlCommand cmd = new MySqlCommand(string.Format(sql, sno, isbn, borrow_time), con);
            MySqlDataReader dr = null;
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                UIMessageBox.ShowError("修改书籍信息错误" + ex.Message);
            }
            while (dr.Read())
            {
                if((int)dr[0]== 1)
                    this.uiCheckBox1.Checked = true;
                if ((int)dr[1] == 1)
                    this.uiCheckBox2.Checked = true;
                if ((int)dr[2] == 1)
                    this.uiCheckBox3.Checked = true;
                break;

            }
            dr.Close();
        }
    }
}
