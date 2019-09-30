using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RouteDTO
    {
        public int RouteId { get; set; }
        public string StartingPoint { get; set; }
        public string DroppingPoint { get; set; }

        public virtual ICollection<BusDTO> Buses { get; set; }
        public virtual ICollection<RouteStopDTO> RouteStops { get; set; }
    }
}
