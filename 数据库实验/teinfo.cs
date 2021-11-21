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
    
    public partial class teinfo : UIForm
    {
        MySqlConnection con;
        String username;
        public teinfo(MySqlConnection con, String user)
        {
            InitializeComponent();
            this.con = con;
            this.username = user;
        }

        private void teinfo_Load(object sender, EventArgs e)
        {
            int suc = 1;
            this.uiLabel3.Text = this.username;
            string sql = "select a_password from administer where a_name=\"{0}\"";
            MySqlCommand cmd = new MySqlCommand(String.Format(sql, username), con);
            string pass = "";
            try
            {
                pass = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                UIMessageTip.ShowError("查询失败" + ex.Message);
                suc = 0;
                this.Close();

            }
            if (suc == 1)
            {
                UIMessageTip.ShowOk("查询成功");
                this.uiLabel4.Text = pass;
            }




            
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            int suc = 1;
            String pass = this.uiTextBox1.Text.Trim();

            string sql = "update administer set a_password=\"{1}\" where a_name=\"{0}\";";
            MySqlCommand cmd = new MySqlCommand(String.Format(sql, this.uiLabel3.Text, pass), con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError("修改失败" + ex.Message);
                suc = 0;
                this.Close();

            }
            if (suc == 1)
            {
                UIMessageTip.ShowOk("修改成功");
                this.uiLabel4.Text = pass;
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
