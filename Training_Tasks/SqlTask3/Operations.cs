using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SqlTask3
{
    internal class Operations
    {
        SqlConnection con = new SqlConnection("Data Source=QUAL-LT89W8PL3\\SQLEXPRESS07;Initial Catalog=EmployeeDB;Integrated Security=True;");
        SqlDataAdapter da;
        DataTable dt;
        DataRow dr;
        DataSet ds = new DataSet();
        
        public void AddRow(EmployeeModel employeeModel)
        {
            try
            {
                
                da = new SqlDataAdapter($"Select * from Employees", con);
                da.Fill(ds);
                dt = ds.Tables[0];
                dr = dt.NewRow();
                dr[0] = employeeModel.Id;
                dr[1] = employeeModel.Name;
                dr[2] = employeeModel.Salary;
                dr[3] = employeeModel.Age;
                dt.Rows.Add(dr);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(dt);
            }
            catch (SqlException ex) { throw ex; }
        }
        public DataRow ReadRow(int id)
        {
            try
            {
             
                da = new SqlDataAdapter($"Select * from Employees", con);
                da.Fill(ds);
                dt = ds.Tables[0];
                dr = dt.Select("Id = " + id)[0];
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(dt);
                return dr;
            }
            catch (SqlException ex) { throw ex; }

        }
        public void UpdateRow(EmployeeModel employeeModel)
        {
            try
            {
                da = new SqlDataAdapter($"Select * from Employees", con);
                da.Fill(ds);
                dt = ds.Tables[0];
                dr = dt.Select("Id = " + employeeModel.Id)[0];
                dr[1] = employeeModel.Name;
                dr[2] = employeeModel.Salary;
                dr[3] = employeeModel.Age;
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(dt);
            }
            catch (SqlException ex) { throw ex; }
        }
        public void DeleteRow(int id)
        {
            try 
            { 
               da = new SqlDataAdapter("Select * from Employees", con);
               da.Fill(ds);
               dt = ds.Tables[0];
               dr = dt.Select("Id = " + id)[0];
               dr.Delete();
               SqlCommandBuilder cmd = new SqlCommandBuilder(da);
               da.Update(dt);
            }
            catch (SqlException ex) { throw ex; }
        }
        public DataSet DisplayAll()
        {
            ds.Clear();
            da = new SqlDataAdapter("Select * from Employees", con);
            da.Fill(ds);
            return ds;
        }
    }
}
