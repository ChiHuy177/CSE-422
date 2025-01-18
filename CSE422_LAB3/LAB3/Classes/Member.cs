using LAB3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3.Classes
{
    internal class Member : IPrintable, IMemberAction
    {
        private string MemberId { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }

        

        public virtual void DisplayInfo()
        {
            Console.WriteLine(this.MemberId);
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Email);
        }

        public void PrintDetails()
        {
            Console.WriteLine(this.MemberId);
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Email);
        }

        public void BorrowBook(Book book)
        {
            if (book.CopiesAvailable > 0)
            {
                book.CopiesAvailable--;
                Console.WriteLine($"Book borrowed: {book.Title}");
            }
            else
            {
                Console.WriteLine("No copies available to borrow.");
            }
        }
        public void ReturnBook(Book book)
        {
            book.CopiesAvailable++;
            Console.WriteLine("Book " + book.Title + " is returned!");
        }
    }
}
