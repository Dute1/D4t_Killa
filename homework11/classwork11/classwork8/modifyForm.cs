using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classwork8
{
    public partial class modifyForm : Form
    {
        public modifyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyForm_Load(object sender, EventArgs e)
        {
            appleNum_txt.Text = "0";
            bookNum_txt.Text = "0";
            milkNum_txt.Text = "0";
            lampNum_txt.Text = "0";
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            if(changeOrderID_txt.Text == "")
            {
                MessageBox.Show("订单号不能为空!", "提示");
                return;
            }
            if (changeOrderID_txt.Text != "")
            {
                bool flag = int.TryParse(changeOrderID_txt.Text, out int orderID);
                if (flag == false)
                {
                    MessageBox.Show("订单号只能输入整数!");
                    return;
                }
            }
            Order targetOrder = mainForm.orderService.SearchOrder(int.Parse(changeOrderID_txt.Text));
            if(targetOrder == null)
            {
                MessageBox.Show("没有该订单!","提示");
                return;
            }
            
            switch (changeINF_txt.Text)
            {
                case "客户名":
                    mainForm.orderService.ChangeCustomerName(int.Parse(changeOrderID_txt.Text), changedItem_txt.Text);
                    MessageBox.Show("修改成功");
                    this.Close();
                    break;
                case "客户住址":
                    mainForm.orderService.ChangeCustomerAddress(int.Parse(changeOrderID_txt.Text), changedItem_txt.Text);
                    MessageBox.Show("修改成功");
                    this.Close();
                    break;
                case "商品信息":
                    
                    if (appleNum_txt.Text == "" || bookNum_txt.Text == "" || milkNum_txt.Text == "" || lampNum_txt.Text == "")
                    {
                        MessageBox.Show("商品数量不能为空!", "提示");
                        return;
                    }
                    int appleNum = 0, bookNum = 0, milkNum = 0, lampNum = 0;
                    if (appleNum_txt.Text != "")
                    {
                        bool flag = int.TryParse(appleNum_txt.Text, out appleNum);
                        if (flag == false) MessageBox.Show("商品数量请输入数字!", "提示");
                    }
                    if (bookNum_txt.Text != "")
                    {
                        bool flag = int.TryParse(bookNum_txt.Text, out bookNum);
                        if (flag == false) MessageBox.Show("商品数量请输入数字!", "提示");
                    }
                    if (milkNum_txt.Text != "")
                    {
                        bool flag = int.TryParse(milkNum_txt.Text, out milkNum);
                        if (flag == false) MessageBox.Show("商品数量请输入数字!", "提示");
                    }
                    if (lampNum_txt.Text != "")
                    {
                        bool flag = int.TryParse(lampNum_txt.Text, out lampNum);
                        if (flag == false) MessageBox.Show("商品数量请输入数字!", "提示");
                    }
                    if (appleNum < 0 || bookNum < 0 || milkNum < 0 || lampNum < 0)
                    {
                        MessageBox.Show("请输入正确的商品数量!", "提示");
                        return;
                    }
                    if (appleNum == 0 && bookNum == 0 && milkNum == 0 && lampNum == 0)
                    {
                        MessageBox.Show("商品数量不能全为0!", "提示");
                        return;
                    }

                    List<string> commodities = new List<string>();
                    while (appleNum != 0)
                    {
                        commodities.Add("苹果");
                        appleNum--;
                    }
                    while (bookNum != 0)
                    {
                        commodities.Add("软件构造基础");
                        bookNum--;
                    }
                    while (milkNum != 0)
                    {
                        commodities.Add("特仑苏");
                        milkNum--;
                    }
                    while (lampNum != 0)
                    {
                        commodities.Add("台灯");
                        lampNum--;
                    }
                    string[] comArray = commodities.ToArray();
                    mainForm.orderService.modifyOrderDetails(targetOrder, comArray);                  
                    this.Close();
                    break;
            }
                
        }
    }
}
