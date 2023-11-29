namespace BookShop_More.UI;

public class DisplayMessage
{
    public static void DisplayMessageAndWait(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}
