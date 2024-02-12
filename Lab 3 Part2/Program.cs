using System;
using System.Collections.Generic;

interface IAnimal
{
    string Name { get; set; }
    string Colour { get; set; }
    int Height { get; set; }
    int Age { get; set; }

    void Eat();
    string Cry();
}

class Dog : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }

    public string Cry()
    {
        return "Woof!";
    }
}

class Cat : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }

    public string Cry()
    {
        return "Meow!";
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a dog name: ");
        string dogName = Console.ReadLine();

        Dog dog = new Dog();
        Console.Write("Enter a dog height: ");
        dog.Height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a dog colour: ");
        dog.Colour = Console.ReadLine();
        Console.Write("Enter a dog age: ");
        dog.Age = Convert.ToInt32(Console.ReadLine());
        dog.Name = dogName;

        Console.WriteLine("Dog properties:");
        Console.WriteLine($"Name: {dog.Name}");
        Console.WriteLine($"Colour: {dog.Colour}");
        Console.WriteLine($"Height: {dog.Height}");
        Console.WriteLine($"Age: {dog.Age}");
        dog.Eat();
        Console.WriteLine($"Cry: {dog.Cry()}");

        Console.Write("Enter a cat name: ");
        string catName = Console.ReadLine();

        Cat cat = new Cat();
        Console.Write("Enter a cat height: ");
        cat.Height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a cat colour: ");
        cat.Colour = Console.ReadLine();
        Console.Write("Enter a cat age: ");
        cat.Age = Convert.ToInt32(Console.ReadLine());
        cat.Name = catName;

        Console.WriteLine("Cat properties:");
        Console.WriteLine($"Name: {cat.Name}");
        Console.WriteLine($"Colour: {cat.Colour}");
        Console.WriteLine($"Height: {cat.Height}");
        Console.WriteLine($"Age: {cat.Age}");
        cat.Eat();
        Console.WriteLine($"Cry: {cat.Cry()}");

        List<IAnimal> animals = new List<IAnimal>() { dog, cat };

        Console.WriteLine("Names of all the animals:");
        foreach (IAnimal animal in animals)
        {
            Console.WriteLine(animal.Name);
            Console.WriteLine("Press Enter to close...");
            Console.ReadLine();

        }
    }
}