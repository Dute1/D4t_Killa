using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int i;
            Console.Write("please input a number: ");
            s = Console.ReadLine();
            i = Int32.Parse(s);
            Console.Write("prime factor is: ");
            Fun1(i);
        }
        static void Fun1(int i)
        {
            int j = 2;
            if (i > 1)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0 && IsPrime(j))
                    {
                        Console.Write(j);
                        Console.Write(" ");
                    }
                }

            }
            else Console.WriteLine("wrong!");
        }
        public static Boolean IsPrime(int i)
        {
            int j=2;
            if (i <= 1)
            {
                return false;
            }
            else 
                for (j = 2; j < i; j++) {
                    if (i % j == 0)  break; 
                    
                }
            if (j == i) return true;
            else return false;
    
        }
    }
}
