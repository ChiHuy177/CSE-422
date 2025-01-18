using LAB3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3.Interfaces
{
    internal interface IMemberAction

    {
        void BorrowBook(Book book);
        void ReturnBook(Book book);
    }
}
