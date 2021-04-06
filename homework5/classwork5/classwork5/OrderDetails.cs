using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork5
{
    //订单明细:货物，顾客，货物数量
    class OrderDetails
    {
        /*public string commodityID { get; set; }  //货号
        public string commodityName { get; set; }   //商品名称
        public double price { get; set; } //商品单价 */
        //public string customerName { get; set; }    //顾客名称
        //public string customerAddress { get; set; }     //顾客地址
           
        //public int amount = 1;   //货物数量    

        public customer customer; 
        public commodity commodity;  //货物
        public OrderDetails(customer cus,commodity com)
        {
            this.customer = cus;
            this.commodity = com;
        }
        public override string ToString()
        {
            return commodity.ToString() + customer.ToString();  //+"\n货物数量:" + amount;
        }
    }
}
