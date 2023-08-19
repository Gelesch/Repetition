 static void Main(string[] args)
{
    var object1 = new SomeClass();
    var object2 = new SomeClass();
    object1.d = 42;
    object2.d = 43;
    Console.Write(object1.d + " " + object2.d);
}

class SomeClass
{
    public static int s;
    public int d;
}