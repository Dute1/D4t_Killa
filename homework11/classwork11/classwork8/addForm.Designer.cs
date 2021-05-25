namespace classwork8
{
    partial class addForm
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
            this.CusName = new System.Windows.Forms.Label();
            this.cusName_Textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cusAddress_textbox = new System.Windows.Forms.TextBox();
            this.cusAddress = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.createOrder_btn = new System.Windows.Forms.Button();
            this.lampNum_txtbox = new System.Windows.Forms.TextBox();
            this.milkNum_txtbox = new System.Windows.Forms.TextBox();
            this.lamp = new System.Windows.Forms.Label();
            this.milk = new System.Windows.Forms.Label();
            this.bookNum_txtbox = new System.Windows.Forms.TextBox();
            this.book = new System.Windows.Forms.Label();
            this.appleNum_txtbox = new System.Windows.Forms.TextBox();
            this.apple = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CusName
            // 
            this.CusName.AutoSize = true;
            this.CusName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CusName.Location = new System.Drawing.Point(183, 60);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(166, 24);
            this.CusName.TabIndex = 0;
            this.CusName.Text = "请输入客户名:";
            // 
            // cusName_Textbox
            // 
            this.cusName_Textbox.Location = new System.Drawing.Point(376, 60);
            this.cusName_Textbox.Name = "cusName_Textbox";
            this.cusName_Textbox.Size = new System.Drawing.Size(188, 25);
            this.cusName_Textbox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cusAddress_textbox);
            this.groupBox1.Controls.Add(this.cusAddress);
            this.groupBox1.Controls.Add(this.cusName_Textbox);
            this.groupBox1.Controls.Add(this.CusName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cusAddress_textbox
            // 
            this.cusAddress_textbox.Location = new System.Drawing.Point(376, 124);
            this.cusAddress_textbox.Name = "cusAddress_textbox";
            this.cusAddress_textbox.Size = new System.Drawing.Size(188, 25);
            this.cusAddress_textbox.TabIndex = 3;
            // 
            // cusAddress
            // 
            this.cusAddress.AutoSize = true;
            this.cusAddress.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cusAddress.Location = new System.Drawing.Point(159, 124);
            this.cusAddress.Name = "cusAddress";
            this.cusAddress.Size = new System.Drawing.Size(190, 24);
            this.cusAddress.TabIndex = 2;
            this.cusAddress.Text = "请输入客户住址:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancel_btn);
            this.groupBox2.Controls.Add(this.createOrder_btn);
            this.groupBox2.Controls.Add(this.lampNum_txtbox);
            this.groupBox2.Controls.Add(this.milkNum_txtbox);
            this.groupBox2.Controls.Add(this.lamp);
            this.groupBox2.Controls.Add(this.milk);
            this.groupBox2.Controls.Add(this.bookNum_txtbox);
            this.groupBox2.Controls.Add(this.book);
            this.groupBox2.Controls.Add(this.appleNum_txtbox);
            this.groupBox2.Controls.Add(this.apple);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 263);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请选择要购买的商品及数量:";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel_btn.Location = new System.Drawing.Point(435, 193);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(86, 35);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "退出";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // createOrder_btn
            // 
            this.createOrder_btn.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.createOrder_btn.Location = new System.Drawing.Point(263, 193);
            this.createOrder_btn.Name = "createOrder_btn";
            this.createOrder_btn.Size = new System.Drawing.Size(86, 35);
            this.createOrder_btn.TabIndex = 8;
            this.createOrder_btn.Text = "添加";
            this.createOrder_btn.UseVisualStyleBackColor = true;
            this.createOrder_btn.Click += new System.EventHandler(this.createOrder_btn_Click);
            // 
            // lampNum_txtbox
            // 
            this.lampNum_txtbox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lampNum_txtbox.Location = new System.Drawing.Point(539, 110);
            this.lampNum_txtbox.Name = "lampNum_txtbox";
            this.lampNum_txtbox.Size = new System.Drawing.Size(100, 25);
            this.lampNum_txtbox.TabIndex = 7;
            // 
            // milkNum_txtbox
            // 
            this.milkNum_txtbox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.milkNum_txtbox.Location = new System.Drawing.Point(231, 110);
            this.milkNum_txtbox.Name = "milkNum_txtbox";
            this.milkNum_txtbox.Size = new System.Drawing.Size(100, 25);
            this.milkNum_txtbox.TabIndex = 6;
            // 
            // lamp
            // 
            this.lamp.AutoSize = true;
            this.lamp.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lamp.Location = new System.Drawing.Point(470, 115);
            this.lamp.Name = "lamp";
            this.lamp.Size = new System.Drawing.Size(51, 17);
            this.lamp.TabIndex = 5;
            this.lamp.Text = "台灯:";
            // 
            // milk
            // 
            this.milk.AutoSize = true;
            this.milk.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.milk.Location = new System.Drawing.Point(151, 115);
            this.milk.Name = "milk";
            this.milk.Size = new System.Drawing.Size(68, 17);
            this.milk.TabIndex = 4;
            this.milk.Text = "特仑苏:";
            // 
            // bookNum_txtbox
            // 
            this.bookNum_txtbox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookNum_txtbox.Location = new System.Drawing.Point(539, 40);
            this.bookNum_txtbox.Name = "bookNum_txtbox";
            this.bookNum_txtbox.Size = new System.Drawing.Size(100, 25);
            this.bookNum_txtbox.TabIndex = 3;
            // 
            // book
            // 
            this.book.AutoSize = true;
            this.book.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.book.Location = new System.Drawing.Point(402, 44);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(119, 17);
            this.book.TabIndex = 2;
            this.book.Text = "软件构造基础:";
            // 
            // appleNum_txtbox
            // 
            this.appleNum_txtbox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.appleNum_txtbox.Location = new System.Drawing.Point(231, 40);
            this.appleNum_txtbox.Name = "appleNum_txtbox";
            this.appleNum_txtbox.Size = new System.Drawing.Size(100, 25);
            this.appleNum_txtbox.TabIndex = 1;
            // 
            // apple
            // 
            this.apple.AutoSize = true;
            this.apple.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.apple.Location = new System.Drawing.Point(160, 44);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(51, 17);
            this.apple.TabIndex = 0;
            this.apple.Text = "苹果:";
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "addForm";
            this.Text = "添加订单";
            this.Load += new System.EventHandler(this.addForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CusName;
        private System.Windows.Forms.TextBox cusName_Textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cusAddress_textbox;
        private System.Windows.Forms.Label cusAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox appleNum_txtbox;
        private System.Windows.Forms.Label apple;
        private System.Windows.Forms.TextBox bookNum_txtbox;
        private System.Windows.Forms.Label book;
        private System.Windows.Forms.TextBox lampNum_txtbox;
        private System.Windows.Forms.TextBox milkNum_txtbox;
        private System.Windows.Forms.Label lamp;
        private System.Windows.Forms.Label milk;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button createOrder_btn;
    }
}