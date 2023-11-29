using BookShop_More.Interfaces;

namespace BookShop_More.Models;

public class LoanBook(string title, string author, int isbn, int loanPeriod) : Books(title, author, isbn), IBooks
{

}
