using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlTask2
{
    internal class Operations
    {
        SqlCommand cmd;
        SqlDataReader dr;
        EmployeeDetails employeeDetails = new EmployeeDetails();

        SqlConnection cn = new SqlConnection("Data Source=QUAL-LT89W8PL3\\SQLEXPRESS07;Initial Catalog=EmployeeDB;Integrated Security=True");
        public int ExecuteNonQueryMethod(string sqltext)
        {
            cn.Open();
            cmd = new SqlCommand(sqltext, cn);
            int recs = cmd.ExecuteNonQuery(); // to run action queries
            cn.Close();
            return recs;
        }
        public List<EmployeeDetails> Display(string sqltext)
        {
            cn.Open();
            List<EmployeeDetails> employees = new List<EmployeeDetails>();
            cmd = new SqlCommand(sqltext, cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EmployeeDetails employeeDetails = new EmployeeDetails
                {
                    Id = dr.GetInt32(0),
                    Name = dr.GetString(1),
                    Salary = dr.GetDecimal(2),
                    Age = dr.GetInt32(3)
                };
                employees.Add(employeeDetails);
            }
            cn.Close();
            dr.Close();
            return employees;
        }
    }
}
