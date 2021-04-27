                                                                                                                                                                                                                                              
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace classwork8
{ 
    //订单服务需要实现的功能:1.添加订单 2.删除订单 3.查询订单(按订单总金额排序) 4.修改订单(修改客户姓名，客户住址以及添删订单明细)
    public class OrderService
    {
        public List<Order> orders = new List<Order>();
        private static int ordernumber = 0;

        //创建订单
        public void AddOrder(string name,string address,string []commodity)
        {
            ordernumber++;
            Console.WriteLine("创建"+ordernumber.ToString("00")+"号订单");
            Order order = new Order(name,address);          
            for(int i = 0;i<commodity.Length;i++)
            {
                order.AddOrderDetails(commodity[i]);
            }
            orders.Add(order);
        }

        //一次性修改某个订单的订单明细
        public void modifyOrderDetails(Order order,string[] commodity)
        {
            order.orderdetails = new List<OrderDetails>();
            order.sumPrice = 0;
            for (int i = 0; i < commodity.Length; i++)
            {
                order.AddOrderDetails(commodity[i]);
            }
        }

        //按照订单号查找订单
        public List<Order> SearchID(int ID)
        {
            var orderlist = from order in orders
                            where order.ID == ID
                            select order;
            if (orderlist.ToList<Order>().Count() == 0) return null;
            else return orderlist.ToList<Order>();
        }

        //按照客户姓名查找订单
        public List<Order> SearchCustomerName(string name)
        {
            var orderlist = from order in orders
                            where order.customerName == name
                            select order;
            if (orderlist.ToList<Order>().Count() == 0) return null;
            else return orderlist.ToList<Order>();
        }

        //按照商品名称查找订单
        public List<Order> SearchCommodityName(string name)
        {
            var orderlist = from order in orders
                            where order.searchCommodity(name)
                            select order;
            if (orderlist.ToList<Order>().Count() == 0) return null;
            else return orderlist.ToList<Order>();
        }

        //按照订单号查找某个具体的订单
        public Order SearchOrder(int ID)
        {
            Order orderexample = new Order("", "");
            orderexample.ID = ID;
            if (orders.Count() == 0) Console.WriteLine("没有订单!");
            foreach(Order target in orders)
            {
                if (target.Equals(orderexample)) return target;
            }
            Console.WriteLine("没有查到相应订单!");
            return null;             
        }


        //按照订单号删除订单
        public void DeleteOrderID(int ID)
        {
            Order targetOrder = SearchOrder(ID);
            if (targetOrder == null) return ;
            orders.Remove(targetOrder);
        }

        //按照客户姓名删除订单
        //public void DeleteCusName(string name)
        //{
            //List<Order> orderlist = order
        //}

        //修改客户姓名
        public void ChangeCustomerName(int ID,string name)
        {
            Order targetOrder = SearchOrder(ID);
            targetOrder.customerName = name;
        }

        //修改客户住址
        public void ChangeCustomerAddress(int ID, string address)
        {
            Order targetOrder = SearchOrder(ID);
            targetOrder.customerAddress = address;
        }

        //添加订单明细
        public void AddCommodity(int ID,string commodityName)
        {
            Order targetOrder = SearchOrder(ID);
            targetOrder.AddOrderDetails(commodityName);
        }

    }
}