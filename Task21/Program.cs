using System;
using System.Collections.Generic;
using System.Linq;

namespace Task21
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User { FirstName = "Alice", LastName = "Smith", UserName = "asmith", Password = "password123" },
                new User { FirstName = "Bob", LastName = "Johnson", UserName = "bjohnson", Password = "mypassword" },
                new User { FirstName = "Charlie", LastName = "Brown", UserName = "cbrown", Password = "securepass" }
            };

            List<Book> books = new List<Book>
            {
                new Book { BarCode = "001", Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 10.99, Quantity = 5 },
                new Book { BarCode = "002", Title = "1984", Author = "George Orwell", Price = 8.99, Quantity = 10 },
                new Book { BarCode = "003", Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 7.99, Quantity = 1 }
            };

            bool authenticated = false;
            while (!authenticated)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                authenticated = users.Exists(u => u.UserName == username && u.Password == password);

                if (!authenticated)
                {
                    Console.WriteLine("Invalid username or password. Try again.");
                }
            }

            while (true)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("a - to add book");
                Console.WriteLine("s - to sell a book");
                Console.WriteLine("b - to search books with barcode");
                Console.WriteLine("l - to list all the books");
                Console.WriteLine("e - to exit");

                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "a":
                        AddBook(books);
                        break;
                    case "s":
                        SellBook(books);
                        break;
                    case "b":
                        SearchBookByBarcode(books);
                        break;
                    case "l":
                        ListAllBooks(books);
                        break;
                    case "e":
                        return;
                    default:
                        Console.WriteLine("Invalid operation. Try again.");
                        break;
                }
            }
        }

        static void AddBook(List<Book> books)
        {
            Console.Write("Enter barcode: ");
            string barcode = Console.ReadLine();

            Console.Write("Enter title: ");
            string title = Console.ReadLine();

            Console.Write("Enter author: ");
            string author = Console.ReadLine();

            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Book existingBook = books.SingleOrDefault(b => b.BarCode == barcode);
            if (existingBook != null)
            {
                existingBook.Quantity += quantity;
                Console.WriteLine($"Quantity increased by {quantity}. New quantity: {existingBook.Quantity}");
            }
            else
            {
                books.Add(new Book { BarCode = barcode, Title = title, Author = author, Price = price, Quantity = quantity });
                Console.WriteLine("Book added successfully");
            }
        }

        static void SellBook(List<Book> books)
        {
            Console.Write("Enter barcode of the book to sell: ");
            string barcode = Console.ReadLine();

            Book bookToSell = books.SingleOrDefault(b => b.BarCode == barcode);
            if (bookToSell != null && bookToSell.Quantity > 0)
            {
                bookToSell.Quantity--;
                Console.WriteLine($"Sold one copy of '{bookToSell.Title}'. Remaining quantity: {bookToSell.Quantity}");
            }
            else if (bookToSell == null)
            {
                Console.WriteLine("Book not found.");
            }
            else
            {
                Console.WriteLine("No copies left to sell");
            }
        }

        static void SearchBookByBarcode(List<Book> books)
        {
            Console.Write("Enter barcode to search: ");
            string barcode = Console.ReadLine();

            Book foundBook = books.SingleOrDefault(b => b.BarCode == barcode);
            if (foundBook != null)
            {
                Console.WriteLine($"Found Book: {foundBook.Title}, Author: {foundBook.Author}, Price: {foundBook.Price}, Quantity: {foundBook.Quantity}");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }

        static void ListAllBooks(List<Book> books)
        {
            Console.WriteLine("\nList of all books:");
            foreach (var book in books)
            {
                if (book.Quantity > 0)
                    Console.WriteLine($"Barcode: {book.BarCode}, Title: {book.Title}, Author: {book.Author}, Price: {book.Price}, Quantity: {book.Quantity}");
            }
        }
    }

}
