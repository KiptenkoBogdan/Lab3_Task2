using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int N, M;
            Console.WriteLine("Input number of elements");
            N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];

            Console.WriteLine("Height of employees (cm)");
            for (int i = 0; i < N; i++)
                A[i] = rnd.Next(160, 200);

            foreach (int i in A)
                Console.Write(i + " ");

            Console.WriteLine("\n\nWeight of employees (kg)");
            for (int i = 0; i < N; i++)
                B[i] = rnd.Next(70, 110);

            foreach (int i in B)
                Console.Write(i + " ");

            Array.Sort(A, B);

            Console.Write("\n\nHeight: ");
            foreach (int i in A)
                Console.Write(i + "\t");

            Console.Write("\nWeight: ");
            foreach (int i in B)
                Console.Write(i + "\t");

            Console.ReadKey();
        }
    }
}
