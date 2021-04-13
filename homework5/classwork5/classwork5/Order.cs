using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork5
{
    //订单明细:订单号 下单时间
    public class Order
    {
        //创建一个空订单

        public Order() { }
        
        public customer cus1 = null; //该订单下单的顾客
        //创建一个含有多个商品的链表
        public List<OrderDetails> orderdetails = new List<OrderDetails>();
        public string OrderTime { get=> DateTime.Now.ToString();}
        public int Id { get; set; }

        public double TotalPrice()
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
        }
        public override string ToString()
        {
            return "订单号:" + Id + "\n\n" + LinkConnect().ToString()+"下单时间:" + OrderTime+"\n";
        }

        public bool selectCustomerName(string name)
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
        }



        public override bool Equals(object obj)
        {
            Order ord1 = obj as Order;
            return ord1.Id == Id&&ord1.OrderTime == OrderTime;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
