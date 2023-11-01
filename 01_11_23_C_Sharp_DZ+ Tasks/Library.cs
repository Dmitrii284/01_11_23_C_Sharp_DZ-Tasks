using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _01_11_23_C_Sharp_DZ__Tasks
{
    [Serializable]
    internal class Library
    {
        public List<Book> books{ get; set; }
        public Library(List<Book> books) {
            this.books = books;
        }

        public void AddBook(Book book) {
            books.Add(book);
        }
        public void RemoveBook(Book book) {
            books.Remove(book);
        }

        public List<Book> SearchByAuthor(string Author) {
            return books.FindAll(books => books.Author.ToLower()== Author.ToLower());
        }

        public List<Book> SearchByTitle(string BookiTitle) {
            return books.FindAll(books => books.BookiTitle.ToLower() == BookiTitle.ToLower());
        }

        public void DisplayAllBooks() {
            foreach (Book book in books) {
                Console.WriteLine($"Название книги: {book.BookiTitle}\nАвтор: {book.Author}\n Дата выпуска книги: {book.YearOfPublication}\nЖанр книги: {book.Genre}");
            }
        }

        public void SaveLibrary(string libraryFilePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(libraryFilePath, FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, books);
                    Console.WriteLine("Библиотека успешно сохранена");
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error saving library");
            }
        }

        private static Library LoadLibrary(string libraryFilePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(libraryFilePath, FileMode.OpenOrCreate))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    if (fileStream.Length > 0)
                    {
                        return (Library)binaryFormatter.Deserialize(fileStream);
                    }
                    else
                    {
                        return new Library();
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error loading library");
                return new Library();
            }
        }


    }
}
