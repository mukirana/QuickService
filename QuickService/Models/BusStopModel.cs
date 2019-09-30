using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
namespace QuickService.Models
{
    public class BusStopModel
    {
        public StopDTO stop1 { get; set; }
        public StopDTO stop2 { get; set; }
        public DateTime date { get; set; }
    }
}