using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CancelBookingDTO
    {
        public int CancellationId { get; set; }
        public int BookingId { get; set; }
        public System.DateTime CancellationDate { get; set; }
        public int RefundId { get; set; }
        public virtual RefundDTO Refund { get; set; }
        public virtual TicketBookingDTO TicketBooking { get; set; }
    }
}
