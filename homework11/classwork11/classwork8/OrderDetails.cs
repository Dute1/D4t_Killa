using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace classwork8
{
    //订单明细:货物，顾客，货物数量
    public class OrderDetails
    {
        /*public string commodityID { get; set; }  //货号
        public string commodityName { get; set; }   //商品名称
        public double price { get; set; } //商品单价 */
        //public string customerName { get; set; }    //顾客名称
        //public string customerAddress { get; set; }     //顾客地址
           
        //public int amount = 1;   //货物数量    

        public string commodityID{get;set;}
        public string commodityName { get; set; }  //货物
        public double commodityPrice{get;set;}

        public commodity commodity { get; set; }

        public OrderDetails(string name)
        {
            commodity = commodity.createNewCommodity(name);
            if (commodity == null)
                return;
            commodityID = commodity.commodityID;
            commodityName = name;
            commodityPrice = commodity.price;
        }

        public OrderDetails() { }

        public override string ToString()
        {
            return "商品ID:" + commodityID + "\n" + commodityName; //+"\n货物数量:" + amount;
        }

        public override bool Equals(object obj)
        {
            OrderDetails orderDetails = obj as OrderDetails;
            return(this.commodityID == orderDetails.commodityID);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
