using ModelBindingDbCode.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBindingDbCode.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> ListobjEmp = new List<Employee>();
            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee";

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListobjEmp.Add(new Employee { EmpNo = Convert.ToInt32(dr["EmpNo"]), Name = dr["Name"].ToString(), Basic = Convert.ToDecimal(dr["Basic"]), DeptNo = (short)Convert.ToInt32(dr["DeptNo"]) });

            }

            dr.Close();

            cn.Close();


            return View(ListobjEmp);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id=0)
        {
            Employee objEmp = new Employee();

            //objEmp.EmpNo = 123;
            //objEmp.Name = "ram";
            //objEmp.Basic = 70000;
            //objEmp.DeptNO = 2;

            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee";

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                objEmp.EmpNo = Convert.ToInt32(dr["EmpNo"]);
                objEmp.Name = Convert.ToString(dr["Name"]);
                objEmp.Basic = Convert.ToDecimal(dr["Basic"]);
                objEmp.DeptNo = (short)Convert.ToInt32(dr["DeptNo"]);


            }

            dr.Close();

            cn.Close();

            return View(objEmp);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            Employee objEmp = new Employee();
            return View(objEmp);
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee objEmp)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Employee values(@EmpNo,@Name,@Basic,@DeptNo)";

                cmd.Parameters.AddWithValue("@EmpNo", objEmp.EmpNo);
                cmd.Parameters.AddWithValue("@Name", objEmp.Name);
                cmd.Parameters.AddWithValue("@Basic", objEmp.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", objEmp.DeptNo);
                cmd.ExecuteNonQuery();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id=0)
        {
            Employee objEmp = new Employee();

            //objEmp.EmpNo = 123;
            //objEmp.Name = "ram";
            //objEmp.Basic = 70000;
            //objEmp.DeptNo = 2;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee where EmpNo=" + id;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                objEmp.EmpNo = Convert.ToInt32(dr["EmpNo"]);
                objEmp.Name = dr["Name"].ToString();
                objEmp.Basic = Convert.ToDecimal(dr["Basic"]);
                objEmp.DeptNo =(short) Convert.ToInt32(dr["DeptNo"]);

            }
            dr.Close();
            cn.Close();
            return View(objEmp);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id,Employee objEmp )
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Employees set Name=@Name,Basic=@Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";

                cmd.Parameters.AddWithValue("@EmpNo", id);
                cmd.Parameters.AddWithValue("@Name", objEmp.Name);
                cmd.Parameters.AddWithValue("@Basic", objEmp.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", objEmp.DeptNo);
                cmd.ExecuteNonQuery();

                cn.Close();



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id=0)
        {
            Employee objEmp = new Employee();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee where EmpNo=" + id;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                objEmp.EmpNo = Convert.ToInt32(dr["EmpNo"]);
                objEmp.Name = dr["Name"].ToString();
                objEmp.Basic = Convert.ToDecimal(dr["Basic"]);
                objEmp.DeptNo =(short) Convert.ToInt32(dr["DeptNo"]);

            }
            dr.Close();
            cn.Close();
            return View(objEmp);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, FormCollection collection)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "delete from Employee where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", id);
                cmd.ExecuteNonQuery();

                cn.Close();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
