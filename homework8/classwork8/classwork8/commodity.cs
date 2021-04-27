using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork8
{
    abstract class commodity
    {

        public commodity() { }
        public string commodityID { get; set; }  //货号
        public string commodityName { get; set; }   //商品名称
        public double price { get; set; } //商品单价

        public commodity(string name, double price)
        {
            this.commodityName = name;
            this.price = price;
        }

        public override string ToString()
        {
            return "货号:" + commodityID + "\n商品名称:" + commodityName + "\n商品单价:" + price;
            //Console.WriteLine("订单号:" + commodityID + " 商品名称:" + commodityName + " 商品价格:" + price);
        }

        /*public override bool Equals(object obj)
        {
            commodity com = obj as commodity;
            return com.commodityID == commodityID;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }*/

        public static commodity createNewCommodity(string name)
        {
            switch (name)
            {
                case "苹果": return new Apple();
                case "软件构造基础": return new Book();
                case "特仑苏": return new Milk();
                case "台灯": return new Lamp();
                default: return null;
            }
        }
    }

        class Apple:commodity
        {
            public Apple()
            {
                this.commodityName = "苹果";
                this.price = 3;
                this.commodityID = "001";
            }
        }

        class Book:commodity
        {
            public Book()
            {
                this.commodityName = "软件构造基础";
                this.price = 39.8;
                this.commodityID = "002";
            }
        }

        class Milk:commodity
        {
            public Milk()
            {
                this.commodityName = "特仑苏";
                this.price = 5;
                this.commodityID = "003";
            }
        }

        class Lamp:commodity
        {
            public Lamp()
            {
                this.commodityName = "台灯";
                this.price = 16.5;
                this.commodityID = "004";
            }
        }

        
}
