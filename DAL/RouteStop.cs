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
    
    public partial class RouteStop
    {
        public int RouteId { get; set; }
        public int StopId { get; set; }
        public int StopOrder { get; set; }
        public System.TimeSpan Time { get; set; }
        public decimal Distance { get; set; }
        public decimal TollPrice { get; set; }
        public System.TimeSpan HaltTime { get; set; }
    
        public virtual Route Route { get; set; }
        public virtual Stop Stop { get; set; }
    }
}
