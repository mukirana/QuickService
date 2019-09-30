using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerGender { get; set; }
        public decimal CustomerContactNumber { get; set; }

        public virtual ICollection<PaymentDetailDTO> PaymentDetails { get; set; }
        public virtual ICollection<QueryDTO> Queries { get; set; }
        public virtual ICollection<TicketBookingDTO> TicketBookings { get; set; }
    }
}
