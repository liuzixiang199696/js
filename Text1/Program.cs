using System;

namespace Text1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 45, 36, 18, 53, 72, 30, 48, 93, 15, 36 };

            Sort.quickSort(myArray, 0, myArray.Length - 1);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

        }
        static void seek()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            Console.WriteLine(c);
          
           
            //int[] array = { 1, 2, 3, 4, 3 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("{0},{1}", i + 1, array[i]);
            //}


        }
        static int MySum(int x, int y) {
            int sum;
            sum = x + y;
            return sum;
        }
        struct Books {
            public String Title;
            public String Author;
            public String subject;
            public int book_id;
            public void getBooks (String p1, String p2, String p3, int p4)
            {
                Title = p1;
                Author = p2;
                subject = p3;
                book_id = p4;
            }
            public void getcw() {
               Console.WriteLine("Book {1} title : {0}", Title, book_id);
               Console.WriteLine("Book {1} author : {0}", Author, book_id);
               Console.WriteLine("Book {1} subject : {0}", subject, book_id);
               Console.WriteLine("Book {1} book_id :{0}", book_id, book_id);

            }
        }
        static void Judgment() {
          int input = int.Parse( Console.ReadLine());
            if (input>90)
            {
                Console.WriteLine(1);
                return;
            }
            if (input>80) {
                Console.WriteLine(2);
                return;
            }
            if (input > 70)
            {
                Console.WriteLine(3);
                return;
            }
            else {
                Console.WriteLine(4);
            }
                    

        }
        static void text() {
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
        static void Query()
            {
            //生成一个固定数组
            // int[] array =new int[] {1,13,45,78,98,111,133,144,199,210,230 };
            //更新： 生成了一个完全随机且有序数组，（初始值也随机）。
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
            //index  = 数组的最大位数，
            int index = array.Length - 1;//右边界
            int input = Convert.ToInt32(Console.ReadLine());







            for (int i = 0; i < array.Length; i++)
            {
                // steps = 数组中间角标值，
                int steps = (index + 1) / 2;
                /*若一次猜中， input = array[index]，结束，break，
                 若猜测得数大于中间数， index += steps ====  index = index + steps ;
                 若猜测得数小于中间数， index -= steps ====  index = index - steps ;
                 */
                while (input == array[index])
                {
                    Console.WriteLine("找到了" + array[index]);
                    Console.WriteLine($"第{i + 1}查找，取第{index},值为{array[index]}");
                    while (input > array[index])
                    {
                        index = steps + index;
                    }
                    while (input < array[index])
                    {
                        index = index - steps;
                    }
                }
                //Console.WriteLine($"第{i + 1}查找，取第{index},值为{array[index]}");
                //while (input > array[index])
                //{
                //    index = steps + index;
                //}
                //while (input < array[index])
                //{
                //    index = index - steps;
                //}
            }

        }
        static void maopao(int[] a)
        {
            for (int w = 0; w < a.Length - 1; w++)
            {

                //内循环，冒泡排序，
                for (int i = 0; i < a.Length - 1 - w; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        //赋值
                        int c;
                        c = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = c;

                    }
                }
            }

        }
        static void Guess() {
            int max = 1000;
            int random = new Random().Next(max);
            for (int i = 0; i < 10; i++)

            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("您还有{0}次机会输入", 10 - i);
                Console.WriteLine($"请输入你要猜的数字{max}以内");

                int number = Convert.ToInt32(Console.ReadLine());
                //int num = convert.ToInt32(Console.RedLine()）；
                // num = Console.Read();只能输入一个字符。
                if (number > random)
                {
                    Console.WriteLine("您猜大了！");
                }
                if (number < random)
                {
                    Console.WriteLine("您猜小了！");
                }
                if (number == random)
                {
                    Console.WriteLine("您猜中了！");
                    break;
                }
                Console.WriteLine("正确数字是" + random);
            }
        }
        static void Console() {

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
            Qurey qurey = new Qurey();
            qurey.lzx(array);
        }

    }
    
    class peison {
        public int age;
        public string name;
        //public peison() {
        //    this.age = 18;
        //    this.name="子祥";
        //    Console.WriteLine(age+name);
        //}
        public peison(int age, string name) {
            this.age = age;
            this.name = name;
            Console.WriteLine(age);
            Console.WriteLine(name);
        }

    }
    class Sort
    {
        public static void quickSort(int[] list, int left, int right)
        {
            if (left > right)
            {
                return;
            }
            int i, j, key;
            i = left;
            j = right;
            key = list[left];
            while (i != j)
            {
                while (list[j] >= key && i < j)
                {
                    j--;
                }
                while (list[i] <= key && i < j)
                {
                    i++;
                }
                if (i < j)
                {
                    int t = list[i];
                    list[i] = list[j];
                    list[j] = t;
                }
            }
            list[left] = list[i];
            list[i] = key;
            quickSort(list, left, i - 1);
            quickSort(list, i + 1, right);

        }


    }

}