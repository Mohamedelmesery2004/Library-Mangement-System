using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangement_System
{
    internal class Library
    {
        private Book[] books = new Book[100];
        private int booksCount = 0;
        private Book[] BorrowBooks = new Book[50];
        private int booksBorrowCount = 0;
        public void Display ()
        {
            for (int i = 0; i < booksCount; i++)
            {
                Console.WriteLine(books[i].Title);
            }
        }

        public void Add(Book book)
        {
            if (booksCount<books.Length)
            {
                books[booksCount]=book;
                booksCount++;
                Console.WriteLine("Book added sucessfully");
            }
            else
            {
                Console.WriteLine("Space is full");
            }
        }

        public void Remove(Book book)
        {
            int index = Array.IndexOf(books, book);
            books[index] = null; booksCount--;
            Console.WriteLine("Book removed");
        }

        public void BorrowBook(Book book)
        {
            if (booksBorrowCount < BorrowBooks.Length)
            {
                books[booksBorrowCount] = book;
                booksBorrowCount++;
                Console.WriteLine("Book borrow sucessfully");
            }
            else
            {
                Console.WriteLine("you can not borrow");
            }
        }
    }
}
