using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_11_23_C_Sharp_DZ__Tasks
{
    [Serializable]
    public class Book
    {
        public string BookiTitle { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }
        public string Genre { get; set; }

        public Book() { }
        public Book(string bookiTitle, string author, int yearOfPublication, string genre)
        {
            BookiTitle = bookiTitle;
            Author = author;
            YearOfPublication = yearOfPublication;
            Genre = genre;
        }
    }
}
