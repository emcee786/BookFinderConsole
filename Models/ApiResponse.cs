/// Contains data transfer objects for deserializing Open Library API responses.
using System.Text.Json.Serialization;

namespace BookFinderApp
{
    public class LibraryApiResponse
    {

        /// The list of book documents returned by the API.

        [JsonPropertyName("docs")]
        public List<BookDto> Docs { get; set; } = new();
    }


    /// Represents a book document from the Open Library API response.

    public class BookDto
    {
 
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("author_name")]
        public List<string> AuthorNames { get; set; } = new();

        [JsonPropertyName("first_publish_year")]
        public int? FirstPublished { get; set; }

        [JsonPropertyName("isbn")]
        public List<string> ISBNs { get; set; } = new();
    }
}
