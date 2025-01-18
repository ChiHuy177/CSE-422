using LAB3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3.Classes
{
    internal class PremiumMember : Member, IMemberAction
    {
        private DateTime MembershipExpiry {  get; set; }
        private int MaxBooksAllowed { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(this.MembershipExpiry.ToString());
            Console.WriteLine(this.MaxBooksAllowed);
        }
    }
}
