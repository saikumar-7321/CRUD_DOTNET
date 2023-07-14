using System;
using System.Collections.Generic;

public class EmployeeWorker
{
    private List<Employee> employees;

    public EmployeeWorker()
    {
        employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
        Console.WriteLine("Employee added successfully.");
    }

    public void UpdateEmployee(int id, Employee updatedEmployee)
    {
        Employee employee = employees.Find(emp => emp.Id == id);
        if (employee != null)
        {
            employee.Name = updatedEmployee.Name;
            employee.Department = updatedEmployee.Department;
            Console.WriteLine("Employee updated successfully.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    public void DeleteEmployee(int id)
    {
        Employee employee = employees.Find(emp => emp.Id == id);
        if (employee != null)
        {
            employees.Remove(employee);
            Console.WriteLine("Employee deleted successfully.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    public void GetEmployee(int id)
    {
        Employee employee = employees.Find(emp => emp.Id == id);
        if (employee != null)
        {
            Console.WriteLine($"Employee ID: {employee.Id}");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Department: {employee.Department}");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    public void GetAllEmployees()
    {
        if (employees.Count > 0)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Employee ID: {employee.Id}");
                Console.WriteLine($"Name: {employee.Name}");
                Console.WriteLine($"Department: {employee.Department}");
                Console.WriteLine("---------------------------------");
            }
        }
        else
        {
            Console.WriteLine("No employees found.");
        }
    }
}
