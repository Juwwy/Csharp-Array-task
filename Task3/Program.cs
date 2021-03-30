using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Matrix());
            int rowNum, colNum;
            int[,] firstMatrix = new int[20, 20];
            int[,] secondMatrix = new int[20, 20];
            int[,] sumOfMatrix = new int[20, 20];



            Console.Write("Enter a number of row: ");
            rowNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number for column: ");
            colNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter element of first matrix below:\n ");
            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Please enter element of second matrix below: \n");
            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Sum of given matrixes: \n");
            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    sumOfMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                    Console.Write(sumOfMatrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

        // static int Matrix()
        // {
           

        //     return sumOfMatrix;

        // }
    }
}
