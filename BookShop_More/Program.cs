using BookShop_More.Interfaces;
using BookShop_More.Models;
using BookShop_More.Services;
using BookShop_More.UI;
using System.Runtime.CompilerServices;

namespace BookShop_More;

public class Program
{
    private readonly List<Books> bookList = [];
    private readonly List<Customers> customerList = [];
    private readonly List<Employees> employeeList = [];

    public void BookShopMenu()
    {
        while (true)
        {

            Menu.MenuOptions();

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    AddBook.AddBookToList(bookList);
                    break;

                case "2":
                    ViewSingleBook.ViewSingleBookSearch(bookList);
                    break;

                case "3":
                    ViewAllBooks.ViewAllBooksSearch(bookList);
                    break;

                case "4":
                    LoanService.BorrowBook(bookList, book => book.Borrow());
                    break;

                case "5":
                    RegisterMembership.Register(customerList);
                    break;
                case "6":
                    DisplayCustomers.Customers(customerList);
                    break;

                case "0":
                    ExitApplication.ExitApplicationOption();
                    break;

                default:
                    Console.WriteLine("Not a valid option");
                    break;

            }
            Console.Clear();
        }
    }
}
