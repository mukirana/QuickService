using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RefundDTO
    {
        public int RefundId { get; set; }
        public decimal RefundMoney { get; set; }
        public virtual ICollection<CancelBookingDTO> CancelBookings { get; set; }
    }
}
