using BookShop_More.Interfaces;

namespace BookShop_More.Models;

public class Books : IBooks
{
    public Books() { }


    public Books(string title, string author, int? iSBN, bool isAvailable, int? loanPeriod, int? bookPrice)
    {
        Title = title;
        Author = author;
        ISBN = iSBN;
        IsAvailable = isAvailable;
        LoanPeriod = loanPeriod;
        BookPrice = bookPrice;
    }

    public string Title { get; set; } 
    public string Author { get; set; } 
    public int? ISBN { get; set; } 
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


