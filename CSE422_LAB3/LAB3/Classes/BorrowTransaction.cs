using LAB3.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB3.Classes
{
    internal class BorrowTransaction : Transaction
    {
        public Book BookBorrowed { get; set; }
        public override void Execute()
        {
            if (BookBorrowed.CopiesAvailable > 0) 
            { 
                BookBorrowed.CopiesAvailable--; 
                Console.WriteLine($"Book borrowed: {BookBorrowed.Title}"); 
            } else 
            { 
                Console.WriteLine("No copies available to borrow."); 
            }
        }
    }
}
