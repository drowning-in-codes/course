
namespace 数据库实验
{
    partial class bookinfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.book_systemDataSet_book = new 数据库实验.book_systemDataSet_book();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new 数据库实验.book_systemDataSet_bookTableAdapters.booksTableAdapter();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bpublishtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bpopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiButton4 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_systemDataSet_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.uiDataGridView1.AutoGenerateColumns = false;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.bnameDataGridViewTextBoxColumn,
            this.bpublishtimeDataGridViewTextBoxColumn,
            this.bauthorDataGridViewTextBoxColumn,
            this.bnumDataGridViewTextBoxColumn,
            this.bpopDataGridViewTextBoxColumn});
            this.uiDataGridView1.DataSource = this.booksBindingSource;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle33;
            this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(2, 35);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.uiDataGridView1.RowHeadersWidth = 51;
            this.uiDataGridView1.RowHeight = 27;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.uiDataGridView1.RowTemplate.Height = 27;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.ShowGridLine = true;
            this.uiDataGridView1.Size = new System.Drawing.Size(846, 175);
            this.uiDataGridView1.TabIndex = 0;
            // 
            // book_systemDataSet_book
            // 
            this.book_systemDataSet_book.DataSetName = "book_systemDataSet_book";
            this.book_systemDataSet_book.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.book_systemDataSet_book;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.Width = 125;
            // 
            // bnameDataGridViewTextBoxColumn
            // 
            this.bnameDataGridViewTextBoxColumn.DataPropertyName = "b_name";
            this.bnameDataGridViewTextBoxColumn.HeaderText = "b_name";
            this.bnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bnameDataGridViewTextBoxColumn.Name = "bnameDataGridViewTextBoxColumn";
            this.bnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bpublishtimeDataGridViewTextBoxColumn
            // 
            this.bpublishtimeDataGridViewTextBoxColumn.DataPropertyName = "b_publish_time";
            this.bpublishtimeDataGridViewTextBoxColumn.HeaderText = "b_publish_time";
            this.bpublishtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bpublishtimeDataGridViewTextBoxColumn.Name = "bpublishtimeDataGridViewTextBoxColumn";
            this.bpublishtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // bauthorDataGridViewTextBoxColumn
            // 
            this.bauthorDataGridViewTextBoxColumn.DataPropertyName = "b_author";
            this.bauthorDataGridViewTextBoxColumn.HeaderText = "b_author";
            this.bauthorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bauthorDataGridViewTextBoxColumn.Name = "bauthorDataGridViewTextBoxColumn";
            this.bauthorDataGridViewTextBoxColumn.Width = 125;
            // 
            // bnumDataGridViewTextBoxColumn
            // 
            this.bnumDataGridViewTextBoxColumn.DataPropertyName = "b_num";
            this.bnumDataGridViewTextBoxColumn.HeaderText = "b_num";
            this.bnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bnumDataGridViewTextBoxColumn.Name = "bnumDataGridViewTextBoxColumn";
            this.bnumDataGridViewTextBoxColumn.Width = 125;
            // 
            // bpopDataGridViewTextBoxColumn
            // 
            this.bpopDataGridViewTextBoxColumn.DataPropertyName = "b_pop";
            this.bpopDataGridViewTextBoxColumn.HeaderText = "b_pop";
            this.bpopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bpopDataGridViewTextBoxColumn.Name = "bpopDataGridViewTextBoxColumn";
            this.bpopDataGridViewTextBoxColumn.Width = 125;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiButton4);
            this.uiGroupBox1.Controls.Add(this.uiTextBox2);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiTextBox1);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.uiLine1);
            this.uiGroupBox1.Controls.Add(this.uiButton3);
            this.uiGroupBox1.Controls.Add(this.uiButton2);
            this.uiGroupBox1.Controls.Add(this.uiButton1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(2, 246);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(846, 230);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "书籍信息";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(511, 35);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 0;
            this.uiButton1.Text = "更新书籍";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(511, 86);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 1;
            this.uiButton2.Text = "增加书籍";
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.FillColor = System.Drawing.Color.Red;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(529, 174);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(100, 35);
            this.uiButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton3.TabIndex = 2;
            this.uiButton3.Text = "删除书籍";
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.Location = new System.Drawing.Point(0, 139);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(850, 29);
            this.uiLine1.TabIndex = 3;
            this.uiLine1.Text = "删除信息";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(232, 175);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(83, 34);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "ISBN";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.ButtonSymbol = 61761;
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(336, 175);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Size = new System.Drawing.Size(150, 34);
            this.uiTextBox1.TabIndex = 5;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(153, 37);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 34);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "ISBN";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.ButtonSymbol = 61761;
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.FillColor = System.Drawing.Color.White;
            this.uiTextBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox2.Location = new System.Drawing.Point(246, 37);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.Maximum = 2147483647D;
            this.uiTextBox2.Minimum = -2147483648D;
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Size = new System.Drawing.Size(150, 34);
            this.uiTextBox2.TabIndex = 7;
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.Location = new System.Drawing.Point(246, 86);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Size = new System.Drawing.Size(100, 35);
            this.uiButton4.TabIndex = 8;
            this.uiButton4.Text = "修改信息";
            this.uiButton4.Click += new System.EventHandler(this.uiButton4_Click);
            // 
            // bookinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 478);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiDataGridView1);
            this.MaximumSize = new System.Drawing.Size(850, 800);
            this.Name = "bookinfo";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 2);
            this.ShowDragStretch = true;
            this.ShowRadius = false;
            this.ShowTitleIcon = true;
            this.Text = "bookinfo";
            this.Load += new System.EventHandler(this.bookinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_systemDataSet_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView1;
        private book_systemDataSet_book book_systemDataSet_book;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private book_systemDataSet_bookTableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bpublishtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bpopDataGridViewTextBoxColumn;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton4;
    }
}