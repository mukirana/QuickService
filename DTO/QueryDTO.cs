using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QueryDTO
    {
        public int QueryId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public virtual CustomerDTO Customer { get; set; }
    }
}
