using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    public abstract class Ticket : IPrintable, IBookable, ICloneable
    {
        private static int counter = 1;

        public int TicketId { get; private set; }
        public string MovieName { get; set; }
        public decimal Price { get; set; }
        public bool IsBooked { get; private set; }

        protected Ticket(string movieName, decimal price)
        {
            TicketId = counter++;
            MovieName = movieName;
            Price = price;
            IsBooked = false;
        }

        public decimal AfterTax()
        {
            return Math.Round(Price * 1.14m, 2);
        }

        // Booking
        public bool Book()
        {
            if (IsBooked)
                return false;

            IsBooked = true;
            return true;
        }

        // Cancellation
        public bool Cancel()
        {
            if (!IsBooked)
                return false;

            IsBooked = false;
            return true;
        }

        // Printing contract
        public abstract void Print();

        // Cloning contract
        public abstract object Clone();
    }
}
