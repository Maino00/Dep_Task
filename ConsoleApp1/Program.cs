using System;

namespace OOP_Task;

public class Department
{
    public string Name;
    public float Compensation;
    public double Salary
    {
        get;
        set;
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
    private int eLength;
    private int dLength;
    public Department[] Dep = new Department[20];
    public Employee[] Emp = new Employee[20];
    public Database()
    {
        eLength = 0;
        dLength = 0;
    }
    public void AddDepartment(Department dep)
    {
        Dep[dLength]= dep;
        dLength++;
    }
    public void AddEmployee(Employee emp)
    {
        Emp[eLength]= emp;
        eLength++;
    }
    public Department getDepartmentByIndex(int index)
    {
        if (index < 0 || index >dLength) {
            Console.WriteLine("Out of Range index");
            return null;
        }
        return Dep[index];
    }
    public void DisplayAllDepartments()
    {

        for (int i = 0; i < dLength; i++)
        {
            Console.WriteLine($"{i} == for ==> {Dep[i].Name}");
        }
    }

}

public class OOP_Task
{
    private static void Main()
    {
        bool key = true;
        var database = new Database();
        while (key)
        {
            Console.WriteLine("1) Add a department  2) Add an Employee 3)Exit");

            var option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Name: ");
                    var name = Console.ReadLine();

                    Console.Write("Compensation: ");
                    var compensation = float.Parse(Console.ReadLine());

                    var dept = new Department(name, compensation);
                    database.AddDepartment(dept);

                    break;
                case 2:
                    Console.Write("First name: ");
                    var firstName = Console.ReadLine();

                    Console.Write("Last name: ");
                    var lastName = Console.ReadLine();

                    Console.Write("Salary: ");
                    var Salary = Convert.ToDouble(Console.ReadLine());
                    database.DisplayAllDepartments();


                    Console.Write("Department: ");
                    int index = int.Parse( Console.ReadLine());
                    Department d = database.getDepartmentByIndex(index);

                    d.Salary = Salary;

                    var emp = new Employee(firstName, lastName, Salary,d);
                    Console.WriteLine(emp.Dept.Salary);
                    database.AddEmployee(emp);

                    break;
                case 3:
                    key = false;
                    break;
                default:
                    Console.WriteLine("Try another option");
                    option = Convert.ToInt32(Console.ReadLine());
                    return;



            }
        }
        
    }

}