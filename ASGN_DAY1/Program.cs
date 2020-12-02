using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASGN1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Employee o1 = new Employee("Teju", 123465, 10);
            Employee o2 = new Employee("Teju", 123465);
            Employee o3 = new Employee("Teju");
            Employee o4 = new Employee();


            Console.WriteLine();
            Console.WriteLine(o1.EMPNO);
            Console.WriteLine(o1.GetNetSalary());
            Console.WriteLine();
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o2.GetNetSalary());
            Console.WriteLine();
            Console.WriteLine(o3.EMPNO);
            Console.WriteLine(o3.GetNetSalary());
            Console.WriteLine();
            Console.WriteLine(o4.EMPNO);
            Console.WriteLine(o4.GetNetSalary());
            Console.WriteLine("===================");

            Console.WriteLine();
            Console.WriteLine(o4.EMPNO);
            Console.WriteLine(o4.GetNetSalary());
            Console.WriteLine();
            Console.WriteLine(o3.EMPNO);
            Console.WriteLine(o3.GetNetSalary());
            Console.WriteLine();
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o2.GetNetSalary());
            Console.WriteLine();
            Console.WriteLine(o1.EMPNO);
            Console.WriteLine(o1.GetNetSalary());
            Console.WriteLine();

            Console.ReadLine();


        }
    }
    class Employee
    {


      
        public Employee(String NAME="Noname", decimal BASIC=20000, short DEPTNO=0)
        {
            this.EmpNo = ++lastempno;
            this.NAME = NAME;
            this.BASIC = BASIC;
            this.DEPTNO = DEPTNO;

           // Console.WriteLine("Employee no ="+lastempno);
            //Console.WriteLine(NAME + "" + BASIC + "" + DEPTNO);
        }

        #region properties
        private string name;

        public string NAME
        {
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {

                    Console.WriteLine("wrong input!!! please enter valid input!!");

                }

            }
            get
            {

                return name;
            }

        }
        #endregion

        #region properties
        private decimal Basic;

        public decimal BASIC
        {

            set
            {
                if (value > 100000 && value < 999999)
                {
                    Basic = value;
                }
                else
                {
                    Console.WriteLine("invalide basic salary");
                }
            }
            get
            {

                return Basic;
            }

        }
        #endregion

        #region properties
        private short DeptNo;

        public short DEPTNO
        {
            set
            {
                if (value > 0)
                {
                    DeptNo = value;
                }
                else
                {
                    Console.WriteLine("invalide department No");
                }
            }
            get
            {

                return DeptNo;
            }
        }
        #endregion


        #region properties

        private static int lastempno=0;
        private int EmpNo;

        public int EMPNO
        {

            get
            {
                return EmpNo;
            }
        }
        #endregion

        #region method
        public decimal GetNetSalary()
        {
            decimal basic = 100000;
            decimal hra = 50000;
            decimal da = 40000;

            decimal netSalary = basic + hra + da;

            return netSalary;
        }
        #endregion
    }
}
