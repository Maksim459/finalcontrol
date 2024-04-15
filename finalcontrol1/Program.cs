
public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }
    public void ShowInfo()
    {
        Console.WriteLine($"Работник.Имя:{Name},Возраст:{Age},Зарплата:{Salary}");
    }
}

public class Manager : Employee, IComparable<Manager>
{
    public string Department { get; set; }

    public int CompareTo(Manager other)
    {
        return Salary.CompareTo(other.Salary);
    }

    
}

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee
        {
            Name = "Tom",
            Age = 30,
            Salary = 1000
        };

        Manager manager1 = new Manager
        {
            Name = "Bill",
            Age = 30,
            Salary = 10000,
            Department = "First"
        };

        Manager manager2 = new Manager
        {
            Name = "Bob",
            Age = 40,
            Salary = 55000,
            Department = "Marketing"
        };

        employee.ShowInfo();
        manager1.ShowInfo();
        manager2.ShowInfo();

        
        int comparisonResult = manager1.CompareTo(manager2);
        if (comparisonResult < 0)
        {
            Console.WriteLine($"{manager1.Name} имеет меньшую зарплату, чем {manager2.Name}");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine($"{manager1.Name} имеет большую зарплату, чем {manager2.Name}");
        }
        else
        {
            Console.WriteLine($"{manager1.Name} и {manager2.Name} имеют одинаковую зарплату");
        }
    }
}

