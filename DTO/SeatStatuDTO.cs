using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SeatStatuDTO
    {
        public int SeatNumber { get; set; }
        public int BusStatusId { get; set; }
        public virtual BusStatuDTO BusStatu { get; set; }
    }
}
