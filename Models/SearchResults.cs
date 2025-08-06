/// Represents a collection of book search results.
using System.Collections.Generic;

namespace BookFinderApp
{
    public class SearchResults
    {
        private readonly List<Book> _books = new List<Book>();


        /// Gets the list of books found in the search.

        public IReadOnlyList<Book> Books => _books;

        public void AddBook(Book book)
        {
            _books.Add(book);
        }
    }
}
