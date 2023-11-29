using BookShop_More.Interfaces;
namespace BookShop_More.Models;

public class AudioBook(string title, string author, int isbn, string narrator) : Books(title, author, isbn), IAudioBooks
{
    public string Narrator { get; set; } = null!;
}
