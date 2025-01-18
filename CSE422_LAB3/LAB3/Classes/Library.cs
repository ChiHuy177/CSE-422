using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3.Classes
{
    internal class Library
    {
        public string LibraryName { get; set; }
        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }
        public Library() {
            this.LibraryName = "Default";
            this.Books = new List<Book>();
            this.Members = new List<Member>();
        }
        public Library(string libraryName, List<Book> book) { 
            this.LibraryName=libraryName;
            this.Books = book;
            this.Members = new List<Member>();
        }
        public Library (Library library)
        {
            this.LibraryName = library.LibraryName;
            this.Books = library.Books;
            this.Members = library.Members;
        }
        public void DisplayLibraryInfo()
        {
            Console.WriteLine(this.LibraryName);
            Console.WriteLine(this.Books.Count);
            Console.WriteLine(this.Members.Count);
        }
    }
}
