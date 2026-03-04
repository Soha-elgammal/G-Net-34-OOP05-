using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    public class VIPTicket : Ticket
    {
        public bool HasLounge { get; set; }
        public decimal ExtraFee { get; set; }

        public VIPTicket(string movie, decimal price, bool lounge, decimal fee)
            : base(movie, price)
        {
            HasLounge = lounge;
            ExtraFee = fee;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(HasLounge ? "Yes" : "No")} | Fee: {ExtraFee} | Price: {Price} | After Tax: {AfterTax()} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new VIPTicket(MovieName, Price, HasLounge, ExtraFee);
        }
    }
}
