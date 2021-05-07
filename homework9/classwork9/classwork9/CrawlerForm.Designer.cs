namespace classwork9
{
    partial class CrawlerForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crawlBtn = new System.Windows.Forms.Button();
            this.websiteTxt = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.absoluteUriDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absoluteUriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crawlBtn);
            this.groupBox1.Controls.Add(this.websiteTxt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请输入你要爬取的网址:";
            // 
            // crawlBtn
            // 
            this.crawlBtn.Location = new System.Drawing.Point(562, 47);
            this.crawlBtn.Name = "crawlBtn";
            this.crawlBtn.Size = new System.Drawing.Size(89, 32);
            this.crawlBtn.TabIndex = 1;
            this.crawlBtn.Text = "开始爬取";
            this.crawlBtn.UseVisualStyleBackColor = true;
            this.crawlBtn.Click += new System.EventHandler(this.crawlBtn_Click);
            // 
            // websiteTxt
            // 
            this.websiteTxt.Location = new System.Drawing.Point(61, 47);
            this.websiteTxt.Name = "websiteTxt";
            this.websiteTxt.Size = new System.Drawing.Size(416, 25);
            this.websiteTxt.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 130);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 320);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "正确网页信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "错误网页信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.absoluteUriDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "RightUrl";
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(786, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.absoluteUriDataGridViewTextBoxColumn1});
            this.dataGridView2.DataMember = "WrongUrl";
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(786, 288);
            this.dataGridView2.TabIndex = 1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(classwork9.Crawler);
            // 
            // absoluteUriDataGridViewTextBoxColumn1
            // 
            this.absoluteUriDataGridViewTextBoxColumn1.DataPropertyName = "AbsoluteUri";
            this.absoluteUriDataGridViewTextBoxColumn1.HeaderText = "网页信息";
            this.absoluteUriDataGridViewTextBoxColumn1.Name = "absoluteUriDataGridViewTextBoxColumn1";
            this.absoluteUriDataGridViewTextBoxColumn1.ReadOnly = true;
            this.absoluteUriDataGridViewTextBoxColumn1.Width = 500;
            // 
            // absoluteUriDataGridViewTextBoxColumn
            // 
            this.absoluteUriDataGridViewTextBoxColumn.DataPropertyName = "AbsoluteUri";
            this.absoluteUriDataGridViewTextBoxColumn.HeaderText = "网页信息";
            this.absoluteUriDataGridViewTextBoxColumn.Name = "absoluteUriDataGridViewTextBoxColumn";
            this.absoluteUriDataGridViewTextBoxColumn.ReadOnly = true;
            this.absoluteUriDataGridViewTextBoxColumn.Width = 500;
            // 
            // CrawlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrawlerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CrawlerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button crawlBtn;
        private System.Windows.Forms.TextBox websiteTxt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn absoluteUriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn absoluteUriDataGridViewTextBoxColumn1;
    }
}

