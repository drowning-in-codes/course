
namespace 数据库实验
{
    partial class borrow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.book_systemDataSet1 = new 数据库实验.book_systemDataSet1();
            this.sbinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sb_infoTableAdapter = new 数据库实验.book_systemDataSet1TableAdapters.sb_infoTableAdapter();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrownumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isconDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbackallowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isallowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isconallowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sbinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sbinfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_systemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbinfoBindingSource)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbinfoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.AutoGenerateColumns = false;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.borrowtimeDataGridViewTextBoxColumn,
            this.backtimeDataGridViewTextBoxColumn,
            this.borrownumDataGridViewTextBoxColumn,
            this.isbackDataGridViewTextBoxColumn,
            this.isconDataGridViewTextBoxColumn,
            this.isbackallowedDataGridViewTextBoxColumn,
            this.isallowedDataGridViewTextBoxColumn,
            this.isconallowedDataGridViewTextBoxColumn});
            this.uiDataGridView1.DataSource = this.sbinfoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(2, 35);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView1.RowHeadersWidth = 51;
            this.uiDataGridView1.RowHeight = 27;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.RowTemplate.Height = 27;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.ShowGridLine = true;
            this.uiDataGridView1.Size = new System.Drawing.Size(796, 200);
            this.uiDataGridView1.TabIndex = 0;
            // 
            // book_systemDataSet1
            // 
            this.book_systemDataSet1.DataSetName = "book_systemDataSet1";
            this.book_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sbinfoBindingSource
            // 
            this.sbinfoBindingSource.DataMember = "sb_info";
            this.sbinfoBindingSource.DataSource = this.book_systemDataSet1;
            // 
            // sb_infoTableAdapter
            // 
            this.sb_infoTableAdapter.ClearBeforeFill = true;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "sno";
            this.snoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.snoDataGridViewTextBoxColumn.Width = 125;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.Width = 125;
            // 
            // borrowtimeDataGridViewTextBoxColumn
            // 
            this.borrowtimeDataGridViewTextBoxColumn.DataPropertyName = "borrow_time";
            this.borrowtimeDataGridViewTextBoxColumn.HeaderText = "borrow_time";
            this.borrowtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowtimeDataGridViewTextBoxColumn.Name = "borrowtimeDataGridViewTextBoxColumn";
            this.borrowtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // backtimeDataGridViewTextBoxColumn
            // 
            this.backtimeDataGridViewTextBoxColumn.DataPropertyName = "back_time";
            this.backtimeDataGridViewTextBoxColumn.HeaderText = "back_time";
            this.backtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.backtimeDataGridViewTextBoxColumn.Name = "backtimeDataGridViewTextBoxColumn";
            this.backtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // borrownumDataGridViewTextBoxColumn
            // 
            this.borrownumDataGridViewTextBoxColumn.DataPropertyName = "borrow_num";
            this.borrownumDataGridViewTextBoxColumn.HeaderText = "borrow_num";
            this.borrownumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrownumDataGridViewTextBoxColumn.Name = "borrownumDataGridViewTextBoxColumn";
            this.borrownumDataGridViewTextBoxColumn.Width = 125;
            // 
            // isbackDataGridViewTextBoxColumn
            // 
            this.isbackDataGridViewTextBoxColumn.DataPropertyName = "is_back";
            this.isbackDataGridViewTextBoxColumn.HeaderText = "is_back";
            this.isbackDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbackDataGridViewTextBoxColumn.Name = "isbackDataGridViewTextBoxColumn";
            this.isbackDataGridViewTextBoxColumn.Width = 125;
            // 
            // isconDataGridViewTextBoxColumn
            // 
            this.isconDataGridViewTextBoxColumn.DataPropertyName = "is_con";
            this.isconDataGridViewTextBoxColumn.HeaderText = "is_con";
            this.isconDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isconDataGridViewTextBoxColumn.Name = "isconDataGridViewTextBoxColumn";
            this.isconDataGridViewTextBoxColumn.Width = 125;
            // 
            // isbackallowedDataGridViewTextBoxColumn
            // 
            this.isbackallowedDataGridViewTextBoxColumn.DataPropertyName = "is_back_allowed";
            this.isbackallowedDataGridViewTextBoxColumn.HeaderText = "is_back_allowed";
            this.isbackallowedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbackallowedDataGridViewTextBoxColumn.Name = "isbackallowedDataGridViewTextBoxColumn";
            this.isbackallowedDataGridViewTextBoxColumn.Width = 125;
            // 
            // isallowedDataGridViewTextBoxColumn
            // 
            this.isallowedDataGridViewTextBoxColumn.DataPropertyName = "is_allowed";
            this.isallowedDataGridViewTextBoxColumn.HeaderText = "is_allowed";
            this.isallowedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isallowedDataGridViewTextBoxColumn.Name = "isallowedDataGridViewTextBoxColumn";
            this.isallowedDataGridViewTextBoxColumn.Width = 125;
            // 
            // isconallowedDataGridViewTextBoxColumn
            // 
            this.isconallowedDataGridViewTextBoxColumn.DataPropertyName = "is_con_allowed";
            this.isconallowedDataGridViewTextBoxColumn.HeaderText = "is_con_allowed";
            this.isconallowedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isconallowedDataGridViewTextBoxColumn.Name = "isconallowedDataGridViewTextBoxColumn";
            this.isconallowedDataGridViewTextBoxColumn.Width = 125;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiButton2);
            this.uiGroupBox1.Controls.Add(this.uiButton1);
            this.uiGroupBox1.Controls.Add(this.comboBox2);
            this.uiGroupBox1.Controls.Add(this.comboBox1);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(2, 241);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(796, 207);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "借阅信息修改";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(103, 56);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 34);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "检查信息";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sbinfoBindingSource1;
            this.comboBox1.DisplayMember = "sno";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 35);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "sno";
            // 
            // sbinfoBindingSource1
            // 
            this.sbinfoBindingSource1.DataMember = "sb_info";
            this.sbinfoBindingSource1.DataSource = this.book_systemDataSet1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.sbinfoBindingSource2;
            this.comboBox2.DisplayMember = "isbn";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(415, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 35);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "isbn";
            // 
            // sbinfoBindingSource2
            // 
            this.sbinfoBindingSource2.DataMember = "sb_info";
            this.sbinfoBindingSource2.DataSource = this.book_systemDataSet1;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(599, 55);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 4;
            this.uiButton1.Text = "修改记录";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(237, 116);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton2.TabIndex = 5;
            this.uiButton2.Text = "确认";
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiDataGridView1);
            this.Name = "borrow";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 2);
            this.ShowDragStretch = true;
            this.ShowIcon = true;
            this.ShowRadius = false;
            this.ShowTitleIcon = true;
            this.Text = "borrow";
            this.Load += new System.EventHandler(this.borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_systemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbinfoBindingSource)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sbinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbinfoBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView1;
        private book_systemDataSet1 book_systemDataSet1;
        private System.Windows.Forms.BindingSource sbinfoBindingSource;
        private book_systemDataSet1TableAdapters.sb_infoTableAdapter sb_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrownumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isconDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbackallowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isallowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isconallowedDataGridViewTextBoxColumn;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource sbinfoBindingSource1;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource sbinfoBindingSource2;
        private Sunny.UI.UIButton uiButton2;
    }
}