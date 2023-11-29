namespace BookShop_More.Services;

using BookShop_More.Interfaces;
using BookShop_More.Models;
using BookShop_More.UI;
using System;
using System.Collections.Generic;



public class AddBook
{
    public static void AddBookToList(List<IBooks> bookList)
    {
        Console.WriteLine("Add a book to the system");
        Console.Write("Title: ");
        string title = Console.ReadLine()!;

        Console.Write("Author:");
        string author = Console.ReadLine()!;

        Console.Write("ISBN:");
        if (int.TryParse(Console.ReadLine(), out int isbn))
        {
            Console.WriteLine("What type of book are you adding?");
            Console.WriteLine(" \n[1.] Loan book\n[2.] Audio book\n[3.] Purchasable book");


            if (int.TryParse(Console.ReadLine(), out int typeOfBook) && typeOfBook >= 1 && typeOfBook <= 3)
            {
                switch (typeOfBook)
                {
                    case 1:
                        Console.Write("Loan period (days):");
                        if (int.TryParse(Console.ReadLine(), out int loanPeriod))
                        {
                            IBooks newLoanBook = new LoanBook(title, author, isbn, loanPeriod);
                            bookList.Add(newLoanBook);
                            Console.WriteLine($"'{newLoanBook}' added successfully");
                        }
                        else
                        {
                            DisplayMessage.DisplayMessageAndWait("Invalid input, book not added");
                        }
                        break;

                    case 2:
                        Console.Write("Add narrator:");
                        string narrator = Console.ReadLine()!;
                        IBooks newAudioBook = new AudioBook(title, author, isbn, narrator);
                        bookList.Add(newAudioBook);
                        DisplayMessage.DisplayMessageAndWait($"{newAudioBook} added successfully");
                        break;

                    case 3:
                        Console.Write("Book price:");
                        if (int.TryParse(Console.ReadLine(), out int bookPrice))
                        {
                            IBooks newPurchasableBook = new PurchasableBook(title, author, isbn, bookPrice);
                            bookList.Add(newPurchasableBook);
                            DisplayMessage.DisplayMessageAndWait($"{newPurchasableBook} added successfully");
                        }
                        break;
                }
            }
        }
        else
        {
            DisplayMessage.DisplayMessageAndWait("Invalid ISBN, no book added.");
        }
    }
}




