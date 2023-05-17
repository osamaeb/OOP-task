using System;

// Abstract class
public abstract class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }

    protected Vehicle(string make, string model)
    {
        Make = make;
        Model = model;
    }

    // Abstract method
    public abstract void Start();

    // Override ToString() method
    public override string ToString()
    {
        return $"{Make} {Model}";
    }
}

// Derived class
public class Car : Vehicle
{
    public int Year { get; set; }
    public string Color { get; set; }

    public Car(string make, string model, int year, string color) : base(make, model)
    {
        Year = year;
        Color = color;
    }

    // Parameterized constructor
    public Car(Car otherCar) : base(otherCar.Make, otherCar.Model)
    {
        Year = otherCar.Year;
        Color = otherCar.Color;
    }

    // Implementing abstract method
    public override void Start()
    {
        Console.WriteLine("Car started.");
    }

    // Override ToString() method
    public override string ToString()
    {
        return $"Car: {base.ToString()}, Year: {Year}, Color: {Color}";
    }
}

// Another derived class
public class Motorcycle : Vehicle
{
    public string Type { get; set; }

    public Motorcycle(string make, string model, string type) : base(make, model)
    {
        Type = type;
    }

    // Copy constructor
    public Motorcycle(Motorcycle otherMotorcycle) : base(otherMotorcycle.Make, otherMotorcycle.Model)
    {
        Type = otherMotorcycle.Type;
    }

    // Implementing abstract method
    public override void Start()
    {
        Console.WriteLine("Motorcycle started.");
    }

    // Override ToString() method
    public override string ToString()
    {
        return $"Motorcycle: {base.ToString()}, Type: {Type}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Toyota", "Camry", 2022, "Red");
        Car car2 = new Car(car1); // Using copy constructor
        car1.Start(); // Start the car
        Console.WriteLine(car1);
        Console.WriteLine(car2);

        Motorcycle motorcycle = new Motorcycle("Honda", "CBR500R", "Sport");
        motorcycle.Start(); // Start the motorcycle
        Console.WriteLine(motorcycle);

        Console.ReadLine();
    }
}
