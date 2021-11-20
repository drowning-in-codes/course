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
    public partial class stuinfo : UIForm
    {
        MySqlConnection con;
        String usersno;
        public stuinfo(MySqlConnection con, String usersno)
        {
            InitializeComponent();
            this.usersno = usersno;
            this.con = con;
        }

        private void stuinfo_Load(object sender, EventArgs e)
        {
            int suc = 1;
            this.uiLabel2.Text = usersno;
            string sql = "select s_password from student where sno=\"{0}\"";
            MySqlCommand cmd = new MySqlCommand(String.Format(sql,usersno),con);
            string pass = "";
            try
            {
                pass = cmd.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {
                UIMessageTip.ShowError("查询失败"+ex.Message);
                suc = 0;
                this.Close();
                
            }
            if (suc == 1)
            {
                UIMessageTip.ShowOk("查询成功");
                this.uiLabel1.Text = pass;
            }

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            int suc = 1;
            String pass =  this.uiTextBox1.Text.Trim();
            
            string sql = "update student set s_password=\"{1}\" where sno=\"{0}\";";
            MySqlCommand cmd = new MySqlCommand(String.Format(sql,this.uiLabel2.Text,pass), con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError("修改失败" +ex.Message);
                suc = 0;
                this.Close();

            }
            if (suc == 1)
            {
                UIMessageTip.ShowOk("修改成功");
                this.uiLabel1.Text = pass;
            }

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
