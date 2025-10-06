class Book
{
    string Title;
    string Author;
    string ISBN;

    void DisplayInfo()
    {
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        // create new instance of the Book class
        Book book = new Book();

        // info for one book in the library
        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";

        // create another book
        Book book1 = new Book();
        book1.Title = "C# Methods and classes";
        book1.Author = "Microsoft";
        book1.ISBN = "55667778";

        // output book info to console
        book.DisplayInfo();

        // output book1 info to console
        book1.DisplayInfo();
    }
}