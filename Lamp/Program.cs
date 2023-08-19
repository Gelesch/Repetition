using System;

namespace ClassesAndObjects
{
    public class Task
    {
        public static void Main(string[] args)
        {
            var lamp = new Lamp();
        
            Console.WriteLine($"IsEnabled: {lamp.IsEnabled}");
            // Ожидаемый вывод:
            // IsEnabled: False

            // Включаем лампу.
            lamp.SwitchOn();
            Console.WriteLine($"IsEnabled: {lamp.IsEnabled}");
            // Ожидаемый вывод:
            // IsEnabled: True
        
            // Выключаем лампу.
            lamp.SwitchOff();
            Console.WriteLine($"IsEnabled: {lamp.IsEnabled}");
            // Ожидаемый вывод:
            // IsEnabled: False
        }

    }
    
    //TODO: Допишите класс Лампа:
    public class Lamp
    {
        public bool IsEnabled;

        public bool SwitchOn()
        {
            IsEnabled = true;
            return IsEnabled;
        }

        public bool SwitchOff()
        {
            return IsEnabled = false;
        }
    }
}