using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickService.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string end { get; set; }
        public DateTime DropOffDate { get; set; }
    }
}