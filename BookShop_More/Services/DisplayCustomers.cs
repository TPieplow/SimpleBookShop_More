using BookShop_More.Interfaces;
using BookShop_More.Models;
using BookShop_More.UI;

namespace BookShop_More.Services;

public class DisplayCustomers
{
    public static void Customers(List<ICustomers> customerList)
    {
        if (customerList != null)
        {
            foreach (ICustomers customer in customerList)
            {
                DisplayCustomerDetails(customer);
                Console.ReadKey();
            }
        }
        else
        {
            DisplayMessage.DisplayMessageAndWait("No available customers");
           
        }
    }

    private static void DisplayCustomerDetails(ICustomers customer)
    {
        Console.Clear();
        Console.WriteLine("\t### MEMBER ###");
        Console.WriteLine($"Name: {customer.FirstName} {customer.LastName}");
        Console.WriteLine($"Adress: {customer.Address}\nNumber: {customer.Phone}\nE-mail: <{customer.Email}>");
    }
}
