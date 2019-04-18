using System;

namespace Text1
{
    class Program
    {
        static void Main(string[] args)
        {
            Judgment();

            //Console.WriteLine("Hello World!");
            //seek();
            //peison pr = new peison(19,"zixiang");
            //Console.WriteLine(pr);
            //int SUM=MySum(5, 8);
            //Console.WriteLine(SUM);
            //Books book1 = new Books();
            //Books book2 = new Books();
            //book1.getBooks("china","zx","English",1);
            //book2.getBooks("chinaa", "zxx", "Englishh", 2);
            //book1.getcw();
            //book2.getcw();
            //DayOfWeek d = DayOfWeek.Sunday;
            //switch (d)
            //{
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("5");
            //        break;
            //    case DayOfWeek.Monday:
            //        Console.WriteLine("1");
            //        break;
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("3");
            //        break;
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("7");
            //        break;
            //    case DayOfWeek.Thursday:
            //        Console.WriteLine("4");
            //        break;
            //    case DayOfWeek.Tuesday: 
            //        Console.WriteLine("2");
            //        break;
            //    case DayOfWeek.Wednesday:
            //        Console.WriteLine("6");
            //        break;
            //    default:
            //        break;
            //}
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
