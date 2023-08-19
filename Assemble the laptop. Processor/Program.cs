using System;

namespace ClassesAndObjects
{
    public class Task
    {
        public static void Main(string[] args)
        {
            // Создаем объект типа Процессор.
            var processor = new Processor("i9", "4500Ghz");
            
            // Создаем объект типа Ноутбук.
            var laptop = new Laptop("Gray", "HP", "Envy 14", processor);
        }
    }
    
    //TODO: Допишите класс Ноутбук:
    //1. Добавьте поле Processor
    //2. Добавьте конструктор, принимающий параметры Цвет, Бренд, Модель и Процессор и сохраняющий их в поля класса.
   
    public class Laptop
    {
        public Laptop(string color, string brand, string model, Processor processor)
        {
            Color = color;
            Brand = brand;
            Model = model;
            Processor = processor;
        }

        public string Color;
        public string Brand;
        public string Model;
        public Processor Processor;
    }
    
    public class Processor
    {
        public string Model;
        public string ClockRate;

        public Processor(string model, string clockRate)
        {
            Model = model;
            ClockRate = clockRate;
        }
    }
}