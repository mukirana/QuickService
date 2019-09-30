using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BusStatuDTO
    {
        public int BusRegistrationNumber { get; set; }
        public int SeatFilled { get; set; }
        public System.DateTime Date { get; set; }
        public int RouteId { get; set; }
        public int BusStatusId { get; set; }
        public int BusTimingId { get; set; }

        public virtual BusDTO Bus { get; set; }
        public virtual BusTimingDTO BusTiming { get; set; }
        public virtual ICollection<SeatStatuDTO> SeatStatus { get; set; }
        public virtual ICollection<TicketBookingDTO> TicketBookings { get; set; }
    }
}
