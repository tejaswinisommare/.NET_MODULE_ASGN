using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3ToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EList = new List<Employee>();
            EList.Add(new Employee {EmpNo = 1,Ename = "Teju", Salary =600000});
            EList.Add(new Employee { EmpNo = 2, Ename = "Pooja", Salary = 800000 });

            Object[] arr = EList.ToArray<Employee>();

            foreach(Employee e in arr)
            {
                Console.WriteLine("Emloyee list =" + e.EmpNo + " "  + e.Ename + " " + e.Salary);
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
        public String Ename
        {
            set;
            get;
        }
        public Decimal Salary
        {
            set;
            get;
        }
    }
}
