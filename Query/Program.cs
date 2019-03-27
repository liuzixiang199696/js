using System;

namespace Query
{
    class Program
    {
        static void Main(string[] args)
        {
            //生成一个固定数组
            int[] array =new int[] {1,13,45,78,98,111,133,144,199,210,230 };
            Console.WriteLine("现有数据为1{0},13{1},45{2},78{3},98{4},111{5},133{6},144{7},199{8},210{9},230{10} ");
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
