using Week3Library;

    internal class Program
    {static void Main(string[] args)
        {
            // create new instance of the Book class
            Book book = new Book("C# for beginners", "Bill Gates", "1234567");

            // display book info
            book.DisplayInfo();

        // create new instance of the Book class
        Book book1 = new Book("Ultimate C#", "Microsoft", "2233445");

        // display book info
        book1.DisplayInfo();
    }
}