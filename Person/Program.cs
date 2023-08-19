// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Person vlad = new Person("Vlad", 20, 375291924903);
Person kiril = new Person("Kiril", 28, 375291924903);
vlad.Call(kiril);
vlad.PrintInformation();



public static class TaxCalculator
{
    public static int GetTaxParcent(Person person)
    {
        if (person.Age>=25)
        {
            return 20;
        }

        return 0;
    }
}

public class Person
{
    public string Name;
    public int Age;
    public long Number;

    public Person(string name, int age, long number)
    {
        Name = name;
        Age = age;
        Number = number;
    }

    
    
    public void Call(Person receiver)
    {
        Console.WriteLine($"Кто звонит {Name} {Number}");
        Console.WriteLine($"Кому звонят {receiver.Name} {receiver.Number}");
        
    }
    
    
    public void PrintInformation()
    {
        Console.WriteLine("Имя: "+ Name +", Номер телефона: " +Number);
        Console.WriteLine("Возраст " + Age);
        Console.WriteLine("Налогавая ставка: " +TaxCalculator.GetTaxParcent(this));
    }
}

