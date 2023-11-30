using BookShop_More.Interfaces;

namespace BookShop_More.Models;

public class LoanBook(string title, string author, int isbn, int loanPeriod) : Books(title, author, isbn, true, null, null), IBooks
{
    public void WhosLoaning()
    {

    }
    public void ExtendLoanPeriod(int additionalDays)
    {
        LoanPeriod += additionalDays;
    }

    public bool IsOverdue(DateTime dueDate)
    {
        return DateTime.Now > dueDate;
    }

    public decimal CalculateFine(DateTime dueDate)
    {
        if (DateTime.Now > dueDate)
        {
            int daysOverdue = (int)(DateTime.Now - dueDate).TotalDays;
            decimal fineRate = 0.50M;
            return daysOverdue * fineRate;
        }
        else
        {
            return 0;
        }
    }
}
