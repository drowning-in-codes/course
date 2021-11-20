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
    public partial class borrow : UIForm
    {
        MySqlConnection con;
        Boolean[] info = new Boolean[3];
        public borrow(MySqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void borrow_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“book_systemDataSet1.sb_info”中。您可以根据需要移动或删除它。
            this.sb_infoTableAdapter.Fill(this.book_systemDataSet1.sb_info);

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            
            alterinfo ai = new alterinfo(info);
            ai.Show();
       
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            string sno = this.comboBox1.Text;
            string isbn = this.comboBox2.Text;
            string sql = "update sb_info set is_back_allowed=\"{0}\",is_allowed=\"{1}\",is_con_allowed=\"{2}\" where sno=\"{3}\" and isbn=\"{4}\";";
            int i=0, j=0, k=0;
            i = info[0] ? 1 : 0;
            j = info[1] ? 1 : 0;
            k = info[2] ? 1 : 0;       

            MySqlCommand cmd = new MySqlCommand(string.Format(sql, i, j, k, sno, isbn), con);
            int suc = 1;
            i = 0;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                suc = 0;
                UIMessageTip.ShowError("更新错误"+ex.Message);
            }
            if (suc==1)
                UIMessageTip.ShowOk("更新成功");
            this.sb_infoTableAdapter.Fill(this.book_systemDataSet1.sb_info);
        }
    }
}
