using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    public class BookManagement : Bookchild
    {
                
        public static void Main(string[] args)
        {
            Bookchild book = new Bookchild();
            bool close = true;
            while (close)
            {
                Console.WriteLine("\nMenu\n" +
                                "1)Add book\n" +
                                "2)Search book\n" +
                                "3)Delete book\n" +
                                "4)update book\n"+
                                "5)List of book\n"+
                                "6)Close\n\n");
                Console.Write("Choose your option from menu :");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    book.GetBook();
                }
                else if (option == 2)
                {
                    book.SearchBook();
                }
                else if (option == 3)
                {
                    book.RemoveBook();
                }
                else if (option == 4)
                {
                    book.updatebook();
                }
                else if (option == 5)
                {
                    book.BookList();
                }
                else if (option == 6)
                {
                    Console.WriteLine("Thank you");
                    close = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option\nRetry !!!");
                }
            }
                 
            Console.ReadLine();
        } 
    }
                
}
