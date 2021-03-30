using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] salesCount = {};
           int salesCheck = 0;
           
           int salary = 200;

           Console.WriteLine("Lets check out your earning range base on sales: \n");
           for (int i = 0; i < 10; i++)
           {
              while(true)
              {
                    try
                    {
                        Console.Write("Enter your sales amount:\n");
                    int sales = int.Parse(Console.ReadLine());
                    
                    if(sales > 0)
                    {
                        salesCheck = (sales * (int)0.09) + salary;
                        ++salesCount[salesCheck];
                    break;
                    }else{
                    Console.Write("Enter a  valid number");
                    }
                    }
                    catch (Exception e)
                    {
                        
                       Console.Write(e.Message);
                    }

                } 
           }

           Console.WriteLine("Range\tFrequency\n");

            for (int i = 1; i < salesCount.Length; i++)
            {
                Console.Write($"{i}: ");
                for (int k = 0; k < (int)salesCount[i]; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
