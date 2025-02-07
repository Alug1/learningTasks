using Task_2_classes_metods;

class BookReader : Reader
{

    public string Name { get; set; }
    public BookReader(string Name)
    {
        this.Name = Name;
    }
    public void ReturnBook(string book, Librarian librarian)
    {
        Console.WriteLine($"Читатель {Name} возвращает книгу \"{book}\" библиотекарю {librarian.Name}");
        librarian.GetBook(book, this);
    }

    public void TakeBook(string book, Librarian librarian)
    {
        librarian.IssueBook(book, this);
        Console.WriteLine($"Читатель {Name} получает книгу \"{book}\" у библиотекаря {librarian.Name}");
    }
}
class BookLibrarian : Librarian, Administrator
{

    public string Name { get; set; }

    public BookLibrarian(string Name)
    {
        this.Name = Name;
    }
    public void FindBook(string book)
    {
        Console.WriteLine($"Библиотекарь {Name} ищет книгу \"{book}\"");
    }

    public void GetBook(string book, Reader reader)
    {
        Console.WriteLine($"Библиотекарь {Name} принимает книгу \"{book}\" от читателя {reader.Name}");
    }

    public void IssueBook(string book, Reader reader)
    {
        Console.WriteLine($"Библиотекарь {Name} выдает книгу \"{book}\" читателю {reader.Name}");
    }
}
class BookSupplier : Supplier, Reader
{

    public string Name { get; set; }
    public BookSupplier(string Name)
    {
        this.Name = Name;
    }
    public void DeliverBooks(string book, Administrator administrator)
    {
        Console.WriteLine($"Поставщик {Name} привозит книгу \"{book}\" администратору {administrator.Name}");

    }
    public void ReturnBook(string book, Librarian librarian)
    {
        Console.WriteLine($"Поставщик {Name} возвращает книгу \"{book}\" библиотекарю {librarian.Name}");
        librarian.GetBook(book, this);
    }
    public void TakeBook(string book, Librarian librarian)
    {
        librarian.IssueBook(book, this);
        Console.WriteLine($"Поставщик {Name} получает книгу \"{book}\" у библиотекаря {librarian.Name}");
    }
}
class BookAdmin : Administrator
{
    public string Name { get; set; }
    public BookAdmin(string Name)
    {
        this.Name = Name;
    }
    public void FindBook(string book)
    {
        Console.WriteLine($"администратор {Name} ищет книгу \"{book}\"");
    }
}