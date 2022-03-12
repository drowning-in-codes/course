using Sunny.UI;
namespace 数据库实验
{
    partial class loginform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "图书馆借阅系统";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Text = "";
            // 
            // lblSubText
            // 
            this.lblSubText.Location = new System.Drawing.Point(374, 456);
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.uiCheckBox1.Location = new System.Drawing.Point(433, 379);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox1.Size = new System.Drawing.Size(90, 25);
            this.uiCheckBox1.TabIndex = 9;
            this.uiCheckBox1.Text = "管理员";
            this.uiCheckBox1.CheckedChanged += new System.EventHandler(this.uiCheckBox1_CheckedChanged);
            // 
            // loginform
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.uiCheckBox1);
            this.LoginImage = Sunny.UI.UILoginForm.UILoginImage.Login4;
            this.MaximizeBox = false;
            this.Name = "loginform";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 2);
            this.ShowDragStretch = true;
            this.ShowInTaskbar = true;
            this.ShowRadius = false;
            this.ShowTitle = true;
            this.Text = "登录窗口";
            this.Title = "图书馆借阅系统";
            this.ButtonLoginClick += new System.EventHandler(this.loginform_ButtonLoginClick);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.loginform_FormClosed);
            this.Load += new System.EventHandler(this.loginform_Load);
            this.Controls.SetChildIndex(this.uiCheckBox1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblSubText, 0);
            this.Controls.SetChildIndex(this.uiPanel1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UICheckBox uiCheckBox1;
    }
}