using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            int[]a= new int[] { 1, 5, 4, 6, 8, 3, 11, 9 };
            for(int i = 0; i <8; i++)
            {
                intlist.Add(a[i]);
            }
            int max = intlist.Head.Data, min = intlist.Head.Data, sum = 0;
            Action<int> getMax = x => { if (x > max) max = x; };
            Action<int> getMin = x => { if (x < min) min = x; };
            Action<int> getSum = x => { sum += x; };
            Console.Write("链表元素为:");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("链表遍历中...");
            intlist.ForEach(getMax);
            Console.WriteLine("链表中的最大值为:" + max);
            intlist.ForEach(getMin);
            Console.WriteLine("链表中的最小值为:" + min);
            intlist.ForEach(getSum);
            Console.WriteLine("链表中元素的和为:" + sum);
            Console.WriteLine("链表遍历结束.");
            Console.ReadLine();

        }
    }
}
