namespace Library.Core
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int YearOfPublication { get; set; }
        public int? BorrowedById { get; set; }
        public bool Available { get; set; } = true;

        public Book(string title, string author, int yearOfPublication)
        {
            Title = title;
            Author = author;
            YearOfPublication = yearOfPublication;
        }

        public override string ToString()
        {
            return $"{Title} - {Author}, {YearOfPublication}";
        }
    }
}