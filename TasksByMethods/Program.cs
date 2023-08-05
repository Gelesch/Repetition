using System;
using Math = System.Math;


//1.Finding minimal number
 /*   namespace StaticMethods
    {
        public static class Task
        {
            public static void Main()
            {
                Console.WriteLine(Min(15, -9)); //-9
                Console.WriteLine(Min(1, 2)); //1
                Console.WriteLine(Min(5, 8)); //5
                Console.WriteLine(Min(9, 10)); //9
            }

            public static int Min(int a,int b)
            {
                return Math.Min(a, b);
            }
        }
    }
    */
    

//2.Is number  odd or even?
/*
 namespace StaticMethods
{
    public class Task
    {
        public static void Main()
        {
            if (IsEvenNumber(9))
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное"); //Должна выводиться данная строка
            }

            if (IsEvenNumber(8))
            {
                Console.WriteLine("Число четное"); //Должна выводиться данная строка
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
        
        /// <summary>
        /// Метод проверяет, является ли число четным.
        /// </summary>
        public static  bool IsEvenNumber(int a)
        {
            //TODO: Допишите реализацию данного метода, а также входные параметры и тип возвращаемого результата вместо “…”
            bool x=a%2==0?true : false;
            return x;
        }
    }
}
*/

//3.Sum of numbers
/*
namespace StaticMethods
{
    public class Task
    {
        public static void Main()
        {
            Console.WriteLine(Sum(5,9,8,7,4,1,3)); //37
            Console.WriteLine(Sum(4,5,3,2)); //14
            Console.WriteLine(Sum(3,2,5,7,5)); //22
            Console.WriteLine(Sum(435,5,6,9,7,4,4)); //470
            Console.WriteLine(Sum(0,1,2,5,4)); //12
            Console.WriteLine(Sum(1)); //1
        }
        
        /// <summary>
        /// Метод вычисляет сумму любого количества переданных в него чисел.
        /// </summary>
        public static int Sum(params int[] array)
        {
            int sum=0;
            //TODO: Допишите реализацию данного метода, а также входные параметры и тип возвращаемого результата вместо “…”.
            for (var i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
    */
    
//4.Console Calculator

/*
namespace StaticMethods
{
    public class Task
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetCalculationResult(3, 3, '+')); //6
            Console.WriteLine(GetCalculationResult(2, 2, '*')); //4
            Console.WriteLine(GetCalculationResult(5, 5, '-')); //0
            Console.WriteLine(GetCalculationResult(3, 1, '/')); //3
            Console.WriteLine(GetCalculationResult(4, 2, '%')); //0
        }
        
        /// <summary>
        /// Метод выполняет арифметическую операцию над двумя числами и возвращает ее результат.
        /// </summary>
        public static int GetCalculationResult(int a,int b,char c)
        {
            //TODO: Допишите реализацию данного метода, а также входные параметры и тип возвращаемого результата вместо “…”.
            int result = 0;
            switch (c)
            {
                case '+' :
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                    
                
            }
            return result;
            

        }
    }
}    
*/

//5. Raise to a degree
/*
namespace StaticMethods
{
    public class Task
    {
        public static void Main()
        {
            Console.WriteLine(Pow(9, 3)); //729
            Console.WriteLine(Pow(2, 2)); //4
            Console.WriteLine(Pow(4, 3)); //64
            Console.WriteLine(Pow(2, 8)); //256
        }
        
        /// <summary>
        /// Метод возводит число в степень.
        /// </summary>
        public static int Pow(int a,int b)
        {
            //TODO: Допишите реализацию данного метода, а также входные параметры и тип возвращаемого результата вместо “…”.
            return (int) Math.Pow(a, b);
        }
    }
}
*/

//6.  Area and perimeter
/*
namespace Methods
{
    public class Task
    {
        static void Main(string[] args)
        {
            int area;
            int perimeter;
            GetData(20, 15, out area, out perimeter);
            Console.WriteLine($"Площадь : {area}. Периметр : {perimeter}"); //Площадь : 300. Периметр : 70
            GetData(2, 2, out area, out perimeter);
            Console.WriteLine($"Площадь : {area}. Периметр : {perimeter}"); //Площадь : 4. Периметр : 8
            GetData(10, 7, out area, out perimeter);
            Console.WriteLine($"Площадь : {area}. Периметр : {perimeter}"); //Площадь : 70. Периметр : 34
            GetData(8, 3, out area, out perimeter);
            Console.WriteLine($"Площадь : {area}. Периметр : {perimeter}"); //Площадь : 24. Периметр : 22
        }

        public static void GetData(int a,int b,out int area,out int  perimetr)
        {
            area = a * b;
            perimetr = 2 * (a + b);
        }
    }
}  
*/

//7. Are two arrays equal?

/*
 * using System;

namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = {1, 2, 3, 4, 5, 6};
            int[] array2 = {1, 2, 3, 4, 5, 6};
            int[] array3 = {2, 2, 3, 4, 5, 6};

            Console.WriteLine(AreArraysEqual(array1, array2)); // True
            Console.WriteLine(AreArraysEqual(array2, array2)); // True
            Console.WriteLine(AreArraysEqual(array2, array3)); // False
        }

        // Напишите реализацию метода:
        public static bool AreArraysEqual(int[] array, int[] array2)
        {
           

            if (array == null || array2 == null)
            {
                return false;
            }

            if (array.Length != array2.Length)
            {
                return false;
            }

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] != array2[i])
                {
                    return false;
                }

                if (array.Length == 0 || array2.Length== 0)
                {
                    return false;
                }
            }


            return true;
        }
    }
}
 */
 
 //8.Rounding a number
 
 /*
  * using System;

namespace Methods
{
    public class Task
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Round(15.23659)); //15.24
            Console.WriteLine(Round(15.23659, 3)); //15.237
            Console.WriteLine(Round(10.2)); //10.20
            Console.WriteLine(Round(19.2515463, 5)); //19.25155
        }

         public static double Round(double number, int x = 2)
        {
            return Math.Round( number,x);
        }
    }
}
  */
  
  
//9. Search for the index of a number greater than the specified one
/*
namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Пример использования вашего метода:
            int[] array = {1, -1, 3, 2, 3, 6, 7};
            int index = FindIndexOfElementGreaterThan(array, 3);
            Console.WriteLine(index); // Ожидаемый результат 5
        }

        // Напишите ваш метод тут.
        public static int FindIndexOfElementGreaterThan(int [] array,int x)
        {
           
            for (var i = 0; i < array.Length; i++)
            {
                int max = array[i];
                int index = i;
                if (array[i]>x) 
                {
                    array[i] = max;
                    return i = index;
                }
            }

            return -1;
        }
    }
}  
*/

//10. Factorial
/*
 * using System;

namespace Methods
{
    public class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5)); //120
            Console.WriteLine(Factorial(1)); //1
            Console.WriteLine(Factorial(4)); //24
            Console.WriteLine(Factorial(0)); //1
            Console.WriteLine(Factorial(10)); //3628800
        }

        public static int Factorial(int x)
        {
            if (x==1)
            {
                return 1;
            }

            if (x==0)
            {
                return 1;
            }
            return x * Factorial(x - 1);
        }
    }
}
 */
//11.Which is string more?

/*using System;

namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsStringLess("МАТЕМАТИК", "МАТЕМАТИКА")); // Результат: True
            Console.WriteLine(IsStringLess("МАТЕМАТИК", "МАТЕМАТИК")); // Результат: False
            Console.WriteLine(IsStringLess("АБАК", "АБРАКАДАБРА")); // Результат: True
            Console.WriteLine(IsStringLess("А", "АА")); // Результат: True
            Console.WriteLine(IsStringLess("АА", "ААА")); // Результат: True
            Console.WriteLine(IsStringLess("ААА", "ААБ")); // Результат: True
            Console.WriteLine(IsStringLess("ААД", "ААА")); // Результат: False
        }

        // Напишите реализацию этого метода
        public static bool IsStringLess(string firstArray, string secondArray)
        {
            int number = firstArray.CompareTo(secondArray);
            if (0<=number)
            {
                return false;
            }
            else
            {
                return true;
            }
           
            

            
        }
    }
}*/ 
//12. Reversal of the number

/*using System;

namespace Methods
{
    public class Task
    {
        public static void Main(string[] args)
        {
             Console.WriteLine(ReverseNumber(1548)); //8451
             Console.WriteLine(ReverseNumber(5113)); //3115
             Console.WriteLine(ReverseNumber(89571)); //17598
             Console.WriteLine(ReverseNumber(57)); //75
             Console.WriteLine(ReverseNumber(4)); //4
            
        }

        public static int ReverseNumber(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            int lastnumber = number % 10;//Полуаем послденюю цифру от текущего элемента
            int countOfDigits = (int) Math.Floor(Math.Log10(number) + 1);//Считаем количество дестков в числе
            int reverseNumberBase = lastnumber * (int) Math.Pow(10, countOfDigits);

            int remainPartOfNumber = number / 10;
            return reverseNumberBase + ReverseNumber(remainPartOfNumber); 

        }
        
          
           
    }
}*/

//13. Polindrom

/*
 * using System;

namespace StaticMethods
{
    public class Task
    {
        public static void Main()
        {
            Console.WriteLine(IsPalindrome("radar")); //YES
            Console.WriteLine(IsPalindrome("addcsd")); //NO
            Console.WriteLine(IsPalindrome("mam")); //YES
            Console.WriteLine(IsPalindrome("доход")); //YES
            Console.WriteLine(IsPalindrome("ывимывол")); //NO
        }

        // Метод принимает слово типа string и возвращает тип string.
        public static string IsPalindrome(string word)
        {
            //Терминальное условие для рекурсии: если в слове осталась одна буква.
            if (word.Length <= 1)
            {
                //Возвращаем "YES".
                return "YES";
            }
            
            //Если первая буква слова не совпадает с последней - значит слово не является палиндромом.
            if (word[0] != word[word.Length - 1])
            {
                //Возвращаем "NO".
                return "NO";
            }

            //Возвращаем в метод слово без первой и последней букв.
            return IsPalindrome(word.Substring(1, word.Length - 2));
        }
    }
}
 */

//14.Sorting

/*
 * using System;

namespace Methods
{
    public class Task
    {
        public static void Main(string[] args)
        {
            PrintArray(Sort(5, 6, 9, 8, 7, 4)); //4 5 6 7 8 9
            PrintArray(Sort(1, 8, 9, 6)); //1 6 8 9
            PrintArray(Sort(9, 5, 4, 2, 0)); //0 2 4 5 9
            PrintArray(Sort("Tree", "Scone")); //Scone Tree
            PrintArray(Sort("Love", "Sonic", "Bottle")); //Bottle Love Sonic
            PrintArray(Sort("Anna", "An", "Sonia")); //An Anna Sonia
            PrintArray(Sort("hello", "world", "School", "cat")); //cat hello School world
            PrintArray(Sort("Kiril", "Alex", "Anton", "David")); //Alex Anton David Kiril
        }

        private static void PrintArray(params int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }

            Console.WriteLine();
        }
        
        private static void PrintArray(params string[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }

            Console.WriteLine();
        }

        public static string[] Sort(params string[] arrayString)
        {
            Array.Sort(arrayString);
            return arrayString;
        }
        public static int[] Sort(params int[] number)
        {
            Array.Sort(number);
            return number;
        }
    }
}
 */

