                                                                                                                                                                                                                                              
using System;
using System.Data.Entity;
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
        //public List<Order> orders = new List<Order>();
        private static int ordernumber = 0;

        //创建订单
        public void AddOrder(string name,string address,string []commodity)
        {
            ordernumber++;
            Console.WriteLine("创建"+ordernumber.ToString("00")+"号订单");
            Order order = new Order(name,address);
            for(int i = 0; i < commodity.Length; i++)
            {
                order.AddOrderDetails(commodity[i]);
            }
            using (var ctx = new OrderContext())
            {
                ctx.Entry(order).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        //返回订单链表
        public List<Order> orders
        {
            get {
                using (var ctx = new OrderContext())
                {
                    var query =  ctx.Orders.Include(o => o.orderdetails.Select(d => d.commodity)).Include("cutomerName").Include("customerAddress").ToList<Order>();
                    return query;
                }
            }set { }
            
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
            using(var ctx = new OrderContext())
            {
                return ctx.Orders.Include(o => o.orderdetails.Select(d => d.commodity)).Include("customerName").Include("customerAddress").Where(order => order.ID == ID).OrderBy(o => o.sumPrice).ToList();
            }
        }

        //按照客户姓名查找订单
        public List<Order> SearchCustomerName(string name)
        {
            using(var ctx = new OrderContext())
            {
                return ctx.Orders.Include(o => o.orderdetails.Select(d => d.commodity)).Include("customerName").Include("customerAddress").Where(order => order.customerName == name).OrderBy(o => o.sumPrice).ToList();
            }
            /*var orderlist = from order in orders
                            where order.customerName == name
                            select order;
            if (orderlist.ToList<Order>().Count() == 0) return null;
            else return orderlist.ToList<Order>();*/
        }

        //按照商品名称查找订单
        public List<Order> SearchcustomerAddress(string address)
        {
            using(var ctx = new OrderContext())
            {
                return ctx.Orders.Include(o => o.orderdetails.Select(d => d.commodity)).Include("customerName").Include("customerAddress").Where(order => order.customerAddress == address).OrderBy(o => o.sumPrice).ToList();
            }
            /*var orderlist = from order in orders
                            where order.searchCommodity(name)
                            select order;
            if (orderlist.ToList<Order>().Count() == 0) return null;
            else return orderlist.ToList<Order>();*/
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
            using(var ctx = new OrderContext())
            {
                var order = ctx.Orders.Include("Details").SingleOrDefault(o => o.ID == ID);
                if (order == null) return;
                ctx.OrderDetails.RemoveRange(order.orderdetails);
                ctx.Orders.Remove(order);
                ctx.SaveChanges();
            }
        }

        //按照客户姓名删除订单
        //public void DeleteCusName(string name)
        //{
            //List<Order> orderlist = order
        //}


        /*private static void FixOrder(Order newOrder)
        {
            newOrder.customerName = newOrder.cus1.customerName;
            newOrder.customerAddress = newOrder.cus1.customerAddress;
            newOrder.cus1 = null;
            newOrder.orderdetails.ForEach(d => { d.commodityID = d.commodity.Id; d.commodity = null; });
        }*/

       ///修改客户姓名
        public void ChangeCustomerName(int ID,string name)
        {
            using(var ctx = new OrderContext())
            {
                var order = ctx.Orders.Include("cus1").SingleOrDefault(o => o.ID == ID);
                if (order != null)
                {
                    order.customerName = name;
                    ctx.SaveChanges();
                }
            }
        }

        //修改客户住址
        public void ChangeCustomerAddress(int ID, string address)
        {
            using(var ctx = new OrderContext())
            {
                var order = ctx.Orders.Include("cus1").SingleOrDefault(o => o.ID == ID);
                if (order != null)
                {
                    order.customerAddress = address;
                    ctx.SaveChanges();
                }
            }
        }

        //添加订单明细
        public void AddCommodity(int ID,string commodityName)
        {
            using (var ctx = new OrderContext())
            {
                var targetOrder = ctx.Orders.Include("cus1").SingleOrDefault(o=>o.ID == ID);
                var order = ctx.Orders.Include("orderdetails").SingleOrDefault(o => o.ID == ID);
                if (order != null)
                {
                    order.cus1 = targetOrder.cus1;
                    order.AddOrderDetails(commodityName);
                    ctx.SaveChanges();
                }
            }
        }

        //删除订单明细
        public void DeleteCommodity(int ID,string commodityId)
        {
            using(var ctx = new OrderContext())
            {
                var order = ctx.Orders.Include(o => o.orderdetails.Select(d => d.commodity.commodityID == commodityId)).SingleOrDefault(o => o.ID == ID);
                OrderDetails ord = null;
                foreach(OrderDetails orderDetail in order.orderdetails)
                {
                    if (orderDetail.commodityID == commodityId)
                    {
                        ord = orderDetail;
                        if (ord != null)
                            ctx.OrderDetails.Remove(ord);
                    }
                }
                
            }
        }

    }
}