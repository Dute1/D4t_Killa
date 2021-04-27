namespace classwork8
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.inf_txt = new System.Windows.Forms.ComboBox();
            this.order_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.findOrder_btn = new System.Windows.Forms.Button();
            this.exportOrder_btn = new System.Windows.Forms.Button();
            this.importOrder_btn = new System.Windows.Forms.Button();
            this.modifyOrder_btn = new System.Windows.Forms.Button();
            this.addOrder_btn = new System.Windows.Forms.Button();
            this.deleteOrder_btn = new System.Windows.Forms.Button();
            this.showAllOrders = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.commodityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodityPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showAllOrders);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inf_txt);
            this.groupBox1.Controls.Add(this.order_txt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(576, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "订单管理系统";
            // 
            // inf_txt
            // 
            this.inf_txt.FormattingEnabled = true;
            this.inf_txt.Items.AddRange(new object[] {
            "订单号",
            "客户名",
            "商品名称"});
            this.inf_txt.Location = new System.Drawing.Point(53, 59);
            this.inf_txt.Name = "inf_txt";
            this.inf_txt.Size = new System.Drawing.Size(112, 23);
            this.inf_txt.TabIndex = 4;
            // 
            // order_txt
            // 
            this.order_txt.Location = new System.Drawing.Point(207, 57);
            this.order_txt.Name = "order_txt";
            this.order_txt.Size = new System.Drawing.Size(259, 25);
            this.order_txt.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 330);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 231);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 202);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "订单基本信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerAddress,
            this.orderTimeDataGridViewTextBoxColumn,
            this.sumPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(793, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // customerAddress
            // 
            this.customerAddress.DataPropertyName = "customerAddress";
            this.customerAddress.HeaderText = "客户住址";
            this.customerAddress.Name = "customerAddress";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "订单明细";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commodityIDDataGridViewTextBoxColumn,
            this.commodityNameDataGridViewTextBoxColumn,
            this.commodityPriceDataGridViewTextBoxColumn});
            this.dataGridView2.DataMember = "orderdetails";
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(793, 202);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.findOrder_btn);
            this.groupBox2.Controls.Add(this.exportOrder_btn);
            this.groupBox2.Controls.Add(this.importOrder_btn);
            this.groupBox2.Controls.Add(this.modifyOrder_btn);
            this.groupBox2.Controls.Add(this.addOrder_btn);
            this.groupBox2.Controls.Add(this.deleteOrder_btn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请选择你的操作";
            // 
            // findOrder_btn
            // 
            this.findOrder_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findOrder_btn.Location = new System.Drawing.Point(425, 30);
            this.findOrder_btn.Name = "findOrder_btn";
            this.findOrder_btn.Size = new System.Drawing.Size(91, 32);
            this.findOrder_btn.TabIndex = 5;
            this.findOrder_btn.Text = "查询订单";
            this.findOrder_btn.UseVisualStyleBackColor = true;
            this.findOrder_btn.Click += new System.EventHandler(this.findOrder_Click);
            // 
            // exportOrder_btn
            // 
            this.exportOrder_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exportOrder_btn.Location = new System.Drawing.Point(685, 30);
            this.exportOrder_btn.Name = "exportOrder_btn";
            this.exportOrder_btn.Size = new System.Drawing.Size(91, 32);
            this.exportOrder_btn.TabIndex = 4;
            this.exportOrder_btn.Text = "导出订单";
            this.exportOrder_btn.UseVisualStyleBackColor = true;
            this.exportOrder_btn.Click += new System.EventHandler(this.exportOrder_btn_Click);
            // 
            // importOrder_btn
            // 
            this.importOrder_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.importOrder_btn.Location = new System.Drawing.Point(555, 30);
            this.importOrder_btn.Name = "importOrder_btn";
            this.importOrder_btn.Size = new System.Drawing.Size(91, 32);
            this.importOrder_btn.TabIndex = 3;
            this.importOrder_btn.Text = "导入订单";
            this.importOrder_btn.UseVisualStyleBackColor = true;
            this.importOrder_btn.Click += new System.EventHandler(this.importOrder_Click);
            // 
            // modifyOrder_btn
            // 
            this.modifyOrder_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modifyOrder_btn.Location = new System.Drawing.Point(295, 30);
            this.modifyOrder_btn.Name = "modifyOrder_btn";
            this.modifyOrder_btn.Size = new System.Drawing.Size(91, 32);
            this.modifyOrder_btn.TabIndex = 2;
            this.modifyOrder_btn.Text = "修改订单";
            this.modifyOrder_btn.UseVisualStyleBackColor = true;
            this.modifyOrder_btn.Click += new System.EventHandler(this.modifyOrder_Click);
            // 
            // addOrder_btn
            // 
            this.addOrder_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addOrder_btn.Location = new System.Drawing.Point(35, 30);
            this.addOrder_btn.Name = "addOrder_btn";
            this.addOrder_btn.Size = new System.Drawing.Size(91, 32);
            this.addOrder_btn.TabIndex = 0;
            this.addOrder_btn.Text = "添加订单";
            this.addOrder_btn.UseVisualStyleBackColor = true;
            this.addOrder_btn.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // deleteOrder_btn
            // 
            this.deleteOrder_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteOrder_btn.Location = new System.Drawing.Point(165, 30);
            this.deleteOrder_btn.Name = "deleteOrder_btn";
            this.deleteOrder_btn.Size = new System.Drawing.Size(91, 32);
            this.deleteOrder_btn.TabIndex = 1;
            this.deleteOrder_btn.Text = "删除订单";
            this.deleteOrder_btn.UseVisualStyleBackColor = true;
            this.deleteOrder_btn.Click += new System.EventHandler(this.deleteOrder_Click);
            // 
            // showAllOrders
            // 
            this.showAllOrders.Location = new System.Drawing.Point(580, 80);
            this.showAllOrders.Name = "showAllOrders";
            this.showAllOrders.Size = new System.Drawing.Size(124, 34);
            this.showAllOrders.TabIndex = 6;
            this.showAllOrders.Text = "显示所有订单";
            this.showAllOrders.UseVisualStyleBackColor = true;
            this.showAllOrders.Click += new System.EventHandler(this.showAllOrders_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "客户名";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "下单时间";
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumPriceDataGridViewTextBoxColumn
            // 
            this.sumPriceDataGridViewTextBoxColumn.DataPropertyName = "sumPrice";
            this.sumPriceDataGridViewTextBoxColumn.HeaderText = "总金额";
            this.sumPriceDataGridViewTextBoxColumn.Name = "sumPriceDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(classwork8.Order);
            // 
            // commodityIDDataGridViewTextBoxColumn
            // 
            this.commodityIDDataGridViewTextBoxColumn.DataPropertyName = "commodityID";
            this.commodityIDDataGridViewTextBoxColumn.HeaderText = "货号";
            this.commodityIDDataGridViewTextBoxColumn.Name = "commodityIDDataGridViewTextBoxColumn";
            // 
            // commodityNameDataGridViewTextBoxColumn
            // 
            this.commodityNameDataGridViewTextBoxColumn.DataPropertyName = "commodityName";
            this.commodityNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.commodityNameDataGridViewTextBoxColumn.Name = "commodityNameDataGridViewTextBoxColumn";
            // 
            // commodityPriceDataGridViewTextBoxColumn
            // 
            this.commodityPriceDataGridViewTextBoxColumn.DataPropertyName = "commodityPrice";
            this.commodityPriceDataGridViewTextBoxColumn.HeaderText = "商品价格";
            this.commodityPriceDataGridViewTextBoxColumn.Name = "commodityPriceDataGridViewTextBoxColumn";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox order_txt;
        private System.Windows.Forms.ComboBox inf_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button modifyOrder_btn;
        private System.Windows.Forms.Button deleteOrder_btn;
        private System.Windows.Forms.Button addOrder_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button importOrder_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exportOrder_btn;
        private System.Windows.Forms.Button findOrder_btn;
        public System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button showAllOrders;
    }
}

