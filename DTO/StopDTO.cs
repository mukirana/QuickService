using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StopDTO
    {
        public int StopId { get; set; }
        public string StopName { get; set; }

        public virtual ICollection<RouteStopDTO> RouteStops { get; set; }
    }
}
