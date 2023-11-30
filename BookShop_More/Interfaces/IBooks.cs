namespace BookShop_More.Interfaces
{
    public interface IBooks
    {
        string Author { get; set; }
        bool IsAvailable { get; set; }
        int? ISBN { get; set; }
        string Title { get; set; }
        int? LoanPeriod { get; set; }

        bool Borrow();
    }

    public interface IAudioBooks : IBooks
    {
        string Narrator { get; set; }
    }

    public interface ILoanBooks : IBooks
    {

    }

    public interface IPurchasableBook : IBooks 
    {
        int? BookPrice { get; set; }
    }
}