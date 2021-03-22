using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double x, y, num;
            Console.Write("please input a number: ");
            s = Console.ReadLine();
            x = double.Parse(s);
            Console.Write("please input another number: ");
            s = Console.ReadLine();
            y = double.Parse(s);
            Console.Write("choose your operation(1.+ 2.- 3.× 4.÷): ");
            s = Console.ReadLine();
            switch(s)
            {
                
                case "1":
                    num = x + y;
                    break;
                case "2":
                    num = x - y;
                    break;
                case "3":
                    num = x * y;
                    break;
                case "4":
                    num = x/y;
                    break;
                default:
                    Console.WriteLine("please input the right num！");
                    return;
            }

            Console.Write("calculation results is: ");
            Console.WriteLine($"{num}");
            
        }
        

        
    }
}
