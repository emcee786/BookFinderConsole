/// Entry point for the BookFinderApp console application.
using System;
using System.Threading.Tasks;

namespace BookFinderApp
{
    class Program
    {
        /// Main entry point. Prompts the user for a search query and displays book results.

        static async Task Main()
        {
            Console.WriteLine("Enter a book title or author to search:");
            string query = Console.ReadLine() ?? string.Empty;

            var results = await LibraryService.FetchBooksAsync(query);

            if (results.Books.Count == 0)
            {
                Console.WriteLine("No books found.");
            }
            else
            {
                foreach (var book in results.Books)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}