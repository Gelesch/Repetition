using System;

namespace ClassesAndObjects
{
    public class Task
    {
        public static void Main(string[] args)
        {
            // Создаем массив трех книг:
            var books = CreateBooks();

            // Выводим информацию о книгах:
            foreach (var book in books)
            {
                book.Print();
            }
            
        }
        
        //TODO: Допишите данный метод:
        // Метод должен создать три объекта класса Book и вернуть их как массив.
        public static Book[] CreateBooks()
        {
            var book1 = new Book("Лев Толсой", "Война и Мир");
            var book2 = new Book("Александр Грибоедов", "Горе от ума");
            var book3 = new Book("Александр Пушкин", "Евгений Онегин");

            Book[] books = new Book[3]
            {
                book1,
                book2,
                book3
            } ;
            return books;
        }
    }
    
    //TODO: Допишите класс Book:
    //1. Создайте конструктор класса Book, принимающий автора и название книги и сохраняющий их в поля.
    //2. Создайте метод Print,выводящий на консоль информацию о книге в формате: Автор - Название книги.
    public class Book
    {
        public Book(string author, string title)
        {
            Author = author;
            Title = title;
        }

        public string Author;
        public string Title;

        public void Print()
        {
            Console.WriteLine($"{Author}-{Title}");
        }
    }
}