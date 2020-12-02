using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("manager");
            Manager m1 = new Manager("Teju",1,70000, "HR");
            Console.WriteLine("name " + m1.Name);
            Console.WriteLine("net salary == " + m1.CalcNetSalary());
            Console.WriteLine("===========================================");
            Console.WriteLine("general manager");
            GeneralManager gm1 = new GeneralManager("mahesh", 1,100000, "GM", "abccc");
            Console.WriteLine("name " + gm1.Name);
            Console.WriteLine("net salary == " + gm1.CalcNetSalary());
            Console.WriteLine("===========================================");
            Console.WriteLine("CEO");
            CEO c1 = new CEO("yamini",4,60000);
            Console.WriteLine("name " + c1.Name);
            Console.WriteLine("net salary == " + c1.CalcNetSalary());
            Console.WriteLine("===========================================");
            Console.ReadLine();



        }
    }

    public abstract class Employee
    {

        public Employee(String Name = "Noname", short DeptNo = 0, Decimal Basic = 20000)
        {
            Empno = ++empno;
            this.Name = Name;
            this.DeptNo = DeptNo;
            this.Basic = Basic;


        }

        public Employee()
        {
            Empno = ++empno;
        }



        private String name;

        public String Name
        {
            set
            {

                if (value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("invalide input ...!");
                }
            }
            get
            {
                return name;
            }
        }

        private short deptno;

        public short DeptNo
        {
            set
            {
                if(value > 0)
                {
                    deptno = value;
                }
                else
                {
                    Console.WriteLine("NO valide Deptno");
                }
            }
            get
            {
                return deptno;
            }
        }

        private decimal basic;

        public abstract decimal Basic
        {
            get;
            set;
           
        }

        
        private static int empno=0;

        private int Empno;

        public int EmpNo
        {
            get
            {
                return Empno;
            }
        }

        public abstract decimal CalcNetSalary();

    }


    public class Manager : Employee
    {

        public Manager(string Name,short DeptNo,decimal Basic,string Designation) : base(Name,DeptNo,Basic)
        {
            this.Name = Name;
            this.DeptNo = DeptNo;
            this.Basic = Basic;
            this.Designation = Designation;
                
        }

           
        public override decimal CalcNetSalary()
        {
            decimal hra = 50000;
            decimal da = 60000;

            decimal netSalary = Basic + hra + da;

            return netSalary;
            
        }


        private string designation;

        public string Designation
        {
            set
            {
                value = designation;

            }
            get
            {
                return designation;
            }
        }

        public override decimal Basic {
           
            set;
            get;
            
        
        }
    }

    public class GeneralManager : Manager
    {

        public GeneralManager(String Name,short DeptNo, decimal Basic,String Designation,String Perks):base(Name,DeptNo,Basic,Designation)
        {
            this.Name = Name;
            this.DeptNo = DeptNo;
            this.Basic = Basic;
            this.Designation = Designation;
            this.Perks = Perks;


        }
        private string perks;

        public string Perks
        {
            set;
            get;
        }
    }

    public class CEO : Employee
    {

        public CEO(String Name,short DeptNO, decimal Basic): base(Name,DeptNO,Basic)
        {
            this.Name = Name;
            this.DeptNo = DeptNo;
            this.Basic = Basic;

        }
        public override decimal Basic { 
            
            set;
            get;
        }

        public sealed override decimal CalcNetSalary()
        {
            decimal hra = 50000;
            decimal da = 60000;

            decimal netSalary = Basic + hra + da;

            return netSalary;

        }
    }
}