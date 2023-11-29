using BookShop_More.Interfaces;
using BookShop_More.Models;
using BookShop_More.UI;
using System.Text.RegularExpressions;

namespace BookShop_More.Services;

public class ViewAllBooks
{
    public static void ViewAllBooksSearch(List<Books> bookList)
    {
        if (bookList != null && bookList.Count > 0)
        {
            Console.WriteLine("### All available books ###");

            var bookTypes = bookList.Select(book => book.GetType().Name).Distinct();

            foreach (var bookType in bookTypes)
            {

                Console.WriteLine($"Books of type {bookType}\n");

                var booksOfType = bookList.Where(book => book.GetType().Name == bookType);
                foreach (var book in booksOfType)
                {
                    Console.WriteLine($"\tTitle: {book.Title}\n \tAuthor: {book.Author}\n \tISBN: {book.ISBN}");
                    Console.WriteLine("----------------------------------------------------------------------");
                }
            }
        }
        else
        {
            DisplayMessage.DisplayMessageAndWait("No books available");
        }
            DisplayMessage.DisplayMessageAndWait("That's all current books");
    }
}
