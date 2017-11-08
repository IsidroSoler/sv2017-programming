// Create an array of 3 "struct" book: title (string), author (string), 
// numPages (short)

using System;

struct Book
{
    public string title;
    public string author;
    public short numPages;
}

public class Ex170
{
    public static void Main()
    {
        Book[] books = new Book[3];

        books[0].title = "It";
        books[0].author = "Stephen King";
        books[0].numPages = 1067;

        books[1].title = "Dr.No";
        books[1].author = "Ian Fleming";
        books[1].numPages = 258;

        books[2].title = "Selected tales";
        books[2].author = "Edgar Allan Poe";
        books[2].numPages = 303;

        foreach (Book b in books)
        {
            Console.WriteLine(b.title);
            Console.WriteLine(b.author);
            Console.WriteLine(b.numPages);
            Console.WriteLine();
        }
    }
}
