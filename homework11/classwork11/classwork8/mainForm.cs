using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace classwork8
{
    public partial class mainForm : Form
    {
        public static OrderService orderService = new OrderService();
        public mainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
            bindingSource1.DataSource = orderService.orders;         
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            inf_txt.Text = "订单号"; 
        }

        //修改订单
        private void modifyOrder_Click(object sender, EventArgs e)
        {
            modifyForm modifyForm = new modifyForm();
            //modifyForm.MdiParent = this;
            modifyForm.Size = new Size(650, 400);
            modifyForm.ShowDialog();
            bindingSource1.ResetBindings(false);
        }
        
        //添加订单
        private void addOrder_Click(object sender, EventArgs e)
        {
            addForm addForm = new addForm();
            //addForm.MdiParent = this;
            addForm.Size = new Size(600, 400);
            addForm.ShowDialog();
            bindingSource1.ResetBindings(false);
        }
        

        //删除订单
        private void deleteOrder_Click(object sender, EventArgs e)
        {    
            if(inf_txt.Text != "订单号")
            {
                MessageBox.Show("请按订单号删除订单!", "提示");
                return;
            }
            if(order_txt.Text == "")
            {
                MessageBox.Show("请输入要删除的订单号!", "提示");
                return;
            }
            if(order_txt.Text != "")
            {
                bool flag = int.TryParse(order_txt.Text, out int orderID);
                if(flag == false)
                {
                    MessageBox.Show("订单号只能输入整数!");
                    return;
                }
            }
            Order targetOrder = orderService.SearchOrder(int.Parse(order_txt.Text));
            if(targetOrder == null)
            {
                MessageBox.Show("未找到对应订单!");
                return;
            }
            else orderService.DeleteOrderID(int.Parse(order_txt.Text));
            MessageBox.Show("删除成功!");
            bindingSource1.ResetBindings(false);

        }


        //查找订单
        private void findOrder_Click(object sender, EventArgs e)
        {
            switch (inf_txt.Text)
            {
                case "订单号": if (order_txt.Text == "")
                    {
                        MessageBox.Show("订单号不能为空!");
                        return;
                    }
                    else bindingSource1.DataSource = orderService.SearchID(int.Parse(order_txt.Text));
                    break;
                case "客户名":
                    if (order_txt.Text == "")
                    {
                        MessageBox.Show("客户名不能为空!");
                        return;
                    }
                    bindingSource1.DataSource = orderService.SearchCustomerName(order_txt.Text);break;
                case "客户住址":
                    if (order_txt.Text == "")
                    {
                        MessageBox.Show("客户地址不能为空!");
                        return;
                    }
                    bindingSource1.DataSource = orderService.SearchcustomerAddress(order_txt.Text);break;
                default:break;              
            }
            if (bindingSource1.DataSource != null)
                bindingSource1.ResetBindings(false);
            else
                MessageBox.Show("无查询结果", "提示");
        }


        //导入订单
        private void importOrder_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImportOrder = new OpenFileDialog();
            XmlSerializer OrderXml = new XmlSerializer(typeof(List<Order>));
            ImportOrder.InitialDirectory = @"E:\";
            ImportOrder.Filter = "txt files(*.txt)|*.xml";
            ImportOrder.FilterIndex = 1;
            ImportOrder.RestoreDirectory = true;
            if(ImportOrder.ShowDialog() == DialogResult.OK)
            {
                ShowFileText(ImportOrder.FileName);
                using (FileStream orderlist = new FileStream(ImportOrder.FileName, FileMode.Open))
                {
                    orderService.orders = (List<Order>)OrderXml.Deserialize(orderlist);
                }
                bindingSource1.DataSource = orderService.orders;
                MessageBox.Show("导入成功!");
            }
            //bindingSource1.ResetBindings(false);
        }

        private void ShowFileText(string filename)
        {
            System.IO.StreamReader SR = new System.IO.StreamReader(filename, System.Text.Encoding.Default);
            string content = SR.ReadToEnd();
            SR.Close();
        }


        //导出订单
        private void exportOrder_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog ExportOrder = new SaveFileDialog();
            XmlSerializer OrderXml = new XmlSerializer(typeof(List<Order>));

            if (ExportOrder.ShowDialog() == DialogResult.OK)
            {
                using (FileStream orders = new FileStream(ExportOrder.FileName, FileMode.Create))
                {
                    OrderXml.Serialize(orders, orderService.orders);
                }
                MessageBox.Show("导出成功!");
            }
        }

        private void showAllOrders_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = mainForm.orderService.orders;
        }
    }
}
