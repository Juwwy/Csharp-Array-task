using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArr = {7, 8, 2};
            Console.WriteLine(Product(newArr));
        }

        static int Product(int[] arr)
        {
           int product = 1;
            for(int i=0; i < arr.Length; i++)
            {
                product = product * arr[i];
            }
            return product;
        }
    }
}
