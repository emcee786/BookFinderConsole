/// Represents a book result with title, author, and first published year.

namespace BookFinderApp
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string FirstPublished { get; set; } = string.Empty;
  
        public Book(string title, string author, string firstPublished)
        {
            Title = title;
            Author = author;
            FirstPublished = firstPublished;
        }
    
        public override string ToString()
        {
            return $"{Title} by {Author} (Published: {FirstPublished})\n";
        }
    }
}
    
 
