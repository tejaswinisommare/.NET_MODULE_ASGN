using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP
{
    class Program
    {
        static void Main()
        {

            Employee e = new Employee();

            e.NAME ="yamini";

            Console.WriteLine(e.NAME);
            e.BASIC = 180000;
            Console.WriteLine("basic salary = " + e.BASIC);
            e.DEPTNO = 1;
            Console.WriteLine("Dept no ="+e.DEPTNO);
            Console.WriteLine("netsalary is " + e.GetNetSalary());

            Employee e1 = new Employee();
            e1.NAME = "Teju";
            Console.WriteLine(e1.NAME);

            e.BASIC = 190000;
            Console.WriteLine("basic salary = " + e.BASIC);

          //e.BASIC = 19000000;

            e.DEPTNO = 2;
            Console.WriteLine("Dept no ="+e.DEPTNO);
            Console.WriteLine("netsalary is " + e.GetNetSalary());

            //e.DEPTNO =-2;
            //Console.WriteLine(e.DEPTNO);


            Employee o1 = new Employee("Teju", 123465, 10);
            Employee o2 = new Employee("Teju", 123465);
            Employee o3 = new Employee("Teju");
            Employee o4 = new Employee();

            Employee o5 = new Employee();
            Employee o6 = new Employee();

            Console.ReadLine();


        }
    }
    class Employee
    {
        

        public Employee()
        {
            empno++;
            Console.WriteLine("employee no =" + empno);
                
        }

        public Employee(String NAME, decimal BASIC , short DEPTNO)
        {
            this.NAME = NAME;
            this.BASIC = BASIC;
            this.DEPTNO = DEPTNO;

            Console.WriteLine(NAME + "" + BASIC + "" + DEPTNO);
        }

        public Employee(String NAME, decimal BASIC)
        {
            this.NAME = NAME;
            this.BASIC = BASIC;

            Console.WriteLine( NAME + "" + BASIC);
        }


        public Employee(String NAME)
        {
            this.NAME = NAME;

            Console.WriteLine("emp Name = " + NAME);

        }

        #region properties
        private string name;

        public string NAME
        {
            set
            {
                if(value != "")
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
                if(value > 0)
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

        private static int empno;
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
