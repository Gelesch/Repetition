
//public static class Program
//{
//    static void Main(string[] args)
//    {
//   
//
//    }
//}

//№2
//Console.WriteLine(FindMax(numbers: new[] { 5, 4, 3, 2, 10 }, endIndex: 3));
//
//int FindMax(int[] numbers, int startIndex = 0, int endIndex = -1)
//{
//    if (endIndex < 0)
//    {
//        endIndex = numbers.Length - 1;
//    }
//
//    var max = numbers[startIndex];
//    for (int i = startIndex + 1; i <= endIndex; i++)
//    {
//        max = Math.Max(max, numbers[i]);
//    }
//
//    return max;
//}


//3 -ошибка
//Console.WriteLine(ConvertToFahrenheit(13));    
//double ConvertToFahrenheit(int accuracy = 2, double celsius)
//{
//    return Math.Round(celsius * 9 / 5 + 32, accuracy);
//}



//4
//SayHello("Viktor", "13");
//SayHello("Viktor", "Petrov");
//
//void SayHello(string name, string surname)
//{
//    Console.WriteLine($"Hello {name} {surname}" );
//}
//void SayHello(string name, string age)
//{
//    Console.WriteLine($"Hello {name} (Age: {age})" );
//}


//5
//onsole.WriteLine(FindMax(numbers: new[] { 10, 4, 3, 2, 50 }, 1, 3));

//nt FindMax(int[] numbers, int startIndex = 0, int endIndex = -1)
//

//   if (endIndex < 0)
//   {
//       endIndex = numbers.Length - 1;
//   }

//   var max = numbers[startIndex];
//       for (int i = startIndex + 1; i <= endIndex; i++)
//       {
//           max = Math.Max(max, numbers[i]);

//           return max;
//       }

//       return max;

//}


//8
//Console.WriteLine(RecursiveMethod(6));
//
//int RecursiveMethod(int n)
//{
//    if (n == 0 || n == 1) return n;
//
//    return RecursiveMethod(n - 1) + RecursiveMethod(n - 2);
//}

//9
//Console.WriteLine(Sum(2, 2));
//
//int Sum(int a, int b) => a + b;


//10
//Console.WriteLine(RecursiveMethod(4));
//int RecursiveMethod(int number)
//{
//    if (number == 5)
//    {
//        return 5;
//    }
//
//    return number * RecursiveMethod(number - 1);
//}

//11
Console.WriteLine(RecursiveMethod(4));
int RecursiveMethod(int number)
{
    if (number == 1)
    {
        return 1;
    }

    return number + RecursiveMethod(number - 1);
}

//12
//Console.WriteLine(FindMax(startIndex: 1, numbers: new[] { 1, 2, 3, 4, 5 }, endIndex:  3));
//
//int FindMax(int[] numbers, int startIndex = 0, int endIndex = -1)
//{
//    if (endIndex < 0)
//    {
//        endIndex = numbers.Length - 1;
//    }
//
//    var max = numbers[startIndex];
//    for (int i = startIndex + 1; i <= endIndex; i++)
//    {
//        max = Math.Max(max, numbers[i]);
//    }
//
//    return max;
//}