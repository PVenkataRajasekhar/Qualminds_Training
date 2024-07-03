using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Emp
    {
        private string EmpName;
        private int salary;

        public Emp(string Name, int sal)
        {
            EmpName = Name;
            salary = sal;
        }
        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("employee Name : {0}{1}", EmpName, Environment.NewLine);
            sb.AppendFormat("employee salary : {0}{1}", salary, Environment.NewLine) ;
            return sb.ToString();
        }

    }
}
