using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 5, 6 }, { 3, 1, 2, 5 }, { 4, 3, 1, 2 }, { 4, 4, 3, 1 } };
            for(int i =1;i < 4;i++)
            {
                for(int j = 1; j < 4;j++)
                {
                    if (a[i, j] != a[i - 1, j - 1])
                    {
                        Console.WriteLine("不是托普利茨矩阵");
                        return;
                    }
                }
            }
            Console.WriteLine("是托普利茨矩阵");
            return;
        }
    }
}
