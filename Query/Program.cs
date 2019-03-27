using System;

namespace Query
{
    class Program
    {
        static void Main(string[] args)
        {
            //生成一个固定数组
            // int[] array =new int[] {1,13,45,78,98,111,133,144,199,210,230 };
            int Length = 10;
            int[] array = new int[Length];
            array[0] = new Random().Next(15, 500);
           
            for (int i = 0; i <Length-1; i++)
            {
                array[i+1] = array[i] + new Random().Next(15,500); 
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"现有数据为:{array[i]}"+"      ");
            }
           
            Console.WriteLine("请输入您要查询的数字:");
            //index  = 数组的最大位数，
            int index = array.Length - 1;
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {    
                // steps = 数组中间角标值，
                int steps = (index+1)/2;
                /*若一次猜中， input = array[index]，结束，break，
                 若猜测得数大于中间数， index += steps ====  index = index + steps ;
                 若猜测得数小于中间数， index -= steps ====  index = index - steps ;
                 */
                if (input == array[index])//    取最大值10.230

                {
                    Console.WriteLine("找到了" + array[index]);
                    break;
                }
                else {
                    Console.WriteLine($"第{i+1}查找，取第{index},值为{array[index]}");
                    if (input > array[index])
                    {
                        index = steps + index;
                    }
                    else {
                        index = index -  steps;

                    }
                }





            }

        }
    }
}
