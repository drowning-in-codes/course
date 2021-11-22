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
    public partial class alterinfo : UIForm
    {
        Boolean[] info;
        public alterinfo(Boolean []info)
        {
            InitializeComponent();
            this.info = info;
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
            this.uiCheckBox1.Checked = info[0] ;
            this.uiCheckBox2.Checked = info[1] ;
            this.uiCheckBox3.Checked = info[2] ;
        }
    }
}
