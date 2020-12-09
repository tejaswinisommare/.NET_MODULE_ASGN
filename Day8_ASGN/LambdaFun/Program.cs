using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunction
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee e = new Employee();


            Func<decimal, decimal, decimal, decimal> SI = (P, N, R) => (P * N * R ) / 100;

            Console.WriteLine(SI(20,5,60));

            Console.WriteLine();
            Console.WriteLine();

            Func<int, int,bool> IG = (a,b) => (a > b);
            Console.WriteLine(IG(20,10));

            Console.WriteLine();
            Console.WriteLine();

            Predicate<int> IE = IsEven;
            Console.WriteLine(IE(10));

            Console.WriteLine();
            Console.WriteLine();

            Func<Employee, decimal> BS = e1 => e1.GetBasic(e);
            Console.WriteLine("Basic Salary = " + BS(e));

            Console.WriteLine();
            Console.WriteLine();


            Predicate<Employee> BG = e2 => e2.IsGreaterThan10000(e);
            Console.WriteLine("Is greater = " +BG(e));

            console.ReadLine();


        }
        static decimal SimpleInterest(decimal P, decimal N, decimal R)
        {
            return (P * N * R) / 100;
        }

        static bool IsGreater(int a, int b)
        {
            if (a > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

    }



    class Employee
    {
        public decimal BasicSalary = 20000;



        public decimal GetBasic(Employee e)
        {
            return e.BasicSalary;
        }


        public bool IsGreaterThan10000(Employee e)
        {
            if (e.BasicSalary > 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
