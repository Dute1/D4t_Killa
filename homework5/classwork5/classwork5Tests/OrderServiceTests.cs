using Microsoft.VisualStudio.TestTools.UnitTesting;
using classwork5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderService = new OrderService();
        [TestInitialize]
        public void Initialize()
        {
            customer customer = new customer(杜特,武汉大学);
            commodity commodity = new commodity(ipad2020,25,2998);
            OrderDetails orderDetails = new OrderDetails(customer,commodity);
            Order ord = new Order();
            ord.orderdetails.Add(orderDetails);
            orderService.orders.Add(ord);
        }
        [TestMethod()]
        public void AddorderTest()
        {
            customer customer = new customer(杜特,武汉大学);
            commodity commodity = new commodity(ipad2020,25,2998);
            OrderDetails orderDetails = new OrderDetails(customer,commodity);
            Order ord = new Order();
            ord.orderdetails.Add(orderDetails);
            orderService.orders.Add(ord);
            
            customer customer2 = new customer(肖宇航,武汉大学);
            commodity commodity2 = new commodity(足球,305,98);
            OrderDetails orderDetails2 = new OrderDetails(customer2,commodity2);
            Order ord2 = new Order();
            ord2.orderdetails.Add(orderDetails2);
            orderService.orders.Add(ord2);

            Assert.IsTrue(count == 2);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            customer customer = new customer(杜特,武汉大学);
            commodity commodity = new commodity(ipad2020,25,2998);
            OrderDetails orderDetails = new OrderDetails(customer,commodity);
            Order ord = new Order();
            ord.orderdetails.Add(orderDetails);
            orderService.orders.Add(ord);
            
            customer customer2 = new customer(肖宇航,武汉大学);
            commodity commodity2 = new commodity(足球,305,98);
            OrderDetails orderDetails2 = new OrderDetails(customer2,commodity2);
            Order ord2 = new Order();
            ord2.orderdetails.Add(orderDetails2);
            orderService.orders.Add(ord2);

            orderService.orders.Remove(orderService[count-1]);
            Assert.isTrue(count == 1);
        }

        [TestMethod()]
        public void FindTest()
        {
            customer customer = new customer(杜特,武汉大学);
            commodity commodity = new commodity(ipad2020,25,2998);
            OrderDetails orderDetails = new OrderDetails(customer,commodity);
            Order ord = new Order();
            ord.orderdetails.Add(orderDetails);
            orderService.orders.Add(ord);

            Assert.IsTrue(ord.orderdetails[0].customer=="杜特");
        }

        [TestMethod()]
        public void modifyTest()
        {
            Assert.Fail();
        }

        /*[TestMethod()]
        public void ExportTest()
        {
            Assert.Fail();
        }*/

        /*[TestMethod()]
        public void ImportTest()
        {
            Assert.Fail();
        }*/
    }
}