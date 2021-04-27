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
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void createOrder_btn_Click(object sender, EventArgs e)
        {
            if(cusName_Textbox.Text == "")
            {
                MessageBox.Show("客户名不能为空!","提示");
                return;
            }
            if(cusAddress_textbox.Text == "")
            {
                MessageBox.Show("客户住址不能为空!", "提示");
                return;
            }
            //appleNum_txtbox.Text = bookNum_txtbox.Text = milkNum_txtbox.Text = lampNum_txtbox.Text = "0";
            if (appleNum_txtbox.Text == ""|| bookNum_txtbox.Text == ""|| milkNum_txtbox.Text == ""|| lampNum_txtbox.Text == "")
            {
                MessageBox.Show("商品数量不能为空!", "提示");
                return;
            }
            int appleNum = 0, bookNum = 0, milkNum = 0, lampNum = 0;
            if (appleNum_txtbox.Text != "")
            {
                bool flag = int.TryParse(appleNum_txtbox.Text, out appleNum);
                if (flag == false) MessageBox.Show("商品数量请输入数字!", "提示");
            }
            if (bookNum_txtbox.Text != "")
            {
                bool flag = int.TryParse(bookNum_txtbox.Text, out bookNum);
                if (flag == false) MessageBox.Show("商品数量请输入数字!", "提示");
            }
            if (milkNum_txtbox.Text != "")
            {
                bool flag = int.TryParse(milkNum_txtbox.Text, out milkNum);
                if (flag == false) MessageBox.Show("商品数量请输入数字!", "提示");
            }
            if (lampNum_txtbox.Text != "")
            {
                bool flag = int.TryParse(lampNum_txtbox.Text, out lampNum);
                if (flag == false) MessageBox.Show("商品数量请输入数字!", "提示");
            }
            if(appleNum<0||bookNum<0||milkNum<0||lampNum<0)
            {
                MessageBox.Show("请输入正确的商品数量!","提示");
                return;
            }
            if (appleNum ==0 && bookNum == 0 && milkNum == 0 && lampNum == 0)
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
            while(milkNum != 0)
            {
                commodities.Add("特仑苏");
                milkNum--;
            }
            while(lampNum != 0)
            {
                commodities.Add("台灯");
                lampNum--;
            }
            string[] comArray = commodities.ToArray();
            mainForm.orderService.AddOrder(cusName_Textbox.Text, cusAddress_textbox.Text, comArray);
            MessageBox.Show("添加成功!");
            this.Close();
        }

        private void addForm_Load(object sender, EventArgs e)
        {
            appleNum_txtbox.Text = "0";
            bookNum_txtbox.Text = "0";
            milkNum_txtbox.Text = "0";
            lampNum_txtbox.Text = "0";
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
