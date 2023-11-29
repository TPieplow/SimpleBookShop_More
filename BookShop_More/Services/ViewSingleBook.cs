using BookShop_More.Models;
namespace BookShop_More.Services;

public class ViewSingleBook
{
    public static void ViewSingleBookSearch(List<Books> bookList)
    {
        Console.Write("Enter ISBN to search for a book: ");

        if (int.TryParse(Console.ReadLine(), out int isbn))
        {
            var foundBook = bookList.Find(book => book.ISBN == isbn);

            if (foundBook != null)
            {
                Console.WriteLine($"Title: {foundBook.Title}");
                Console.WriteLine($"Author: {foundBook.Author}");
                Console.WriteLine($"ISBN: {foundBook.ISBN}");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Couldnt find a book with the coresponding ISBN: {isbn}");
            }
        }
        else
        {
            Console.WriteLine("Invalid ISBN");
        }
    }
}
