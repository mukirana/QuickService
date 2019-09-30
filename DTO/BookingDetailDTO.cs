 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookingDetailDTO
    {
        public int BookingId { get; set; }
        public int SeatNumber { get; set; }
        public string PassengerName { get; set; }
        public string PassengerAge { get; set; }
        public string PassengerGender { get; set; }

        public virtual TicketBookingDTO TicketBooking { get; set; }
    }
}
