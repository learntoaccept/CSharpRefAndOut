using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //------------------------------------
            float avg;//在使用out关键字时，不需要在此处初始化，初始化也不会影响到方法内部的值，所以你初始化没用//在使用ref关键字时，不需要在此处初始化
            int max;
            int min;
            int sum = GetIntResult(arr, out avg, out max, out min);
            Console.WriteLine("和：{0}\t平均值：{1}\t最大值：{2}\t最小值：{3}", sum, avg, max, min);
            //------------------------------------
            float avgref = 0.0f;//在使用ref关键字时，需要在此处初始化
            int maxref = 0;
            int minref = 0;
            int sumref = GetIntResultRef(arr, ref avgref, ref maxref, ref minref);
            Console.WriteLine("和：{0}\t平均值：{1}\t最大值：{2}\t最小值：{3}", sumref, avgref, maxref, minref);
            Console.Read();
        }
        static int GetIntResult(int[] arry, out float avg, out int max, out int min)
        {
            int sum = 0;
            max = arry[0];
            min = arry[0];//使用out关键字时，必须在离开方法前对out关键字修饰的参数初始化
            for (int i = 0; i < arry.Length; i++)
            {
                sum += arry[i];

                if (max < arry[i])
                {
                    max = arry[i];
                }
                if (min > arry[i])
                {
                    min = arry[i];
                }
            }
            avg = sum / arry.Length;
            return sum;
        }
        static int GetIntResultRef(int[] arry, ref float avg, ref int max, ref int min)
        {
            int sum = 0;
            max = arry[0];
            min = arry[0];
            for (int i = 0; i < arry.Length; i++)
            {
                sum += arry[i];

                if (max < arry[i])
                {
                    max = arry[i];
                }
                if (min > arry[i])
                {
                    min = arry[i];
                }
            }
            avg = sum / arry.Length;
            return sum;
        }
    }
}
