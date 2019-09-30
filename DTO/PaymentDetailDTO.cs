using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PaymentDetailDTO
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public System.TimeSpan PaymentTime { get; set; }
        public Nullable<int> CustomerId { get; set; }

        public virtual CustomerDTO Customer { get; set; }
        public virtual ICollection<TicketBookingDTO> TicketBookings { get; set; }
    }
}
