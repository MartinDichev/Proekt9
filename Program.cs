using System;

static void Main()
{
    Bookstore bookstore = new Bookstore();

    Author author1 = new Author { AuthorId = 1, Name = "J.K. Rowling", Description = "British author best known for the Harry Potter series." };
    Book book1 = new Book { BookId = 101, Title = "Harry Potter and the Sorcerer's Stone", Description = "First book in the series", Genre = "Fantasy" };
    Book book2 = new Book { BookId = 102, Title = "Harry Potter and the Chamber of Secrets", Description = "Second book in the series", Genre = "Fantasy" };

    author1.AddBook(book1);
    author1.AddBook(book2);

    Author author2 = new Author { AuthorId = 2, Name = "George R.R. Martin", Description = "American novelist and short story writer." };
    Book book3 = new Book { BookId = 201, Title = "A Game of Thrones", Description = "First book in A Song of Ice and Fire series", Genre = "Fantasy" };
    Book book4 = new Book { BookId = 202, Title = "A Clash of Kings", Description = "Second book in A Song of Ice and Fire series", Genre = "Fantasy" };

    author2.AddBook(book3);
    author2.AddBook(book4);

    bookstore.AddAuthor(author1);
    bookstore.AddAuthor(author2);

    Console.WriteLine(bookstore.GetAuthorById(1));
    Console.WriteLine("\n" + new string('=', 30) + "\n");
    Console.WriteLine(bookstore.GetAuthorById(2));