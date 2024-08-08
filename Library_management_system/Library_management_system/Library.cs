using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class Library
    {
        private Book[] books=new Book[100];
        private int CurrentBookCount = 0;


        private Book[] borrow_books = new Book[50];
        private int CurrentBorrowBookCount = 0;

        public void Display()
        {
            for (int i = 0; i < CurrentBookCount; i++)
            {
                Console.WriteLine(books[i].Title);
            }
        } 
        public void Add(Book book)
        {
            if (CurrentBookCount < books.Length)
            {
                books[CurrentBookCount] = book;
                CurrentBookCount++;
                Console.WriteLine("Add Book Successfully");
            }else
            {
                Console.WriteLine("Library is full can't add new Book");
            }
        }
        public void Remove(Book book)
        {
            int idx = Array.IndexOf(books, book);
            books[idx] = null;
            CurrentBookCount--;
            Console.WriteLine("Book Removed");
        }

        public void BorrowBook(Book book)
        {
            if (CurrentBorrowBookCount < borrow_books.Length)
            {
                borrow_books[CurrentBorrowBookCount] = book;
                CurrentBorrowBookCount++;
                Console.WriteLine("Book Borrowed Successfully");
            }
            else
            {
                Console.WriteLine("Can't Borrow More Book");
            }
        }

    }
}
