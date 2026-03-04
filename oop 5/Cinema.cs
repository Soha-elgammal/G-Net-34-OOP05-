using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    public class Cinema
    {
        private List<IPrintable> tickets = new List<IPrintable>();

        public void Open()
        {
            Console.WriteLine("=== Cinema Opened ===\n");
        }

        public void Close()
        {
            Console.WriteLine("\n=== Cinema Closed ===");
        }

        public void AddTicket(IPrintable ticket)
        {
            tickets.Add(ticket);
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("--- All Tickets ---");
            foreach (var ticket in tickets)
            {
                ticket.Print();
            }
        }
    }
}
