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
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Text = "";
            // 
            // lblSubText
            // 
            this.lblSubText.Location = new System.Drawing.Point(376, 456);
            // 
            // loginform
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.LoginImage = Sunny.UI.UILoginForm.UILoginImage.Login4;
            this.MaximizeBox = false;
            this.Name = "loginform";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ShowInTaskbar = true;
            this.ShowRadius = false;
            this.ShowRect = false;
            this.ShowTitle = true;
            this.Text = "loginform";
            this.ButtonLoginClick += new System.EventHandler(this.loginform_ButtonLoginClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}