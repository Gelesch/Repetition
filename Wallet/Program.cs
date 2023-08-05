

Wallet walletDima = new Wallet(800);
Person dima = new Person("Дима",180,28,walletDima);
dima.PrintInformation();



Wallet walletStast = new Wallet(600);
Person stas = new Person("Дима",180,28,walletStast);
stas.PrintInformation();

stas.Wallet.Pay(800);



public class Person
{
    
    public Wallet Wallet;
    public  string Name;
    public  double Height;
    public  int Age;

    public Person( string name, double height, int age,Wallet wallet)
    {
       
        Name = name;
        Height = height;
        Age = age;
        Wallet = wallet;
    }

   

    public void PrintInformation()
    {
        Console.WriteLine($"Имя: {Name},Возраст: {Age},Рост: {Height},Количество денег:{Wallet.Money}");
    }

}
public class Wallet
{
    public int Money;

    public Wallet(int totalMoney)
    {
        Money = totalMoney;
    }
    

    public void Pay(int amount)
    {
        if (Money<amount)
        {
            Console.WriteLine("У вас недостаточно денег");
            return;
        }

        Money -= amount;
    }


}