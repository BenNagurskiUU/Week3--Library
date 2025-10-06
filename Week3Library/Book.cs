namespace Week3Library
{
    internal class Book
    {
        private string title; // variable
        private string author; // variable
        private string isbn; // variable

        // Title property to allow access to the title private variable
        public string Title
        {
            get { return title; } // get method
            set { title = value; } // set method
        }

        // Author property to allow access to the author private variable
        public string Author
        {
            get { return author; } // get method
            set { author = value; } // set method
        }

        // ISBN property to allow access to the isbn private variable
        public string ISBN
        {
            get { return isbn; } // get method
            set { isbn = value; } // set method
        }
        //constructor
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
