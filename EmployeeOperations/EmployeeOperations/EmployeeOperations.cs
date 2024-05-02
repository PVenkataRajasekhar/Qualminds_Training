using EmployeeOperations;
using System;
using System.Collections;

namespace ArrayListDemo;

public class EmployeeOperations
{
    private ArrayList employees = new ArrayList();

    public ArrayList Employees { get { return employees; } }

    public bool AddEmployee(Employee emp)
    {
        Employees.Add(emp);
        return true;
    }

    public bool RemoveEmployee(int empId)
    {
        Employee empToRemove = null;
        foreach (Employee item in Employees)
        {
            if (item.Id == empId)
            {
                empToRemove = item;
                break;
            }
        }

        if (empToRemove != null)
        {
            Employees.Remove(empToRemove);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool UpdateEmployee(Employee emp, int empId)
    {
        bool employeeFound = false;
        for (int i = 0; i < Employees.Count; i++)
        {
            Employee item = (Employee)Employees[i];
            if (item.Id == empId)
            {
                employeeFound = true;
                Employees[i] = emp;
                break;
            }
        }
        return employeeFound;
    }

    public Employee GetEmployee(int empId)
    {
        foreach (Employee item in Employees)
        {
            if (item.Id == empId)
            {
                return item;
            }
        }
        return null;
    }
}


