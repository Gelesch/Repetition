

public static class Proggram
{
    static void Main(string[] args)
    {
      // int[] array1 = { 1, 2, 3, 4, 5 };
      // int[] array2 = { 9, 7, 34, 66, 5, 67, };
      // int[] array3 = { -1, -2, 3, 4, 5 };
      // int[] array4 = { 0, 0, 3, 4, 5 };
      // int[] array5 = { -1, 0, 3, 4, 5, -1 };
      // string[] arrayString = { "Hello", "World" };
      // PrintArray(arrayString);
      // PrintArray(array1);
      // PrintArray(array2);
      // PrintArray(array3, 2);
      // PrintArray(array4);
      // PrintArray(array5, lastIndex: 5);
      // PrintArray(arrayString);
      //  int sum = Sum(4, 5, 6, 7, 8, 88, 3, 456, 7);
      //  Console.WriteLine(sum);
      int factorial = Factorial(6);
      Console.WriteLine(factorial);
    }
    
    static void PrintArray(int[] a, int startIndex = 0, int lastIndex = -1)
    {
        if (lastIndex < 0)
        {
            lastIndex = a.Length;
        }

        for (var i = 0; i < lastIndex; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
    }

    static void PrintArray(string[] a, int startIndex = 0, int lastIndex = -1)
    {
        if (lastIndex < 0)
        {
            lastIndex = a.Length;
        }

        for (var i = 0; i < lastIndex; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
    }


    static int Sum(params int[] array)
    {
        int sum = 0;
        for (var i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }


    static int Factorial(int n)
    {

        if (n == 1)
        {
            return 1;
        }

        return n * Factorial(n - 1);
    }
}

