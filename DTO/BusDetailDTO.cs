using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BusDetailDTO
    {
        public string BusName { get; set; }
        public int BusRegistrationNumber { get; set; }
        public string BusType { get; set; }
        public decimal Fare { get; set; }
        public decimal BasePrice { get; set; }
        public int BusContactNumber { get; set; }
        public int TotalSeat { get; set; }

        public virtual ICollection<BusDTO> Buses { get; set; }
    }
}
