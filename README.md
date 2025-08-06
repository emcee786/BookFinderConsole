# BookFinderApp

BookFinderApp is a simple C# console application that allows users to search for books by title or author using the Open Library API. The app fetches and displays a list of matching books, including their title, author(s), and first published year.

## Features
- Search for books by title or author
- Fetches data from the Open Library API
- Displays results in a readable format

## Project Structure
- `Program.cs`: Entry point for the application
- `Services/BookService.cs`: Contains logic for fetching book data from the API
- `Models/`: Contains data models for books and API responses

## Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later

## How to Build and Run
1. Open a terminal and navigate to the project directory:
   ```bash
   cd /home/emc/Documents/BookFinderApp
   ```
2. Build the project:
   ```bash
   dotnet build
   ```
3. Run the application:
   ```bash
   dotnet run
   ```
4. When prompted, enter a book title or author to search.

## Example Usage
```
Enter a book title or author to search:
tolkien
The Lord of the Rings by J.R.R. Tolkien (Published: 1954)
The Hobbit by J.R.R. Tolkien (Published: 1937)
...
```

