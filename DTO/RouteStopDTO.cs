using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RouteStopDTO
    {
        public int RouteId { get; set; }
        public int StopId { get; set; }
        public int StopOrder { get; set; }
        public System.TimeSpan Time { get; set; }
        public decimal Distance { get; set; }
        public decimal TollPrice { get; set; }
        public System.TimeSpan HaltTime { get; set; }

        public virtual RouteDTO Route { get; set; }
        public virtual StopDTO Stop { get; set; }
    }
}
