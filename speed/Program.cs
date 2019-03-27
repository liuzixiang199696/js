using System;

namespace speed
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

