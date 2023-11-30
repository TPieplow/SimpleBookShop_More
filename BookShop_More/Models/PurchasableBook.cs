namespace BookShop_More.Models
{
    internal class PurchasableBook : Books
    {


        public PurchasableBook(string title, string author, int isbn, int price) : base(title, author, isbn, true, null, null)
        {
            this.BookPrice = price;
        }
    }
}