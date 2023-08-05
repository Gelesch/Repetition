// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Person vlad = new Person("Vlad", 28, 375291924903);
Person kiril = new Person("Kiril", 28, 375291924903);
vlad.Call(kiril);


class Person
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

    public void Call(Person person)
    {
        Console.WriteLine($"{this.Name} звонит {person.Name}");
       
    }
}