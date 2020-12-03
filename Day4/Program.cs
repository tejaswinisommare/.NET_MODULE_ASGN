using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("manager");
            Manager m1 = new Manager("Teju", 1, 70000, "HR");
            Console.WriteLine("name " + m1.Name);
            Console.WriteLine("net salary == " + m1.CalcNetSalary());
            Console.WriteLine("===========================================");
            Console.WriteLine("general manager");
            GeneralManager gm1 = new GeneralManager("mahesh", 1, 100000, "GM", "abccc");
            Console.WriteLine("name " + gm1.Name);
            Console.WriteLine("net salary == " + gm1.CalcNetSalary());
            Console.WriteLine("===========================================");
            Console.WriteLine("CEO");
            CEO c1 = new CEO("yamini", 4, 60000);
            Console.WriteLine("name " + c1.Name);
            Console.WriteLine("net salary == " + c1.CalcNetSalary());
            Console.WriteLine("===========================================");


            Console.WriteLine("=============================================");
            IDbFuctions i1 = new Manager();
            i1.Delete();
            i1.Update();
            i1.insert();

            Console.WriteLine("===========================================");
            IDbFuctions i2 = new GeneralManager();
            i2.insert();
            i2.Update();
            i2.Delete();

            Console.WriteLine("==========================================");
            IDbFuctions i3 = new CEO();
            i3.Delete();
            i3.Update();
            i3.insert();

            Console.WriteLine("==========================================");
            Console.ReadLine();


        }
    }

    public interface IDbFuctions
    {
        void insert();
        void Update();
        void Delete();

    }


    public abstract class Employee : IDbFuctions
    {

        public Employee(String Name = "Noname", short DeptNo = 100, Decimal Basic = 20000)
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
                if (value > 0)
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

        protected decimal basic;

        public abstract decimal Basic
        {
            get;
            set;

        }


        private static int empno = 0;

        private int Empno;

        public int EmpNo
        {
            get
            {
                return Empno;
            }
        }

        public abstract decimal CalcNetSalary();

        public void insert()
        {
            Console.WriteLine("Employee insert called...");
        }

        public void Update()
        {
            Console.WriteLine("Employee update called...");      
        }

        public void Delete()
        {
            Console.WriteLine("Employee delete called..");    
        }
    }


    public class Manager : Employee,IDbFuctions
    {

        public Manager(String Name = "Noname", short DeptNo = 100, Decimal Basic = 20000, string Designation = "GM") : base(Name, DeptNo, Basic)
        {
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

        public override decimal Basic
        {

            set;
            get;


        }

        public new void insert()
        {
            Console.WriteLine("Manager insert called...");
        }

        public new void Update()
        {
            Console.WriteLine("Manager update called...");
        }

        public new void Delete()
        {
            Console.WriteLine("Manager delete called..");
        }
    }

    public class GeneralManager : Manager, IDbFuctions
    {

        public GeneralManager(String Name = "Noname", short DeptNo = 100, Decimal Basic = 20000, string Designation = "GM", String Perks = "none") : base(Name, DeptNo, Basic, Designation)
        {
            this.Perks = Perks;


        }
        private string perks;

        public string Perks
        {
            set;
            get;
        }

        public new void insert()
        {
            Console.WriteLine("GeneralManager insert called...");
        }

        public new void Update()
        {
            Console.WriteLine("GeneralManager update called...");
        }

        public new void Delete()
        {
            Console.WriteLine("GeneralManager delete called..");
        }

    }

    public class CEO : Employee,IDbFuctions
    {

        public CEO(String Name = "Noname", short DeptNo = 100, Decimal Basic = 20000) : base(Name, DeptNo, Basic)
        {
            this.Name = Name;
            this.DeptNo = DeptNo;
            this.Basic = Basic;

        }
        public override decimal Basic
        {

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

        public new void Delete()
        {
            Console.WriteLine("CEO-- Delete");
        }

        public new void insert()
        {
            Console.WriteLine("CEO-- Insert");
        }

        public new void Update()
        {
            Console.WriteLine("CEO-- update");
        }

    }
}