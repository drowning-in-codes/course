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
        public alterbook(string []info)
        {
            InitializeComponent();
            this.info = info;
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
    }
}
