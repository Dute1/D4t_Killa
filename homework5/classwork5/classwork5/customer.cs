using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork5
{
    class customer
    {
        public string customerName { get; set; }    //顾客名称
        public string customerAddress { get; set; }     //顾客地址
        public customer(string name,string address)
        {
            this.customerName = name;
            this.customerAddress = address;
        }
        public override string ToString()
        {
            return "\n顾客名称:" + customerName + "\n顾客地址:" + customerAddress+"\n\n";
        }

        public override bool Equals(object obj)
        {
            customer cus = obj as customer;
            return cus.customerName == customerName && cus.customerAddress == customerAddress;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
