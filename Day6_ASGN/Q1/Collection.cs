using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Dictionary<int, Employee> DicEmployee = new Dictionary<int, Employee>();
            char choice = 'y';
            while(choice == 'y')
            {
                Employee.InsertEmployee(DicEmployee);
                Console.WriteLine("Do you want to continue type (y/n)");
                choice = Convert.ToChar(Console.ReadLine());
            }
            Employee.DisplayHighsalary(DicEmployee);
            Employee.SearchEmployee(DicEmployee);
            Employee.NthSearchEmp(DicEmployee);
            
           

            //foreach (KeyValuePair<int,Employee> KVP in DicEmployee)
            //{
            //    Console.WriteLine("key ={0}", KVP.Key);
            //    Employee emp = KVP.Value;
            //    Console.WriteLine("Empno = {0}, Name={1}, Salary = {2}",emp.Empno,emp.Name,emp.Salary );

            //}
            //Console.ReadKey();
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

        public static void InsertEmployee(Dictionary<int, Employee> DicEmployee)
        {
            Console.WriteLine("Enter emp number...");
            int Empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter emp name ...");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter emp salary...");
            Decimal Salary = Convert.ToDecimal(Console.ReadLine());


        }

       
        public static void DisplayHighsalary(Dictionary<int, Employee> DicEmployee)
        {
            Decimal max = 0;

            foreach(KeyValuePair<int,Employee> KVP in DicEmployee)
            {
                if(KVP.Value.Salary > max)
                {
                    max = KVP.Value.Salary;
                }
            }

            Console.WriteLine("Highest Salary = " + max);


            foreach(KeyValuePair<int,Employee> KVP1 in DicEmployee)
            {
                if(KVP1.Value.Salary == max)
                {
                    Console.WriteLine("highest Salary Employee Details =>"+ KVP1.Key + "  " + KVP1.Value.Empno + " " + KVP1.Value.Name + " " + KVP1.Value.Salary);

                    Console.WriteLine();
                }
            }

        }

        public static void SearchEmployee(Dictionary<int, Employee> DicEmployee)
        {
            int searchNo;
            Console.WriteLine("Enetr number to search Employee details:");

            searchNo = Convert.ToInt32(Console.ReadLine());

            foreach(KeyValuePair<int,Employee> KVP3 in DicEmployee)
            {
                if(KVP3.Value.Empno == searchNo)
                {
                    Console.WriteLine("Employee Details: "+ "  " + KVP3.Value.Empno + " " + KVP3.Value.Name + " " + KVP3.Value.Salary);
                    Console.WriteLine();                
                }
            }

        }

        public static void NthSearchEmp(Dictionary<int, Employee> DicEmployee)
        {
            int searchNth;
            Console.WriteLine("Enetr number to search Employee details:");

            searchNth = Convert.ToInt32(Console.ReadLine());

            int count = 1;

            foreach (KeyValuePair<int, Employee> KVP3 in DicEmployee)
            {
                if (searchNth == count)
                {
                    Console.WriteLine("Employee Details of Last Employee: " + "  " + KVP3.Value.Empno + " " + KVP3.Value.Name + " " + KVP3.Value.Salary);
                }

                count++;
            }


        }

        public string Name
        {
            set
            {
                if (value != null)
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
            set
            {
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
