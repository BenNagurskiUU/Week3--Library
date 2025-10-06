namespace Week3Library
{
    internal class Book
    {
        string Title;
        string Author;
        string ISBN;


        //constructor
        public Book (string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }
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
            Book book = new Book("C# for beginners", "Bill Gates", "1234567");

            // display book info
            book.DisplayInfo();
        }
    }
}

