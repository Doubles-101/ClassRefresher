// Basic Creating Class
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }

    // Constructor
    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Price: ${Price:F2}"); // Format to 2 decimal places
    }
};

// test 
public class Program
{
    public static void Main()
    {
        Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10.99m);
        book.DisplayDetails();
    }
}

// Inheritance Case
public class Employee
{
    public string Name { get; set; }
    public Int32 Salary { get; set; }

    // Constructor
    public Employee(string name, Int32 salary)
    {
        Name = name;
        Salary = salary;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary}");
    }
}

public class Manager : Employee
{
    public string Department { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Department: {Department}");
    }
}

//test inheritance
public class Program2
{
    public static void Main()
    {
        Manager manager = new Manager("Alice", 75000, "IT");
        manager.DisplayInfo();
    }
}


// Polymorphism Case
public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }
    public override double CalculateArea()
    {
        return Length * Width;
    }
}

public class Circle : Shape
{
    public int Radius { get; set; }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;       
    }
}

public class Program3
{
    public static void Main()
    {
        // Create instances of Rectangle and Circle
        Shape rectangle = new Rectangle { Length = 5, Width = 3 };
        Shape circle = new Circle { Radius = 4 };

        // Add them to a list of shapes
        List<Shape> shapes = new List<Shape> { rectangle, circle };

        // Calculate and display the area of each shape
        foreach (var shape in shapes)
        {
            Console.WriteLine($"The area of the {shape.GetType().Name} is: {shape.CalculateArea():F2}");
        }
    }
}


// abstract test
public abstract class Vehicle
{
    public abstract string Start();
}

public class Car : Vehicle
{
    public override string Start()
    {
        return "Car starts with a key.";
    }
}

public class Motorcycle : Vehicle
{
    public override string Start()
        {
            return "Motorcycle starts with a button.";
        }
}

class Program4
{
    public static void Main()
    {
        Vehicle car = new Car();
        Vehicle motorcycle = new Motorcycle();

        Console.WriteLine(car.Start());
        Console.WriteLine(motorcycle.Start());
    }
}

