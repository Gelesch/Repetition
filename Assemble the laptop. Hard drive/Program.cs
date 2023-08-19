using System;

namespace ClassesAndObjects
{
    public class Task
    {
        public static void Main(string[] args)
        {
            // Создаем объект типа Процессор.
            var processor = new Processor("i9", "4500Ghz");
            
            // Создаем объект типа ЖесткийДиск.
            var hdd = new HDD(500);

            // Создаем объект типа Ноутбук.
            var laptop = new Laptop("Gray", "HP", "Envy 14", processor, hdd);
        }
    }
    
    //TODO: Допишите класс Ноутбук:
    //1. Добавьте поле HDD
    //2. Добавьте конструктор, принимающий параметры Цвет, Бренд, Модель, Процессор и ЖесткийДиск и сохраняющий их в поля класса.
    public class Laptop
    {
        public Laptop(string color, string brand, string model, Processor processor, HDD hdd)
        {
            Color = color;
            Brand = brand;
            Model = model;
            Processor = processor;
            HDD = hdd;
        }

        public string Color;
        public string Brand;
        public string Model;
        public Processor Processor;
        public HDD HDD;
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
    
    //TODO: Опишите класс ЖесткийДиск тут:
    public class HDD
    {
    public int Memory;

    public HDD(int memory)
    {
        Memory = memory;
    }
    }
}