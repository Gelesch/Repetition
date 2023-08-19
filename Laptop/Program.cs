using System;

namespace ClassesAndObjects
{
    public class Task
    {
        public static void Main(string[] args)
        {
            // Создаем объект типа Ноутбук.
            var notebook = CreateLaptop();
        
            // Выводим на экран характеристики ноутбука.
            Console.WriteLine($"Color: {notebook.Color}, Brand: {notebook.Brand}, Model: {notebook.Model}");
       
            // Ожидаемый вывод:
            // Color: Gray, Brand: HP, Model: ENVY 14
        }
    
        /// <summary>
        /// Метод для создания объекта типа Ноутбук.
        /// </summary>
        public static Laptop CreateLaptop()
        {
            Laptop laptop = new Laptop();
            laptop.Color = "Grey";
            laptop.Brand = "HP";
            laptop.Model = "ENVY 14";
            
            //TODO: Напишите реализацию данного метода:
            // Необходимо создать объект класса Ноутбук:
            // В качестве бренда указать "HP",
            // В качестве модели "ENVY 14",
            // В качестве цвета "Gray"
            // и вернуть созданный объект в качестве результата данного метода.
            return laptop;
        }
    }
    
    //TODO: Опишите класс Ноутбук тут:
    public class Laptop
    {
        public string Color;
        public string Brand;
        public string Model;
        
    }
}