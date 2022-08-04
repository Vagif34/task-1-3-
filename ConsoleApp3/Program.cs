using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();
           //int Min =int.Parse(Console.ReadLine());

            
        }
        static int Min(int[] arr )
        {
            //int[] arr = { 4, 3, 2, 5, 6 };
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                {
                    if (min < arr[0])

                    
                        min = arr[i];
                    
                }
            }
            return min;
            Console.WriteLine(min);
          





        }
    }
}
