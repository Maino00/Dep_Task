using System;

namespace OOP_Task;

public class Department
{
    public string Name;
    public float Compensation;
    public double Salary
    {
        get;
        private set;
    }

    public Department(string name , float compensation)
    {
        Name = name;
        Compensation = compensation;
    }
    public double GetSalary(double salary, int workingDays)
    {
        Salary = salary;
        return ((salary * workingDays) + ((salary * workingDays) * (Compensation / 100)));
    }

}

public class Employee
{
    public string firstName;
    public string lastName;
    public double Sal;
    public Department Dept;
    public Employee (string firstname, string lastname, double salary, Department dept)
    {
        firstName = firstname;
        lastName = lastname;
        Sal = salary;
        Dept = dept;
        
    }
    public double GetSalary(int workingDays)
    {
        return Dept.Salary + Sal;
    } 
}


    
public class Database
{
    private int employee;
    private int department;
    public Department[] Dep = new Department[20];
    public Employee[] Emp = new Employee[20];
    public void AddDepartment(Department dep)
    {
        Dep[department ++]= dep;
    }
    public void AddEmployee(Employee emp)
    {
        Emp[employee ++]= emp;
    } 
}

public class OOP_Task
{
    private static void Main()
    {
        var database = new Database();
        while (true)
        {
            Console.WriteLine("1) Add a department  2) Add an Employee");
        }
        var option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.Write("Name: ");
                var name = Console.ReadLine();

                Console.Write("Compensation: ");
                var compensation = Convert.ToSingle(Console.ReadLine());

                Console.Write("Salary: ");
                var salary = Convert.ToSingle(Console.ReadLine());

                var dept = new Department(name, compensation);
                database.AddDepartment(dept);

                break;
            case 2:
                Console.Write("First name: ");
                var firstName = Console.ReadLine();

                Console.Write("Last name: ");
                var lastName = Console.ReadLine(); 

                Console.Write("Salary: ");
                var Salary = Convert.ToSingle(Console.ReadLine());

                Console.Write("Department: ");
                var department = Console.ReadLine();

                var emp = new Employee(firstName, lastName, Salary, dept);
                database.AddEmployee(emp);

                break;
            default:
                Console.WriteLine("Try another option");
                 option = Convert.ToInt32(Console.ReadLine());
                return;

               
                
        }
             
        
    }

}