using BookShop_More.Interfaces;
using BookShop_More.Models;
using BookShop_More.UI;
using System.Diagnostics;

namespace BookShop_More.Services;

public class LoanService
{

    public static bool BorrowBook(List<IBooks> bookList, Func<IBooks, bool> borrowFunction)
    {
        if (bookList == null || bookList.Count == 0)
        {
            Console.Clear();
            DisplayMessage.DisplayMessageAndWait("No books available.");
            return false;
        }
        else
        {
            Console.Write("Enter ISBN: ");
            if (int.TryParse(Console.ReadLine(), out int isbn))
            {
                try
                {
                    IBooks loanBook = bookList.FirstOrDefault(x => x.ISBN == isbn)!;
                    if (loanBook == null)
                    {
                        DisplayMessage.DisplayMessageAndWait("No book with the given ISBN.");
                    }
                    else if (loanBook.ISBN == isbn && borrowFunction(loanBook))
                    {
                        DisplayMessage.DisplayMessageAndWait($"Book '{loanBook.Title}' borrows successfully.");
                        loanBook.Borrow();
                        return true;
                    }
                    else if (!borrowFunction(loanBook))
                    {
                        DisplayMessage.DisplayMessageAndWait($"The book '{loanBook.Title}' is not avaiable.");
                    }
                }
                catch (Exception ex)
                { Debug.WriteLine($"An error occured: {ex.Message}"); }
            }
            else
            {
                DisplayMessage.DisplayMessageAndWait("Invalid ISBN.");
            }
            return false;
        }
    }
}
