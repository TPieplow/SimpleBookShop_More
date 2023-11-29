using BookShop_More.Interfaces;
using BookShop_More.Models;
using BookShop_More.UI;

namespace BookShop_More.Services;

public class DisplayCustomers
{
    public static void Customers(List<Customers> customerList)
    {
        if (customerList != null)
        {
            foreach (Customers customer in customerList)
            {
                DisplayCustomerDetails(customer);
            }
        }
        else
        {
            DisplayMessage.DisplayMessageAndWait("No available customers");
        }
        Console.ReadKey();
    }

    private static void DisplayCustomerDetails(Customers customer)
    {
        Console.Clear();
        Console.WriteLine("\t### MEMBER ###");
        Console.WriteLine($"Name: {customer.FirstName} {customer.LastName}");
        Console.WriteLine($"Adress: {customer.Address}\nNumber: {customer.Phone}\nE-mail: <{customer.Email}>");
    }
}
