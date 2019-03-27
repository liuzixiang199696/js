using System;

namespace text
{
    class Program
    {
        private static int t;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //创建一个数组
            int[] a = { 7, 1, 8, 9, 4, 1, 2, 6, 5 };
            for (int i = 0; i < a.Length; i++)
            {
                //数组的遍历
                Console.WriteLine("第{0}个数组中的数字为{1}", i + 1, a[i]);
            }
            //求最大值
            int max = a[0];
            for (int z = 0; z < a.Length; z++)
            {
                //把最大值赋值给max
                if (max < a[z])
                {
                    max = a[z];
                }
            }
            Console.WriteLine("最大值为:{0}", max);
            int q = 10;
            int w = 20;
            Console.WriteLine(q - w);
            Console.WriteLine(q + w);
            Console.WriteLine(q * w);
            Console.WriteLine(q / w);
            double e = 10.1;
            double r = 5.5;
            Console.WriteLine(e + r);
            Console.WriteLine(e - r);
            Console.WriteLine(e * r);
            Console.WriteLine(e / r);


        }
    }
}