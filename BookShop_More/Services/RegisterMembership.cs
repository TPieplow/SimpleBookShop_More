using BookShop_More.Models;
using BookShop_More.UI;

namespace BookShop_More.Services;

public class RegisterMembership
{
    public static void Register(List<Customers> customerList)
    {
        string[] regFields =
        {
            "first name",
            "last name",
            "e-mail",
            "address",
            "phone number"
        };

        Customers newCustomer = new();

        for (int i = 0; i < regFields.Length; i++)
        {
            Console.WriteLine($"Enter {regFields[i]}: ");
            string input = Console.ReadLine()!;

            if (string.IsNullOrEmpty(input))
            {
                DisplayMessage.DisplayMessageAndWait("Unvalid input");
                return;
            }

            switch (i)
            {
                case 0:
                    newCustomer.FirstName = input!;
                    break;
                case 1:
                    newCustomer.LastName = input!;
                    break;
                case 2:
                    newCustomer.Email = input!;
                    break;
                case 3:
                    newCustomer.Address = input!;
                    break;
                case 4:
                    newCustomer.Phone = input!;
                    break;
            }
        }
        customerList.Add(newCustomer);
    }
}
