using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

internal class Task_5
{
    private static void Main(string[] args)
    {
        BookReader reader = new BookReader("Иван");
        BookLibrarian librarian = new BookLibrarian("Алексей");
        BookSupplier bookSupplier = new BookSupplier("Лаврентий");
        BookAdmin bookAdmin = new BookAdmin("Анастасия");
        reader.TakeBook("Мастер и Маргарита", librarian);
        reader.ReturnBook("Мастер и Маргарита", librarian);
        bookSupplier.DeliverBooks("1000 и 1 рецепт пива", bookAdmin);
        bookAdmin.FindBook("Сборник анекдотов за 2003 год");
        bookSupplier.TakeBook("Краткое руководство по C#, Том 16", librarian);
    }
}

public interface Reader
{
    string Name { get; set; }
    void TakeBook(string book, Librarian librarian);
    void ReturnBook(string book, Librarian librarian);
}
public interface Librarian
{
    string Name { get; set; }
    void IssueBook(string book, Reader reader);
    void GetBook(string book, Reader reader);
}
public interface Supplier
{
    string Name { get; set; }
    void DeliverBooks(string book, Administrator administrator);
}
public interface Administrator
{
    string Name { get; set; }
    void FindBook(string book);
}


