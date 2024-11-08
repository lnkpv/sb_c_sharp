using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main()
        {
            // Task 1

            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[rows, columns];

            Random rand = new Random();

            int sum = 0;
            Console.WriteLine("\nМатрица A:\n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixA[i, j] = rand.Next(0, 100);
                    Console.Write(matrixA[i, j] + "\t");
                    sum += matrixA[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nСумма матрицы A: " + sum);

            // Task 2

            int[,] matrixB = new int[rows, columns];
            int[,] matrixC = new int[rows, columns];

            Console.WriteLine("\n\nМатрица B:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixB[i, j] = rand.Next(0, 100);
                    Console.Write(matrixB[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nСумма матриц (Матрица C):");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                    Console.Write(matrixC[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
