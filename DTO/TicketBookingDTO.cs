using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TicketBookingDTO
    {
        public int BookingId { get; set; }
        public int NumberOfSeat { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime BookingDate { get; set; }
        public int BusStatusId { get; set; }
        public int PaymentId { get; set; }
        public System.DateTime DepartureDate { get; set; }

        public virtual ICollection<BookingDetailDTO> BookingDetails { get; set; }
        public virtual BusStatuDTO BusStatu { get; set; }
        public virtual ICollection<CancelBookingDTO> CancelBookings { get; set; }
        public virtual CustomerDTO Customer { get; set; }
        public virtual PaymentDetailDTO  PaymentDetail { get; set; }
    }
}
