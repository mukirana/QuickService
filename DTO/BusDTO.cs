using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BusDTO
    {
        public int BusRegistrationNumber { get; set; }
        public int RouteId { get; set; }

        public virtual BusDetailDTO BusDetail { get; set; }
        public virtual RouteDTO Route { get; set; }
        public virtual ICollection<BusStatuDTO> BusStatus { get; set; }

    }
}
