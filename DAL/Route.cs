//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Route
    {
        public Route()
        {
            this.Buses = new HashSet<Bus>();
            this.RouteStops = new HashSet<RouteStop>();
        }
    
        public int RouteId { get; set; }
        public string StartingPoint { get; set; }
        public string DroppingPoint { get; set; }
    
        public virtual ICollection<Bus> Buses { get; set; }
        public virtual ICollection<RouteStop> RouteStops { get; set; }
    }
}