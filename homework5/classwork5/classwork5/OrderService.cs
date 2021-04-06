                                                                                                                                                                                                                                              
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace classwork5
{
    //订单服务需要实现的功能:1.添加订单 2.删除订单 3.查询订单(按订单总金额排序)
    class OrderService
    {
        public static int count = 0;
        public OrderService() { }
        public List<Order> orders = new List<Order>();   //创建一个含有多个订单的表

        /*       //用一个布偶函数用来寻找订单号
               public bool FindOrderId(int n)
               {
                   foreach (Order order in orders)    
                   {
                       if (order.Id == n) return true; 
                   }
                   return false;
               }
               */

        //添加订单
        public void Addorder()
        {

            Console.WriteLine("****正在进行添加订单服务****");

            bool a = true;
            while (a)
            {
                Order neworder = new Order();  //创建一个新的订单
                Console.Clear();
                Console.WriteLine("请输入您的名称:");
                string customerName = Console.ReadLine();
                Console.WriteLine("请输入您的住址:");
                string customerAddress = Console.ReadLine();
                customer cus = new customer(customerName, customerAddress);
                Console.WriteLine("==请输入商品的相关信息==");
                Console.Write("1.货号:");
                string commodityId = Console.ReadLine();
                Console.Write("2.商品名称:");
                string commodityName = Console.ReadLine();
                Console.Write("3.商品单价:");
                string commodityPrice = Console.ReadLine();
                int n = int.Parse(commodityPrice);
                commodity com = new commodity(commodityName, commodityId, n);

                //将上述信息添加到新的订单中
                OrderDetails ord = new OrderDetails(cus, com);
                neworder.orderdetails.Add(ord);
                orders.Add(neworder);
                count++;
                Console.WriteLine("已经成功创建一个订单并添加一个订单明细！\n\n");
                

                //向订单中继续添加订单明细
                bool flag2 = true;
                while (flag2)
                {
                    Console.WriteLine("是否继续向该订单中添加订单明细？(1.添加 2.退出)");
                    int x1 = int.Parse(Console.ReadLine());
                    if (x1 == 1)
                    {
                        Console.WriteLine("请输入您的名称:");
                        string customerName2 = Console.ReadLine();
                        Console.WriteLine("请输入您的住址:");
                        string customerAddress2 = Console.ReadLine();
                        customer cus2 = new customer(customerName2, customerAddress2);
                        Console.WriteLine("==请输入商品的相关信息==");
                        Console.Write("1.货号:");
                        string commodityId2 = Console.ReadLine();
                        Console.Write("2.商品名称:");
                        string commodityName2 = Console.ReadLine();
                        Console.Write("3.商品单价:");
                        string commodityPrice2 = Console.ReadLine();
                        int n2 = int.Parse(commodityPrice2);
                        commodity com2 = new commodity(commodityName2, commodityId2, n2);

                        OrderDetails ord2 = new OrderDetails(cus2, com2);
                        neworder.orderdetails.Add(ord2);
                    }
                    else if (x1 == 2)
                    {
                        Console.WriteLine("退出中...");
                        Thread.Sleep(1000);
                        flag2 = false;
                    }
                    else
                    {
                        flag2 = true;
                        Console.WriteLine("请输入1或者2选择你的操作！");
                    }
                }

                neworder.Id = count;

                Console.WriteLine("全部添加已完成！(订单号为" + orders.Count() + ") 是否继续添加订单?(1.继续 2.退出)");
                int x = int.Parse(Console.ReadLine());
                if (x == 1) a = true;
                else a = false;
            }

            Console.WriteLine("全部订单已经添加完毕！将在三秒后返回界面...");
            Thread.Sleep(3000);
            Console.Clear();
        }


        //删除订单
        public void Delete()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("请输入你要删除的订单号:");
                int n = int.Parse(Console.ReadLine());
                if (orders[n - 1] == null) Console.WriteLine("没有该订单！无法删除");
                else
                {
                    orders.Remove(orders[n - 1]);
                    Console.WriteLine("该订单已经删除,是否继续删除订单？(1.继续 2.退出)");
                    int x = int.Parse(Console.ReadLine());
                    if (n == 1) flag = true;
                    else flag = false;
                }
            }
            Console.WriteLine("订单已经删除完毕!将在三秒后返回界面...");
            Thread.Sleep(3000);
            Console.Clear();
        }



        //查询订单
        public void Find()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("请选择你要使用的查询方式(1.按订单号查询 2.按客户名称查询):");
                int y = int.Parse(Console.ReadLine());
                if (y == 1)
                {
                    Console.WriteLine("请输入你要查询的订单号:");
                    int m = int.Parse(Console.ReadLine());
                    var s = from n in orders
                            where n.Id == m
                            select n;
                    List<Order> selectorders = s.ToList<Order>();
                    if (selectorders.Count() != 0)
                    {
                        Console.WriteLine("已查询到您的订单！");
                        Console.WriteLine("订单号为" + m + "的订单明细如下:");
                        foreach (Order ord in selectorders)
                        {
                            Console.WriteLine(ord.ToString());
                        }
                    }
                    else Console.WriteLine("未查询到您的订单！");
                    /*if (flag == true)
                    {
                        Console.WriteLine("已查询到您的订单！");
                        Console.WriteLine("订单号为" + n + "的订单明细如下:");
                        Console.WriteLine(orders[n-1].ToString());
                    }
                    else
                        Console.WriteLine("未查询到你的订单！");



                }*/
                    Console.WriteLine("是否要继续查询订单？(1.继续 2.退出)");

                    int x = int.Parse(Console.ReadLine());
                    if (x == 1) flag = true;
                    else flag = false;

                }

                //按客户名称查询
                if (y == 2)
                {
                    Console.WriteLine("请输入你要查询的客户的名称:");
                    string cusName = Console.ReadLine();
                    var s = from n in orders
                            where n.selectCustomerName(cusName)
                            select n;
                    List<Order> selectorders = s.ToList<Order>();
                    if (selectorders.Count() != 0)
                    {
                        Console.WriteLine("已查询到您的订单！");
                        Console.WriteLine("客户名称为"+ cusName + "的订单明细如下:");
                        foreach (Order ord in selectorders)
                        {
                            Console.WriteLine(ord.ToString());
                        }
                    }
                    else Console.WriteLine("未查询到您的订单！");

                    Console.WriteLine("是否要继续查询订单？(1.继续 2.退出)");

                    int x = int.Parse(Console.ReadLine());
                    if (x == 1) flag = true;
                    else flag = false;
                }
            }
            Console.WriteLine("查询结束！将在三秒后返回界面...");
            Thread.Sleep(3000);
            Console.Clear();

        }


        //修改订单
        public void modify()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("请输入你要修改的订单的订单号:");
                int n = int.Parse(Console.ReadLine());
                if (orders[n - 1] == null) Console.WriteLine("没有该订单！无法修改");
                else Console.WriteLine("请输入你要修改的内容(1.客户名称 2.客户住址):");
                int m = int.Parse(Console.ReadLine());
                if(m == 1)
                {
                    Console.WriteLine("请输入客户的名称:");
                    string cusName = Console.ReadLine();
                    var s = from x in orders
                            where x.selectCustomerName(cusName)
                            select x;
                    List<Order> selectorders = s.ToList<Order>();
                    Console.WriteLine("请输入修改后的客户名称:");
                    string cusName2 = Console.ReadLine();
                    if (selectorders != null)
                    {
                        foreach(Order ord in selectorders)
                        {
                            foreach (OrderDetails ordDetail in ord.orderdetails)
                            {
                                if (ordDetail.customer.customerName != null) ordDetail.customer.customerName = cusName2;
                            }
                        }
                        Console.WriteLine("修改成功!一秒之后返回...");
                        Thread.Sleep(1000);
                    }
                    else Console.WriteLine("没有含有该客户名称的订单！");

                }
                else if (m == 2)
                {
                    Console.WriteLine("请输入客户的住址:");
                    string cusAddress = Console.ReadLine();
                    var s = from x in orders
                            where x.selectCustomerAddress(cusAddress)
                            select x;
                    List<Order> selectorders = s.ToList<Order>();
                    Console.WriteLine("请输入修改后的客户住址:");
                    string cusAddress2 = Console.ReadLine();
                    if (selectorders != null)
                    {
                        foreach (Order ord in selectorders)
                        {
                            foreach (OrderDetails ordDetail in ord.orderdetails)
                            {
                                if (ordDetail.customer.customerAddress != null) ordDetail.customer.customerAddress = cusAddress2;
                            }
                        }
                        Console.WriteLine("修改成功！一秒之后返回...");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("没有含有该客户地址的订单！一秒之后返回");        
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    Console.WriteLine("是否要继续修改？(1.修改 2.退出)");
                    int m1 = int.Parse(Console.ReadLine());

                    bool flag2 = true;
                    while (flag2)
                    {
                        if (m1 == 1) {
                            flag2 = false;
                            flag = true; }
                        else if (m1 == 2) {
                            flag2 = false;
                            flag = false; }
                        else
                        {
                            Console.WriteLine("请选择正确的修改方式！");
                            flag2 = true;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("请输入正确的修改方式！");
                    flag = false;
                }
                Console.WriteLine("是否要继续修改？(1.继续 2.退出)");
                int p = int.Parse(Console.ReadLine());
                bool flag3 = true;
                while (flag3)
                {
                    if (p == 1)
                    {
                        flag3 = false;
                        flag = true;
                    }
                    else if (p == 2)
                    {
                        flag3 = false;
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("请输入1或者2表示你下一步的选择！");
                    }

                }
            }
            
        }
    }
}