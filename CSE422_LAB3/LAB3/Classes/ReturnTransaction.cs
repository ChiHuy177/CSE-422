using LAB3.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB3.Classes
{
    internal class ReturnTransaction : Transaction
    {
        public Book BookReturned { get; set; }
        public override void Execute()
        {
            BookReturned.CopiesAvailable++;
            Console.WriteLine("Book " + BookReturned.Title + " is returned!"); 
        }
    }
}
