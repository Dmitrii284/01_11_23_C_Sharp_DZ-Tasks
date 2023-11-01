
/*
 Задача: Создание приложения для управления библиотекой книг.
Описание задачи:
Вам необходимо разработать приложение, которое будет позволять управлять коллекцией книг в небольшой библиотеке.
Приложение должно обладать основными функциями, такими как добавление новой книги, удаление книги, поиск книги по автору или названию,
а также вывод списка всех книг.
Требования к решению:
Создайте класс Book, представляющий отдельную книгу. (он содержит в себе List книг) В классе должны быть следующие свойства: название книги, автор, год издания и жанр.
Создайте класс Library, который будет представлять библиотеку книг. В классе Library должна быть коллекция экземпляров класса Book для хранения книг.
Реализуйте методы и функциональность класса Library:
AddBook: метод для добавления новой книги в библиотеку.
RemoveBook: метод для удаления книги из библиотеки.
SearchByAuthor: метод для поиска книг по автору.
SearchByTitle: метод для поиска книг по названию.
DisplayAllBooks: метод для вывода списка всех книг в библиотеке.
Создайте консольное приложение, которое будет использовать классы Book и Library.
С помощью switch В приложении должно быть меню для взаимодействия с библиотекой: добавление книги, удаление книги, 
поиск книги по автору или названию, а также вывод списка всех книг PrintBook.
Приложение должно обеспечивать удобный пользовательский интерфейс и обрабатывать возможные ошибки ввода try catch.
Реализуйте возможность сохранения и загрузки коллекции книг на диск с использованием сериализации [Serializable].
Путь для хранения книг прописать в Main() Path(C:\Users\Ж - 17\Documents\Feofanov\01_11_23_C_Sharp_DZ+ Tasks\01_11_23_C_Sharp_DZ+ Tasks\BooksLibr.txt)
 */
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace _01_11_23_C_Sharp_DZ__Tasks
{

    internal class Program
    {
        public class Operations
        {
            private static void RemoveBook(Library library)
            {
                Console.WriteLine("Введите название книги, которую нужно удалить:");
                string title = Console.ReadLine();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Book book = new();
            List<Book> books = new List<Book>()
            { 
                new Book("Jon", "Donjovi5", 2025,"Ужастики" ),
                new Book("Jon1", "Donjovi6", 2024,"Ужастики" ),
                new Book("Jon2", "Donjovi7", 2026,"Ужастики" ),
                new Book("Jon3", "Donjovi8", 2027,"Ужастики" ),
                new Book("Jon4", "Donjovi9", 2028,"Ужастики" )
            };
            Library library = new Library(books);
            bool exit = false;
            while(!exit) {
                Console.WriteLine("Выберите вариант:");
                Console.WriteLine("1. Добывить книгу.");
                Console.WriteLine("2. Удалить книгу.");
                Console.WriteLine("3. 3. Поиск книги по автору");
                Console.WriteLine("4. Поиск книги по названию");
                Console.WriteLine("5. Отобразить все книги");
                Console.WriteLine("6. Выход");
            }

            int options;
            if (int.TryParse(Console.ReadLine(), out options))
            switch (options)
            {
                case 1: library.AddBook(book); break;
                case 2: library.RemoveBook(book);break;
                case 3: library.SearchByAuthor(book.Author);break;
                case 4: library.SearchByTitle(book.BookiTitle);break;
                case 5: library.DisplayAllBooks();break;
            }
            Console.WriteLine("Неправильно выбран вариант!!!");
            Console.WriteLine();

            
        }
    }
}



