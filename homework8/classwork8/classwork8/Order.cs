using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork8
{
    //订单明细:订单号 下单时间
    public class Order
    {
        //创建一个空订单
                
        public customer cus1 { get; set; } //该订单下单的顾客
        public static int num = 0;
        public int ID { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string OrderTime { get=> DateTime.Now.ToString();}
        public double sumPrice{get;set;}
        public List<OrderDetails> orderdetails { get; set; }


        public Order() { }
        public Order(string name,string address)
        {
            this.cus1 = new customer(name, address);
            customerName = cus1.customerName;
            customerAddress = cus1.customerAddress;
            orderdetails = new List<OrderDetails>();
            num++;
            this.ID = num;
        }

        /*public double TotalPrice()
        {   
            double totalPrice = 0;
            foreach(OrderDetails ordDt in orderdetails)
            {
                totalPrice+=ordDt.commodity.price;
            }
            return totalPrice;

        }

        public string LinkConnect()
        {
            string s=null;
            foreach(OrderDetails ord in orderdetails)
            {
                s += ord;
            }
            return s;
        }*/
        public override string ToString()
        {
            return "订单号:" + ID + "\n" +"顾客姓名:"+cus1.customerName+"\n"+"顾客地址:"+cus1.customerAddress +"\n下单时间:" + OrderTime+"\n";
        }

       /* public bool selectCustomerName(string name)
        {
            var s = from n in orderdetails
                    where n.customer.customerName == name
                    select n;
            List<OrderDetails> selectOrderDetails = s.ToList<OrderDetails>();
            if (selectOrderDetails.Count()!= 0)
                return true;
            else return false;
        }

        public bool selectCustomerAddress(string address)
        {
            var s = from m in orderdetails
                    where m.customer.customerAddress == address
                    select m;
            List<OrderDetails> selectOrderDetails = s.ToList<OrderDetails>();
            if (selectOrderDetails != null)
                return true;
            else return false;
        }*/

        //查找某个订单明细
        public OrderDetails Search(string ID)
        {
            if (orderdetails.Count() == 0)
            {
                Console.WriteLine("订单中无订单明细！");
                return null;
            }
            foreach (OrderDetails ordts in orderdetails)
            {
                if (ordts.commodityID == ID)
                    return ordts;
            }
            Console.WriteLine("未找到相关商品");
            return null;
        }


        //添加订单明细
        public void AddOrderDetails(string name)
        {
            OrderDetails orderDetail = new OrderDetails(name);
            sumPrice += orderDetail.commodityPrice;
            orderdetails.Add(orderDetail);
        }

        //删除订单明细
        public void DeleteOrderDetails(string id)
        {
            OrderDetails ordt = Search(id);
            orderdetails.Remove(ordt);
            Console.WriteLine("已经删除ID为"+id+"的订单明细");
        }


        //修改订单明细
        public void ModifyOrderDetails(string name)
        {
            OrderDetails orderDetail = new OrderDetails(name);
        }
        public bool searchCommodity(string name)
        {
            var orderDetailselected = from orderDetail in orderdetails
                                      where orderDetail.commodityName == name
                                      select orderDetail;
            if (orderDetailselected.ToList<OrderDetails>().Count() != 0) return true;
            else return false;
        }

        public override bool Equals(object obj)
        {
            Order ord1 = obj as Order;
            return ord1.ID == ID ;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
