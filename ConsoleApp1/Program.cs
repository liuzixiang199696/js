using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] arrays = new int[9,9];
            //for (int i = 0; i < 9; i++)
            //{
            //    Console.WriteLine("  ");
            //    for (int j = 0; j < 9; j++)
            //    {
            //        arrays[i, j] = i + j;
            //        Console.Write(arrays[i,j]);
            //    }
            //}
            int c = 1;
            int Length = 10;//指定数组长度。
            int[] array = new int[Length];
            array[0] = new Random().Next(15, 500);//初始值随机。
            //每次数组值增加随机。
            for (int i = 0; i < Length - 1; i++)
            {

                array[i + 1] = array[i] + new Random().Next(10, 5000);
            }
            //打印查看。
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"现有数据为:{array[i]}" + "      ");

            }
            Console.WriteLine("请输入您要查询的数字:");
            int index = array.Length - 1;//右边界
            int input = Convert.ToInt32(Console.ReadLine());
            int min = 0;
            while (min<=index)
            {
                int steps = (index + 1) / 2;
                if (input == array[index])
                {
                    Console.Write($"第{c}查找，取第{index}位,值为{array[index]}");
                    Console.WriteLine("找到了" + array[index]);
                    c++;
                    break;
                }
                else if (input < array[index])
                {
                    
                    Console.WriteLine($"第{c}查找，取第{index}位,值为{array[index]}");
                    index = index - steps;
                    c++;
                }
                else {
                    Console.WriteLine($"第{c}查找，取第{index},值为{array[index]}");
                    index = steps + index;
                    c++;
                }



            }


        }
    }
}
