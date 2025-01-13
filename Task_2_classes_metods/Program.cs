using System;

namespace Task_2_classes_metods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book newBook = new Book(205060, "1984", "Роман о тоталитарном государстве", "Джордж Оруэл", 300);
            Console.WriteLine($"Вы можете прочитать книгу: \n {newBook}");
            newBook.ReadBook(40);
            Reader newReader = new Reader("Иван");
            Console.WriteLine($"Читатель {newReader} читает книгу {newBook.bookName} за авторством {newBook.Author}");
        }
    }

    public class Book
    {
        public int ISBN { get; set; }
        public string bookName { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book()
        {
            ISBN = 0;
            bookName = "Noname book";
            Description = "No desctription";
            Author = "Noname author";
            PageCount = 0;
        }

        public Book(int ISBN, string bookName, string Description, string Author, int PageCount)
        {
            this.ISBN = ISBN;
            this.bookName = bookName;
            this.Description = Description;
            this.Author = Author;
            this.PageCount = PageCount;
        }

        public override string ToString()
        {
            return "ISBN: " + ISBN + ", Name: " + bookName + ", Description: " + Description + ", Author: " + Author + ", PageCount:" + PageCount;
        }

        public void ReadBook(int readedPages)
        {
            Console.WriteLine($"You read {readedPages} pages in book: \n {this}");
        }
    }
    public class Reader
    {
        public string ReaderName { get; set; }

        public Reader()
        {
            ReaderName = "Noname reader";
        }
        public Reader(string readerName)  
        {
            this.ReaderName = readerName;
        }
        public override string ToString()
        {
            return ReaderName;
        }
    }


}
