﻿using System;

namespace maopao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 1, 8, 9, 4, 1, 2, 6, 5 };
            Mysort mysort =new Mysort();
            mysort.Lzx(a);
            for (int v = 0; v < a.Length; v++)
            {
                Console.WriteLine("第{0}个数字为{1}", v + 1, a[v]);
            }
        }
    }
    public class Mysort
    {
        public  void Lzx(int[] a)
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


    }
}


