using BookShop_More.Interfaces;

namespace BookShop_More.Models;

public class Books(string title, string author, int isbn) : IBooks
{
    public string Title { get; set; } = title;
    public string Author { get; set; } = author;
    public int? ISBN { get; set; } = isbn;
    public bool IsAvailable { get; set; } = true;
    public int? LoanPeriod { get; set; }
    public int? BookPrice { get; set; }

    public bool Borrow()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            return true;
        }
        return false;
    }
}


