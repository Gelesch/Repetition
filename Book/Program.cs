using System;

namespace ClassesAndObjects
{
    public class Task
    {
        public static void Main(string[] args)
        {
            // Создаем первую книгу при помощи конструктора.
            var firstBook = new Book("Лев Толстой", "Война и Мир");
            // Создаем вторую книгу при помощи конструктора.
            var secondBook = new Book("Александр Грибоедов", "Горе от ума");
            // Создаем третью книгу при помощи конструктора.
            var thirdBook = new Book("Александр Пушкин", "Евгений Онегин");
            
            // Выводим информацию о первой книге.
            firstBook.Print();
            // Выводим информацию о второй книге.
            secondBook.Print();
            // Выводим информацию о третьей книге.
            thirdBook.Print();
        }
    }
    
    //TODO: Допишите класс Book:
    //1. Создайте конструктор класса Book, принимающий автора и название книги и сохраняющий их в поля.
    //2. Создайте метод Print,выводящий на консоль информацию о книге в формате: Автор - Название книги.
    public class Book
    {
        public string Author;
        public string Title;

        public Book(string author,string title)
        {
            Author = author;
            Title = title;
        }

        public void Print()
        {
            Console.WriteLine($"{Author}-{Title}");
        }
    }
}