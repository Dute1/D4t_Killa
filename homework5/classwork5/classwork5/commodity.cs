using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork5
{
    public class commodity
    {
        public string commodityID { get; set; }  //货号
        public string commodityName { get; set; }   //商品名称
        public double price { get; set; } //商品单价

        public commodity(string name, string id, double price)
        {
            this.commodityName = name;
            this.commodityID = id;
            this.price = price;
        }
        public commodity() { }

        public override string ToString()
        {
            return "货号:" + commodityID + "\n商品名称:" + commodityName + "\n商品单价:" + price;
            //Console.WriteLine("订单号:" + commodityID + " 商品名称:" + commodityName + " 商品价格:" + price);
        }

        public override bool Equals(object obj)
        {
            commodity com = obj as commodity;
            return com.commodityID == commodityID;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
