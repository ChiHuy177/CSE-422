using LAB3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3.Abstract
{
    internal abstract class Transaction
    {
        private string TransactionID { get; set; }
        private DateTime TransactionTime { get; set; }

        private Member Member { get; set; }

        public abstract void Execute();
    }
}
