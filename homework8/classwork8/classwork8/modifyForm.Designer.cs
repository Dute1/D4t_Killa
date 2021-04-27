namespace classwork8
{
    partial class modifyForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.changeINF_txt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changeOrderID_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.changedItem_txt = new System.Windows.Forms.TextBox();
            this.change_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.commodityInf_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.appleNum_txt = new System.Windows.Forms.TextBox();
            this.bookNum_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.milkNum_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lampNum_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lampNum_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.milkNum_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bookNum_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.appleNum_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.commodityInf_label);
            this.groupBox1.Controls.Add(this.changedItem_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.changeOrderID_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.changeINF_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择你要修改的属性:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.change_btn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "是否确认修改";
            // 
            // changeINF_txt
            // 
            this.changeINF_txt.FormattingEnabled = true;
            this.changeINF_txt.Items.AddRange(new object[] {
            "客户名",
            "客户住址",
            "商品信息"});
            this.changeINF_txt.Location = new System.Drawing.Point(257, 135);
            this.changeINF_txt.Name = "changeINF_txt";
            this.changeINF_txt.Size = new System.Drawing.Size(194, 23);
            this.changeINF_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "请选择你要修改的订单号:";
            // 
            // changeOrderID_txt
            // 
            this.changeOrderID_txt.Location = new System.Drawing.Point(258, 71);
            this.changeOrderID_txt.Name = "changeOrderID_txt";
            this.changeOrderID_txt.Size = new System.Drawing.Size(193, 25);
            this.changeOrderID_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(86, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "修改后的内容为:";
            // 
            // changedItem_txt
            // 
            this.changedItem_txt.Location = new System.Drawing.Point(258, 199);
            this.changedItem_txt.Name = "changedItem_txt";
            this.changedItem_txt.Size = new System.Drawing.Size(193, 25);
            this.changedItem_txt.TabIndex = 5;
            // 
            // change_btn
            // 
            this.change_btn.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.change_btn.Location = new System.Drawing.Point(200, 73);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(84, 32);
            this.change_btn.TabIndex = 0;
            this.change_btn.Text = "确定";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(471, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // commodityInf_label
            // 
            this.commodityInf_label.AutoSize = true;
            this.commodityInf_label.Location = new System.Drawing.Point(502, 39);
            this.commodityInf_label.Name = "commodityInf_label";
            this.commodityInf_label.Size = new System.Drawing.Size(105, 15);
            this.commodityInf_label.TabIndex = 6;
            this.commodityInf_label.Text = "商品数量修改:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(556, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "苹果:";
            // 
            // appleNum_txt
            // 
            this.appleNum_txt.Location = new System.Drawing.Point(625, 71);
            this.appleNum_txt.Name = "appleNum_txt";
            this.appleNum_txt.Size = new System.Drawing.Size(100, 25);
            this.appleNum_txt.TabIndex = 8;
            // 
            // bookNum_txt
            // 
            this.bookNum_txt.Location = new System.Drawing.Point(625, 132);
            this.bookNum_txt.Name = "bookNum_txt";
            this.bookNum_txt.Size = new System.Drawing.Size(100, 25);
            this.bookNum_txt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(488, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "软件构造基础:";
            // 
            // milkNum_txt
            // 
            this.milkNum_txt.Location = new System.Drawing.Point(625, 194);
            this.milkNum_txt.Name = "milkNum_txt";
            this.milkNum_txt.Size = new System.Drawing.Size(100, 25);
            this.milkNum_txt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(539, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "特仑苏:";
            // 
            // lampNum_txt
            // 
            this.lampNum_txt.Location = new System.Drawing.Point(625, 249);
            this.lampNum_txt.Name = "lampNum_txt";
            this.lampNum_txt.Size = new System.Drawing.Size(100, 25);
            this.lampNum_txt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(556, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "台灯:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "(修改商品信息时此处不需要填写内容）";
            // 
            // modifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "modifyForm";
            this.Text = "修改订单";
            this.Load += new System.EventHandler(this.modifyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox changedItem_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox changeOrderID_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox changeINF_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.TextBox lampNum_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox milkNum_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bookNum_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox appleNum_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label commodityInf_label;
        private System.Windows.Forms.Label label8;
    }
}