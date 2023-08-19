/*class Program
{
    private static int _health = 100;
    private static void Main(string[] args)
    {
        _health -= 80;
        Console.WriteLine($"Health: {_health}");
    }
}
*/
/*
class Program
{
    private static readonly int Health = 100;
    private static void Main(string[] args)
    {
        Health -= 80;
        Console.WriteLine($"Health: {Health}");
    }
}
*/

/*
class Program
{
    private static const double G = 9.18;
    private static void Main(string[] args)
    {
        Console.WriteLine($"G: {G}");
    }
}


Console.WriteLine(Operations.Add(5, 4));
Console.WriteLine(Operations.Subtract(5, 4));
Console.WriteLine(Operations.Multiply(5, 4));
*/

/*
public static class Operations
{
    public static int Add(int x, int y) => x + y;
    public static int Subtract(int x, int y) => x - y;
    public static int Multiply(int x, int y) => x * y;
}
*/



/*
class Program
{
    private static int _health = 100;
    private static void Main(string[] args)
    {
        AddHealth(20);
        TakeDamage(20);
        TakeDamage(30);
        Console.WriteLine(_health);
    }

    private static void TakeDamage(int amount) => _health -= amount;
    private static void AddHealth(int amount) => _health += amount;
}

*/



/*
public static class MyCalculator
{
    public static int Result = 0;

    public static void Add(int a, int b)
    {
        Result = a + b;
    }

    public static void Multiply(int a, int b)
    {
        Result = a * b;
    }
}

class Program
{
    private static void Main(string[] args)
    {
        MyCalculator.Add(2, 2);
        MyCalculator.Multiply(MyCalculator.Result, 10);
        MyCalculator.Add(2, 2);
        Console.WriteLine(MyCalculator.Result);
    }
}

*/


/*

private static int _sum = 0;

public static class Summarizer
{
    public static int CalculateSum(params int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            _sum += array[i];
        }

        return _sum;
    }
}

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Summarizer.CalculateSum(1, 2, 3));
        Console.WriteLine(Summarizer.CalculateSum(10, 20, 30));
    }
}

*/


/*
public static class Summarizer
{
    private static int _sum = 0;

    public static int CalculateSum(params int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            _sum += array[i];
        }

        return _sum;
    }
}

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Summarizer.CalculateSum(1, 2, 3));
        Console.WriteLine(Summarizer.CalculateSum(10, 20, 30));
    }
}

*/


//public static class MyStatistics
//{
//    public static int TotalCountStudents;
//    public static int PassedExam;
//
//    public static double GetSuccessfulRate()
//    {
//        return PassedExam / TotalCountStudents;
//    }
//}
//
//class Program
//{
//    private static void Main(string[] args)
//    {
//        MyStatistics.TotalCountStudents = 10;
//        MyStatistics.PassedExam = 7;
//        Console.WriteLine(MyStatistics.GetSuccessfulRate());
//    }
//}


/// <summary>
/// Прлебажить
/// </summary>
//public class Program
//{
//    public static void Main()
//    {
//        var object1 = new SomeClass();
//        var object2 = new SomeClass();
//    
//        object1.Run();
//        object2.Run();
//        object1.Run();
//    }
//}
//
//    
//class SomeClass
//{
//    public static int s = 1;
//    public int d = 1;
//
//    public void Run()
//    {
//        Console.Write(s + " " + d + " ");
//        s++;
//        d++;
//    }	
//}


/*
 * public class Program
{
    public static void Main()
    {
        var object1 = new SomeClass();
        var object2 = new SomeClass();
    
        object1.Run();
        object2.Run();
        object1.Run();
    }
}


class SomeClass
{
    public static int s = 1;
    public int d = 1;

    public void Run()
    {
        Console.Write(s + " " + d + " ");
        s++;
        d++;
    }	
}

 */

/*
public class Task
{
    static void Main(string[] args)
    {
        var person1 = new Person("Vika");
        var person2 = new Person("Petya");
        person1.Do();
    }
}

public class Person
{
    public static string Name;

    public Person(string name)
    {
        Name = name;
    }

    public void Do()
    {
        Console.WriteLine($"{Name} do something");
    }
}

*/
public class Task
{
    static void Main(string[] args)
    {
        var persons = new Person[] 
        { 
            new Person("Ivan"),
            new Person("Nikita"),
            new Person("Danik") 
        };

        foreach (var person in persons)
        {
            Console.Write(person.Name + " ");
        }
    }
}

public class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
}