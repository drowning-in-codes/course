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
            int suc = 1;
            string sql = "select sno,isbn,b_num,b_name from stu_sb where sno=\"{0}\";";
            MySqlCommand cmd = new MySqlCommand(String.Format(sql,this.username),con);
            MySqlDataReader dr = null ;
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                UIMessageTip.ShowError("查询失败"+ex.Message);
                suc = 0;
                this.Close();
            }
            if (suc == 1)
            {
                int i = 0;
                UIMessageTip.ShowOk("查询成功");
                while (dr.Read())
                {
                    this.uiDataGridView1.Rows[i].Cells[0].Value = dr[0];
                    this.uiDataGridView1.Rows[i].Cells[1].Value = dr[1];
                    this.uiDataGridView1.Rows[i].Cells[2].Value = dr[2];
                    this.uiDataGridView1.Rows[i].Cells[3].Value = dr[3];
                    i++;
                }
                dr.Close();
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string sql = "select sno,isbn,b_num,b_name from stu_sb where sno=\"{0}\";";
            MySqlCommand cmd = new MySqlCommand(String.Format(sql, this.username), con);
            MySqlDataReader dr = null;
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                UIMessageTip.ShowError("查询失败" + ex.Message);
                this.Close();
            }
            int i = 0;
            UIMessageTip.Show("刷新成功");
            while (dr.Read())
            {
                this.uiDataGridView1.Rows[i].Cells[0].Value = dr[0];
                this.uiDataGridView1.Rows[i].Cells[1].Value = dr[1];
                this.uiDataGridView1.Rows[i].Cells[2].Value = dr[2];
                this.uiDataGridView1.Rows[i].Cells[3].Value = dr[3];
                i++;
            }
            dr.Close();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
