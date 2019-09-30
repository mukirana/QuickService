using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BusTimingDTO
    {
        public int BusRegistrationNumber { get; set; }
        public int RouteId { get; set; }
        public System.TimeSpan StartingTime { get; set; }
        public int BusTimingId { get; set; }

        public virtual ICollection<BusStatuDTO> BusStatus { get; set; }
    }
}
