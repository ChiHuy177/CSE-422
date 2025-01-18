using LAB3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3.Classes
{
    internal class Book : IPrintable
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public int year;
        public int copiesAvailable;

        public int Year
        {
            get{return year;}
            set
            {
                if (year < 0)
                {
                    year = 0;
                }
                else
                {
                    year = value;
                }
            }
        }

        public int CopiesAvailable
        {
            get { return copiesAvailable; }
            set
            {
                if (value < 0)
                {
                    copiesAvailable = 0;
                }
                else
                {
                    copiesAvailable = value;
                }
            }
        }


        public void DisplayInfo() { 
            Console.WriteLine($"ISBN: {ISBN}"); 
            Console.WriteLine($"Title: {Title}"); 
            Console.WriteLine($"Author: {Author}"); 
            Console.WriteLine($"Year: {Year}"); 
            Console.WriteLine($"Copies Available: {CopiesAvailable}");
        }

        public void PrintDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Copies Available: {CopiesAvailable}");
        }
    }
}
