using System;

class Program
{
    static void Main()
    {
        EmployeeWorker worker = new EmployeeWorker();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Update employee");
            Console.WriteLine("3. Delete employee");
            Console.WriteLine("4. Get employee");
            Console.WriteLine("5. Get all employees");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter employee details:");
                    Console.Write("ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Department: ");
                    string department = Console.ReadLine();
                    Employee newEmployee = new Employee { Id = id, Name = name, Department = department };
                    worker.AddEmployee(newEmployee);
                    break;
                case "2":
                    Console.WriteLine("Enter employee ID to update:");
                    int updateId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter updated employee details:");
                    Console.Write("Name: ");
                    string updatedName = Console.ReadLine();
                    Console.Write("Department: ");
                    string updatedDepartment = Console.ReadLine();
                    Employee updatedEmployee = new Employee { Name = updatedName, Department = updatedDepartment };
                    worker.UpdateEmployee(updateId, updatedEmployee);
                    break;
                case "3":
                    Console.WriteLine("Enter employee ID to delete:");
                    int deleteId = Convert.ToInt32(Console.ReadLine());
                    worker.DeleteEmployee(deleteId);
                    break;
                case "4":
                    Console.WriteLine("Enter employee ID to get details:");
                    int getId = Convert.ToInt32(Console.ReadLine());
                    worker.GetEmployee(getId);
                    break;
                case "5":
                    worker.GetAllEmployees();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
