using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLCRUDOperations
{
    internal class Operations
    {
        

        SqlCommand cmd;
        SqlDataReader dr;
        EmployeeDetails employeeDetails = new EmployeeDetails();

        SqlConnection cn = new SqlConnection("Data Source=QUAL-LT89W8PL3\\SQLEXPRESS07;Initial Catalog=EmployeeDB;Integrated Security=True");
        public int Add(EmployeeDetails employeeDetails)
        {
            cn.Open();
            string sqltext = $"Insert Into Employees Values({employeeDetails.Id},'{employeeDetails.Name}',{employeeDetails.Salary},{employeeDetails.Age}) ";
            cmd = new SqlCommand(sqltext, cn);
            int recs = cmd.ExecuteNonQuery(); // to run action queries
            cn.Close();
            return recs;
        }
        public SqlDataReader Read(int id)
        {
            cn.Open();
            string sqltext = $"Select * From Employees Where Id={id}";
            cmd = new SqlCommand(sqltext, cn);
            SqlDataReader dr=cmd.ExecuteReader();
            return dr;
        }
        public int Update(EmployeeDetails employeeDetails)
        {
            cn.Open();
            string sqltext = $"Update Employees SET name='{employeeDetails.Name}',salary={employeeDetails.Salary},age={employeeDetails.Age} where Id={employeeDetails.Id}";
            cmd = new SqlCommand(sqltext, cn);
            int result = cmd.ExecuteNonQuery();
            cn.Close();
            return result;
        }
        public int Delete(int id)
        {
            cn.Open();
            string sqltext = $"Delete From Employees Where Id={id}";
            cmd = new SqlCommand(sqltext, cn);
            int result = cmd.ExecuteNonQuery();
            cn.Close();
            return result;
        }
        public List<EmployeeDetails> DisplayAll()
        {
            cn.Open();
            List<EmployeeDetails> employees = new List<EmployeeDetails>();
            string sqltext = $"Select * from Employees";
            cmd = new SqlCommand(sqltext, cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EmployeeDetails employeeDetails = new EmployeeDetails
                {
                    Id = dr.GetInt32(0),
                    Name = dr.GetString(1),
                    Salary = dr.GetDecimal(2),
                    Age=dr.GetInt32(3)
                };
                employees.Add(employeeDetails);
            }
            cn.Close();
            dr.Close();
            return employees;
        }
    }
}
