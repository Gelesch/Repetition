using System;

namespace ClassesAndObjects
{
    public class Task
    {
        public static void Main(string[] args)
        {
            // Создаем объект типа Процессор.
            var processor = new Processor("i9", "4000Ghz");
            
            // Создаем объект типа ЖесткийДиск.
            var hdd = new HDD(500);
            
            // Создаем объект типа Ноутбук.
            var laptop = new Laptop("Gray", "HP", "Envy 14", processor, hdd);

            // Выводим на экран информацию о ноутбуке:
            laptop.Print();
            //Вывод на экран:
            // Color: Gray, Brand: HP, Model: Envy 14 Processor: i9, HDD: 500

            // Создаем новый процессор.
            var newProcessor = new Processor("i12", "4500Ghz");

            // Заменяем процессор в ноутбуке.
            laptop.ChangeProcessor(newProcessor);

            // Выводим на экран информацию о ноутбуке:
            laptop.Print();
            //Вывод на экран:
            // Color: Gray, Brand: HP, Model: Envy 14 Processor: i12, HDD: 500
        }
    }

    public class Laptop
    {
        public string Color;
        public string Brand;
        public string Model;
        public Processor Processor;
        public HDD HDD;

        // Конструктор класса Laptop, принимающий цвет, бренд и модель процессор, жесткий диск и сохраняющий их в поля.
        public Laptop(string color, string brand, string model, Processor processor, HDD hdd)
        {
            Color = color;
            Brand = brand;
            Model = model;
            Processor = processor;
            HDD = hdd;
        }

        // Метод выводит на экран информацию о характеристиках и комплектующих ноутбука.
        public void Print()
        {
            Console.WriteLine(
                $"Color: {Color}, Brand: {Brand}, Model: {Model} Processor: {Processor.Model}, HDD: {HDD.Memory}");
        }

        /// <summary>
        /// Метод заменяет процессор в ноутбуке. 
        /// </summary>
        public void ChangeProcessor(Processor newprocessor)
        {
            Processor = newprocessor;
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
