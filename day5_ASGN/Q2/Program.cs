using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr number of batches==>");
            int batch = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[batch][];

            for(int i=0; i<batch; i++)
            {
                Console.WriteLine("enetr number of students=>");
                int batchsize = Convert.ToInt32(Console.ReadLine());

                arr[i] = new int[batchsize];
               
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("enter marks for students [{0}][{1}] : ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("students marks {0},{1} is {2}  ", i, j, arr[i][j]);

                }
            }
            Console.ReadLine();
        

    }
    }
}








   