using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            Console.WriteLine("*****欢迎使用订单管理系统*****");
            
            while(true)
            {
                Console.WriteLine("*****请选择你要使用的功能*****");
                Console.WriteLine("*        1.添加订单          *");
                Console.WriteLine("*        2.删除订单          *");
                Console.WriteLine("*        3.查询订单          *");
                Console.WriteLine("*        4.修改订单          *");
                Console.WriteLine("*        5.导出订单          *");
                Console.WriteLine("*        6.导入订单          *");
                Console.WriteLine("******************************");
                string use = Console.ReadLine();
                int n = int.Parse(use);
                switch(n)
                {
                    case 1:
                        os.Addorder();
                        break;
                    case 2:
                        os.Delete();
                        break;
                    case 3:
                        os.Find();
                        break;
                    case 4:
                        os.modify();
                        break;
                    case 5:
                        os.Export();
                        break;
                    case 6:
                        os.Import();
                        break;
                }


                
            }
        
        }
    }
}
