using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("2到100内的素数为:");
            PrimeNum();
        }

        static void PrimeNum()
        {
            int []a1= new int[101];
            for(int i=2;i<=100;i++)
            {
                a1[i] = 1;
            }
            for(int i = 2; i <= 100; i++)
            {
                if (a1[i] == 1)
                {
                    Console.Write(i+" ");
                    
                }
                for (int j = 2; j * i <= 100; j++)
                    a1[j * i] = 0;
            }
        }
    }
}
