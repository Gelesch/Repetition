using System;

namespace AreAllNumbersEqualTo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rowsCount = Convert.ToInt32(Console.ReadLine());
            var columnsCount = Convert.ToInt32(Console.ReadLine());

            // Создаем и считываем массив чисел
            var numbers = new int[rowsCount, columnsCount];
            for (var row = 0; row < numbers.GetLength(0); row++)
            {
                for (var column = 0; column < numbers.GetLength(1); column++)
                {
                    numbers[row, column] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            if (AreAllNumbersEqualTo(numbers, 0) || AreAllNumbersEqualTo(numbers, 1))
            {
                Console.WriteLine("Да вы медвежатник, шеф!");
            }
            else
            {
                Console.WriteLine("М-да, друг, взломщик из тебя так себе, попробуй еще раз!");
            }
        }

        /// <summary>
        /// Проверяем все элементы массива, и если они равны переданной цифре - возвращаем true
        /// Иначе возвращаем - false
        /// </summary>        
        public static bool AreAllNumbersEqualTo(int [,] array,int number)
        {  
         
            //TODO: Допишите реализацию данного метода, а также входные параметры и тип возвращаемого результата вместо “…”.
            bool areAllNumbersZero = true;
            
           for (var row = 0; row < array.GetLength(0); row++)
            {
                for (var column = 0; column < array.GetLength(1); column++)
                {
                    if (array[row, column] != 0)
                    {
                        areAllNumbersZero = false;
                        break;
                    }
                }

                if (areAllNumbersZero == false)
                {
                    break;
                }
            }

           

            bool areAllNumbersOne = true;
            for (var row = 0; row < array.GetLength(0); row++)
            {
                for (var column = 0; column < array.GetLength(1); column++)
                {
                    if (array[row, column] != 1)
                    {
                        areAllNumbersOne = false;
                        break;
                    }
                }

                if (areAllNumbersOne == false)
                {
                    break;
                }
            }
            if (areAllNumbersZero == true)
            {
                return true;
            }
            else if (areAllNumbersOne == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}