using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enetr Size of Array");
            size = Convert.ToInt32(Console.ReadLine());

            Employee[] emp = new Employee[size];

            for (int i = 0; i < size; i++)
            {
                emp[i] = new Employee();
                emp[i].empdatils();

            }
            Console.WriteLine("All employee details ");

            for (int i = 0; i < size; i++)
            {
                emp[i].Display();
            }
            Console.ReadLine();

            List<Employee> listEmp = emp.ToList<Employee>();

            foreach(Employee e in listEmp)
            {
                Console.WriteLine("Employee Details in a list ==>" + e.EmpNo + " " + e.Name + " " + e.Salary);
                Console.WriteLine();
            }
        }
    }


    class Employee
    {

        public int EmpNo
        {
            set;
            get;
        }
        public String Name
        {
            set;
            get;
        }
        public Decimal Salary
        {
            set;
            get;
        }



        public Employee()
        {
                
        }

        public void empdatils()
        {
            Console.WriteLine("Enter emp number...");
            EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter emp name ...");
            Name = Console.ReadLine();
            Console.WriteLine("Enter emp salary...");
            Salary = Convert.ToDecimal(Console.ReadLine());

        }

        public void Display()
        {
            Console.WriteLine(EmpNo + "  " + Name + "  " + Salary);
        }

    }
}
