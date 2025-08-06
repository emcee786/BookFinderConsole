/// Provides services for fetching book data from the Open Library API.
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace BookFinderApp
{
    public class LibraryService
    {

        /// Fetches books from the Open Library API based on the provided search query.
        /// <param name="query">The search term for book title or author.</param>
        /// <returns>A <see cref="SearchResults"/> object containing the list of found books.</returns>
        public static async Task<SearchResults> FetchBooksAsync(string query)
        {
            using HttpClient client = new HttpClient();
            string url = $"https://openlibrary.org/search.json?q={Uri.EscapeDataString(query)}";

            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var bookResponse = JsonSerializer.Deserialize<LibraryApiResponse>(jsonResponse, options);

            var results = new SearchResults();

            if (bookResponse?.Docs == null || bookResponse.Docs.Count == 0)
            {
                return results;
            }

            foreach (var bookDto in bookResponse.Docs)
            {
                string authors = (bookDto.AuthorNames.Count > 0) ? string.Join(", ", bookDto.AuthorNames) : "Unknown Author";
                string isbn = (bookDto.ISBNs.Count > 0) ? bookDto.ISBNs[0] : "N/A";

                results.AddBook(new Book(
                    bookDto.Title,
                    authors,
                    bookDto.FirstPublished?.ToString() ?? "Unknown"
                ));
            }

            return results;
        }
    }
}