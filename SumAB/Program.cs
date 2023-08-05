namespace SumAB
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите два слогаемых");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (Sum(a, b) == -999)
            {
                Console.WriteLine("Вы ввели нули0");
            }

            Console.WriteLine("Сумма равно: " + Sum(a, b));

        }


        public static int Sum(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                return -999;
            }

            int sum = 0;
            sum = a + b;
            return sum;
        }

    }
}


