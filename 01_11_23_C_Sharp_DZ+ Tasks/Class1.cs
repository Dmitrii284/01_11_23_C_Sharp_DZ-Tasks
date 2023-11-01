using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_11_23_C_Sharp_DZ__Tasks
{
    internal class Class1
    {
        //using System;
        //using System.Collections.Generic;
        //using System.IO;
        //using System.Runtime.Serialization.Formatters.Binary;

        //[Serializable]
        //public class Book
        //{
        //    public string Title { get; set; }
        //    public string Author { get; set; }
        //    public int Year { get; set; }
        //    public string Genre { get; set; }
        //}

        //[Serializable]
        //public class Library
        //{
        //    public List<Book> Books { get; set; }

        //    public Library()
        //    {
        //        Books = new List<Book>();
        //    }

        //    public void AddBook(Book book)
        //    {
        //        Books.Add(book);
        //    }

        //    public void RemoveBook(Book book)
        //    {
        //        Books.Remove(book);
        //    }

        //    public List<Book> SearchByAuthor(string author)
        //    {
        //        return Books.FindAll(book => book.Author.ToLower() == author.ToLower());
        //    }

        //    public List<Book> SearchByTitle(string title)
        //    {
        //        return Books.FindAll(book => book.Title.ToLower() == title.ToLower());
        //    }

        //    public void DisplayAllBooks()
        //    {
        //        foreach (Book book in Books)
        //        {
        //            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}, Genre: {book.Genre}");
        //        }
        //    }
        //}

        //public static class BookLibraryApp
        //{
        //    private static string libraryFilePath = "C:\\Users\\Ж-17\\Documents\\Feofanov\\01_11_23_C_Sharp_DZ+ Tasks\\01_11_23_C_Sharp_DZ+ Tasks\\BooksLibr.txt";

        //    public static void Main()
        //    {
        //        Library library = LoadLibrary();

        //        bool exit = false;
        //        while (!exit)
        //        {
        //            Console.WriteLine("Choose an option:");
        //            Console.WriteLine("1. Add a book");
        //            Console.WriteLine("2. Remove a book");
        //            Console.WriteLine("3. Search for a book by author");
        //            Console.WriteLine("4. Search for a book by title");
        //            Console.WriteLine("5. Display all books");
        //            Console.WriteLine("6. Exit");

        //            int option;
        //            if (int.TryParse(Console.ReadLine(), out option))
        //            {
        //                switch (option)
        //                {
        //                    case 1:
        //                        AddBook(library);
        //                        break;
        //                    case 2:
        //                        RemoveBook(library);
        //                        break;
        //                    case 3:
        //                        SearchByAuthor(library);
        //                        break;
        //                    case 4:
        //                        SearchByTitle(library);
        //                        break;
        //                    case 5:
        //                        DisplayAllBooks(library);
        //                        break;
        //                    case 6:
        //                        SaveLibrary(library);
        //                        exit = true;
        //                        break;
        //                    default:
        //                        Console.WriteLine("Invalid option");
        //                        break;
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("Invalid option");
        //            }

        //            Console.WriteLine();
        //        }
        //    }

        //    private static void AddBook(Library library)
        //    {
        //        Console.WriteLine("Enter the title:");
        //        string title = Console.ReadLine();

        //        Console.WriteLine("Enter the author:");
        //        string author = Console.ReadLine();

        //        Console.WriteLine("Enter the year:");
        //        int year;
        //        if (int.TryParse(Console.ReadLine(), out year))
        //        {
        //            Console.WriteLine("Enter the genre:");
        //            string genre = Console.ReadLine();

        //            Book book = new Book { Title = title, Author = author, Year = year, Genre = genre };
        //            library.AddBook(book);

        //            Console.WriteLine("Book added successfully");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid year");
        //        }
        //    }

        //    private static void RemoveBook(Library library)
        //    {
        //        Console.WriteLine("Enter the title of the book to remove:");
        //        string title = Console.ReadLine();

        //        Console.WriteLine("Enter the author of the book to remove:");
        //        string author = Console.ReadLine();

        //        List<Book> matchingBooks = library.SearchByTitle(title);
        //        matchingBooks = matchingBooks.FindAll(book => book.Author.ToLower() == author.ToLower());

        //        if (matchingBooks.Count > 0)
        //        {
        //            if (matchingBooks.Count > 1)
        //            {
        //                Console.WriteLine("Multiple books found. Please select the book to remove:");
        //                for (int i = 0; i < matchingBooks.Count; i++)
        //                {
        //                    Console.WriteLine($"{i + 1}. Title: {matchingBooks[i].Title}, Author: {matchingBooks[i].Author}");
        //                }

        //                int index;
        //                if (int.TryParse(Console.ReadLine(), out index) && index >= 1 && index <= matchingBooks.Count)
        //                {
        //                    library.RemoveBook(matchingBooks[index - 1]);
        //                    Console.WriteLine("Book removed successfully");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Invalid selection");
        //                }
        //            }
        //            else
        //            {
        //                library.RemoveBook(matchingBooks[0]);
        //                Console.WriteLine("Book removed successfully");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Book not found");
        //        }
        //    }

        //    private static void SearchByAuthor(Library library)
        //    {
        //        Console.WriteLine("Enter the author to search for:");
        //        string author = Console.ReadLine();

        //        List<Book> matchingBooks = library.SearchByAuthor(author);
        //        if (matchingBooks.Count > 0)
        //        {
        //            Console.WriteLine("Matching books:");
        //            foreach (Book book in matchingBooks)
        //            {
        //                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}, Genre: {book.Genre}");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("No books found");
        //        }
        //    }

        //    private static void SearchByTitle(Library library)
        //    {
        //        Console.WriteLine("Enter the title to search for:");
        //        string title = Console.ReadLine();

        //        List<Book> matchingBooks = library.SearchByTitle(title);
        //        if (matchingBooks.Count > 0)
        //        {
        //            Console.WriteLine("Matching books:");
        //            foreach (Book book in matchingBooks)
        //            {
        //                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}, Genre: {book.Genre}");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("No books found");
        //        }
        //    }

        //    private static void DisplayAllBooks(Library library)
        //    {
        //        library.DisplayAllBooks();
        //    }

        //    private static void SaveLibrary(Library library)
        //    {
        //        try
        //        {
        //            using (FileStream fileStream = new FileStream(libraryFilePath, FileMode.Create))
        //            {
        //                BinaryFormatter binaryFormatter = new BinaryFormatter();
        //                binaryFormatter.Serialize(fileStream, library);
        //                Console.WriteLine("Library saved successfully");
        //            }
        //        }
        //        catch (IOException)
        //        {
        //            Console.WriteLine("Error saving library");
        //        }
        //    }

        //    private static Library LoadLibrary()
        //    {
        //        try
        //        {
        //            using (FileStream fileStream = new FileStream(libraryFilePath, FileMode.OpenOrCreate))
        //            {
        //                BinaryFormatter binaryFormatter = new BinaryFormatter();
        //                if (fileStream.Length > 0)
        //                {
        //                    return (Library)binaryFormatter.Deserialize(fileStream);
        //                }
        //                else
        //                {
        //                    return new Library();
        //                }
        //            }
        //        }
        //        catch (IOException)
        //        {
        //            Console.WriteLine("Error loading library");
        //            return new Library();
        //        }
        //    }
        //}

    }
}
