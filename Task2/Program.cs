using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] data = {7.55, 2.43, 5.00};
            Console.Write(AddThis(data));
        }

        static double AddThis(double[] arr)
        {
            int i=0;
            double sumUp = 0;
            foreach (double num in arr)
            {
                sumUp = sumUp + arr[i];
                i++;
            }
            return sumUp;
        }
    }
}
