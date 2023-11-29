namespace BookShop_More.UI;

public class ExitApplication
{
    public static void ExitApplicationOption()
    {
        Console.Clear();
        Console.Write("Are you sure you want to close the application? (y/n): ");
        var option = Console.ReadLine() ?? "";

        if (option.Equals("y", StringComparison.OrdinalIgnoreCase))
        {
            Environment.Exit(0);
        }
    }
}
