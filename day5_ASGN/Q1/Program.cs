using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enetr total employee number..");

            size = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Employee[] e = new Employee[size];


            for(int i = 0; i< size; i++)
            {
                e[i] = new Employee();
                e[i].empdatils();

            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("All employee details ");
                e[i].Display();
            }
                Console.ReadLine();

            Console.WriteLine("employee with highest salary =>");
            decimal temp= 0;
            for (int i = 0; i < size; i++)
            {

                    if(e[i].Salary > temp)
                    {
                        temp = e[i].Salary;
                      

                    }
                
            }


            Console.WriteLine("highest salary = " + temp);
            Employee details;
            for (int i = 0; i < size; i++)
            {
                details = e[i];
                if(temp == details.Salary)
                {
                    Console.WriteLine();
                    Console.WriteLine("highest salary employee details ===>");
                    Console.WriteLine("Employee number = "+details.Empno);
                    Console.WriteLine("Employee name = "+details.Name);
                    Console.WriteLine("Employee Salary = " + details.Salary);
                }
            }
                Console.ReadLine();

        }
    }

    class Employee
    {
        private string name;
        private decimal salary;
        private int empno;


        public Employee()
        {
           
        }

        public void empdatils()
        {
            Console.WriteLine("Enter emp number...");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter emp name ...");
            name = Console.ReadLine();
            Console.WriteLine("Enter emp salary...");
            salary = Convert.ToDecimal(Console.ReadLine());

        }

        public void Display()
        {
            Console.WriteLine(Empno + "  " + Name + "  " + Salary);
        }

        public string Name
        {
            set
            {
                if(value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("invalide input....please enetr valide");
                }
            }
            get
            {
                return name;
            }
        }

        public decimal Salary
        {
            set {
                value = salary;
            }
            get
            {
                return salary;
            }
        }

        public int Empno
        {

            set
            {
                value = empno;
            }
            get
            {
                return empno;
            }
        }
    }
}
