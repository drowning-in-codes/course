using MySql.Data.MySqlClient;
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
    public partial class alterbook : UIForm
    {
        string[] info;
        string sno;
        MySqlConnection con;
        public alterbook(MySqlConnection con,string []info,string sno)
        {
            InitializeComponent();
            this.info = info;
            this.con = con;
            this.sno = sno;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
           


            info[0] = this.uiTextBox1.Text.Trim() == "" ? info[0]:this.uiTextBox1.Text;
            info[1] = this.uiTextBox2.Text.Trim() == "" ? info[1] : this.uiTextBox2.Text;
            info[2] = this.uiTextBox3.Text.Trim() == "" ? info[2] : this.uiTextBox3.Text;
            info[3] = this.uiTextBox4.Text.Trim() == "" ? info[3] : this.uiTextBox4.Text;
            info[4] = this.uiTextBox5.Text.Trim() == "" ? info[4] : this.uiTextBox5.Text;
            this.DialogResult = DialogResult.Yes;
            UIMessageTip.ShowOk("填写成功");
            this.Close();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alterbook_Load(object sender, EventArgs e)
        {
            string sql = "select b_name, b_publish_time, b_author, b_num, b_pop from books where isbn=\"{0}\"";

            MySqlCommand cmd = new MySqlCommand(string.Format(sql, this.sno), con);
            MySqlDataReader dr = null;
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError("查询书籍错误" + ex.Message);
            }


            while (dr.Read())
            {
                this.uiTextBox1.Text = dr[0].ToString();
                this.uiTextBox2.Text = dr[1].ToString();
                this.uiTextBox3.Text = dr[2].ToString();
                this.uiTextBox4.Text = dr[3].ToString();
                this.uiTextBox5.Text = dr[4].ToString();
                break;
            }
            dr.Close();
        }
    }
}
