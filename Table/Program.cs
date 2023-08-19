using System;

namespace ClassesAndObjects
{
    public class Task
    {
        public static void Main(string[] args)
        {
            // Создаем объект типа Стол.
            var table = CreateTable();
        
            // Выводим на экран характеристики созданного стола.
            Console.WriteLine($"Color: {table.Color}, Material: {table.Material}");
       
            // Ожидаемый вывод:
            // Color: White, Material: Metal
        }
        
        /// <summary>
        /// Метод для создания объекта типа Стол.
        /// </summary>
        public static Table CreateTable()
        {
            //TODO: Напишите реализацию данного метода:
            // Необходимо создать объект класса Стол, заполнить его поля так, как указано в примере.
            // и вернуть созданный объект в качестве результата данного метода.
            Table table = new Table();
            table.Color = "White";
            table.Material = "Metal";
            return table;
        }
    }
    
    //TODO: Опишите класс Стол тут:
    public class Table
    {
        public string Material;
        public string Color;
    }
}