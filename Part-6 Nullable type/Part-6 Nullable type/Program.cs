using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_Nullable_type
{
    class Program
    {
        static void Main(string[] args)
        {
            int? ticketsOnsale = 10;
            int availableTickets;
            if (ticketsOnsale==null)
            {
                availableTickets = 0;
            }
            else
            {
                //non nullable cannot accept the nullable type even if they are same so we need to perform conversion
                availableTickets = ticketsOnsale.Value;
                //or
                availableTickets = ticketsOnsale.Value;
            }
            Console.WriteLine("There are {0} tickets that are available ", availableTickets);
            Console.ReadKey();
        }
    }
}
