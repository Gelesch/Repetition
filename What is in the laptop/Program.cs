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
            
            // Выводим на экран информацию о ноутбуке:
            laptop.Print();
        }
    }
    
    public class Laptop
    {
        public string Color;
        public string Brand;
        public string Model;
        public Processor Processor;
        public HDD HDD;

        // Конструктор класса Laptop, принимающий Цвет, Бренд, Модель, Процессор и ЖесткийДиск и сохраняющий их в поля класса.
        public Laptop(string color, string brand, string model, Processor processor, HDD hdd)
        {
            Color = color;
            Brand = brand;
            Model = model;
            Processor = processor;
            HDD = hdd;
        }
        
        /// <summary>
        /// Метод выводит на экран информацию о характеристиках и комплектующих ноутбука в формате:
        /// Color: {цвет}, Brand: {бренд}, Model: {модель} Processor: {модель процессора}, HDD: {память жесткого диска}
        /// </summary>
        public void Print()
        {
            Console.WriteLine(
                $"Color: {Color}, Brand: {Brand}, Model:{Model}, Processor: {Processor.Model}, HDD: {HDD.Memory}");
        }
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
    
    public class HDD
    {
        public int Memory;

        public HDD(int memory)
        {
            Memory = memory;
        }
    }
}