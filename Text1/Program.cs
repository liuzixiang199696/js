using System;

namespace Text1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //seek();
            peison pr = new peison(19,"zixiang");
            Console.WriteLine(pr);
            int SUM=MySum(5, 8);
            Console.WriteLine(SUM);
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
}
