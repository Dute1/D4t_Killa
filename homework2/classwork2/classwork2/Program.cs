using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1;
            a1 = new int[] { 3, 6, 2, 5, 14, 8, 9, 13, 1 };
            MaxMinAdvSum(a1);
            Console.ReadLine();
        }

        static void MaxMinAdvSum(int[] a)
        {
            int max = a[0],min = a[0],sum=0,adv=0;
            for(int i=0;i <= 8; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            Console.WriteLine("数组中的最大值为:"+max);

            for (int i = 0; i <= 8; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            Console.WriteLine("数组中的最小值为:" + min);

            for(int i = 0; i <= 8; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("数组中数据的和为:" + sum);

            adv = sum / 8;
            Console.WriteLine("数组中数据的平均数为:" + adv);
        }
    }
}
