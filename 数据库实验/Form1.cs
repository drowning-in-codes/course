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
    public partial class Form1 : UIForm
    {
        private string username;
        public Form1(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.greetings.Text = this.username+",你好呀";
            
            this.level.Text = "";
        }
    }
}
