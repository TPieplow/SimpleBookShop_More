using BookShop_More.Interfaces;

namespace BookShop_More.Models
{
    public class AudioBook : Books, IAudioBooks
    {
        public string Narrator { get; set; }

        public AudioBook(string title, string author, int isbn, string narrator)
            : base(title, author, isbn, true, null, null)
        {
            Narrator = narrator;
        }
    }
}

